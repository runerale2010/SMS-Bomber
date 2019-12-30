using System.Drawing;

namespace SmsBomber
{
    internal class ReturnTypes
    {
        public class ResponseGetProxyFromTxt
        {
            public string messageError = null;
            public string proxyAdress = null;
        }

        public class ResponseSendSms
        {
            public bool SuccessSend = false;
            public bool FailedConnected = false;
        }

        public class ResponseGetCaptcha
        {
            public Image Captcha = null;
            public bool RequestError = false;
            public bool FailedConnected = false;
        }

        public class ResponseGetHLRRequestInfo
        {
            public string Error = null;
            public bool RequestError = false;
            public bool FailedConnected = false;
            public string Country = null;
            public string Operator = null;
            public string TimeZone = null;
            public string Network = null;
            public string MCC = null;
            public string MNC = null;
            public string IMSI = null;
            public string MSC = null;
            public string Status = null;
        }
    }
}
