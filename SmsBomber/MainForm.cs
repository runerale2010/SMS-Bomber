using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsBomber
{
    public partial class MainForm : MetroForm
    {
        // Task лист с активными потоками
        public static List<Task> TaskList = new List<Task>();

        public MainForm()
        {
            InitializeComponent();
            ComboBox_ProxyType.SelectedIndex = 0;
            Methods.RichTextBox_Log = this.RichTextBox_Log;
            Methods.Label_LogCounter = this.Label_LogCounter;
            Working.ProgressBar_CountCycle = this.ProgressBar_CountCycle;
            Button_ViewOnGithub.Text = "View on Github, Current Version " + Application.ProductVersion.Replace(".0.0", "");
            LoadSettings();
        }

        #region Запуск всех потоков
        public void StartWork()
        {
            ClearLog();
            #region Обнуление переменных со статистикой
            Globals.WorkingStats.CountUsedProxy = 0;
            Globals.WorkingStats.CountSendingSms = 0;
            Globals.WorkingStats.CountMadeCalls = 0;
            Methods.ProxyCounter = 0;
            #endregion
            Globals.WorkingData.CycleDelay = Convert.ToInt32(TextBox_Delay.Text);
            Globals.WorkingData.ProxyTypeLeaf = (Leaf.xNet.ProxyType)ComboBox_ProxyType.SelectedIndex;
            Globals.WorkingData.PhoneNumber = long.Parse(TextBox_PhoneNumber.Text);
            Globals.WorkingData.StopWork = false;
            Globals.WorkingData.SitesList = new SmsService.SitesList
            {
                Alpari = CheckBox_Sites_Alpari.Checked,
                FindClone = CheckBox_Sites_FindClone.Checked,
                Tinder = CheckBox_Sites_Tinder.Checked,
                Twitch = CheckBox_Sites_Twitch.Checked,
                Invitro = CheckBox_Sites_Invitro.Checked,
                Youla = CheckBox_Sites_Youla.Checked,
                GuruTaxi = CheckBox_Sites_GuruTaxi.Checked
            };

            ProgressBar_CountCycle.Value = 0;
            ProgressBar_CountCycle.Maximum = Convert.ToInt32(TextBox_CountCycle.Text);

            SendLog("Запускаю потоки");

            int threadCount = Convert.ToInt32(TextBox_CountThreads.Text);
            int needCycleCount = Convert.ToInt32(TextBox_CountCycle.Text);
            int counter = needCycleCount / threadCount;
            int minCount = 0;

            int maxCount = counter;
            int ostDivision = needCycleCount % threadCount;

            for (int i = 0; i < threadCount; i++)
            {
                var minCountTask = minCount;
                var maxCountTask = maxCount;
                var threadCounter = i;

                var task = Task.Factory.StartNew(() =>
                {
                    Working.Start(minCountTask, maxCountTask, threadCounter);
                });
                TaskList.Add(task);

                minCount = minCount + counter;
                maxCount = maxCount + counter;

                if (i + 2 == threadCount)
                    maxCount += ostDivision;
            }

            SendLog("Все потоки поставлены в очередь");
        }
        #endregion

        #region Работа с логом
        private void SendLog(string log, int threadCount = -1)
        {
            string threadInfo = "";

            if (threadCount != -1)
                threadInfo = $"[Поток№{threadCount}]";

            Invoke((MethodInvoker)delegate ()
           {
               RichTextBox_Log.AppendText($"{Globals.System.Time}{threadInfo}{log}" + Environment.NewLine);
               Label_LogCounter.Text = $"Лог[{RichTextBox_Log.Lines.Count() - 1}]";
               RichTextBox_Log.ScrollToCaret();
           });
        }

        private void ClearLog()
        {
            Invoke((MethodInvoker)delegate ()
            {
                RichTextBox_Log.Clear();
                Label_LogCounter.Text = $"Лог[0]";
            });
        }
        #endregion

        #region Таймеры, для обновления времени и информации о работе
        private void timer_UpdateTime_Tick(object sender, EventArgs e)
        {
            Globals.System.Time = $"[{DateTime.Now.ToLongTimeString()}]";
        }

        private void timer_UpdateWorkStats_Tick(object sender, EventArgs e)
        {
            int runningTask = TaskList.GetRunningTaskListCount();
            Label_CountUsedProxy.Text = Globals.WorkingStats.CountUsedProxy.ToString();
            Label_CountSendingSms.Text = Globals.WorkingStats.CountSendingSms.ToString();
            Label_CountMadeCalls.Text = Globals.WorkingStats.CountMadeCalls.ToString();
            Label_CountActiveThreads.Text = runningTask.ToString();

            if (runningTask == 0)
                SetEnableControls(true);
            else
                SetEnableControls(false);
        }
        #endregion

        #region Отправка HLR запроса к телефону
        private async void Button_UpdateCaptcha_Click(object sender, EventArgs e)
        {
            Button_UpdateCaptcha.Enabled = false;
            if (Globals.WorkingStats.CountProxy > 0)
            {
                var getProxy = Methods.GetProxyFromTxt();
                if (!String.IsNullOrWhiteSpace(getProxy.messageError)) { MetroMessageBox.Show(this, getProxy.messageError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); Button_UpdateCaptcha.Enabled = true; return; }
                HLRRequest.Api.SetProxy((Leaf.xNet.ProxyType)ComboBox_ProxyType.SelectedIndex, getProxy.proxyAdress);
            }

            var responseGetCaptcha = await HLRRequest.Api.GetCaptchaAsync();
            Button_UpdateCaptcha.Enabled = true;

            if (responseGetCaptcha.FailedConnected && Globals.WorkingStats.CountProxy > 0)
            {
                MetroMessageBox.Show(this, "Прокси для получения информации о номере оказался невалидный, попробуйте еще раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (responseGetCaptcha.RequestError)
            {
                MetroMessageBox.Show(this, "Сайт вернул ложный запрос, попробуйте еще раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            pictureBox_ImageCaptcha.Image = responseGetCaptcha.Captcha;
        }

        private async void Button_OK_GetInfoNumber_Click(object sender, EventArgs e)
        {
            if (!CheckValidateInfoPhoneNumber())
                return;

            Button_OK_GetInfoNumber.Enabled = false;
            if (String.IsNullOrWhiteSpace(TextBox_Number_PhoneNumber.Text))
            {
                MetroMessageBox.Show(this, "Укажите номер телефона в поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Button_OK_GetInfoNumber.Enabled = true;
                return;
            }
            if (String.IsNullOrWhiteSpace(Textbox_ResultCaptcha.Text))
            {
                MetroMessageBox.Show(this, "Укажите капчу в поле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Button_OK_GetInfoNumber.Enabled = true;
                return;
            }

            #region Очистка полей
            TextBox_Number_Country.Text = "";
            TextBox_Number_Operator.Text = "";
            TextBox_Number_TimeZone.Text = "";
            TextBox_Number_Network.Text = "";
            TextBox_Number_MCC.Text = "";
            TextBox_Number_MNC.Text = "";
            TextBox_Number_IMSI.Text = "";
            TextBox_Number_MSC.Text = "";
            TextBox_Number_Status.Text = "";
            #endregion

            var responseGetHLRInfo = await HLRRequest.Api.GetHLRRequestInfoAsync(Textbox_ResultCaptcha.Text, TextBox_Number_PhoneNumber.Text);

            Button_OK_GetInfoNumber.Enabled = true;
            pictureBox_ImageCaptcha.Image = null;
            Textbox_ResultCaptcha.Text = "";
            if (responseGetHLRInfo.FailedConnected && Globals.WorkingStats.CountProxy > 0)
            {
                MetroMessageBox.Show(this, "Прокси для получения информации о номере оказался невалидный, попробуйте еще раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (responseGetHLRInfo.RequestError)
            {
                MetroMessageBox.Show(this, "Сайт вернул ложный запрос, попробуйте еще раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!String.IsNullOrWhiteSpace(responseGetHLRInfo.Error))
            {
                MetroMessageBox.Show(this, responseGetHLRInfo.Error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrWhiteSpace(responseGetHLRInfo.Country))
            {
                MetroMessageBox.Show(this, "Неизвестная ошибка, попробуйте еще раз", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TextBox_Number_Country.Text = responseGetHLRInfo.Country;
            TextBox_Number_Operator.Text = responseGetHLRInfo.Operator;
            TextBox_Number_TimeZone.Text = responseGetHLRInfo.TimeZone;
            TextBox_Number_Network.Text = responseGetHLRInfo.Network;
            TextBox_Number_MCC.Text = responseGetHLRInfo.MCC;
            TextBox_Number_MNC.Text = responseGetHLRInfo.MNC;
            TextBox_Number_IMSI.Text = responseGetHLRInfo.IMSI;
            TextBox_Number_MSC.Text = responseGetHLRInfo.MSC;
            TextBox_Number_Status.Text = responseGetHLRInfo.Status;
        }
        #endregion

        #region Перетаскивание формы за название программы
        private void Label_NameProgramm_MouseDown(object sender, MouseEventArgs e)
        {
            Label_NameProgramm.Capture = false;
            Message m = Message.Create(base.Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
            base.WndProc(ref m);
        }
        #endregion

        #region Проверка контролов на валидность
        private bool CheckValidateSettings()
        {
            int intValue = 0;
            long longValue = 0;
            if (!Int32.TryParse(TextBox_CountCycle.Text, out intValue))
            {
                MetroMessageBox.Show(this, "Поле с кол-во циклов неккоректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Int32.TryParse(TextBox_Delay.Text, out intValue))
            {
                MetroMessageBox.Show(this, "Поле с задержкой неккоректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Int32.TryParse(TextBox_CountThreads.Text, out intValue))
            {
                MetroMessageBox.Show(this, "Поле с кол-во потоков неккоректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!long.TryParse(TextBox_PhoneNumber.Text, out longValue))
            {
                MetroMessageBox.Show(this, "Поле с номером неккоректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckValidateInfoPhoneNumber()
        {
            int intValue = 0;
            long longValue = 0;
            if (!long.TryParse(TextBox_Number_PhoneNumber.Text, out longValue))
            {
                MetroMessageBox.Show(this, "Поле с номером телефона неккоректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Int32.TryParse(Textbox_ResultCaptcha.Text, out intValue))
            {
                MetroMessageBox.Show(this, "Поле с решеной капчей неккоректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        #region Управление контролами
        private void SetEnableControls(bool status)
        {
            panel_Settings.Enabled = status;
            Button_Start.Enabled = status;
            Button_Stop.Enabled = !status;
        }
        #endregion

        #region Событие при закрытии программы, сохранение настроек
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }
        #endregion

        #region Сохранение и загрузка настроек
        private void SaveSettings()
        {
            var file = GetFilePath();

            using (var buffer = File.OpenWrite(file))
            {
                var formatter = new BinaryFormatter();

                formatter.Serialize(buffer, bindingSource.DataSource);
            }
        }

        private void LoadSettings()
        {
            var model = LoadContent() as ControlsViewModel;

            if (model != null)
            {
                try
                {
                    bindingSource.DataSource = model;
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, $"\n\n{ex}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static object LoadContent()
        {
            var file = GetFilePath();

            if (!File.Exists(file))
                return null;

            using (var buffer = File.OpenRead(file))
            {
                var formatter = new BinaryFormatter();

                try
                {
                    return formatter.Deserialize(buffer);
                }
                catch
                {
                    //TODO Add error handling
                    return null;
                }
            }
        }

        private static string GetFilePath()
        {
            var directory = Path.GetDirectoryName(typeof(MainForm).Assembly.Location);
            return Path.Combine(directory, "Settings.txt");
        }
        #endregion

        #region Кнопки
        private void Button_ViewOnGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DeWizzard/SMS-Bomber");
        }

        private void Button_ClearLog_Click(object sender, EventArgs e)
        {
            ClearLog();
        }

        private async void Button_LoadProxyFromTxt_Click(object sender, EventArgs e)
        {
            Button_LoadProxyFromTxt.Enabled = false;

            string loadingProxy = await Methods.LoadingProxyFromPath();
            if (!String.IsNullOrEmpty(loadingProxy))
            {
                MetroMessageBox.Show(this, $"\n\n{loadingProxy}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Button_LoadProxyFromTxt.Enabled = true;
                return;
            }

            Label_CountProxy.Text = Globals.WorkingStats.CountProxy.ToString();

            Button_LoadProxyFromTxt.Enabled = true;
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (CheckValidateSettings())
            {
                StartWork();
            }
        }

        private void Button_Stop_Click(object sender, EventArgs e)
        {
            Globals.WorkingData.StopWork = true;
        }
        #endregion
    }
}
