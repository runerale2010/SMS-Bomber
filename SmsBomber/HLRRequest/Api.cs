using Leaf.xNet;
using System.Drawing;
using System.Threading.Tasks;

namespace SmsBomber.HLRRequest
{
    internal class Api
    {
        private static CookieStorage Cookies { get; set; }

        private static string SECookie { get; set; }

        private static string ProxyAdress { get; set; }

        private static ProxyType ProxyTypeLeaf { get; set; }

        /// <summary>
        /// Указать прокси
        /// </summary>
        /// <param name="proxyType">Тип прокси</param>
        /// <param name="proxyAdress">Прокси адрес, в формате ip:port, ip:port:login:password</param>
        public static void SetProxy(ProxyType proxyType, string proxyAdress)
        {
            if (string.IsNullOrWhiteSpace(proxyAdress))
                throw new System.NullReferenceException("Переменная с прокси null или пустая");

            ProxyAdress = proxyAdress;
            ProxyTypeLeaf = proxyType;
        }

        /// <summary>
        /// Получить капчу, нужна для отправки HLR запроса
        /// </summary>
        /// <returns></returns>
        public static async Task<ReturnTypes.ResponseGetCaptcha> GetCaptchaAsync()
        {
            return await Task.Run(() =>
             {
                 using (var request = new HttpRequest())
                 {
                     Image captchaImage = null;
                     if (!string.IsNullOrEmpty(ProxyAdress)) { request.Proxy = ProxyClient.Parse(ProxyTypeLeaf, ProxyAdress); }
                     try
                     {
                         request.Get("https://smsc.ru/testhlr/").None();
                     }
                     catch
                     {
                         return new ReturnTypes.ResponseGetCaptcha { RequestError = true, FailedConnected = !request.HttpIsConnected() };
                     }
                     Cookies = request.Response.Cookies;
                     request.Cookies = Cookies;
                     try
                     {
                         captchaImage = Image.FromStream(request.Get("https://smsc.ru/sys/imgcode.php?1.1").ToMemoryStream());
                     }
                     catch
                     {
                         return new ReturnTypes.ResponseGetCaptcha { RequestError = true, FailedConnected = !request.HttpIsConnected() };
                     }
                     SECookie = Cookies.GetCookieHeader("https://smsc.ru/testhlr/").Replace("SE=", "");
                     return new ReturnTypes.ResponseGetCaptcha { Captcha = captchaImage };
                 }
             });
        }

        /// <summary>
        /// Отправить HLR запрос о номере телефона
        /// </summary>
        /// <param name="captchaCode">Код с картинки</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <returns></returns>
        public static async Task<ReturnTypes.ResponseGetHLRRequestInfo> GetHLRRequestInfoAsync(string captchaCode, string phoneNumber)
        {
            return await Task.Run(() =>
            {
                using (var request = new HttpRequest())
                {
                    if (!string.IsNullOrEmpty(ProxyAdress)) { request.Proxy = ProxyClient.Parse(ProxyTypeLeaf, ProxyAdress); }
                    var reqParams = new RequestParams();
                    string response = "";
                    reqParams["SE"] = SECookie;
                    reqParams["phone"] = phoneNumber;
                    reqParams["code"] = captchaCode;
                    reqParams["send"] = "(unable to decode value)";
                    reqParams["uniq"] = "1";
                    try
                    {
                        response = request.Post("https://smsc.ru/testhlr/", reqParams).ToString();
                    }
                    catch
                    {
                        return new ReturnTypes.ResponseGetHLRRequestInfo { FailedConnected = !request.HttpIsConnected(), RequestError = true };
                    }

                    if (response.Contains("im/error.gif"))
                    {
                        return new ReturnTypes.ResponseGetHLRRequestInfo { Error = response.Substring("<tr><td><img src=/im/error.gif width=16><td><b>", "</b></table><br><p>") ?? "" };
                    }
                    if (response.Contains("Страна"))
                    {
                        return new ReturnTypes.ResponseGetHLRRequestInfo
                        {
                            Country = response.Substring("<tr><td><b>Страна:</b><td>", "<tr><td><b>") ?? "",
                            Operator = response.Substring("Оператор:</b><td>", "<tr><td><b>") ?? "",
                            TimeZone = response.Substring("Часовой пояс:</b><td>", "<tr>") ?? "",
                            Network = response.Substring("Сеть:</b><td>", "<tr><td><b>") ?? "",
                            MCC = response.Substring("mcc:</b><td>", "<tr><td><b>") ?? "",
                            MNC = response.Substring("mnc:</b><td>", "<tr><td><b>") ?? "",
                            IMSI = response.Substring("imsi:</b><td>", "<tr><td><b>") ?? "",
                            MSC = response.Substring("msc:</b><td>", "<tr><td>") ?? "",
                            Status = response.Substring("Статус:</b><td class=o>", "</table>") ?? response.Substring("Статус:</b><td class=r>", "</table>") ?? "",
                        };
                    }
                    return new ReturnTypes.ResponseGetHLRRequestInfo { Error = "Неизвестная ошибка метода" };
                }
            });
        }
    }
}
