using Leaf.xNet;
using SmsBomber.SmsService;
using System;

namespace SmsBomber
{
    internal class Globals
    {
        public class System
        {
            public static string Time { get; set; }
        }
        
        public class WorkingStats
        {
            public static int CountProxy { get; set; }

            public static int CountUsedProxy { get; set; }

            public static int CountSendingSms { get; set; }

            public static int CountMadeCalls { get; set; }
        }

        public class WorkingData
        {
            public static int CycleDelay { get; set; }

            public static string ProxyPath { get; set; }

            public static long PhoneNumber { get; set; }

            [ThreadStatic]
            public static string ProxyAdress;

            public static ProxyType ProxyTypeLeaf { get; set; } = ProxyType.HTTP;

            public static SitesList SitesList { get; set; }

            public static bool StopWork { get; set; } = false;
        }
    }
}
