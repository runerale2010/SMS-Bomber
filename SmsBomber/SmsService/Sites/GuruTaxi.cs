using Leaf.xNet;
using static SmsBomber.ReturnTypes;

namespace SmsBomber.SmsService.Sites
{
    internal class GuruTaxi
    {
        public static ResponseSendSms SendSms()
        {
            using (var request = new HttpRequest())
            {
                if (!string.IsNullOrWhiteSpace(Globals.WorkingData.ProxyAdress)) { request.Proxy = ProxyClient.Parse(Globals.WorkingData.ProxyTypeLeaf, Globals.WorkingData.ProxyAdress); }
                try
                {
                    request.Post($"{DomainList.GuruTaxi}/api/v1/driver/session/verify", $"{{\"phone\": {{\"code\": 1, \"number\": \"{Globals.WorkingData.PhoneNumber}\"}}}}", "application/json").ToString();
                }
                catch
                {
                    return new ResponseSendSms { FailedConnected = !request.HttpIsConnected(), SuccessSend = false };
                }

                if ((int)request.Response.StatusCode == 200)
                {
                    Globals.WorkingStats.CountSendingSms++;
                    return new ResponseSendSms { SuccessSend = true };
                }
                return new ResponseSendSms { SuccessSend = false };
            }
        }
    }
}
