namespace ANOGround
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Iocomp.Classes.PlotChannelTrace plotChannelTrace1 = new Iocomp.Classes.PlotChannelTrace();
            Iocomp.Classes.PlotChannelTrace plotChannelTrace2 = new Iocomp.Classes.PlotChannelTrace();
            Iocomp.Classes.PlotDataCursorXY plotDataCursorXY1 = new Iocomp.Classes.PlotDataCursorXY();
            Iocomp.Classes.PlotDataView plotDataView1 = new Iocomp.Classes.PlotDataView();
            Iocomp.Classes.PlotLabelBasic plotLabelBasic1 = new Iocomp.Classes.PlotLabelBasic();
            Iocomp.Classes.PlotLegendBasic plotLegendBasic1 = new Iocomp.Classes.PlotLegendBasic();
            Iocomp.Classes.PlotXAxis plotXAxis1 = new Iocomp.Classes.PlotXAxis();
            Iocomp.Classes.PlotYAxis plotYAxis1 = new Iocomp.Classes.PlotYAxis();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_txcnt = new System.Windows.Forms.Label();
            this.lbl_rxcnt = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btn_com_close = new System.Windows.Forms.Button();
            this.btn_com_open = new System.Windows.Forms.Button();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_comname = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage_rxtx = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rdb_tx_chr = new System.Windows.Forms.RadioButton();
            this.rdb_tx_hex = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rdb_rx_chr = new System.Windows.Forms.RadioButton();
            this.rdb_rx_hex = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_com_send = new System.Windows.Forms.Button();
            this.richTextBox_tx = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox_rx = new System.Windows.Forms.RichTextBox();
            this.tabPage_datashow = new System.Windows.Forms.TabPage();
            this.grp_8 = new System.Windows.Forms.GroupBox();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.verticalSpeedIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.VerticalSpeedIndicatorInstrumentControl();
            this.turnCoordinatorInstrumentControl1 = new AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.attitudeIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
            this.altimeterInstrumentControl1 = new AvionicsInstrumentControlDemo.AltimeterInstrumentControl();
            this.airSpeedIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AirSpeedIndicatorInstrumentControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_vot_1 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_moto_8 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tb_moto_4 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tb_moto_7 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_moto_6 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_moto_5 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_moto_3 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_moto_2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_moto_1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_alt_prs = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_alt_csb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_mag_z = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_mag_y = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_mag_x = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_armed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_yaw = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_pit = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_rol = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_gyr_z = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_gyr_y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_gyr_x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_acc_z = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_acc_y = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_acc_x = new System.Windows.Forms.TextBox();
            this.tabPage_set = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage_scope = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_pause = new System.Windows.Forms.Button();
            this.iocomp = new System.Windows.Forms.TabPage();
            this.plotToolBarStandard1 = new Iocomp.Instrumentation.Plotting.PlotToolBarStandard();
            this.plotToolBarButton1 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton2 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton3 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton4 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton5 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton6 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton7 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton8 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton9 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton10 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton11 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton12 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton13 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton14 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton15 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton16 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton17 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton18 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton19 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton20 = new Iocomp.Classes.PlotToolBarButton();
            this.plotToolBarButton21 = new Iocomp.Classes.PlotToolBarButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.plot1 = new Iocomp.Instrumentation.Plotting.Plot();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxWantDis = new System.Windows.Forms.CheckBox();
            this.btnCloseBarrier = new System.Windows.Forms.Button();
            this.btnOPenBarrier = new System.Windows.Forms.Button();
            this.checkBoxDestination = new System.Windows.Forms.CheckBox();
            this.headingDirection = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.label32 = new System.Windows.Forms.Label();
            this.txtazimuth = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtdistanceAll = new System.Windows.Forms.TextBox();
            this.checkBoxGPS = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtDistance2 = new System.Windows.Forms.TextBox();
            this.checkBoxAddLine = new System.Windows.Forms.CheckBox();
            this.checkBoxMarker = new System.Windows.Forms.CheckBox();
            this.textBoxlng = new System.Windows.Forms.TextBox();
            this.btn_aq_gps = new System.Windows.Forms.Button();
            this.textBoxlat = new System.Windows.Forms.TextBox();
            this.MainMap = new GMap.NET.WindowsForms.GMapControl();
            this.btnyes = new System.Windows.Forms.Button();
            this.timer_ui = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1.SuspendLayout();
            this.tabControl_main.SuspendLayout();
            this.tabPage_rxtx.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage_datashow.SuspendLayout();
            this.grp_8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage_set.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage_scope.SuspendLayout();
            this.iocomp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_txcnt);
            this.groupBox1.Controls.Add(this.lbl_rxcnt);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.btn_com_close);
            this.groupBox1.Controls.Add(this.btn_com_open);
            this.groupBox1.Controls.Add(this.comboBox_baudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_comname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(984, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // lbl_txcnt
            // 
            this.lbl_txcnt.AutoSize = true;
            this.lbl_txcnt.Location = new System.Drawing.Point(90, 102);
            this.lbl_txcnt.Name = "lbl_txcnt";
            this.lbl_txcnt.Size = new System.Drawing.Size(11, 12);
            this.lbl_txcnt.TabIndex = 9;
            this.lbl_txcnt.Text = "0";
            // 
            // lbl_rxcnt
            // 
            this.lbl_rxcnt.AutoSize = true;
            this.lbl_rxcnt.Location = new System.Drawing.Point(90, 80);
            this.lbl_rxcnt.Name = "lbl_rxcnt";
            this.lbl_rxcnt.Size = new System.Drawing.Size(11, 12);
            this.lbl_rxcnt.TabIndex = 8;
            this.lbl_rxcnt.Text = "0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(4, 102);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 12);
            this.label26.TabIndex = 7;
            this.label26.Text = "串口发送计数";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(4, 80);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(77, 12);
            this.label27.TabIndex = 6;
            this.label27.Text = "串口接收计数";
            // 
            // btn_com_close
            // 
            this.btn_com_close.Enabled = false;
            this.btn_com_close.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_com_close.Location = new System.Drawing.Point(5, 168);
            this.btn_com_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_com_close.Name = "btn_com_close";
            this.btn_com_close.Size = new System.Drawing.Size(180, 38);
            this.btn_com_close.TabIndex = 5;
            this.btn_com_close.Text = "关闭串口";
            this.btn_com_close.UseVisualStyleBackColor = true;
            this.btn_com_close.Click += new System.EventHandler(this.btn_com_close_Click);
            // 
            // btn_com_open
            // 
            this.btn_com_open.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_com_open.Location = new System.Drawing.Point(5, 125);
            this.btn_com_open.Margin = new System.Windows.Forms.Padding(2);
            this.btn_com_open.Name = "btn_com_open";
            this.btn_com_open.Size = new System.Drawing.Size(180, 38);
            this.btn_com_open.TabIndex = 4;
            this.btn_com_open.Text = "打开串口";
            this.btn_com_open.UseVisualStyleBackColor = true;
            this.btn_com_open.Click += new System.EventHandler(this.btn_com_open_Click);
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "15200",
            "38400",
            "115200",
            "256000",
            "500000"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(92, 41);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(81, 20);
            this.comboBox_baudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // comboBox_comname
            // 
            this.comboBox_comname.FormattingEnabled = true;
            this.comboBox_comname.Location = new System.Drawing.Point(92, 19);
            this.comboBox_comname.Name = "comboBox_comname";
            this.comboBox_comname.Size = new System.Drawing.Size(81, 20);
            this.comboBox_comname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号";
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage_rxtx);
            this.tabControl_main.Controls.Add(this.tabPage_datashow);
            this.tabControl_main.Controls.Add(this.tabPage_set);
            this.tabControl_main.Controls.Add(this.tabPage_scope);
            this.tabControl_main.Controls.Add(this.iocomp);
            this.tabControl_main.Controls.Add(this.tabPage1);
            this.tabControl_main.Location = new System.Drawing.Point(9, 10);
            this.tabControl_main.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_main.Multiline = true;
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(970, 642);
            this.tabControl_main.TabIndex = 5;
            this.tabControl_main.SelectedIndexChanged += new System.EventHandler(this.tabControl_main_SelectedIndexChanged_1);
            // 
            // tabPage_rxtx
            // 
            this.tabPage_rxtx.Controls.Add(this.groupBox5);
            this.tabPage_rxtx.Controls.Add(this.groupBox4);
            this.tabPage_rxtx.Controls.Add(this.groupBox3);
            this.tabPage_rxtx.Location = new System.Drawing.Point(4, 22);
            this.tabPage_rxtx.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_rxtx.Name = "tabPage_rxtx";
            this.tabPage_rxtx.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_rxtx.Size = new System.Drawing.Size(962, 616);
            this.tabPage_rxtx.TabIndex = 1;
            this.tabPage_rxtx.Text = "串口基本收发";
            this.tabPage_rxtx.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(582, 464);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(377, 150);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "收发设置";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rdb_tx_chr);
            this.groupBox7.Controls.Add(this.rdb_tx_hex);
            this.groupBox7.Location = new System.Drawing.Point(194, 19);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(178, 126);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "发送设置";
            // 
            // rdb_tx_chr
            // 
            this.rdb_tx_chr.AutoSize = true;
            this.rdb_tx_chr.Location = new System.Drawing.Point(45, 70);
            this.rdb_tx_chr.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_tx_chr.Name = "rdb_tx_chr";
            this.rdb_tx_chr.Size = new System.Drawing.Size(83, 16);
            this.rdb_tx_chr.TabIndex = 3;
            this.rdb_tx_chr.Text = "字符串格式";
            this.rdb_tx_chr.UseVisualStyleBackColor = true;
            // 
            // rdb_tx_hex
            // 
            this.rdb_tx_hex.AutoSize = true;
            this.rdb_tx_hex.Checked = true;
            this.rdb_tx_hex.Location = new System.Drawing.Point(45, 40);
            this.rdb_tx_hex.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_tx_hex.Name = "rdb_tx_hex";
            this.rdb_tx_hex.Size = new System.Drawing.Size(95, 16);
            this.rdb_tx_hex.TabIndex = 2;
            this.rdb_tx_hex.TabStop = true;
            this.rdb_tx_hex.Text = "十六进制格式";
            this.rdb_tx_hex.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rdb_rx_chr);
            this.groupBox6.Controls.Add(this.rdb_rx_hex);
            this.groupBox6.Location = new System.Drawing.Point(4, 19);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(178, 126);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "接收设置";
            // 
            // rdb_rx_chr
            // 
            this.rdb_rx_chr.AutoSize = true;
            this.rdb_rx_chr.Location = new System.Drawing.Point(45, 71);
            this.rdb_rx_chr.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_rx_chr.Name = "rdb_rx_chr";
            this.rdb_rx_chr.Size = new System.Drawing.Size(83, 16);
            this.rdb_rx_chr.TabIndex = 1;
            this.rdb_rx_chr.Text = "字符串格式";
            this.rdb_rx_chr.UseVisualStyleBackColor = true;
            // 
            // rdb_rx_hex
            // 
            this.rdb_rx_hex.AutoSize = true;
            this.rdb_rx_hex.Checked = true;
            this.rdb_rx_hex.Location = new System.Drawing.Point(45, 42);
            this.rdb_rx_hex.Margin = new System.Windows.Forms.Padding(2);
            this.rdb_rx_hex.Name = "rdb_rx_hex";
            this.rdb_rx_hex.Size = new System.Drawing.Size(95, 16);
            this.rdb_rx_hex.TabIndex = 0;
            this.rdb_rx_hex.TabStop = true;
            this.rdb_rx_hex.Text = "十六进制格式";
            this.rdb_rx_hex.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_com_send);
            this.groupBox4.Controls.Add(this.richTextBox_tx);
            this.groupBox4.Location = new System.Drawing.Point(582, 5);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(377, 454);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "串口发送";
            // 
            // btn_com_send
            // 
            this.btn_com_send.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_com_send.Location = new System.Drawing.Point(4, 382);
            this.btn_com_send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_com_send.Name = "btn_com_send";
            this.btn_com_send.Size = new System.Drawing.Size(368, 67);
            this.btn_com_send.TabIndex = 1;
            this.btn_com_send.Text = "串口发送";
            this.btn_com_send.UseVisualStyleBackColor = true;
            this.btn_com_send.Click += new System.EventHandler(this.btn_com_send_Click);
            // 
            // richTextBox_tx
            // 
            this.richTextBox_tx.Location = new System.Drawing.Point(4, 19);
            this.richTextBox_tx.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_tx.Name = "richTextBox_tx";
            this.richTextBox_tx.Size = new System.Drawing.Size(369, 359);
            this.richTextBox_tx.TabIndex = 0;
            this.richTextBox_tx.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox_rx);
            this.groupBox3.Location = new System.Drawing.Point(4, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(573, 609);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "收码显示";
            // 
            // richTextBox_rx
            // 
            this.richTextBox_rx.Location = new System.Drawing.Point(4, 19);
            this.richTextBox_rx.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_rx.Name = "richTextBox_rx";
            this.richTextBox_rx.Size = new System.Drawing.Size(565, 586);
            this.richTextBox_rx.TabIndex = 0;
            this.richTextBox_rx.Text = "";
            // 
            // tabPage_datashow
            // 
            this.tabPage_datashow.Controls.Add(this.grp_8);
            this.tabPage_datashow.Controls.Add(this.groupBox2);
            this.tabPage_datashow.Location = new System.Drawing.Point(4, 22);
            this.tabPage_datashow.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_datashow.Name = "tabPage_datashow";
            this.tabPage_datashow.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage_datashow.Size = new System.Drawing.Size(962, 616);
            this.tabPage_datashow.TabIndex = 0;
            this.tabPage_datashow.Text = "解码数据显示";
            this.tabPage_datashow.UseVisualStyleBackColor = true;
            // 
            // grp_8
            // 
            this.grp_8.Controls.Add(this.label29);
            this.grp_8.Controls.Add(this.pictureBox2);
            this.grp_8.Controls.Add(this.verticalSpeedIndicatorInstrumentControl1);
            this.grp_8.Controls.Add(this.turnCoordinatorInstrumentControl1);
            this.grp_8.Controls.Add(this.headingIndicatorInstrumentControl1);
            this.grp_8.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.grp_8.Controls.Add(this.altimeterInstrumentControl1);
            this.grp_8.Controls.Add(this.airSpeedIndicatorInstrumentControl1);
            this.grp_8.Location = new System.Drawing.Point(5, 215);
            this.grp_8.Margin = new System.Windows.Forms.Padding(2);
            this.grp_8.Name = "grp_8";
            this.grp_8.Padding = new System.Windows.Forms.Padding(2);
            this.grp_8.Size = new System.Drawing.Size(953, 399);
            this.grp_8.TabIndex = 5;
            this.grp_8.TabStop = false;
            this.grp_8.Text = "状态显示";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(514, 27);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 12);
            this.label29.TabIndex = 18;
            this.label29.Text = "固定节点1图像";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(603, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(314, 342);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // verticalSpeedIndicatorInstrumentControl1
            // 
            this.verticalSpeedIndicatorInstrumentControl1.Location = new System.Drawing.Point(175, 27);
            this.verticalSpeedIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(2);
            this.verticalSpeedIndicatorInstrumentControl1.Name = "verticalSpeedIndicatorInstrumentControl1";
            this.verticalSpeedIndicatorInstrumentControl1.Size = new System.Drawing.Size(165, 176);
            this.verticalSpeedIndicatorInstrumentControl1.TabIndex = 16;
            this.verticalSpeedIndicatorInstrumentControl1.Text = "verticalSpeedIndicatorInstrumentControl1";
            // 
            // turnCoordinatorInstrumentControl1
            // 
            this.turnCoordinatorInstrumentControl1.Location = new System.Drawing.Point(4, 27);
            this.turnCoordinatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(2);
            this.turnCoordinatorInstrumentControl1.Name = "turnCoordinatorInstrumentControl1";
            this.turnCoordinatorInstrumentControl1.Size = new System.Drawing.Size(165, 176);
            this.turnCoordinatorInstrumentControl1.TabIndex = 15;
            this.turnCoordinatorInstrumentControl1.Text = "turnCoordinatorInstrumentControl1";
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(344, 208);
            this.headingIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(2);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(165, 176);
            this.headingIndicatorInstrumentControl1.TabIndex = 14;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(344, 27);
            this.attitudeIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(2);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(165, 176);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 13;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // altimeterInstrumentControl1
            // 
            this.altimeterInstrumentControl1.Location = new System.Drawing.Point(175, 208);
            this.altimeterInstrumentControl1.Margin = new System.Windows.Forms.Padding(2);
            this.altimeterInstrumentControl1.Name = "altimeterInstrumentControl1";
            this.altimeterInstrumentControl1.Size = new System.Drawing.Size(165, 176);
            this.altimeterInstrumentControl1.TabIndex = 12;
            this.altimeterInstrumentControl1.Text = "altimeterInstrumentControl1";
            // 
            // airSpeedIndicatorInstrumentControl1
            // 
            this.airSpeedIndicatorInstrumentControl1.Location = new System.Drawing.Point(4, 208);
            this.airSpeedIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(2);
            this.airSpeedIndicatorInstrumentControl1.Name = "airSpeedIndicatorInstrumentControl1";
            this.airSpeedIndicatorInstrumentControl1.Size = new System.Drawing.Size(165, 176);
            this.airSpeedIndicatorInstrumentControl1.TabIndex = 11;
            this.airSpeedIndicatorInstrumentControl1.Text = "airSpeedIndicatorInstrumentControl1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.tb_vot_1);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.tb_moto_8);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.tb_moto_4);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.tb_moto_7);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.tb_moto_6);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.tb_moto_5);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tb_moto_3);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tb_moto_2);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.tb_moto_1);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tb_alt_prs);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tb_alt_csb);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tb_mag_z);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tb_mag_y);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tb_mag_x);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_armed);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tb_yaw);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tb_pit);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_rol);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_gyr_z);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_gyr_y);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_gyr_x);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tb_acc_z);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_acc_y);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_acc_x);
            this.groupBox2.Location = new System.Drawing.Point(5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(953, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "解码数据显示";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(171, 172);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(42, 22);
            this.label28.TabIndex = 47;
            this.label28.Text = "电压";
            // 
            // tb_vot_1
            // 
            this.tb_vot_1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_vot_1.Location = new System.Drawing.Point(238, 171);
            this.tb_vot_1.Name = "tb_vot_1";
            this.tb_vot_1.Size = new System.Drawing.Size(63, 26);
            this.tb_vot_1.TabIndex = 46;
            this.tb_vot_1.Text = "65535";
            this.tb_vot_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(306, 180);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(96, 22);
            this.label24.TabIndex = 45;
            this.label24.Text = "电机8PWM";
            // 
            // tb_moto_8
            // 
            this.tb_moto_8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_moto_8.Location = new System.Drawing.Point(402, 178);
            this.tb_moto_8.Name = "tb_moto_8";
            this.tb_moto_8.Size = new System.Drawing.Size(63, 26);
            this.tb_moto_8.TabIndex = 44;
            this.tb_moto_8.Text = "65535";
            this.tb_moto_8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(306, 85);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(96, 22);
            this.label25.TabIndex = 43;
            this.label25.Text = "电机4PWM";
            // 
            // tb_moto_4
            // 
            this.tb_moto_4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_moto_4.Location = new System.Drawing.Point(402, 82);
            this.tb_moto_4.Name = "tb_moto_4";
            this.tb_moto_4.Size = new System.Drawing.Size(63, 26);
            this.tb_moto_4.TabIndex = 42;
            this.tb_moto_4.Text = "65535";
            this.tb_moto_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(306, 157);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(96, 22);
            this.label21.TabIndex = 41;
            this.label21.Text = "电机7PWM";
            // 
            // tb_moto_7
            // 
            this.tb_moto_7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_moto_7.Location = new System.Drawing.Point(402, 154);
            this.tb_moto_7.Name = "tb_moto_7";
            this.tb_moto_7.Size = new System.Drawing.Size(63, 26);
            this.tb_moto_7.TabIndex = 40;
            this.tb_moto_7.Text = "65535";
            this.tb_moto_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(306, 133);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 22);
            this.label22.TabIndex = 39;
            this.label22.Text = "电机6PWM";
            // 
            // tb_moto_6
            // 
            this.tb_moto_6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_moto_6.Location = new System.Drawing.Point(402, 130);
            this.tb_moto_6.Name = "tb_moto_6";
            this.tb_moto_6.Size = new System.Drawing.Size(63, 26);
            this.tb_moto_6.TabIndex = 38;
            this.tb_moto_6.Text = "65535";
            this.tb_moto_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(306, 109);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 22);
            this.label23.TabIndex = 37;
            this.label23.Text = "电机5PWM";
            // 
            // tb_moto_5
            // 
            this.tb_moto_5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_moto_5.Location = new System.Drawing.Point(402, 106);
            this.tb_moto_5.Name = "tb_moto_5";
            this.tb_moto_5.Size = new System.Drawing.Size(63, 26);
            this.tb_moto_5.TabIndex = 36;
            this.tb_moto_5.Text = "65535";
            this.tb_moto_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(306, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 22);
            this.label18.TabIndex = 35;
            this.label18.Text = "电机3PWM";
            // 
            // tb_moto_3
            // 
            this.tb_moto_3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_moto_3.Location = new System.Drawing.Point(402, 59);
            this.tb_moto_3.Name = "tb_moto_3";
            this.tb_moto_3.Size = new System.Drawing.Size(63, 26);
            this.tb_moto_3.TabIndex = 34;
            this.tb_moto_3.Text = "65535";
            this.tb_moto_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(306, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(96, 22);
            this.label19.TabIndex = 33;
            this.label19.Text = "电机2PWM";
            // 
            // tb_moto_2
            // 
            this.tb_moto_2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_moto_2.Location = new System.Drawing.Point(402, 35);
            this.tb_moto_2.Name = "tb_moto_2";
            this.tb_moto_2.Size = new System.Drawing.Size(63, 26);
            this.tb_moto_2.TabIndex = 32;
            this.tb_moto_2.Text = "65535";
            this.tb_moto_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(306, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 22);
            this.label20.TabIndex = 31;
            this.label20.Text = "电机1PWM";
            // 
            // tb_moto_1
            // 
            this.tb_moto_1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_moto_1.Location = new System.Drawing.Point(402, 11);
            this.tb_moto_1.Name = "tb_moto_1";
            this.tb_moto_1.Size = new System.Drawing.Size(63, 26);
            this.tb_moto_1.TabIndex = 30;
            this.tb_moto_1.Text = "65535";
            this.tb_moto_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(148, 140);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 22);
            this.label16.TabIndex = 29;
            this.label16.Text = "气压计高度";
            // 
            // tb_alt_prs
            // 
            this.tb_alt_prs.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_alt_prs.Location = new System.Drawing.Point(238, 140);
            this.tb_alt_prs.Name = "tb_alt_prs";
            this.tb_alt_prs.Size = new System.Drawing.Size(63, 26);
            this.tb_alt_prs.TabIndex = 28;
            this.tb_alt_prs.Text = "65535";
            this.tb_alt_prs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(148, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 22);
            this.label17.TabIndex = 27;
            this.label17.Text = "超声波高度";
            // 
            // tb_alt_csb
            // 
            this.tb_alt_csb.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_alt_csb.Location = new System.Drawing.Point(238, 110);
            this.tb_alt_csb.Name = "tb_alt_csb";
            this.tb_alt_csb.Size = new System.Drawing.Size(63, 26);
            this.tb_alt_csb.TabIndex = 26;
            this.tb_alt_csb.Text = "65535";
            this.tb_alt_csb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(164, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 22);
            this.label13.TabIndex = 25;
            this.label13.Text = "罗盘 Z";
            // 
            // tb_mag_z
            // 
            this.tb_mag_z.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_mag_z.Location = new System.Drawing.Point(238, 81);
            this.tb_mag_z.Name = "tb_mag_z";
            this.tb_mag_z.Size = new System.Drawing.Size(63, 26);
            this.tb_mag_z.TabIndex = 24;
            this.tb_mag_z.Text = "65535";
            this.tb_mag_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(164, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 22);
            this.label14.TabIndex = 23;
            this.label14.Text = "罗盘 Y";
            // 
            // tb_mag_y
            // 
            this.tb_mag_y.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_mag_y.Location = new System.Drawing.Point(238, 50);
            this.tb_mag_y.Name = "tb_mag_y";
            this.tb_mag_y.Size = new System.Drawing.Size(63, 26);
            this.tb_mag_y.TabIndex = 22;
            this.tb_mag_y.Text = "65535";
            this.tb_mag_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(164, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 22);
            this.label15.TabIndex = 21;
            this.label15.Text = "罗盘 X";
            // 
            // tb_mag_x
            // 
            this.tb_mag_x.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_mag_x.Location = new System.Drawing.Point(238, 20);
            this.tb_mag_x.Name = "tb_mag_x";
            this.tb_mag_x.Size = new System.Drawing.Size(63, 26);
            this.tb_mag_x.TabIndex = 20;
            this.tb_mag_x.Text = "65535";
            this.tb_mag_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(469, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "主控状态";
            // 
            // tb_armed
            // 
            this.tb_armed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_armed.Location = new System.Drawing.Point(551, 110);
            this.tb_armed.Name = "tb_armed";
            this.tb_armed.Size = new System.Drawing.Size(63, 26);
            this.tb_armed.TabIndex = 18;
            this.tb_armed.Text = "锁定";
            this.tb_armed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(476, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "航向角";
            // 
            // tb_yaw
            // 
            this.tb_yaw.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_yaw.Location = new System.Drawing.Point(550, 80);
            this.tb_yaw.Name = "tb_yaw";
            this.tb_yaw.Size = new System.Drawing.Size(63, 26);
            this.tb_yaw.TabIndex = 16;
            this.tb_yaw.Text = "65535";
            this.tb_yaw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(476, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 22);
            this.label10.TabIndex = 15;
            this.label10.Text = "俯仰角";
            // 
            // tb_pit
            // 
            this.tb_pit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pit.Location = new System.Drawing.Point(550, 49);
            this.tb_pit.Name = "tb_pit";
            this.tb_pit.Size = new System.Drawing.Size(63, 26);
            this.tb_pit.TabIndex = 14;
            this.tb_pit.Text = "65535";
            this.tb_pit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(476, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "横滚角";
            // 
            // tb_rol
            // 
            this.tb_rol.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_rol.Location = new System.Drawing.Point(550, 19);
            this.tb_rol.Name = "tb_rol";
            this.tb_rol.Size = new System.Drawing.Size(63, 26);
            this.tb_rol.TabIndex = 12;
            this.tb_rol.Text = "65535";
            this.tb_rol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(6, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "陀螺仪Z";
            // 
            // tb_gyr_z
            // 
            this.tb_gyr_z.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_gyr_z.Location = new System.Drawing.Point(80, 172);
            this.tb_gyr_z.Name = "tb_gyr_z";
            this.tb_gyr_z.Size = new System.Drawing.Size(63, 26);
            this.tb_gyr_z.TabIndex = 10;
            this.tb_gyr_z.Text = "65535";
            this.tb_gyr_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(6, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "陀螺仪Y";
            // 
            // tb_gyr_y
            // 
            this.tb_gyr_y.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_gyr_y.Location = new System.Drawing.Point(80, 142);
            this.tb_gyr_y.Name = "tb_gyr_y";
            this.tb_gyr_y.Size = new System.Drawing.Size(63, 26);
            this.tb_gyr_y.TabIndex = 8;
            this.tb_gyr_y.Text = "65535";
            this.tb_gyr_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "陀螺仪X";
            // 
            // tb_gyr_x
            // 
            this.tb_gyr_x.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_gyr_x.Location = new System.Drawing.Point(80, 111);
            this.tb_gyr_x.Name = "tb_gyr_x";
            this.tb_gyr_x.Size = new System.Drawing.Size(63, 26);
            this.tb_gyr_x.TabIndex = 6;
            this.tb_gyr_x.Text = "65535";
            this.tb_gyr_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "加速度Z";
            // 
            // tb_acc_z
            // 
            this.tb_acc_z.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_acc_z.Location = new System.Drawing.Point(80, 81);
            this.tb_acc_z.Name = "tb_acc_z";
            this.tb_acc_z.Size = new System.Drawing.Size(63, 26);
            this.tb_acc_z.TabIndex = 4;
            this.tb_acc_z.Text = "65535";
            this.tb_acc_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "加速度Y";
            // 
            // tb_acc_y
            // 
            this.tb_acc_y.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_acc_y.Location = new System.Drawing.Point(80, 50);
            this.tb_acc_y.Name = "tb_acc_y";
            this.tb_acc_y.Size = new System.Drawing.Size(63, 26);
            this.tb_acc_y.TabIndex = 2;
            this.tb_acc_y.Text = "65535";
            this.tb_acc_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "加速度X";
            // 
            // tb_acc_x
            // 
            this.tb_acc_x.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_acc_x.Location = new System.Drawing.Point(80, 20);
            this.tb_acc_x.Name = "tb_acc_x";
            this.tb_acc_x.Size = new System.Drawing.Size(63, 26);
            this.tb_acc_x.TabIndex = 0;
            this.tb_acc_x.Text = "65535";
            this.tb_acc_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage_set
            // 
            this.tabPage_set.Controls.Add(this.button3);
            this.tabPage_set.Controls.Add(this.pictureBox1);
            this.tabPage_set.Controls.Add(this.button2);
            this.tabPage_set.Controls.Add(this.button1);
            this.tabPage_set.Location = new System.Drawing.Point(4, 22);
            this.tabPage_set.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage_set.Name = "tabPage_set";
            this.tabPage_set.Size = new System.Drawing.Size(962, 616);
            this.tabPage_set.TabIndex = 2;
            this.tabPage_set.Text = "运动控置界面";
            this.tabPage_set.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "解码收照片";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(591, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 261);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "显示新图片";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "读取图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage_scope
            // 
            this.tabPage_scope.Controls.Add(this.button4);
            this.tabPage_scope.Controls.Add(this.webBrowser1);
            this.tabPage_scope.Controls.Add(this.btn_pause);
            this.tabPage_scope.Location = new System.Drawing.Point(4, 22);
            this.tabPage_scope.Name = "tabPage_scope";
            this.tabPage_scope.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_scope.Size = new System.Drawing.Size(962, 616);
            this.tabPage_scope.TabIndex = 3;
            this.tabPage_scope.Text = "地图导航";
            this.tabPage_scope.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(822, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "winform串口触发";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(956, 610);
            this.webBrowser1.TabIndex = 5;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(854, 458);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.Text = "暂停";
            this.btn_pause.UseVisualStyleBackColor = true;
            // 
            // iocomp
            // 
            this.iocomp.Controls.Add(this.plotToolBarStandard1);
            this.iocomp.Controls.Add(this.plot1);
            this.iocomp.Location = new System.Drawing.Point(4, 22);
            this.iocomp.Name = "iocomp";
            this.iocomp.Padding = new System.Windows.Forms.Padding(3);
            this.iocomp.Size = new System.Drawing.Size(962, 616);
            this.iocomp.TabIndex = 4;
            this.iocomp.Text = "高级示波器";
            this.iocomp.UseVisualStyleBackColor = true;
            // 
            // plotToolBarStandard1
            // 
            this.plotToolBarStandard1.LoadingBegin();
            this.plotToolBarStandard1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.plotToolBarStandard1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.plotToolBarButton1,
            this.plotToolBarButton2,
            this.plotToolBarButton3,
            this.plotToolBarButton4,
            this.plotToolBarButton5,
            this.plotToolBarButton6,
            this.plotToolBarButton7,
            this.plotToolBarButton8,
            this.plotToolBarButton9,
            this.plotToolBarButton10,
            this.plotToolBarButton11,
            this.plotToolBarButton12,
            this.plotToolBarButton13,
            this.plotToolBarButton14,
            this.plotToolBarButton15,
            this.plotToolBarButton16,
            this.plotToolBarButton17,
            this.plotToolBarButton18,
            this.plotToolBarButton19,
            this.plotToolBarButton20,
            this.plotToolBarButton21});
            this.plotToolBarStandard1.DropDownArrows = true;
            this.plotToolBarStandard1.ImageList = this.imageList1;
            this.plotToolBarStandard1.Location = new System.Drawing.Point(3, 3);
            this.plotToolBarStandard1.Name = "plotToolBarStandard1";
            this.plotToolBarStandard1.Plot = this.plot1;
            this.plotToolBarStandard1.ShowToolTips = true;
            this.plotToolBarStandard1.Size = new System.Drawing.Size(956, 28);
            this.plotToolBarStandard1.TabIndex = 1;
            this.plotToolBarStandard1.LoadingEnd();
            // 
            // plotToolBarButton1
            // 
            this.plotToolBarButton1.LoadingBegin();
            this.plotToolBarButton1.Enabled = false;
            this.plotToolBarButton1.ImageIndex = 0;
            this.plotToolBarButton1.Name = "plotToolBarButton1";
            this.plotToolBarButton1.ToolTipText = "Tracking Resume";
            this.plotToolBarButton1.LoadingEnd();
            // 
            // plotToolBarButton2
            // 
            this.plotToolBarButton2.LoadingBegin();
            this.plotToolBarButton2.Command = Iocomp.Types.PlotToolBarCommandStyle.TrackingPause;
            this.plotToolBarButton2.ImageIndex = 1;
            this.plotToolBarButton2.Name = "plotToolBarButton2";
            this.plotToolBarButton2.ToolTipText = "Tracking Pause";
            this.plotToolBarButton2.LoadingEnd();
            // 
            // plotToolBarButton3
            // 
            this.plotToolBarButton3.LoadingBegin();
            this.plotToolBarButton3.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton3.Enabled = false;
            this.plotToolBarButton3.Name = "plotToolBarButton3";
            this.plotToolBarButton3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton3.LoadingEnd();
            // 
            // plotToolBarButton4
            // 
            this.plotToolBarButton4.LoadingBegin();
            this.plotToolBarButton4.Command = Iocomp.Types.PlotToolBarCommandStyle.AxesScroll;
            this.plotToolBarButton4.ImageIndex = 2;
            this.plotToolBarButton4.Name = "plotToolBarButton4";
            this.plotToolBarButton4.Pushed = true;
            this.plotToolBarButton4.ToolTipText = "Axes Scroll";
            this.plotToolBarButton4.LoadingEnd();
            // 
            // plotToolBarButton5
            // 
            this.plotToolBarButton5.LoadingBegin();
            this.plotToolBarButton5.Command = Iocomp.Types.PlotToolBarCommandStyle.AxesZoom;
            this.plotToolBarButton5.ImageIndex = 3;
            this.plotToolBarButton5.Name = "plotToolBarButton5";
            this.plotToolBarButton5.ToolTipText = "Axes Zoom";
            this.plotToolBarButton5.LoadingEnd();
            // 
            // plotToolBarButton6
            // 
            this.plotToolBarButton6.LoadingBegin();
            this.plotToolBarButton6.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton6.Enabled = false;
            this.plotToolBarButton6.Name = "plotToolBarButton6";
            this.plotToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton6.LoadingEnd();
            // 
            // plotToolBarButton7
            // 
            this.plotToolBarButton7.LoadingBegin();
            this.plotToolBarButton7.Command = Iocomp.Types.PlotToolBarCommandStyle.ZoomOut;
            this.plotToolBarButton7.ImageIndex = 4;
            this.plotToolBarButton7.Name = "plotToolBarButton7";
            this.plotToolBarButton7.ToolTipText = "Zoom-Out";
            this.plotToolBarButton7.LoadingEnd();
            // 
            // plotToolBarButton8
            // 
            this.plotToolBarButton8.LoadingBegin();
            this.plotToolBarButton8.Command = Iocomp.Types.PlotToolBarCommandStyle.ZoomIn;
            this.plotToolBarButton8.ImageIndex = 5;
            this.plotToolBarButton8.Name = "plotToolBarButton8";
            this.plotToolBarButton8.ToolTipText = "Zoom-In";
            this.plotToolBarButton8.LoadingEnd();
            // 
            // plotToolBarButton9
            // 
            this.plotToolBarButton9.LoadingBegin();
            this.plotToolBarButton9.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton9.Enabled = false;
            this.plotToolBarButton9.Name = "plotToolBarButton9";
            this.plotToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton9.LoadingEnd();
            // 
            // plotToolBarButton10
            // 
            this.plotToolBarButton10.LoadingBegin();
            this.plotToolBarButton10.Command = Iocomp.Types.PlotToolBarCommandStyle.Select;
            this.plotToolBarButton10.ImageIndex = 6;
            this.plotToolBarButton10.Name = "plotToolBarButton10";
            this.plotToolBarButton10.Pushed = true;
            this.plotToolBarButton10.ToolTipText = "Select";
            this.plotToolBarButton10.LoadingEnd();
            // 
            // plotToolBarButton11
            // 
            this.plotToolBarButton11.LoadingBegin();
            this.plotToolBarButton11.Command = Iocomp.Types.PlotToolBarCommandStyle.ZoomBox;
            this.plotToolBarButton11.ImageIndex = 7;
            this.plotToolBarButton11.Name = "plotToolBarButton11";
            this.plotToolBarButton11.ToolTipText = "Zoom-Box";
            this.plotToolBarButton11.LoadingEnd();
            // 
            // plotToolBarButton12
            // 
            this.plotToolBarButton12.LoadingBegin();
            this.plotToolBarButton12.Command = Iocomp.Types.PlotToolBarCommandStyle.DataCursor;
            this.plotToolBarButton12.ImageIndex = 8;
            this.plotToolBarButton12.Name = "plotToolBarButton12";
            this.plotToolBarButton12.ToolTipText = "Data-Cursor";
            this.plotToolBarButton12.LoadingEnd();
            // 
            // plotToolBarButton13
            // 
            this.plotToolBarButton13.LoadingBegin();
            this.plotToolBarButton13.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton13.Enabled = false;
            this.plotToolBarButton13.Name = "plotToolBarButton13";
            this.plotToolBarButton13.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton13.LoadingEnd();
            // 
            // plotToolBarButton14
            // 
            this.plotToolBarButton14.LoadingBegin();
            this.plotToolBarButton14.Command = Iocomp.Types.PlotToolBarCommandStyle.Edit;
            this.plotToolBarButton14.ImageIndex = 9;
            this.plotToolBarButton14.Name = "plotToolBarButton14";
            this.plotToolBarButton14.ToolTipText = "Edit";
            this.plotToolBarButton14.LoadingEnd();
            // 
            // plotToolBarButton15
            // 
            this.plotToolBarButton15.LoadingBegin();
            this.plotToolBarButton15.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton15.Enabled = false;
            this.plotToolBarButton15.Name = "plotToolBarButton15";
            this.plotToolBarButton15.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton15.LoadingEnd();
            // 
            // plotToolBarButton16
            // 
            this.plotToolBarButton16.LoadingBegin();
            this.plotToolBarButton16.Command = Iocomp.Types.PlotToolBarCommandStyle.Copy;
            this.plotToolBarButton16.ImageIndex = 10;
            this.plotToolBarButton16.Name = "plotToolBarButton16";
            this.plotToolBarButton16.ToolTipText = "Copy to Clipboard";
            this.plotToolBarButton16.LoadingEnd();
            // 
            // plotToolBarButton17
            // 
            this.plotToolBarButton17.LoadingBegin();
            this.plotToolBarButton17.Command = Iocomp.Types.PlotToolBarCommandStyle.Save;
            this.plotToolBarButton17.ImageIndex = 11;
            this.plotToolBarButton17.Name = "plotToolBarButton17";
            this.plotToolBarButton17.ToolTipText = "Save";
            this.plotToolBarButton17.LoadingEnd();
            // 
            // plotToolBarButton18
            // 
            this.plotToolBarButton18.LoadingBegin();
            this.plotToolBarButton18.Command = Iocomp.Types.PlotToolBarCommandStyle.Separator;
            this.plotToolBarButton18.Enabled = false;
            this.plotToolBarButton18.Name = "plotToolBarButton18";
            this.plotToolBarButton18.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            this.plotToolBarButton18.LoadingEnd();
            // 
            // plotToolBarButton19
            // 
            this.plotToolBarButton19.LoadingBegin();
            this.plotToolBarButton19.Command = Iocomp.Types.PlotToolBarCommandStyle.Print;
            this.plotToolBarButton19.ImageIndex = 12;
            this.plotToolBarButton19.Name = "plotToolBarButton19";
            this.plotToolBarButton19.ToolTipText = "Print";
            this.plotToolBarButton19.LoadingEnd();
            // 
            // plotToolBarButton20
            // 
            this.plotToolBarButton20.LoadingBegin();
            this.plotToolBarButton20.Command = Iocomp.Types.PlotToolBarCommandStyle.Preview;
            this.plotToolBarButton20.ImageIndex = 13;
            this.plotToolBarButton20.Name = "plotToolBarButton20";
            this.plotToolBarButton20.ToolTipText = "Preview";
            this.plotToolBarButton20.LoadingEnd();
            // 
            // plotToolBarButton21
            // 
            this.plotToolBarButton21.LoadingBegin();
            this.plotToolBarButton21.Command = Iocomp.Types.PlotToolBarCommandStyle.PageSetup;
            this.plotToolBarButton21.ImageIndex = 14;
            this.plotToolBarButton21.Name = "plotToolBarButton21";
            this.plotToolBarButton21.ToolTipText = "Page Setup";
            this.plotToolBarButton21.LoadingEnd();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            this.imageList1.Images.SetKeyName(12, "");
            this.imageList1.Images.SetKeyName(13, "");
            // 
            // plot1
            // 
            this.plot1.LoadingBegin();
            plotChannelTrace1.Color = System.Drawing.Color.Red;
            plotChannelTrace1.Name = "Channel 1";
            plotChannelTrace1.TitleText = "Channel 1";
            plotChannelTrace2.Color = System.Drawing.Color.Blue;
            plotChannelTrace2.Name = "Channel 2";
            plotChannelTrace2.TitleText = "Channel 2";
            this.plot1.Channels.Add(plotChannelTrace1);
            this.plot1.Channels.Add(plotChannelTrace2);
            plotDataCursorXY1.Hint.Fill.Pen.Color = System.Drawing.SystemColors.InfoText;
            plotDataCursorXY1.Name = "Data-Cursor 1";
            plotDataCursorXY1.TitleText = "Data-Cursor 1";
            this.plot1.DataCursors.Add(plotDataCursorXY1);
            plotDataView1.Name = "Data-View 1";
            plotDataView1.TitleText = "Data-View 1";
            this.plot1.DataViews.Add(plotDataView1);
            this.plot1.Dock = System.Windows.Forms.DockStyle.Fill;
            plotLabelBasic1.DockOrder = 0;
            plotLabelBasic1.Name = "Label 1";
            plotLabelBasic1.TitleText = "Label 1";
            this.plot1.Labels.Add(plotLabelBasic1);
            plotLegendBasic1.DockOrder = 0;
            plotLegendBasic1.Name = "Legend 1";
            plotLegendBasic1.TitleText = "Legend 1";
            this.plot1.Legends.Add(plotLegendBasic1);
            this.plot1.Location = new System.Drawing.Point(3, 3);
            this.plot1.Name = "plot1";
            this.plot1.Size = new System.Drawing.Size(956, 610);
            this.plot1.TabIndex = 0;
            plotXAxis1.DockOrder = 0;
            plotXAxis1.Name = "X-Axis 1";
            plotXAxis1.Title.Text = "X-Axis 1";
            this.plot1.XAxes.Add(plotXAxis1);
            plotYAxis1.DockOrder = 0;
            plotYAxis1.Name = "Y-Axis 1";
            plotYAxis1.Title.Text = "Y-Axis 1";
            this.plot1.YAxes.Add(plotYAxis1);
            this.plot1.LoadingEnd();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.checkBoxWantDis);
            this.tabPage1.Controls.Add(this.btnCloseBarrier);
            this.tabPage1.Controls.Add(this.btnOPenBarrier);
            this.tabPage1.Controls.Add(this.checkBoxDestination);
            this.tabPage1.Controls.Add(this.headingDirection);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.txtazimuth);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.txtdistanceAll);
            this.tabPage1.Controls.Add(this.checkBoxGPS);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.txtDistance2);
            this.tabPage1.Controls.Add(this.checkBoxAddLine);
            this.tabPage1.Controls.Add(this.checkBoxMarker);
            this.tabPage1.Controls.Add(this.textBoxlng);
            this.tabPage1.Controls.Add(this.btn_aq_gps);
            this.tabPage1.Controls.Add(this.textBoxlat);
            this.tabPage1.Controls.Add(this.MainMap);
            this.tabPage1.Controls.Add(this.btnyes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(962, 616);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "离线地图";
            // 
            // checkBoxWantDis
            // 
            this.checkBoxWantDis.AutoSize = true;
            this.checkBoxWantDis.Location = new System.Drawing.Point(298, 536);
            this.checkBoxWantDis.Name = "checkBoxWantDis";
            this.checkBoxWantDis.Size = new System.Drawing.Size(48, 16);
            this.checkBoxWantDis.TabIndex = 25;
            this.checkBoxWantDis.Text = "测距";
            this.checkBoxWantDis.UseVisualStyleBackColor = true;
            // 
            // btnCloseBarrier
            // 
            this.btnCloseBarrier.Location = new System.Drawing.Point(445, 551);
            this.btnCloseBarrier.Name = "btnCloseBarrier";
            this.btnCloseBarrier.Size = new System.Drawing.Size(106, 53);
            this.btnCloseBarrier.TabIndex = 24;
            this.btnCloseBarrier.Text = "关闭蔽障";
            this.btnCloseBarrier.UseVisualStyleBackColor = true;
            this.btnCloseBarrier.Click += new System.EventHandler(this.btnCloseBarrier_Click);
            // 
            // btnOPenBarrier
            // 
            this.btnOPenBarrier.Location = new System.Drawing.Point(445, 496);
            this.btnOPenBarrier.Name = "btnOPenBarrier";
            this.btnOPenBarrier.Size = new System.Drawing.Size(106, 53);
            this.btnOPenBarrier.TabIndex = 23;
            this.btnOPenBarrier.Text = "开启蔽障";
            this.btnOPenBarrier.UseVisualStyleBackColor = true;
            this.btnOPenBarrier.Click += new System.EventHandler(this.btnOPenBarrier_Click);
            // 
            // checkBoxDestination
            // 
            this.checkBoxDestination.AutoSize = true;
            this.checkBoxDestination.Location = new System.Drawing.Point(144, 569);
            this.checkBoxDestination.Name = "checkBoxDestination";
            this.checkBoxDestination.Size = new System.Drawing.Size(72, 16);
            this.checkBoxDestination.TabIndex = 22;
            this.checkBoxDestination.Text = "设目的地";
            this.checkBoxDestination.UseVisualStyleBackColor = true;
            // 
            // headingDirection
            // 
            this.headingDirection.Location = new System.Drawing.Point(641, 502);
            this.headingDirection.Name = "headingDirection";
            this.headingDirection.Size = new System.Drawing.Size(93, 98);
            this.headingDirection.TabIndex = 21;
            this.headingDirection.Text = "headingIndicatorInstrumentControl2";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(740, 575);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(41, 12);
            this.label32.TabIndex = 20;
            this.label32.Text = "方位角";
            // 
            // txtazimuth
            // 
            this.txtazimuth.Location = new System.Drawing.Point(799, 572);
            this.txtazimuth.Name = "txtazimuth";
            this.txtazimuth.Size = new System.Drawing.Size(100, 21);
            this.txtazimuth.TabIndex = 19;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(740, 537);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(41, 12);
            this.label31.TabIndex = 18;
            this.label31.Text = "总距离";
            // 
            // txtdistanceAll
            // 
            this.txtdistanceAll.Location = new System.Drawing.Point(799, 534);
            this.txtdistanceAll.Name = "txtdistanceAll";
            this.txtdistanceAll.Size = new System.Drawing.Size(100, 21);
            this.txtdistanceAll.TabIndex = 17;
            // 
            // checkBoxGPS
            // 
            this.checkBoxGPS.AutoSize = true;
            this.checkBoxGPS.Location = new System.Drawing.Point(144, 534);
            this.checkBoxGPS.Name = "checkBoxGPS";
            this.checkBoxGPS.Size = new System.Drawing.Size(90, 16);
            this.checkBoxGPS.TabIndex = 16;
            this.checkBoxGPS.Text = "实时获取GPS";
            this.checkBoxGPS.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(740, 505);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(53, 12);
            this.label30.TabIndex = 15;
            this.label30.Text = "两点距离";
            // 
            // txtDistance2
            // 
            this.txtDistance2.Location = new System.Drawing.Point(799, 502);
            this.txtDistance2.Name = "txtDistance2";
            this.txtDistance2.Size = new System.Drawing.Size(100, 21);
            this.txtDistance2.TabIndex = 14;
            // 
            // checkBoxAddLine
            // 
            this.checkBoxAddLine.AutoSize = true;
            this.checkBoxAddLine.Location = new System.Drawing.Point(298, 500);
            this.checkBoxAddLine.Name = "checkBoxAddLine";
            this.checkBoxAddLine.Size = new System.Drawing.Size(60, 16);
            this.checkBoxAddLine.TabIndex = 13;
            this.checkBoxAddLine.Text = "加折线";
            this.checkBoxAddLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxMarker
            // 
            this.checkBoxMarker.AutoSize = true;
            this.checkBoxMarker.Location = new System.Drawing.Point(144, 500);
            this.checkBoxMarker.Name = "checkBoxMarker";
            this.checkBoxMarker.Size = new System.Drawing.Size(72, 16);
            this.checkBoxMarker.TabIndex = 12;
            this.checkBoxMarker.Text = "加标记点";
            this.checkBoxMarker.UseVisualStyleBackColor = true;
            // 
            // textBoxlng
            // 
            this.textBoxlng.Location = new System.Drawing.Point(17, 532);
            this.textBoxlng.Name = "textBoxlng";
            this.textBoxlng.Size = new System.Drawing.Size(100, 21);
            this.textBoxlng.TabIndex = 8;
            // 
            // btn_aq_gps
            // 
            this.btn_aq_gps.Enabled = false;
            this.btn_aq_gps.Location = new System.Drawing.Point(289, 566);
            this.btn_aq_gps.Name = "btn_aq_gps";
            this.btn_aq_gps.Size = new System.Drawing.Size(92, 23);
            this.btn_aq_gps.TabIndex = 9;
            this.btn_aq_gps.Text = "Acquire_Gps";
            this.btn_aq_gps.UseVisualStyleBackColor = true;
            this.btn_aq_gps.Click += new System.EventHandler(this.btn_aq_gps_Click);
            // 
            // textBoxlat
            // 
            this.textBoxlat.Location = new System.Drawing.Point(17, 500);
            this.textBoxlat.Name = "textBoxlat";
            this.textBoxlat.Size = new System.Drawing.Size(100, 21);
            this.textBoxlat.TabIndex = 7;
            // 
            // MainMap
            // 
            this.MainMap.Bearing = 0F;
            this.MainMap.CanDragMap = true;
            this.MainMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.MainMap.GrayScaleMode = false;
            this.MainMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.MainMap.LevelsKeepInMemmory = 5;
            this.MainMap.Location = new System.Drawing.Point(0, 0);
            this.MainMap.MarkersEnabled = true;
            this.MainMap.MaxZoom = 18;
            this.MainMap.MinZoom = 5;
            this.MainMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.MainMap.Name = "MainMap";
            this.MainMap.NegativeMode = false;
            this.MainMap.PolygonsEnabled = true;
            this.MainMap.RetryLoadTile = 0;
            this.MainMap.RoutesEnabled = true;
            this.MainMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.MainMap.ShowTileGridLines = false;
            this.MainMap.Size = new System.Drawing.Size(962, 494);
            this.MainMap.TabIndex = 0;
            this.MainMap.Zoom = 18D;
            this.MainMap.Load += new System.EventHandler(this.MainMAp_Load);
            this.MainMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainMap_MouseClick);
            // 
            // btnyes
            // 
            this.btnyes.Location = new System.Drawing.Point(17, 559);
            this.btnyes.Name = "btnyes";
            this.btnyes.Size = new System.Drawing.Size(100, 34);
            this.btnyes.TabIndex = 6;
            this.btnyes.Text = "经纬度加点";
            this.btnyes.UseVisualStyleBackColor = true;
            this.btnyes.Click += new System.EventHandler(this.btnyes_Click);
            // 
            // timer_ui
            // 
            this.timer_ui.Enabled = true;
            this.timer_ui.Tick += new System.EventHandler(this.timer_ui_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "0.ico");
            this.imageList2.Images.SetKeyName(1, "1.ico");
            this.imageList2.Images.SetKeyName(2, "2.ico");
            this.imageList2.Images.SetKeyName(3, "3.ico");
            this.imageList2.Images.SetKeyName(4, "4.ico");
            this.imageList2.Images.SetKeyName(5, "5.ico");
            this.imageList2.Images.SetKeyName(6, "6.ico");
            this.imageList2.Images.SetKeyName(7, "7.ico");
            this.imageList2.Images.SetKeyName(8, "8.ico");
            this.imageList2.Images.SetKeyName(9, "9.ico");
            this.imageList2.Images.SetKeyName(10, "10.ico");
            this.imageList2.Images.SetKeyName(11, "11.ico");
            this.imageList2.Images.SetKeyName(12, "12.ico");
            this.imageList2.Images.SetKeyName(13, "13.ico");
            this.imageList2.Images.SetKeyName(14, "14.ico");
            this.imageList2.Images.SetKeyName(15, "15.ico");
            this.imageList2.Images.SetKeyName(16, "16.ico");
            this.imageList2.Images.SetKeyName(17, "17.ico");
            this.imageList2.Images.SetKeyName(18, "18.ico");
            this.imageList2.Images.SetKeyName(19, "19.ico");
            this.imageList2.Images.SetKeyName(20, "20.ico");
            this.imageList2.Images.SetKeyName(21, "21.ico");
            this.imageList2.Images.SetKeyName(22, "22.ico");
            this.imageList2.Images.SetKeyName(23, "23.ico");
            this.imageList2.Images.SetKeyName(24, "24.ico");
            this.imageList2.Images.SetKeyName(25, "25.ico");
            this.imageList2.Images.SetKeyName(26, "26.ico");
            this.imageList2.Images.SetKeyName(27, "27.ico");
            this.imageList2.Images.SetKeyName(28, "28.ico");
            this.imageList2.Images.SetKeyName(29, "29.ico");
            this.imageList2.Images.SetKeyName(30, "30.ico");
            this.imageList2.Images.SetKeyName(31, "31.ico");
            this.imageList2.Images.SetKeyName(32, "32.ico");
            this.imageList2.Images.SetKeyName(33, "33.ico");
            this.imageList2.Images.SetKeyName(34, "34.ico");
            this.imageList2.Images.SetKeyName(35, "35.ico");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "MapMarker_Bubble_Pink_32px_1061228_easyicon.net.png");
            this.imageList3.Images.SetKeyName(1, "1.ico");
            this.imageList3.Images.SetKeyName(2, "2.ico");
            this.imageList3.Images.SetKeyName(3, "3.ico");
            this.imageList3.Images.SetKeyName(4, "4.ico");
            this.imageList3.Images.SetKeyName(5, "5.ico");
            this.imageList3.Images.SetKeyName(6, "6.ico");
            this.imageList3.Images.SetKeyName(7, "7.ico");
            this.imageList3.Images.SetKeyName(8, "8.ico");
            this.imageList3.Images.SetKeyName(9, "9.ico");
            this.imageList3.Images.SetKeyName(10, "10.ico");
            this.imageList3.Images.SetKeyName(11, "11.ico");
            this.imageList3.Images.SetKeyName(12, "12.ico");
            this.imageList3.Images.SetKeyName(13, "13.ico");
            this.imageList3.Images.SetKeyName(14, "14.ico");
            this.imageList3.Images.SetKeyName(15, "15.ico");
            this.imageList3.Images.SetKeyName(16, "16.ico");
            this.imageList3.Images.SetKeyName(17, "17.ico");
            this.imageList3.Images.SetKeyName(18, "18.ico");
            this.imageList3.Images.SetKeyName(19, "19.ico");
            this.imageList3.Images.SetKeyName(20, "20.ico");
            this.imageList3.Images.SetKeyName(21, "21.ico");
            this.imageList3.Images.SetKeyName(22, "22.ico");
            this.imageList3.Images.SetKeyName(23, "23.ico");
            this.imageList3.Images.SetKeyName(24, "24.ico");
            this.imageList3.Images.SetKeyName(25, "25.ico");
            this.imageList3.Images.SetKeyName(26, "26.ico");
            this.imageList3.Images.SetKeyName(27, "27.ico");
            this.imageList3.Images.SetKeyName(28, "28.ico");
            this.imageList3.Images.SetKeyName(29, "29.ico");
            this.imageList3.Images.SetKeyName(30, "30.ico");
            this.imageList3.Images.SetKeyName(31, "31.ico");
            this.imageList3.Images.SetKeyName(32, "32.ico");
            this.imageList3.Images.SetKeyName(33, "33.ico");
            this.imageList3.Images.SetKeyName(34, "34.ico");
            this.imageList3.Images.SetKeyName(35, "35.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "北理工抛投上位机";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl_main.ResumeLayout(false);
            this.tabPage_rxtx.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage_datashow.ResumeLayout(false);
            this.grp_8.ResumeLayout(false);
            this.grp_8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage_set.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage_scope.ResumeLayout(false);
            this.iocomp.ResumeLayout(false);
            this.iocomp.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_comname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage_rxtx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_com_send;
        private System.Windows.Forms.RichTextBox richTextBox_tx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox_rx;
        private System.Windows.Forms.TabPage tabPage_datashow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_moto_8;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tb_moto_4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tb_moto_7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_moto_6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_moto_5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tb_moto_3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_moto_2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_moto_1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_alt_prs;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_alt_csb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_mag_z;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_mag_y;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_mag_x;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_armed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_yaw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_pit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_rol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_gyr_z;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_gyr_y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_gyr_x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_acc_z;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_acc_y;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_acc_x;
        private System.Windows.Forms.TabPage tabPage_set;
        private System.Windows.Forms.Button btn_com_close;
        private System.Windows.Forms.Button btn_com_open;
        private System.Windows.Forms.Label lbl_txcnt;
        private System.Windows.Forms.Label lbl_rxcnt;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.RadioButton rdb_tx_chr;
        private System.Windows.Forms.RadioButton rdb_tx_hex;
        private System.Windows.Forms.RadioButton rdb_rx_chr;
        private System.Windows.Forms.RadioButton rdb_rx_hex;
        private System.Windows.Forms.Timer timer_ui;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tb_vot_1;
        private System.Windows.Forms.GroupBox grp_8;
        private AvionicsInstrumentControlDemo.VerticalSpeedIndicatorInstrumentControl verticalSpeedIndicatorInstrumentControl1;
        private AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl turnCoordinatorInstrumentControl1;
        private AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
        private AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        private AvionicsInstrumentControlDemo.AltimeterInstrumentControl altimeterInstrumentControl1;
        private AvionicsInstrumentControlDemo.AirSpeedIndicatorInstrumentControl airSpeedIndicatorInstrumentControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabPage tabPage_scope;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.TabPage iocomp;
        private Iocomp.Instrumentation.Plotting.Plot plot1;
        private Iocomp.Instrumentation.Plotting.PlotToolBarStandard plotToolBarStandard1;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton1;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton2;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton3;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton4;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton5;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton6;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton7;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton8;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton9;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton10;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton11;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton12;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton13;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton14;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton15;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton16;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton17;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton18;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton19;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton20;
        private Iocomp.Classes.PlotToolBarButton plotToolBarButton21;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox checkBoxAddLine;
        private System.Windows.Forms.CheckBox checkBoxMarker;
        private System.Windows.Forms.TextBox textBoxlng;
        private System.Windows.Forms.Button btn_aq_gps;
        private System.Windows.Forms.TextBox textBoxlat;
        private GMap.NET.WindowsForms.GMapControl MainMap;
        private System.Windows.Forms.Button btnyes;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtDistance2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBoxGPS;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtdistanceAll;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtazimuth;
        private AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl headingDirection;
        private System.Windows.Forms.CheckBox checkBoxDestination;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Button btnCloseBarrier;
        private System.Windows.Forms.Button btnOPenBarrier;
        private System.Windows.Forms.CheckBox checkBoxWantDis;
    }
}

