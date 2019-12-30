namespace SmsBomber
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_PhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_CountThreads = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Delay = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_CountCycle = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_ClearLog = new MetroFramework.Controls.MetroButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RichTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.Label_LogCounter = new MetroFramework.Controls.MetroLabel();
            this.panel_Settings = new System.Windows.Forms.Panel();
            this.CheckBox_Sites_GuruTaxi = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox_Sites_Youla = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox_Sites_Invitro = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox_Sites_Twitch = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox_Sites_Tinder = new MetroFramework.Controls.MetroCheckBox();
            this.CheckBox_Sites_FindClone = new MetroFramework.Controls.MetroCheckBox();
            this.ComboBox_ProxyType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.Button_LoadProxyFromTxt = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.CheckBox_Sites_Alpari = new MetroFramework.Controls.MetroCheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.Button_Stop = new MetroFramework.Controls.MetroButton();
            this.Button_Start = new MetroFramework.Controls.MetroButton();
            this.Label_NameProgramm = new MetroFramework.Controls.MetroLabel();
            this.ProgressBar_CountCycle = new MetroFramework.Controls.MetroProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Label_CountMadeCalls = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.Label_CountSendingSms = new MetroFramework.Controls.MetroLabel();
            this.Label_CountProxy = new MetroFramework.Controls.MetroLabel();
            this.Label_CountUsedProxy = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.Label_CountActiveThreads = new MetroFramework.Controls.MetroLabel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.timer_UpdateTime = new System.Windows.Forms.Timer(this.components);
            this.timer_UpdateWorkStats = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_ImageCaptcha = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage_Main = new MetroFramework.Controls.MetroTabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Number_PhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.Textbox_ResultCaptcha = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.Button_OK_GetInfoNumber = new MetroFramework.Controls.MetroButton();
            this.Button_UpdateCaptcha = new MetroFramework.Controls.MetroButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_Number_Status = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_Number_MSC = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_Number_MNC = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_Number_MCC = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel29 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Number_Network = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Number_TimeZone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Number_Operator = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Number_Country = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Number_IMSI = new MetroFramework.Controls.MetroTextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage_Log = new MetroFramework.Controls.MetroTabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.Label_Warning = new MetroFramework.Controls.MetroLabel();
            this.Button_ViewOnGithub = new MetroFramework.Controls.MetroButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Settings.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageCaptcha)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage_Main.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.metroTabPage_Log.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TextBox_PhoneNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_CountThreads, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_Delay, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBox_CountCycle, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 102);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBox_PhoneNumber
            // 
            // 
            // 
            // 
            this.TextBox_PhoneNumber.CustomButton.Image = null;
            this.TextBox_PhoneNumber.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.TextBox_PhoneNumber.CustomButton.Name = "";
            this.TextBox_PhoneNumber.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_PhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_PhoneNumber.CustomButton.TabIndex = 1;
            this.TextBox_PhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_PhoneNumber.CustomButton.UseSelectable = true;
            this.TextBox_PhoneNumber.CustomButton.Visible = false;
            this.TextBox_PhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "PhoneNumber", true));
            this.TextBox_PhoneNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_PhoneNumber.Lines = new string[0];
            this.TextBox_PhoneNumber.Location = new System.Drawing.Point(120, 81);
            this.TextBox_PhoneNumber.MaxLength = 32767;
            this.TextBox_PhoneNumber.Name = "TextBox_PhoneNumber";
            this.TextBox_PhoneNumber.PasswordChar = '\0';
            this.TextBox_PhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_PhoneNumber.SelectedText = "";
            this.TextBox_PhoneNumber.SelectionLength = 0;
            this.TextBox_PhoneNumber.SelectionStart = 0;
            this.TextBox_PhoneNumber.ShortcutsEnabled = true;
            this.TextBox_PhoneNumber.Size = new System.Drawing.Size(112, 20);
            this.TextBox_PhoneNumber.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_PhoneNumber.TabIndex = 4;
            this.TextBox_PhoneNumber.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_PhoneNumber.UseSelectable = true;
            this.TextBox_PhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_PhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel7.Location = new System.Drawing.Point(3, 78);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(111, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Номер:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_CountThreads
            // 
            // 
            // 
            // 
            this.TextBox_CountThreads.CustomButton.Image = null;
            this.TextBox_CountThreads.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.TextBox_CountThreads.CustomButton.Name = "";
            this.TextBox_CountThreads.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_CountThreads.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_CountThreads.CustomButton.TabIndex = 1;
            this.TextBox_CountThreads.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_CountThreads.CustomButton.UseSelectable = true;
            this.TextBox_CountThreads.CustomButton.Visible = false;
            this.TextBox_CountThreads.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "CountThreads", true));
            this.TextBox_CountThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_CountThreads.Lines = new string[0];
            this.TextBox_CountThreads.Location = new System.Drawing.Point(120, 55);
            this.TextBox_CountThreads.MaxLength = 32767;
            this.TextBox_CountThreads.Name = "TextBox_CountThreads";
            this.TextBox_CountThreads.PasswordChar = '\0';
            this.TextBox_CountThreads.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_CountThreads.SelectedText = "";
            this.TextBox_CountThreads.SelectionLength = 0;
            this.TextBox_CountThreads.SelectionStart = 0;
            this.TextBox_CountThreads.ShortcutsEnabled = true;
            this.TextBox_CountThreads.Size = new System.Drawing.Size(112, 20);
            this.TextBox_CountThreads.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_CountThreads.TabIndex = 3;
            this.TextBox_CountThreads.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_CountThreads.UseSelectable = true;
            this.TextBox_CountThreads.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_CountThreads.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel6.Location = new System.Drawing.Point(3, 52);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Кол-во потоков:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_Delay
            // 
            // 
            // 
            // 
            this.TextBox_Delay.CustomButton.Image = null;
            this.TextBox_Delay.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.TextBox_Delay.CustomButton.Name = "";
            this.TextBox_Delay.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Delay.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Delay.CustomButton.TabIndex = 1;
            this.TextBox_Delay.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Delay.CustomButton.UseSelectable = true;
            this.TextBox_Delay.CustomButton.Visible = false;
            this.TextBox_Delay.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Delay", true));
            this.TextBox_Delay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Delay.Lines = new string[0];
            this.TextBox_Delay.Location = new System.Drawing.Point(120, 29);
            this.TextBox_Delay.MaxLength = 32767;
            this.TextBox_Delay.Name = "TextBox_Delay";
            this.TextBox_Delay.PasswordChar = '\0';
            this.TextBox_Delay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Delay.SelectedText = "";
            this.TextBox_Delay.SelectionLength = 0;
            this.TextBox_Delay.SelectionStart = 0;
            this.TextBox_Delay.ShortcutsEnabled = true;
            this.TextBox_Delay.Size = new System.Drawing.Size(112, 20);
            this.TextBox_Delay.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Delay.TabIndex = 2;
            this.TextBox_Delay.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Delay.UseSelectable = true;
            this.TextBox_Delay.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Delay.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel2.Location = new System.Drawing.Point(3, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Задержка(ms):";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(111, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Кол-во циклов:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_CountCycle
            // 
            // 
            // 
            // 
            this.TextBox_CountCycle.CustomButton.Image = null;
            this.TextBox_CountCycle.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.TextBox_CountCycle.CustomButton.Name = "";
            this.TextBox_CountCycle.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_CountCycle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_CountCycle.CustomButton.TabIndex = 1;
            this.TextBox_CountCycle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_CountCycle.CustomButton.UseSelectable = true;
            this.TextBox_CountCycle.CustomButton.Visible = false;
            this.TextBox_CountCycle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "CountCycle", true));
            this.TextBox_CountCycle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_CountCycle.Lines = new string[0];
            this.TextBox_CountCycle.Location = new System.Drawing.Point(120, 3);
            this.TextBox_CountCycle.MaxLength = 32767;
            this.TextBox_CountCycle.Name = "TextBox_CountCycle";
            this.TextBox_CountCycle.PasswordChar = '\0';
            this.TextBox_CountCycle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_CountCycle.SelectedText = "";
            this.TextBox_CountCycle.SelectionLength = 0;
            this.TextBox_CountCycle.SelectionStart = 0;
            this.TextBox_CountCycle.ShortcutsEnabled = true;
            this.TextBox_CountCycle.Size = new System.Drawing.Size(112, 20);
            this.TextBox_CountCycle.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_CountCycle.TabIndex = 1;
            this.TextBox_CountCycle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_CountCycle.UseSelectable = true;
            this.TextBox_CountCycle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_CountCycle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Button_ClearLog);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.Label_LogCounter);
            this.panel1.Location = new System.Drawing.Point(3, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 335);
            this.panel1.TabIndex = 1;
            // 
            // Button_ClearLog
            // 
            this.Button_ClearLog.Location = new System.Drawing.Point(684, 1);
            this.Button_ClearLog.Name = "Button_ClearLog";
            this.Button_ClearLog.Size = new System.Drawing.Size(63, 18);
            this.Button_ClearLog.Style = MetroFramework.MetroColorStyle.Blue;
            this.Button_ClearLog.TabIndex = 6;
            this.Button_ClearLog.Text = "Очистить";
            this.Button_ClearLog.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_ClearLog.UseSelectable = true;
            this.Button_ClearLog.Click += new System.EventHandler(this.Button_ClearLog_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.panel4.Controls.Add(this.RichTextBox_Log);
            this.panel4.Location = new System.Drawing.Point(0, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(906, 327);
            this.panel4.TabIndex = 2;
            // 
            // RichTextBox_Log
            // 
            this.RichTextBox_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.RichTextBox_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_Log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.RichTextBox_Log.Location = new System.Drawing.Point(3, 3);
            this.RichTextBox_Log.Name = "RichTextBox_Log";
            this.RichTextBox_Log.ReadOnly = true;
            this.RichTextBox_Log.Size = new System.Drawing.Size(741, 310);
            this.RichTextBox_Log.TabIndex = 0;
            this.RichTextBox_Log.Text = "";
            // 
            // Label_LogCounter
            // 
            this.Label_LogCounter.AutoSize = true;
            this.Label_LogCounter.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_LogCounter.Location = new System.Drawing.Point(0, 0);
            this.Label_LogCounter.Name = "Label_LogCounter";
            this.Label_LogCounter.Size = new System.Drawing.Size(46, 19);
            this.Label_LogCounter.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label_LogCounter.TabIndex = 1;
            this.Label_LogCounter.Text = "Лог[0]";
            this.Label_LogCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_LogCounter.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel_Settings
            // 
            this.panel_Settings.Controls.Add(this.CheckBox_Sites_GuruTaxi);
            this.panel_Settings.Controls.Add(this.CheckBox_Sites_Youla);
            this.panel_Settings.Controls.Add(this.CheckBox_Sites_Invitro);
            this.panel_Settings.Controls.Add(this.CheckBox_Sites_Twitch);
            this.panel_Settings.Controls.Add(this.CheckBox_Sites_Tinder);
            this.panel_Settings.Controls.Add(this.CheckBox_Sites_FindClone);
            this.panel_Settings.Controls.Add(this.ComboBox_ProxyType);
            this.panel_Settings.Controls.Add(this.metroLabel10);
            this.panel_Settings.Controls.Add(this.Button_LoadProxyFromTxt);
            this.panel_Settings.Controls.Add(this.metroLabel8);
            this.panel_Settings.Controls.Add(this.metroLabel3);
            this.panel_Settings.Controls.Add(this.CheckBox_Sites_Alpari);
            this.panel_Settings.Controls.Add(this.tableLayoutPanel1);
            this.panel_Settings.Controls.Add(this.panel3);
            this.panel_Settings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Settings.Location = new System.Drawing.Point(0, 0);
            this.panel_Settings.Name = "panel_Settings";
            this.panel_Settings.Size = new System.Drawing.Size(235, 350);
            this.panel_Settings.TabIndex = 2;
            // 
            // CheckBox_Sites_GuruTaxi
            // 
            this.CheckBox_Sites_GuruTaxi.AutoSize = true;
            this.CheckBox_Sites_GuruTaxi.Checked = true;
            this.CheckBox_Sites_GuruTaxi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Sites_GuruTaxi.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "SitesGuruTaxi", true));
            this.CheckBox_Sites_GuruTaxi.Location = new System.Drawing.Point(163, 265);
            this.CheckBox_Sites_GuruTaxi.Name = "CheckBox_Sites_GuruTaxi";
            this.CheckBox_Sites_GuruTaxi.Size = new System.Drawing.Size(69, 15);
            this.CheckBox_Sites_GuruTaxi.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBox_Sites_GuruTaxi.TabIndex = 13;
            this.CheckBox_Sites_GuruTaxi.Text = "guru.taxi";
            this.CheckBox_Sites_GuruTaxi.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CheckBox_Sites_GuruTaxi.UseSelectable = true;
            // 
            // CheckBox_Sites_Youla
            // 
            this.CheckBox_Sites_Youla.AutoSize = true;
            this.CheckBox_Sites_Youla.Checked = true;
            this.CheckBox_Sites_Youla.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Sites_Youla.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "SitesYoula", true));
            this.CheckBox_Sites_Youla.Location = new System.Drawing.Point(92, 266);
            this.CheckBox_Sites_Youla.Name = "CheckBox_Sites_Youla";
            this.CheckBox_Sites_Youla.Size = new System.Drawing.Size(66, 15);
            this.CheckBox_Sites_Youla.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBox_Sites_Youla.TabIndex = 12;
            this.CheckBox_Sites_Youla.Text = "youla.ru";
            this.CheckBox_Sites_Youla.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CheckBox_Sites_Youla.UseSelectable = true;
            // 
            // CheckBox_Sites_Invitro
            // 
            this.CheckBox_Sites_Invitro.AutoSize = true;
            this.CheckBox_Sites_Invitro.Checked = true;
            this.CheckBox_Sites_Invitro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Sites_Invitro.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "SitesInvitro", true));
            this.CheckBox_Sites_Invitro.Location = new System.Drawing.Point(3, 265);
            this.CheckBox_Sites_Invitro.Name = "CheckBox_Sites_Invitro";
            this.CheckBox_Sites_Invitro.Size = new System.Drawing.Size(83, 15);
            this.CheckBox_Sites_Invitro.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBox_Sites_Invitro.TabIndex = 11;
            this.CheckBox_Sites_Invitro.Text = "lk.invitro.ru";
            this.CheckBox_Sites_Invitro.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CheckBox_Sites_Invitro.UseSelectable = true;
            // 
            // CheckBox_Sites_Twitch
            // 
            this.CheckBox_Sites_Twitch.AutoSize = true;
            this.CheckBox_Sites_Twitch.Checked = true;
            this.CheckBox_Sites_Twitch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Sites_Twitch.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "SitesTwitch", true));
            this.CheckBox_Sites_Twitch.Location = new System.Drawing.Point(3, 247);
            this.CheckBox_Sites_Twitch.Name = "CheckBox_Sites_Twitch";
            this.CheckBox_Sites_Twitch.Size = new System.Drawing.Size(117, 15);
            this.CheckBox_Sites_Twitch.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBox_Sites_Twitch.TabIndex = 9;
            this.CheckBox_Sites_Twitch.Text = "passport.twitch.tv";
            this.CheckBox_Sites_Twitch.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CheckBox_Sites_Twitch.UseSelectable = true;
            // 
            // CheckBox_Sites_Tinder
            // 
            this.CheckBox_Sites_Tinder.AutoSize = true;
            this.CheckBox_Sites_Tinder.Checked = true;
            this.CheckBox_Sites_Tinder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Sites_Tinder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "SitesTinder", true));
            this.CheckBox_Sites_Tinder.Location = new System.Drawing.Point(122, 247);
            this.CheckBox_Sites_Tinder.Name = "CheckBox_Sites_Tinder";
            this.CheckBox_Sites_Tinder.Size = new System.Drawing.Size(114, 15);
            this.CheckBox_Sites_Tinder.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBox_Sites_Tinder.TabIndex = 10;
            this.CheckBox_Sites_Tinder.Text = "api.gotinder.com";
            this.CheckBox_Sites_Tinder.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CheckBox_Sites_Tinder.UseSelectable = true;
            // 
            // CheckBox_Sites_FindClone
            // 
            this.CheckBox_Sites_FindClone.AutoSize = true;
            this.CheckBox_Sites_FindClone.Checked = true;
            this.CheckBox_Sites_FindClone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Sites_FindClone.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "SitesFindClone", true));
            this.CheckBox_Sites_FindClone.Location = new System.Drawing.Point(88, 227);
            this.CheckBox_Sites_FindClone.Name = "CheckBox_Sites_FindClone";
            this.CheckBox_Sites_FindClone.Size = new System.Drawing.Size(87, 15);
            this.CheckBox_Sites_FindClone.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBox_Sites_FindClone.TabIndex = 8;
            this.CheckBox_Sites_FindClone.Text = "findclone.ru";
            this.CheckBox_Sites_FindClone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CheckBox_Sites_FindClone.UseSelectable = true;
            // 
            // ComboBox_ProxyType
            // 
            this.ComboBox_ProxyType.FormattingEnabled = true;
            this.ComboBox_ProxyType.ItemHeight = 23;
            this.ComboBox_ProxyType.Items.AddRange(new object[] {
            "HTTP",
            "SOCKS4",
            "SOCKS4A",
            "SOCKS5"});
            this.ComboBox_ProxyType.Location = new System.Drawing.Point(119, 164);
            this.ComboBox_ProxyType.Name = "ComboBox_ProxyType";
            this.ComboBox_ProxyType.Size = new System.Drawing.Size(113, 29);
            this.ComboBox_ProxyType.Style = MetroFramework.MetroColorStyle.Blue;
            this.ComboBox_ProxyType.TabIndex = 6;
            this.ComboBox_ProxyType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ComboBox_ProxyType.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(19, 169);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(83, 19);
            this.metroLabel10.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "Тип прокси:";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Button_LoadProxyFromTxt
            // 
            this.Button_LoadProxyFromTxt.Location = new System.Drawing.Point(119, 140);
            this.Button_LoadProxyFromTxt.Name = "Button_LoadProxyFromTxt";
            this.Button_LoadProxyFromTxt.Size = new System.Drawing.Size(112, 20);
            this.Button_LoadProxyFromTxt.Style = MetroFramework.MetroColorStyle.Blue;
            this.Button_LoadProxyFromTxt.TabIndex = 5;
            this.Button_LoadProxyFromTxt.Text = "Загрузить из txt";
            this.Button_LoadProxyFromTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_LoadProxyFromTxt.UseSelectable = true;
            this.Button_LoadProxyFromTxt.Click += new System.EventHandler(this.Button_LoadProxyFromTxt_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(30, 138);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(57, 19);
            this.metroLabel8.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Прокси:";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(-6, 198);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Сайты:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // CheckBox_Sites_Alpari
            // 
            this.CheckBox_Sites_Alpari.AutoSize = true;
            this.CheckBox_Sites_Alpari.Checked = true;
            this.CheckBox_Sites_Alpari.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_Sites_Alpari.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "SitesAlpari", true));
            this.CheckBox_Sites_Alpari.Location = new System.Drawing.Point(3, 227);
            this.CheckBox_Sites_Alpari.Name = "CheckBox_Sites_Alpari";
            this.CheckBox_Sites_Alpari.Size = new System.Drawing.Size(79, 15);
            this.CheckBox_Sites_Alpari.Style = MetroFramework.MetroColorStyle.Blue;
            this.CheckBox_Sites_Alpari.TabIndex = 7;
            this.CheckBox_Sites_Alpari.Text = "alpari.com";
            this.CheckBox_Sites_Alpari.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CheckBox_Sites_Alpari.UseSelectable = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroLabel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(235, 33);
            this.panel3.TabIndex = 4;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(-6, 4);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(104, 25);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Настройки:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Button_Stop
            // 
            this.Button_Stop.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Stop.Location = new System.Drawing.Point(75, 0);
            this.Button_Stop.Name = "Button_Stop";
            this.Button_Stop.Size = new System.Drawing.Size(75, 22);
            this.Button_Stop.Style = MetroFramework.MetroColorStyle.Blue;
            this.Button_Stop.TabIndex = 15;
            this.Button_Stop.Text = "Стоп";
            this.Button_Stop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_Stop.UseSelectable = true;
            this.Button_Stop.Click += new System.EventHandler(this.Button_Stop_Click);
            // 
            // Button_Start
            // 
            this.Button_Start.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button_Start.Location = new System.Drawing.Point(0, 0);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(75, 22);
            this.Button_Start.Style = MetroFramework.MetroColorStyle.Blue;
            this.Button_Start.TabIndex = 14;
            this.Button_Start.Text = "Старт";
            this.Button_Start.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_Start.UseSelectable = true;
            this.Button_Start.Click += new System.EventHandler(this.Button_Start_Click);
            // 
            // Label_NameProgramm
            // 
            this.Label_NameProgramm.AutoSize = true;
            this.Label_NameProgramm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Label_NameProgramm.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Label_NameProgramm.Location = new System.Drawing.Point(1, 8);
            this.Label_NameProgramm.Name = "Label_NameProgramm";
            this.Label_NameProgramm.Size = new System.Drawing.Size(176, 19);
            this.Label_NameProgramm.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label_NameProgramm.TabIndex = 8;
            this.Label_NameProgramm.Text = "SMS Bomber By DeWizzard";
            this.Label_NameProgramm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_NameProgramm.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label_NameProgramm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label_NameProgramm_MouseDown);
            // 
            // ProgressBar_CountCycle
            // 
            this.ProgressBar_CountCycle.Dock = System.Windows.Forms.DockStyle.Right;
            this.ProgressBar_CountCycle.Location = new System.Drawing.Point(147, 0);
            this.ProgressBar_CountCycle.Name = "ProgressBar_CountCycle";
            this.ProgressBar_CountCycle.Size = new System.Drawing.Size(615, 22);
            this.ProgressBar_CountCycle.Style = MetroFramework.MetroColorStyle.Blue;
            this.ProgressBar_CountCycle.TabIndex = 8;
            this.ProgressBar_CountCycle.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(473, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 350);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(238, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(235, 350);
            this.panel6.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.65958F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.34043F));
            this.tableLayoutPanel2.Controls.Add(this.Label_CountMadeCalls, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel11, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Label_CountSendingSms, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Label_CountProxy, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label_CountUsedProxy, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel15, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel12, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel13, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Label_CountActiveThreads, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 127);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // Label_CountMadeCalls
            // 
            this.Label_CountMadeCalls.AutoSize = true;
            this.Label_CountMadeCalls.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_CountMadeCalls.Location = new System.Drawing.Point(161, 78);
            this.Label_CountMadeCalls.Name = "Label_CountMadeCalls";
            this.Label_CountMadeCalls.Size = new System.Drawing.Size(71, 19);
            this.Label_CountMadeCalls.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label_CountMadeCalls.TabIndex = 10;
            this.Label_CountMadeCalls.Text = "0";
            this.Label_CountMadeCalls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_CountMadeCalls.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel11.Location = new System.Drawing.Point(3, 100);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(152, 27);
            this.metroLabel11.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel11.TabIndex = 7;
            this.metroLabel11.Text = "Активных потоков:";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Label_CountSendingSms
            // 
            this.Label_CountSendingSms.AutoSize = true;
            this.Label_CountSendingSms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_CountSendingSms.Location = new System.Drawing.Point(161, 52);
            this.Label_CountSendingSms.Name = "Label_CountSendingSms";
            this.Label_CountSendingSms.Size = new System.Drawing.Size(71, 26);
            this.Label_CountSendingSms.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label_CountSendingSms.TabIndex = 8;
            this.Label_CountSendingSms.Text = "0";
            this.Label_CountSendingSms.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_CountSendingSms.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Label_CountProxy
            // 
            this.Label_CountProxy.AutoSize = true;
            this.Label_CountProxy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_CountProxy.Location = new System.Drawing.Point(161, 0);
            this.Label_CountProxy.Name = "Label_CountProxy";
            this.Label_CountProxy.Size = new System.Drawing.Size(71, 26);
            this.Label_CountProxy.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label_CountProxy.TabIndex = 9;
            this.Label_CountProxy.Text = "0";
            this.Label_CountProxy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_CountProxy.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Label_CountUsedProxy
            // 
            this.Label_CountUsedProxy.AutoSize = true;
            this.Label_CountUsedProxy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_CountUsedProxy.Location = new System.Drawing.Point(161, 26);
            this.Label_CountUsedProxy.Name = "Label_CountUsedProxy";
            this.Label_CountUsedProxy.Size = new System.Drawing.Size(71, 26);
            this.Label_CountUsedProxy.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label_CountUsedProxy.TabIndex = 7;
            this.Label_CountUsedProxy.Text = "0";
            this.Label_CountUsedProxy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_CountUsedProxy.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel15.Location = new System.Drawing.Point(3, 78);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(152, 19);
            this.metroLabel15.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel15.TabIndex = 7;
            this.metroLabel15.Text = "Cделано звонков:";
            this.metroLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel12.Location = new System.Drawing.Point(3, 52);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(152, 19);
            this.metroLabel12.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel12.TabIndex = 3;
            this.metroLabel12.Text = "Отправлено sms:";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel13.Location = new System.Drawing.Point(3, 26);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(152, 19);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel13.TabIndex = 2;
            this.metroLabel13.Text = "Использовано прокси:";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel14.Location = new System.Drawing.Point(3, 0);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(152, 19);
            this.metroLabel14.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel14.TabIndex = 0;
            this.metroLabel14.Text = "Загружено прокси:";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Label_CountActiveThreads
            // 
            this.Label_CountActiveThreads.AutoSize = true;
            this.Label_CountActiveThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_CountActiveThreads.Location = new System.Drawing.Point(161, 100);
            this.Label_CountActiveThreads.Name = "Label_CountActiveThreads";
            this.Label_CountActiveThreads.Size = new System.Drawing.Size(71, 27);
            this.Label_CountActiveThreads.Style = MetroFramework.MetroColorStyle.Blue;
            this.Label_CountActiveThreads.TabIndex = 6;
            this.Label_CountActiveThreads.Text = "0";
            this.Label_CountActiveThreads.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_CountActiveThreads.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.metroLabel5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(235, 33);
            this.panel8.TabIndex = 5;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(-3, 4);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(103, 25);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Статистика:";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(235, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(3, 350);
            this.panel7.TabIndex = 11;
            // 
            // timer_UpdateTime
            // 
            this.timer_UpdateTime.Enabled = true;
            this.timer_UpdateTime.Interval = 1000;
            this.timer_UpdateTime.Tick += new System.EventHandler(this.timer_UpdateTime_Tick);
            // 
            // timer_UpdateWorkStats
            // 
            this.timer_UpdateWorkStats.Enabled = true;
            this.timer_UpdateWorkStats.Interval = 1000;
            this.timer_UpdateWorkStats.Tick += new System.EventHandler(this.timer_UpdateWorkStats_Tick);
            // 
            // pictureBox_ImageCaptcha
            // 
            this.pictureBox_ImageCaptcha.Location = new System.Drawing.Point(111, 293);
            this.pictureBox_ImageCaptcha.Name = "pictureBox_ImageCaptcha";
            this.pictureBox_ImageCaptcha.Size = new System.Drawing.Size(84, 23);
            this.pictureBox_ImageCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ImageCaptcha.TabIndex = 7;
            this.pictureBox_ImageCaptcha.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage_Main);
            this.metroTabControl1.Controls.Add(this.metroTabPage_Log);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 30);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(762, 392);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabControl1.TabIndex = 12;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage_Main
            // 
            this.metroTabPage_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage_Main.Controls.Add(this.panel9);
            this.metroTabPage_Main.Controls.Add(this.panel5);
            this.metroTabPage_Main.Controls.Add(this.panel6);
            this.metroTabPage_Main.Controls.Add(this.panel7);
            this.metroTabPage_Main.Controls.Add(this.panel_Settings);
            this.metroTabPage_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage_Main.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Main.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Main.HorizontalScrollbarSize = 10;
            this.metroTabPage_Main.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_Main.Name = "metroTabPage_Main";
            this.metroTabPage_Main.Size = new System.Drawing.Size(754, 350);
            this.metroTabPage_Main.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage_Main.TabIndex = 0;
            this.metroTabPage_Main.Text = "Главная";
            this.metroTabPage_Main.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage_Main.VerticalScrollbarBarColor = true;
            this.metroTabPage_Main.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Main.VerticalScrollbarSize = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.metroLabel16);
            this.panel9.Controls.Add(this.TextBox_Number_PhoneNumber);
            this.panel9.Controls.Add(this.Textbox_ResultCaptcha);
            this.panel9.Controls.Add(this.metroLabel18);
            this.panel9.Controls.Add(this.pictureBox_ImageCaptcha);
            this.panel9.Controls.Add(this.Button_OK_GetInfoNumber);
            this.panel9.Controls.Add(this.Button_UpdateCaptcha);
            this.panel9.Controls.Add(this.tableLayoutPanel3);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(476, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(274, 350);
            this.panel9.TabIndex = 12;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.ForeColor = System.Drawing.Color.Aqua;
            this.metroLabel16.Location = new System.Drawing.Point(3, 268);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(53, 19);
            this.metroLabel16.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel16.TabIndex = 15;
            this.metroLabel16.Text = "Номер:";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_Number_PhoneNumber
            // 
            // 
            // 
            // 
            this.TextBox_Number_PhoneNumber.CustomButton.Image = null;
            this.TextBox_Number_PhoneNumber.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_PhoneNumber.CustomButton.Name = "";
            this.TextBox_Number_PhoneNumber.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_PhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_PhoneNumber.CustomButton.TabIndex = 1;
            this.TextBox_Number_PhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_PhoneNumber.CustomButton.UseSelectable = true;
            this.TextBox_Number_PhoneNumber.CustomButton.Visible = false;
            this.TextBox_Number_PhoneNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "NumberPhoneNumber", true));
            this.TextBox_Number_PhoneNumber.Lines = new string[0];
            this.TextBox_Number_PhoneNumber.Location = new System.Drawing.Point(111, 268);
            this.TextBox_Number_PhoneNumber.MaxLength = 32767;
            this.TextBox_Number_PhoneNumber.Name = "TextBox_Number_PhoneNumber";
            this.TextBox_Number_PhoneNumber.PasswordChar = '\0';
            this.TextBox_Number_PhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_PhoneNumber.SelectedText = "";
            this.TextBox_Number_PhoneNumber.SelectionLength = 0;
            this.TextBox_Number_PhoneNumber.SelectionStart = 0;
            this.TextBox_Number_PhoneNumber.ShortcutsEnabled = true;
            this.TextBox_Number_PhoneNumber.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_PhoneNumber.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_PhoneNumber.TabIndex = 14;
            this.TextBox_Number_PhoneNumber.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_PhoneNumber.UseSelectable = true;
            this.TextBox_Number_PhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_PhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Textbox_ResultCaptcha
            // 
            // 
            // 
            // 
            this.Textbox_ResultCaptcha.CustomButton.Image = null;
            this.Textbox_ResultCaptcha.CustomButton.Location = new System.Drawing.Point(32, 1);
            this.Textbox_ResultCaptcha.CustomButton.Name = "";
            this.Textbox_ResultCaptcha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Textbox_ResultCaptcha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Textbox_ResultCaptcha.CustomButton.TabIndex = 1;
            this.Textbox_ResultCaptcha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Textbox_ResultCaptcha.CustomButton.UseSelectable = true;
            this.Textbox_ResultCaptcha.CustomButton.Visible = false;
            this.Textbox_ResultCaptcha.Lines = new string[0];
            this.Textbox_ResultCaptcha.Location = new System.Drawing.Point(111, 319);
            this.Textbox_ResultCaptcha.MaxLength = 32767;
            this.Textbox_ResultCaptcha.Name = "Textbox_ResultCaptcha";
            this.Textbox_ResultCaptcha.PasswordChar = '\0';
            this.Textbox_ResultCaptcha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Textbox_ResultCaptcha.SelectedText = "";
            this.Textbox_ResultCaptcha.SelectionLength = 0;
            this.Textbox_ResultCaptcha.SelectionStart = 0;
            this.Textbox_ResultCaptcha.ShortcutsEnabled = true;
            this.Textbox_ResultCaptcha.Size = new System.Drawing.Size(54, 23);
            this.Textbox_ResultCaptcha.Style = MetroFramework.MetroColorStyle.Blue;
            this.Textbox_ResultCaptcha.TabIndex = 17;
            this.Textbox_ResultCaptcha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Textbox_ResultCaptcha.UseSelectable = true;
            this.Textbox_ResultCaptcha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Textbox_ResultCaptcha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.Location = new System.Drawing.Point(3, 320);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(99, 19);
            this.metroLabel18.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel18.TabIndex = 12;
            this.metroLabel18.Text = "Введите капчу:";
            this.metroLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Button_OK_GetInfoNumber
            // 
            this.Button_OK_GetInfoNumber.Location = new System.Drawing.Point(161, 319);
            this.Button_OK_GetInfoNumber.Name = "Button_OK_GetInfoNumber";
            this.Button_OK_GetInfoNumber.Size = new System.Drawing.Size(34, 23);
            this.Button_OK_GetInfoNumber.Style = MetroFramework.MetroColorStyle.Blue;
            this.Button_OK_GetInfoNumber.TabIndex = 18;
            this.Button_OK_GetInfoNumber.Text = "ОК";
            this.Button_OK_GetInfoNumber.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_OK_GetInfoNumber.UseSelectable = true;
            this.Button_OK_GetInfoNumber.Click += new System.EventHandler(this.Button_OK_GetInfoNumber_Click);
            // 
            // Button_UpdateCaptcha
            // 
            this.Button_UpdateCaptcha.Location = new System.Drawing.Point(3, 293);
            this.Button_UpdateCaptcha.Name = "Button_UpdateCaptcha";
            this.Button_UpdateCaptcha.Size = new System.Drawing.Size(102, 23);
            this.Button_UpdateCaptcha.Style = MetroFramework.MetroColorStyle.Blue;
            this.Button_UpdateCaptcha.TabIndex = 16;
            this.Button_UpdateCaptcha.Text = "Обновить капчу";
            this.Button_UpdateCaptcha.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_UpdateCaptcha.UseSelectable = true;
            this.Button_UpdateCaptcha.Click += new System.EventHandler(this.Button_UpdateCaptcha_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.50178F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.49822F));
            this.tableLayoutPanel3.Controls.Add(this.TextBox_Number_Status, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_Number_MSC, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_Number_MNC, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_Number_MCC, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel29, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel27, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel25, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel17, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_Number_Network, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel19, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_Number_TimeZone, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel20, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_Number_Operator, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel21, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel22, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_Number_Country, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.metroLabel24, 0, 8);
            this.tableLayoutPanel3.Controls.Add(this.TextBox_Number_IMSI, 1, 6);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 9;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(274, 231);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // TextBox_Number_Status
            // 
            // 
            // 
            // 
            this.TextBox_Number_Status.CustomButton.Image = null;
            this.TextBox_Number_Status.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_Status.CustomButton.Name = "";
            this.TextBox_Number_Status.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_Status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_Status.CustomButton.TabIndex = 1;
            this.TextBox_Number_Status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_Status.CustomButton.UseSelectable = true;
            this.TextBox_Number_Status.CustomButton.Visible = false;
            this.TextBox_Number_Status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Number_Status.Lines = new string[0];
            this.TextBox_Number_Status.Location = new System.Drawing.Point(111, 211);
            this.TextBox_Number_Status.MaxLength = 32767;
            this.TextBox_Number_Status.Name = "TextBox_Number_Status";
            this.TextBox_Number_Status.PasswordChar = '\0';
            this.TextBox_Number_Status.ReadOnly = true;
            this.TextBox_Number_Status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_Status.SelectedText = "";
            this.TextBox_Number_Status.SelectionLength = 0;
            this.TextBox_Number_Status.SelectionStart = 0;
            this.TextBox_Number_Status.ShortcutsEnabled = true;
            this.TextBox_Number_Status.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_Status.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_Status.TabIndex = 28;
            this.TextBox_Number_Status.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_Status.UseSelectable = true;
            this.TextBox_Number_Status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_Status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBox_Number_MSC
            // 
            // 
            // 
            // 
            this.TextBox_Number_MSC.CustomButton.Image = null;
            this.TextBox_Number_MSC.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_MSC.CustomButton.Name = "";
            this.TextBox_Number_MSC.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_MSC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_MSC.CustomButton.TabIndex = 1;
            this.TextBox_Number_MSC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_MSC.CustomButton.UseSelectable = true;
            this.TextBox_Number_MSC.CustomButton.Visible = false;
            this.TextBox_Number_MSC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Number_MSC.Lines = new string[0];
            this.TextBox_Number_MSC.Location = new System.Drawing.Point(111, 185);
            this.TextBox_Number_MSC.MaxLength = 32767;
            this.TextBox_Number_MSC.Name = "TextBox_Number_MSC";
            this.TextBox_Number_MSC.PasswordChar = '\0';
            this.TextBox_Number_MSC.ReadOnly = true;
            this.TextBox_Number_MSC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_MSC.SelectedText = "";
            this.TextBox_Number_MSC.SelectionLength = 0;
            this.TextBox_Number_MSC.SelectionStart = 0;
            this.TextBox_Number_MSC.ShortcutsEnabled = true;
            this.TextBox_Number_MSC.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_MSC.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_MSC.TabIndex = 27;
            this.TextBox_Number_MSC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_MSC.UseSelectable = true;
            this.TextBox_Number_MSC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_MSC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBox_Number_MNC
            // 
            // 
            // 
            // 
            this.TextBox_Number_MNC.CustomButton.Image = null;
            this.TextBox_Number_MNC.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_MNC.CustomButton.Name = "";
            this.TextBox_Number_MNC.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_MNC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_MNC.CustomButton.TabIndex = 1;
            this.TextBox_Number_MNC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_MNC.CustomButton.UseSelectable = true;
            this.TextBox_Number_MNC.CustomButton.Visible = false;
            this.TextBox_Number_MNC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Number_MNC.Lines = new string[0];
            this.TextBox_Number_MNC.Location = new System.Drawing.Point(111, 133);
            this.TextBox_Number_MNC.MaxLength = 32767;
            this.TextBox_Number_MNC.Name = "TextBox_Number_MNC";
            this.TextBox_Number_MNC.PasswordChar = '\0';
            this.TextBox_Number_MNC.ReadOnly = true;
            this.TextBox_Number_MNC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_MNC.SelectedText = "";
            this.TextBox_Number_MNC.SelectionLength = 0;
            this.TextBox_Number_MNC.SelectionStart = 0;
            this.TextBox_Number_MNC.ShortcutsEnabled = true;
            this.TextBox_Number_MNC.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_MNC.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_MNC.TabIndex = 25;
            this.TextBox_Number_MNC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_MNC.UseSelectable = true;
            this.TextBox_Number_MNC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_MNC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TextBox_Number_MCC
            // 
            // 
            // 
            // 
            this.TextBox_Number_MCC.CustomButton.Image = null;
            this.TextBox_Number_MCC.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_MCC.CustomButton.Name = "";
            this.TextBox_Number_MCC.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_MCC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_MCC.CustomButton.TabIndex = 1;
            this.TextBox_Number_MCC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_MCC.CustomButton.UseSelectable = true;
            this.TextBox_Number_MCC.CustomButton.Visible = false;
            this.TextBox_Number_MCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Number_MCC.Lines = new string[0];
            this.TextBox_Number_MCC.Location = new System.Drawing.Point(111, 107);
            this.TextBox_Number_MCC.MaxLength = 32767;
            this.TextBox_Number_MCC.Name = "TextBox_Number_MCC";
            this.TextBox_Number_MCC.PasswordChar = '\0';
            this.TextBox_Number_MCC.ReadOnly = true;
            this.TextBox_Number_MCC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_MCC.SelectedText = "";
            this.TextBox_Number_MCC.SelectionLength = 0;
            this.TextBox_Number_MCC.SelectionStart = 0;
            this.TextBox_Number_MCC.ShortcutsEnabled = true;
            this.TextBox_Number_MCC.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_MCC.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_MCC.TabIndex = 24;
            this.TextBox_Number_MCC.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_MCC.UseSelectable = true;
            this.TextBox_Number_MCC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_MCC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel29
            // 
            this.metroLabel29.AutoSize = true;
            this.metroLabel29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel29.Location = new System.Drawing.Point(3, 182);
            this.metroLabel29.Name = "metroLabel29";
            this.metroLabel29.Size = new System.Drawing.Size(102, 26);
            this.metroLabel29.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel29.TabIndex = 22;
            this.metroLabel29.Text = "msc:";
            this.metroLabel29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel27.Location = new System.Drawing.Point(3, 156);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(102, 26);
            this.metroLabel27.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel27.TabIndex = 20;
            this.metroLabel27.Text = "imsi:";
            this.metroLabel27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel27.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel25.Location = new System.Drawing.Point(3, 130);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(102, 26);
            this.metroLabel25.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel25.TabIndex = 18;
            this.metroLabel25.Text = "mnc:";
            this.metroLabel25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel25.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel17.Location = new System.Drawing.Point(3, 104);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(102, 26);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel17.TabIndex = 16;
            this.metroLabel17.Text = "mcc:";
            this.metroLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_Number_Network
            // 
            // 
            // 
            // 
            this.TextBox_Number_Network.CustomButton.Image = null;
            this.TextBox_Number_Network.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_Network.CustomButton.Name = "";
            this.TextBox_Number_Network.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_Network.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_Network.CustomButton.TabIndex = 1;
            this.TextBox_Number_Network.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_Network.CustomButton.UseSelectable = true;
            this.TextBox_Number_Network.CustomButton.Visible = false;
            this.TextBox_Number_Network.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Number_Network.Lines = new string[0];
            this.TextBox_Number_Network.Location = new System.Drawing.Point(111, 81);
            this.TextBox_Number_Network.MaxLength = 32767;
            this.TextBox_Number_Network.Name = "TextBox_Number_Network";
            this.TextBox_Number_Network.PasswordChar = '\0';
            this.TextBox_Number_Network.ReadOnly = true;
            this.TextBox_Number_Network.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_Network.SelectedText = "";
            this.TextBox_Number_Network.SelectionLength = 0;
            this.TextBox_Number_Network.SelectionStart = 0;
            this.TextBox_Number_Network.ShortcutsEnabled = true;
            this.TextBox_Number_Network.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_Network.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_Network.TabIndex = 7;
            this.TextBox_Number_Network.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_Network.UseSelectable = true;
            this.TextBox_Number_Network.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_Network.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel19
            // 
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel19.Location = new System.Drawing.Point(3, 78);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(102, 19);
            this.metroLabel19.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel19.TabIndex = 6;
            this.metroLabel19.Text = "Сеть:";
            this.metroLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_Number_TimeZone
            // 
            // 
            // 
            // 
            this.TextBox_Number_TimeZone.CustomButton.Image = null;
            this.TextBox_Number_TimeZone.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_TimeZone.CustomButton.Name = "";
            this.TextBox_Number_TimeZone.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_TimeZone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_TimeZone.CustomButton.TabIndex = 1;
            this.TextBox_Number_TimeZone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_TimeZone.CustomButton.UseSelectable = true;
            this.TextBox_Number_TimeZone.CustomButton.Visible = false;
            this.TextBox_Number_TimeZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Number_TimeZone.Lines = new string[0];
            this.TextBox_Number_TimeZone.Location = new System.Drawing.Point(111, 55);
            this.TextBox_Number_TimeZone.MaxLength = 32767;
            this.TextBox_Number_TimeZone.Name = "TextBox_Number_TimeZone";
            this.TextBox_Number_TimeZone.PasswordChar = '\0';
            this.TextBox_Number_TimeZone.ReadOnly = true;
            this.TextBox_Number_TimeZone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_TimeZone.SelectedText = "";
            this.TextBox_Number_TimeZone.SelectionLength = 0;
            this.TextBox_Number_TimeZone.SelectionStart = 0;
            this.TextBox_Number_TimeZone.ShortcutsEnabled = true;
            this.TextBox_Number_TimeZone.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_TimeZone.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_TimeZone.TabIndex = 5;
            this.TextBox_Number_TimeZone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_TimeZone.UseSelectable = true;
            this.TextBox_Number_TimeZone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_TimeZone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel20.Location = new System.Drawing.Point(3, 52);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(102, 19);
            this.metroLabel20.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel20.TabIndex = 3;
            this.metroLabel20.Text = "Часовой пояс:";
            this.metroLabel20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_Number_Operator
            // 
            // 
            // 
            // 
            this.TextBox_Number_Operator.CustomButton.Image = null;
            this.TextBox_Number_Operator.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_Operator.CustomButton.Name = "";
            this.TextBox_Number_Operator.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_Operator.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_Operator.CustomButton.TabIndex = 1;
            this.TextBox_Number_Operator.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_Operator.CustomButton.UseSelectable = true;
            this.TextBox_Number_Operator.CustomButton.Visible = false;
            this.TextBox_Number_Operator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Number_Operator.Lines = new string[0];
            this.TextBox_Number_Operator.Location = new System.Drawing.Point(111, 29);
            this.TextBox_Number_Operator.MaxLength = 32767;
            this.TextBox_Number_Operator.Name = "TextBox_Number_Operator";
            this.TextBox_Number_Operator.PasswordChar = '\0';
            this.TextBox_Number_Operator.ReadOnly = true;
            this.TextBox_Number_Operator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_Operator.SelectedText = "";
            this.TextBox_Number_Operator.SelectionLength = 0;
            this.TextBox_Number_Operator.SelectionStart = 0;
            this.TextBox_Number_Operator.ShortcutsEnabled = true;
            this.TextBox_Number_Operator.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_Operator.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_Operator.TabIndex = 2;
            this.TextBox_Number_Operator.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_Operator.UseSelectable = true;
            this.TextBox_Number_Operator.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_Operator.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel21.Location = new System.Drawing.Point(3, 26);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(102, 19);
            this.metroLabel21.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel21.TabIndex = 2;
            this.metroLabel21.Text = "Оператор:";
            this.metroLabel21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel22.Location = new System.Drawing.Point(3, 0);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(102, 19);
            this.metroLabel22.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel22.TabIndex = 0;
            this.metroLabel22.Text = "Страна:";
            this.metroLabel22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel22.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_Number_Country
            // 
            // 
            // 
            // 
            this.TextBox_Number_Country.CustomButton.Image = null;
            this.TextBox_Number_Country.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_Country.CustomButton.Name = "";
            this.TextBox_Number_Country.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_Country.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_Country.CustomButton.TabIndex = 1;
            this.TextBox_Number_Country.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_Country.CustomButton.UseSelectable = true;
            this.TextBox_Number_Country.CustomButton.Visible = false;
            this.TextBox_Number_Country.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Number_Country.Lines = new string[0];
            this.TextBox_Number_Country.Location = new System.Drawing.Point(111, 3);
            this.TextBox_Number_Country.MaxLength = 32767;
            this.TextBox_Number_Country.Name = "TextBox_Number_Country";
            this.TextBox_Number_Country.PasswordChar = '\0';
            this.TextBox_Number_Country.ReadOnly = true;
            this.TextBox_Number_Country.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_Country.SelectedText = "";
            this.TextBox_Number_Country.SelectionLength = 0;
            this.TextBox_Number_Country.SelectionStart = 0;
            this.TextBox_Number_Country.ShortcutsEnabled = true;
            this.TextBox_Number_Country.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_Country.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_Country.TabIndex = 1;
            this.TextBox_Number_Country.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_Country.UseSelectable = true;
            this.TextBox_Number_Country.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_Country.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel24.Location = new System.Drawing.Point(3, 208);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(102, 26);
            this.metroLabel24.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel24.TabIndex = 23;
            this.metroLabel24.Text = "Статус:";
            this.metroLabel24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel24.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_Number_IMSI
            // 
            // 
            // 
            // 
            this.TextBox_Number_IMSI.CustomButton.Image = null;
            this.TextBox_Number_IMSI.CustomButton.Location = new System.Drawing.Point(142, 2);
            this.TextBox_Number_IMSI.CustomButton.Name = "";
            this.TextBox_Number_IMSI.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.TextBox_Number_IMSI.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_IMSI.CustomButton.TabIndex = 1;
            this.TextBox_Number_IMSI.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Number_IMSI.CustomButton.UseSelectable = true;
            this.TextBox_Number_IMSI.CustomButton.Visible = false;
            this.TextBox_Number_IMSI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Number_IMSI.Lines = new string[0];
            this.TextBox_Number_IMSI.Location = new System.Drawing.Point(111, 159);
            this.TextBox_Number_IMSI.MaxLength = 32767;
            this.TextBox_Number_IMSI.Name = "TextBox_Number_IMSI";
            this.TextBox_Number_IMSI.PasswordChar = '\0';
            this.TextBox_Number_IMSI.ReadOnly = true;
            this.TextBox_Number_IMSI.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Number_IMSI.SelectedText = "";
            this.TextBox_Number_IMSI.SelectionLength = 0;
            this.TextBox_Number_IMSI.SelectionStart = 0;
            this.TextBox_Number_IMSI.ShortcutsEnabled = true;
            this.TextBox_Number_IMSI.Size = new System.Drawing.Size(160, 20);
            this.TextBox_Number_IMSI.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Number_IMSI.TabIndex = 26;
            this.TextBox_Number_IMSI.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Number_IMSI.UseSelectable = true;
            this.TextBox_Number_IMSI.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Number_IMSI.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.metroLabel23);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(274, 33);
            this.panel10.TabIndex = 4;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel23.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel23.Location = new System.Drawing.Point(-3, 4);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(209, 25);
            this.metroLabel23.TabIndex = 3;
            this.metroLabel23.Text = "Информация о номере:";
            this.metroLabel23.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTabPage_Log
            // 
            this.metroTabPage_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroTabPage_Log.Controls.Add(this.panel1);
            this.metroTabPage_Log.HorizontalScrollbarBarColor = true;
            this.metroTabPage_Log.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Log.HorizontalScrollbarSize = 10;
            this.metroTabPage_Log.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage_Log.Name = "metroTabPage_Log";
            this.metroTabPage_Log.Size = new System.Drawing.Size(754, 350);
            this.metroTabPage_Log.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTabPage_Log.TabIndex = 1;
            this.metroTabPage_Log.Text = "Лог";
            this.metroTabPage_Log.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage_Log.VerticalScrollbarBarColor = true;
            this.metroTabPage_Log.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage_Log.VerticalScrollbarSize = 10;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.Label_Warning);
            this.panel11.Controls.Add(this.Button_ViewOnGithub);
            this.panel11.Controls.Add(this.panel2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(20, 422);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(762, 70);
            this.panel11.TabIndex = 13;
            // 
            // Label_Warning
            // 
            this.Label_Warning.AutoSize = true;
            this.Label_Warning.Location = new System.Drawing.Point(75, 53);
            this.Label_Warning.Name = "Label_Warning";
            this.Label_Warning.Size = new System.Drawing.Size(590, 19);
            this.Label_Warning.Style = MetroFramework.MetroColorStyle.Black;
            this.Label_Warning.TabIndex = 14;
            this.Label_Warning.Text = "Разработчик программы не несет ответственность за последствия использования прогр" +
    "аммы";
            this.Label_Warning.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Button_ViewOnGithub
            // 
            this.Button_ViewOnGithub.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_ViewOnGithub.Location = new System.Drawing.Point(0, 22);
            this.Button_ViewOnGithub.Name = "Button_ViewOnGithub";
            this.Button_ViewOnGithub.Size = new System.Drawing.Size(762, 28);
            this.Button_ViewOnGithub.Style = MetroFramework.MetroColorStyle.Blue;
            this.Button_ViewOnGithub.TabIndex = 19;
            this.Button_ViewOnGithub.Text = "View on Github, Current Version 1.0";
            this.Button_ViewOnGithub.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_ViewOnGithub.UseSelectable = true;
            this.Button_ViewOnGithub.Click += new System.EventHandler(this.Button_ViewOnGithub_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ProgressBar_CountCycle);
            this.panel2.Controls.Add(this.Button_Stop);
            this.panel2.Controls.Add(this.Button_Start);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 22);
            this.panel2.TabIndex = 9;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(SmsBomber.ControlsViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 512);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Label_NameProgramm);
            this.Controls.Add(this.panel11);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Sms Bomber By DeWizzard";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel_Settings.ResumeLayout(false);
            this.panel_Settings.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ImageCaptcha)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage_Main.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.metroTabPage_Log.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Settings;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBox_Delay;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Sites_Alpari;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroTextBox TextBox_CountThreads;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton Button_Stop;
        private MetroFramework.Controls.MetroButton Button_Start;
        private MetroFramework.Controls.MetroTextBox TextBox_PhoneNumber;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton Button_ClearLog;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel Label_NameProgramm;
        private MetroFramework.Controls.MetroProgressBar ProgressBar_CountCycle;
        private MetroFramework.Controls.MetroButton Button_LoadProxyFromTxt;
        private MetroFramework.Controls.MetroComboBox ComboBox_ProxyType;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroLabel Label_CountActiveThreads;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.Panel panel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel Label_CountUsedProxy;
        private MetroFramework.Controls.MetroLabel Label_CountSendingSms;
        private MetroFramework.Controls.MetroLabel Label_CountProxy;
        private System.Windows.Forms.Timer timer_UpdateTime;
        private System.Windows.Forms.Timer timer_UpdateWorkStats;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Sites_FindClone;
        private MetroFramework.Controls.MetroLabel Label_CountMadeCalls;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Sites_Tinder;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Sites_Twitch;
        private System.Windows.Forms.PictureBox pictureBox_ImageCaptcha;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage_Main;
        private MetroFramework.Controls.MetroTabPage metroTabPage_Log;
        private System.Windows.Forms.Panel panel9;
        private MetroFramework.Controls.MetroButton Button_UpdateCaptcha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_Network;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_TimeZone;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_Operator;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_Country;
        private System.Windows.Forms.Panel panel10;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroButton Button_OK_GetInfoNumber;
        private MetroFramework.Controls.MetroTextBox Textbox_ResultCaptcha;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_PhoneNumber;
        private MetroFramework.Controls.MetroLabel metroLabel29;
        private MetroFramework.Controls.MetroLabel metroLabel27;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_MCC;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_Status;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_MSC;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_IMSI;
        private MetroFramework.Controls.MetroTextBox TextBox_Number_MNC;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Sites_Invitro;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Sites_Youla;
        private MetroFramework.Controls.MetroCheckBox CheckBox_Sites_GuruTaxi;
        private System.Windows.Forms.RichTextBox RichTextBox_Log;
        private MetroFramework.Controls.MetroLabel Label_LogCounter;
        public MetroFramework.Controls.MetroTextBox TextBox_CountCycle;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.BindingSource bindingSource;
        private MetroFramework.Controls.MetroLabel Label_Warning;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton Button_ViewOnGithub;
    }
}

