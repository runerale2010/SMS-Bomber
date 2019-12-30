using MetroFramework.Controls;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsBomber
{
    internal class Methods
    {
        public static Random rnd = new Random(Guid.NewGuid().GetHashCode());

        public static RichTextBox RichTextBox_Log = null;

        public static MetroLabel Label_LogCounter = null;

        private static object LockGetProxy = new object();

        public static int ProxyCounter { get; set; }

        /// <summary>
        /// Отправить лог
        /// </summary>
        /// <param name="log">Сообщение</param>
        /// <param name="threadCount">Номер потока</param>
        public static void SendLog(string log, int threadCount = -1)
        {
            string threadInfo = "";

            if (threadCount != -1)
                threadInfo = $"[Поток№{threadCount}]";
            RichTextBox_Log.Invoke((MethodInvoker)delegate ()
            {
                RichTextBox_Log.AppendText($"{Globals.System.Time}{threadInfo}{log}" + Environment.NewLine);
                Label_LogCounter.Text = $"Лог[{RichTextBox_Log.Lines.Count() - 1}]";
                RichTextBox_Log.ScrollToCaret();
            });
        }

        /// <summary>
        /// Сгенерировать рандомный пароль
        /// </summary>
        /// <param name="length">Длинна</param>
        /// <returns></returns>
        public static string GenerateRandomPassword(int length)
        {
            StringBuilder res = new StringBuilder();
            const string valid = "0987654321ZYXWVUTSRQPONMLKJIHGFEDCBAzyxwvutsrqponmlkjihgfedcba";
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }

        /// <summary>
        /// Загрузка прокси из файла
        /// </summary>
        /// <returns></returns>
        public static async Task<string> LoadingProxyFromPath()
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Текстовый документ | *.txt";
            var dialogResult = OPF.ShowDialog();

            return await Task.Run(() =>
            {
                if (dialogResult == DialogResult.OK)
                {
                    int countTxtLines = 0;
                    using (TextReader reader = new StreamReader(OPF.FileName))
                    {
                        while ((reader.ReadLine()) != null)
                        {
                            countTxtLines++;
                        }
                    };

                    if (countTxtLines == 0)
                    {
                        return "Txt с прокси для регистрации пустой";
                    }

                    Globals.WorkingStats.CountProxy = countTxtLines;
                    Globals.WorkingData.ProxyPath = OPF.FileName;

                    return "";
                }
                return "Вы не выбрали txt с прокси";
            });
        }

        /// <summary>
        /// Получение прокси
        /// </summary>
        /// <returns></returns>
        public static ReturnTypes.ResponseGetProxyFromTxt GetProxyFromTxt()
        {
            lock (LockGetProxy)
            {
                if (ProxyCounter > Globals.WorkingStats.CountProxy)
                    return new ReturnTypes.ResponseGetProxyFromTxt { messageError = "В txt нету доступных прокси" };

                int i = 0;
                string currentLine = "";
                using (StreamReader reader = new StreamReader(Globals.WorkingData.ProxyPath, Encoding.UTF8))
                {
                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        if (i == ProxyCounter)
                        {
                            ProxyCounter++;
                            Globals.WorkingStats.CountUsedProxy++;
                            return new ReturnTypes.ResponseGetProxyFromTxt { proxyAdress = currentLine };
                        }
                        i++;
                    }
                }
                return new ReturnTypes.ResponseGetProxyFromTxt { messageError = "Не удалось найти строчку с прокси" };
            }
        }
    }
}
