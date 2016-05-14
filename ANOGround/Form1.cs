using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Security.Permissions;//Today
using System.Collections;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.CacheProviders;


namespace ANOGround
{
    [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)] //Today
    public partial class Form1 : Form
    {
        private long RX_CNT = 0;//接收计数  
        private long TX_CNT = 0;//发送计数  
        private StringBuilder strbuilder = new StringBuilder();
        private string ACT_TAB_TEXT = "";

        public bool B_armed = true;
        public Int16 S_acc_x, S_acc_y, S_acc_z, S_gyr_x, S_gyr_y, S_gyr_z, S_mag_x, S_mag_y, S_mag_z;
        public float D_ang_rol, D_ang_pit, D_ang_yaw,D_alt_csb,D_alt_prs;
        public Int16 Rc_thr, Rc_yaw, Rc_rol, Rc_pit, Rc_aux_1, Rc_aux_2, Rc_aux_3, Rc_aux_4, Rc_aux_5, Rc_aux_6;
        public Int16 Moto_1, Moto_2, Moto_3, Moto_4, Moto_5, Moto_6, Moto_7, Moto_8;
        private int m_Counter = 0;



        
    

        public Form1()
        {
            InitializeComponent();
      
        }

        void latlngChange_OntempChange(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

 
       

       

        private void Form1_Load(object sender, EventArgs e)
        {
            scan_com();//扫描可用串口
            comboBox_comname.SelectedIndex = comboBox_comname.Items.Count > 0 ? 0 : -1;//旋转第一个可用串口
            comboBox_baudrate.SelectedIndex = comboBox_baudrate.Items.IndexOf("38400");//选择波特率  
            tabControl_main.SelectedIndex = 5;
            ACT_TAB_TEXT = tabControl_main.SelectedTab.Text;
            plot1.Channels.Trace["Channel 1"].Trace.Thickness = 2;//Today
            try
            {
                //这个文件于可执行文件放在同一目录
                webBrowser1.Url = new Uri(Path.Combine(Application.StartupPath, "LinePlan.htm"));
                webBrowser1.ObjectForScripting = this;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void scan_com()
        {
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            comboBox_comname.Items.AddRange(ports);
        }

        private void btn_com_open_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox_comname.Text;
            serialPort1.BaudRate = int.Parse(comboBox_baudrate.Text);
            try
            {
                serialPort1.Open();
                btn_com_close.Enabled = true;
                btn_com_open.Enabled = false;
                btn_aq_gps.Enabled = true;                        //串口打开使能
            }
            catch (Exception ex)
            {
                //捕获到异常信息
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_com_close_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            btn_com_open.Enabled = true;
            btn_com_close.Enabled = false;
            btn_aq_gps.Enabled = false;                               
        }

        int data_num = 0;//上次未处理数据长度
        byte[] data_buf = new byte[50000];//存放上次未处理数据
        static bool photo_recieved = false;//一帧照片是否接受完毕
        static byte[] photo_buf=new byte[50000] ;
        static int pho_index=0;
        static int pho_frame_count = 0;
        static int pho_length;
        
        
        #region   ///石选阳2016/4/6修改
        // **************************//GPS
        static byte[] latitude = new byte[11];//纬度
        static byte[] longitude = new byte[12];//经度
        static byte[] Azimuth = new byte[7];//对地方向
        static byte[] speed = new byte[8];//对地速度
        static byte[] date = new byte[7];//日期
        static byte[] mag_declination = new byte[7];//磁偏角
        static int status;//定位状态A/V
        static int lat_ns;//南北半球指示S/N
        static int long_ew;//东西半球指示E/W
        static int mag_ew;//磁偏角方向E/W
        static string ceshi = "abcd";
        #endregion


 

        #region  仅供调试使用，不用删除
        //static  int Intrupput_count = 0;
        
        
#endregion
                                       
        int [] buffer_size=new int[1000];
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int n = serialPort1.BytesToRead;//先记录下来，避免某种原因，人为的原因，操作几次之间时间长，缓存不一致  
            RX_CNT += n;//增加接收计数  
            
           // buffer_size[Intrupput_count++]=n;//

            
            if (ACT_TAB_TEXT == "串口基本收发")
            {
                byte[] buf = new byte[n];//声明一个临时数组存储当前来的串口数据  
                serialPort1.Read(buf, 0, n);//读取缓冲数据  
                strbuilder.Clear();//清除字符串构造器的内容  
                //因为要访问ui资源，所以需要使用invoke方式同步ui。  
                //从 SerialPort 对象接收数据时，将在辅助线程上引发 DataReceived 事件。
                //由于此事件在辅助线程而非主线程上引发，因此尝试修改主线程中的一些元素（如 UI 元素）时会引发线程异常。 
                //如果有必要修改主 Form 或 Control 中的元素，请使用 Invoke 回发更改请求，这将在正确的线程上执行。
                this.Invoke((EventHandler)(delegate
               {
                   //判断是否是显示为16禁止  
                   if (rdb_rx_hex.Checked)
                   {
                       //依次的拼接出16进制字符串  
                       foreach (byte b in buf)
                       {
                           strbuilder.Append(b.ToString("X2") + " ");
                       }
                   }
                   else
                   {
                       //直接按ASCII规则转换成字符串  
                       strbuilder.Append(Encoding.ASCII.GetString(buf));
                   }
                   //追加的形式添加到文本框末端，并滚动到最后。  
                   this.richTextBox_rx.AppendText(strbuilder.ToString());
                   
               }));
            }
            else
            {
                int _frame_num = 0; // 接收帧在frame数组里的索引
                int _frame_len = 0; // 帧长度

                if (n > 20000) return;//接收到的数据过长，可能出错
                serialPort1.Read(data_buf, data_num, n);//读取缓冲数据，从data_buf的第data_num处开始写入，与之前未处理数据连接在一起
                data_num += n;
                int I = 0;//
                while(I < data_num-4)//遍历接收数据
                {
                    if(data_buf[I]==0xaa && data_buf[I+1]==0xaa && data_buf[I+3]<=95)
                    {
                        //pho_frame_count++;//照片的有用信息长度
                        _frame_num = data_buf[I + 2];//功能字
                        _frame_len = data_buf[I + 3];//长度
                        if ((data_num - I - 5) >= _frame_len) // 数据接收完毕，收完checksum字节
                        {
                            byte sum = 0;
                            for(int j=I; j<=I+3+_frame_len; j++)//计算sum
                                sum += data_buf[j];
                            if(sum==data_buf[I+4+_frame_len])//sum校验通过
                            {
                                #region //数据解码
                                switch (_frame_num)
                                {
                                    case 1://STATUS
                                       
                                        break;
                                    case 0xFF://一帧照片的信息长度
                                        pho_length = data_buf[I + 4] << 8 | data_buf[I + 5];//发送实际照片长度就好
                                        pho_frame_count = 0;//每一帧相片信息清0 
                                        break;
                                    case 2://照片信息
                                        for (int i = 0; i < _frame_len; i++)
                                        {
                                            photo_buf[pho_index++] = data_buf[I + 4+i];
                                            pho_frame_count++;//照片的有用信息长度
                                        }
                                        if (pho_frame_count==12708)//(RX_CNT == 13378)
                                        {
                                            pho_frame_count = 0;
                                            for (int i=0;i<pho_frame_count;i++)
                                            {
                                                if (i%95==0)
                                                {
                                                    if (i>=95)
                                                    {
                                                       strbuilder.Append("FF ");  
                                                    }                                                  
                                                    strbuilder.Append("AA ");
                                                    strbuilder.Append("AA ");
                                                    strbuilder.Append("02 ");
                                                    strbuilder.Append("5F ");
                                                    
                                                }
                                                strbuilder.Append(photo_buf[i].ToString("X2") + " ");
                                            }

                                            StreamWriter outfile = new StreamWriter("D:\\信息存储" + @"\AllTxtFiles.txt");
                                            outfile.Write(strbuilder.ToString());
                                            outfile.Close();
                                    
                                            photo_recieved = true;
                                        }
                                        if (photo_recieved)//一帧接受完毕
                                        {
                                            string name;
                                            string path = "D:\\图片存储";
                                            System.DateTime currentTime = new System.DateTime();
                                            currentTime = System.DateTime.Now;
                                            name = currentTime.ToShortDateString().Replace("/", "-") + " " 
                                                                + currentTime.ToLongTimeString().Replace(":", "-") + ".jpg";
                                            var newName = path + "\\" + name;

                                            FileStream fs = new FileStream(newName, FileMode.Create, FileAccess.Write);
                                            fs.Write(photo_buf, 0, pho_index--);
                                            fs.Close();
                                            this.Invoke((EventHandler)(delegate
                                            {
                                                pictureBox2.Load(newName);
                                            }));
                                            pho_index = 0;
                                            photo_recieved = false;
                                            RX_CNT = 0;
                                            pho_frame_count = 0;
                                        }                                     
                                        break;
                                    case 3:        
                                     for (int i = 0; i < _frame_len; i++)
                                        {
                                            if (i == 0) status = data_buf[I + 4 + i];
                                            else if (i > 0 && i < 12) latitude[i - 1] = data_buf[I + 4 + i];
                                            else if (i == 12) lat_ns = data_buf[I + 4 + i];
                                            else if (i > 12 && i < 25) longitude[i - 13] = data_buf[I + 4 + i]; 
                                            else if (i == 25) long_ew = data_buf[I + 4 + i];
                                            else if (i > 25 && i < 34) speed[i - 26] = data_buf[I + 4 + i];
                                            else if (i > 33 && i < 41) Azimuth[i - 34] = data_buf[I + 4 + i];
                                            else if (i > 40 && i < 48) date[i - 41] = data_buf[I + 4 + i];
                                            else if (i > 47 && i < 55) mag_declination[i - 48] = data_buf[I + 4 + i];
                                            else mag_ew = data_buf[I + 4 + i];
                                        }
                                     if (I>0)
                                     {
                                         RobotId = data_buf[I - 1] / 16 * 10 +data_buf[I - 1] %16;

                                     }



                                        break;
                                    default:
                                        break;
                                }
                                #endregion
                                I = I + 5 + _frame_len; // I指向下一帧数据 （checksum的下一个字节）
                                
                            }//Sum校验通过
                            else//sum校验未通过
                            {
                                I++;
                            }
                        }//if ((data_num - I - 5) >= _frame_len) // 数据接收完毕，收完checksum字节
                        else//HEAD FUN LEN符合要求,但是数据未接收完毕
                        {
                            for (int j = I; j <= data_num - 1; j++)
                            {
                                data_buf[j - I] = data_buf[j];
                            }
                            data_num = data_num - I;
                            return;
                        }
                    }
                    else//if(data_buf[I]==0xaa && data_buf[I+1]==0xaa && data_buf[I+3]<=95)
                    {
                        I++;
                    }
                }//end  while(I < data_num-4)
                if (I <= data_num) // 剩几字节没有处理完
                {
                    for(int j=I; j<=data_num-1; j++)
                    {
                        data_buf[j-I] = data_buf[j];
                    }
                    data_num = data_num - I;
                }
            }
        }

        private void btn_com_send_Click(object sender, EventArgs e)
        {
            //定义一个变量，记录发送了几个字节  
            int n = 0;
            //16进制发送  
            if (rdb_tx_hex.Checked)
            {
                string s = richTextBox_tx.Text.Replace(" ", "");
                byte[] buffer = new byte[s.Length / 2];
                for (int i = 0; i < s.Length; i += 2)
                    buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
                //转换列表为数组后发送  
                serialPort1.Write(buffer.ToArray(), 0, buffer.Length);
                //记录发送的字节数  
                n = buffer.Length;
            }
            else//ascii编码直接发送  
            {
                serialPort1.Write(richTextBox_tx.Text);
                n = richTextBox_tx.Text.Length;
            }
            TX_CNT += n;//累加发送字节数  
            lbl_txcnt.Text = TX_CNT.ToString();//更新界面  
        }
        public static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            return buffer;
        }

        private void tabControl_main_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ACT_TAB_TEXT = tabControl_main.SelectedTab.Text;
        }

        private void timer_ui_Tick(object sender, EventArgs e) //0.1s进行一次UI界面更新值
        {
            plot1.Channels.Trace["Channel 1"].AddXY(m_Counter++, m_Counter%100);
            plot1.Channels.Trace["Channel 2"].AddXY(m_Counter, new Random().NextDouble() * 100);
            
            //修改接收计数  
            lbl_rxcnt.Text = RX_CNT.ToString();

            tb_rol.Text = D_ang_rol.ToString();
            tb_pit.Text = D_ang_pit.ToString();
            tb_yaw.Text = D_ang_yaw.ToString();

            tb_acc_x.Text = S_acc_x.ToString();
            tb_acc_y.Text = S_acc_y.ToString();
            tb_acc_z.Text = S_acc_z.ToString();

            tb_gyr_x.Text = S_gyr_x.ToString();
            tb_gyr_y.Text = S_gyr_y.ToString();
            tb_gyr_z.Text = S_gyr_z.ToString();

            tb_mag_x.Text = S_mag_x.ToString();
            tb_mag_y.Text = S_mag_y.ToString();
            tb_mag_z.Text = S_mag_z.ToString();

            tb_alt_csb.Text = D_alt_csb.ToString();
            tb_alt_prs.Text = D_alt_prs.ToString();

            if (B_armed)
                tb_armed.Text = "锁定";
            else
                tb_armed.Text = "解锁";

            attitudeIndicatorInstrumentControl1.SetAttitudeIndicatorParameters((double)D_ang_pit, (double)D_ang_rol);
            headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters((int)D_ang_yaw);
            altimeterInstrumentControl1.SetAlimeterParameters((int)D_alt_prs);
            
                txtDistance2.Text = s1.ToString() + "米";
                txtdistanceAll.Text = s2.ToString() + "米";
                txtazimuth.Text = azi.ToString();
                headingDirection.SetHeadingIndicatorParameters((int)azi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("d:\\Blue hills.jpg", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            StreamWriter sw = new StreamWriter("d:\\bb.txt");
            int length = (int)fs.Length;
            while (length > 0)
            {
                byte tempByte = br.ReadByte();
                string tempStr = Convert.ToString(tempByte, 16);
                tempStr=tempStr.PadLeft(2,'0');
                tempStr = tempStr.ToUpper();
                sw.Write(tempStr);
                sw.Write(' ');
                length--;
            }
            fs.Close();
            br.Close();
            sw.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = "D:\\cc.jpg";
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            StreamReader sr = new StreamReader("D:\\bb.txt");
            char[] c = null;
            while (sr.Peek() != -1)
            {
                c = new char[3];
                sr.Read(c,0,c.Length);
                string tempStr=new String(c,0,c.Length);
                byte tempByte = Convert.ToByte(tempStr.Substring(0,2), 16);
                bw.Write(tempByte);
            }
            fs.Close();
            bw.Close();
            sr.Close();
            pictureBox1.Load(path);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
        }



        private void button4_Click(object sender, EventArgs e)//要显示航迹时调用即可
        {
            float longtitude=120,latitude=30;
            Object[] objArray = new Object[2];
            objArray[0] = (Object)longtitude;
            objArray[1] = (Object)latitude;
            webBrowser1.Document.InvokeScript("Display", objArray);
        }
        GMapOverlay markerOverlaysMM = new GMapOverlay();
        GMapOverlay markerOverlaysDis = new GMapOverlay();
        GMapOverlay markerOverlays = new GMapOverlay();
        GMapOverlay markerOverlays1 = new GMapOverlay();
        GMapOverlay markerOverlays2 = new GMapOverlay();
        GMapOverlay markerOverlays0 = new GMapOverlay();  //new一个overlays对象
        GMapOverlay routesOverlay = new GMapOverlay("");
        GMapOverlay routesOverlay1 = new GMapOverlay();  //new一个overlays对象
        GMapOverlay routesOverlay2 = new GMapOverlay();  //new一个overlays对象
        GMapOverlay routesOverlay3 = new GMapOverlay();  //new一个overlays对象
        GMapOverlay routesOverlay4 = new GMapOverlay();  //new一个overlays对象
        GMapOverlay routesOverlay5 = new GMapOverlay();  //new一个overlays对象
        GMapOverlay routesOverlay6 = new GMapOverlay();  //new一个overlays对象
        GMapOverlay routesOverlay27 = new GMapOverlay("");
        GMapOverlay routesOverlay28 = new GMapOverlay("");
        GMapOverlay routesOverlay30 = new GMapOverlay("");
        GMapOverlay routesOverlay32 = new GMapOverlay("");
        private void MainMAp_Load(object sender, EventArgs e)
        {
            
            this.MainMap.Position = new PointLatLng(39.9607345203, 116.3210688729);
            MainMap.ShowCenter = false; //不显示中心十字点 
            this.MainMap.Manager.Mode = AccessMode.ServerAndCache;
            this.MainMap.MapProvider = GMapProviders.AMapSatelite;

            
            MainMap.Overlays.Add(markerOverlaysDis);
            MainMap.Overlays.Add(markerOverlays);
            MainMap.Overlays.Add(markerOverlays1);
            MainMap.Overlays.Add(markerOverlays2);
            MainMap.Overlays.Add(markerOverlays);
            MainMap.Overlays.Add(markerOverlays0);
            MainMap.Overlays.Add(routesOverlay);
            MainMap.Overlays.Add(routesOverlay1);
            MainMap.Overlays.Add(routesOverlay2);
            MainMap.Overlays.Add(routesOverlay3);
            MainMap.Overlays.Add(routesOverlay4);
            MainMap.Overlays.Add(routesOverlay5);
            MainMap.Overlays.Add(routesOverlay6);
            MainMap.Overlays.Add(routesOverlay27);
            MainMap.Overlays.Add(routesOverlay28);
            MainMap.Overlays.Add(routesOverlay30);
            MainMap.Overlays.Add(routesOverlay32);
            MainMap.Overlays.Add(markerOverlaysMM);
            MainMap.OnMarkerClick += MainMap_OnMarkerClick;


            command1 = new MenuItem("航迹",new EventHandler(track));


        }
        int tracki;
        private void track(object sender, EventArgs e)                     //是否显示轨迹
        {
            if (tracki==0)
            {
                MainMap.Overlays.Remove(routesOverlay27);
                MainMap.Overlays.Remove(routesOverlay28);
                MainMap.Overlays.Remove(routesOverlay30);
                MainMap.Overlays.Remove(routesOverlay32);
                tracki++;
            }
            else if (tracki==1)
            {
                MainMap.Overlays.Add(routesOverlay27);
                MainMap.Overlays.Add(routesOverlay28);
                MainMap.Overlays.Add(routesOverlay30);
                MainMap.Overlays.Add(routesOverlay32);
                tracki = 0;
            }
        }

        private ContextMenu markerMenu = new ContextMenu();
        private MenuItem command1 =null;
        
        void MainMap_OnMarkerClick(GMapMarker item, MouseEventArgs e)                     //右键标签调菜单
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                markerMenu.MenuItems.Add(command1);
                markerMenu.Show(MainMap, e.Location);
            }
        }
       

        private void btnyes_Click(object sender, EventArgs e)
        {
            double mouselat, mouselng;
            mouselat = double.Parse(this.textBoxlat.Text);
            mouselng = double.Parse(this.textBoxlng.Text);
            
        }

        private void btn_aq_gps_Click(object sender, EventArgs e)
        {
            if (rdb_tx_hex.Checked)
            {
                string s = "AAD18030AAAF03005C55";//richTextBox_tx.Text.Replace(" ", "");
                byte[] buffer = new byte[s.Length / 2];
                for (int i = 0; i < s.Length; i += 2)
                    buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
                //转换列表为数组后发送  
                serialPort1.Write(buffer.ToArray(), 0, buffer.Length);
                //记录发送的字节数  

            }
            else//ascii编码直接发送  
            {
                serialPort1.Write(richTextBox_tx.Text);

            }
            lbl_txcnt.Text = TX_CNT.ToString();//更新界面  
        }
        int bitmapi;

        private void MainMap_MouseClick(object sender, MouseEventArgs e)          //点击地图加点
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && checkBoxMarker.Checked)     //在markerOverlays加点，不消除
            {
                PointLatLng point = MainMap.FromLocalToLatLng(e.X, e.Y);
                Bitmap bitmap1 = (Bitmap)imageList2.Images[bitmapi++];//bitmapi++
                GMapMarker marker = new GMarkerGoogle(point, bitmap1);
               // marker.ToolTipText = "12";
                markerOverlaysMM.Markers.Add(marker);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left && checkBoxDestination.Checked   //设目的地消除前一点
                    &&btn_com_open.Enabled == false)
            {
      
                 markerOverlays0.Markers.Clear();
                 PointLatLng point = MainMap.FromLocalToLatLng(e.X, e.Y);
                 GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.arrow);
                 //marker.ToolTipText = "12";
                 markerOverlays0.Markers.Add(marker);
                 serialPort1.Write( function1.GPSToCode(point,0x27), 0,  function1.GPSToCode(point,27).Length);  //向机器人发送要走的位置
                 for (int i = 0; i < 10000000; i++)
                 {

                 }
                 serialPort1.Write(function1.GPSToCode(point, 0x28), 0, function1.GPSToCode(point, 28).Length);  //向机器人发送要走的位置
                 for (int i = 0; i < 10000000; i++)
                 {

                 }
                 serialPort1.Write(function1.GPSToCode(point, 0x30), 0, function1.GPSToCode(point, 30).Length);  //向机器人发送要走的位置
                 for (int i = 0; i < 100000000; i++)
                 {

                 }
                 serialPort1.Write(function1.GPSToCode(point, 0x32), 0, function1.GPSToCode(point, 32).Length);  //向机器人发送要走的位置
                
                 
            }


            if (e.Button == System.Windows.Forms.MouseButtons.Left && checkBoxAddLine.Checked)     //加轨迹
            {
                
                PointLatLng point = MainMap.FromLocalToLatLng(e.X, e.Y);
                //markOnePoint(e.X, e.Y);
                mouselat = point.Lat;
                mouselng = point.Lng;
               

                if (nowmouselat != 0 && lastmouselat != mouselat)
                {

                    lastmouselat = nowmouselat;
                    lastmouselng = nowmouselng;
                    nowmouselat = mouselat;
                    nowmouselng = mouselng;

                    PointLatLng nowpoint = new PointLatLng(nowmouselat, nowmouselng);
                    PointLatLng lastpoint = new PointLatLng(lastmouselat, lastmouselng);
                    DrawLineBetweenTwoPoint(nowpoint, lastpoint, 2);

                } 
                else
                {
                    nowmouselat = mouselat;
                    nowmouselng = mouselng;
                }
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left && checkBoxWantDis.Checked)
            {
                if (wandisI==0)
                {
                    wandispoint1 = MainMap.FromLocalToLatLng(e.X, e.Y);
                    wandisI = 1;
                    GMapMarker marker = new GMarkerGoogle(wandispoint1, GMarkerGoogleType.black_small);
                    markerOverlaysMM.Markers.Add(marker);
                }
                else if (wandisI==1)
                {
                    wandispoint2 = MainMap.FromLocalToLatLng(e.X, e.Y);
                    wandisI = 0;
                    double s=gmapFunc.GetDistance(wandispoint1.Lat,wandispoint1.Lng,wandispoint2.Lat,wandispoint2.Lng);

                    GMapMarker marker = new GMarkerGoogle(wandispoint2, GMarkerGoogleType.black_small);
                    marker.ToolTipText = s.ToString()+"米";
                    marker.ToolTipMode = MarkerTooltipMode.Always;
                    markerOverlaysMM.Markers.Add(marker);


                    List<PointLatLng> points = new List<PointLatLng>();
                    points.Add(wandispoint1);
                    points.Add(wandispoint2);
                    GMapRoute r = new GMapRoute(points, "");
                    r.Stroke = new Pen(Color.DarkSeaGreen, 2);
                    markerOverlaysMM.Routes.Add(r);


                }
            }

        }

        int wandisI = 0;
        PointLatLng wandispoint1, wandispoint2;
       




        //标记一个点
        public void markOnePoint(double Lat, double Lng,int i)
        {
            PointLatLng markPoint = new PointLatLng(Lat, Lng);
            Bitmap bitmap1 = (Bitmap)imageList3.Images[i];//bitmapi++
            GMarkerGoogle marker = new GMarkerGoogle(markPoint,bitmap1);
            markerOverlays.Markers.Add(marker);
        }
       


        //画出两点直接的直线
         public void DrawLineBetweenTwoPoint(PointLatLng pointLatLng_S, PointLatLng pointLatLng_E,int m)
        {
            List<PointLatLng> points = new List<PointLatLng>();
            points.Add(pointLatLng_S);
            points.Add(pointLatLng_E);
            GMapRoute r = new GMapRoute(points, "");
            if(m==1)
            r.Stroke = new Pen(Color.Red, 2);
            else
                r.Stroke = new Pen(Color.Green, 4);
            routesOverlay.Routes.Add(r);

        }
        int RobotId;
       

        #region                                                          //GMAP需要的定义
        static double lat, lng, azi;   //定位经纬度变量
        static double nowlat0 = 0, nowlng0 = 0, lastlat0, lastlng0;
        static double nowlat1 , nowlng1 , lastlat1, lastlng1;
        static double nowlat2 = 0, nowlng2 = 0, lastlat2, lastlng2;
        static double nowlat3 = 0, nowlng3 = 0, lastlat3, lastlng3;
        static double nowlat4 = 0, nowlng4 = 0, lastlat4, lastlng4;
        static double nowlat5 = 0, nowlng5 = 0, lastlat5, lastlng5;
        static double nowmouselat = 0, nowmouselng = 0, lastmouselat = 0, lastmouselng = 0, mouselat = 0, mouselng = 0;

        static double s1 = 0, s2 = 0;


        string path = @"d:\GPS.txt";//这是地址
        string Textsave;
        #endregion  



        void getGPS(int id)                                                           //获取GPS函数
        {
            string s = "AAD180" + id + "AAAF03005C55";     //发送指令获取GPS
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            //转换列表为数组后发送  
            serialPort1.Write(buffer.ToArray(), 0, buffer.Length);
        }
        int timei=0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (checkBoxWantDis.Checked==false)
            {
               // markerOverlaysMM.Markers.Clear();
                markerOverlaysMM.Routes.Clear();
            }


            if (checkBoxGPS.Checked&&btn_com_open.Enabled==false)
            {
                if (timei==0)
                {
                    getGPS(27);
                    timei++;
                }
                else if (timei == 1)
                {
                    getGPS(30);
                    timei++;
                }
                else if (timei == 2)
                {
                    getGPS(28);
                    timei=0;
                }
                else if (timei == 3)
                {
                    getGPS(32);
                    timei = 0;
                }
                //getGPS(30);
            }

             #region     机器人接收指令                           
            if (RobotId == 27)
            {

                if (status == 65)
                {
                    double wglat, wglng;


                    double.TryParse(System.Text.Encoding.Default.GetString(latitude), out wglat);
                    double.TryParse(System.Text.Encoding.Default.GetString(longitude), out wglng);
                    //double.TryParse(System.Text.Encoding.Default.GetString(Azimuth), out azi);


                    wglat = (wglat - (int)wglat / 100 * 100) / 60 + (int)wglat / 100;
                    wglng = (wglng - (int)wglng / 100 * 100) / 60 + (int)wglng / 100;
                    EvilTransform.transform(wglat, wglng, out lat, out lng);



                    ////数据存入txt

                    Textsave += wglat.ToString("N13") + "  " + wglng.ToString("N12") + "\r\n";

                    FileStream fs = new FileStream(path, FileMode.Create);
                    StreamWriter sw = new StreamWriter(fs, Encoding.Unicode);
                    sw.Write(Textsave);
                    sw.Close();
                    fs.Close();




                    if (nowlat1 != 0 && lat > 30 && lng > 100)
                    {
                        lastlat1 = nowlat1;
                        lastlng1 = nowlng1;
                        nowlat1 = lat;
                        nowlng1 = lng;

                        List<PointLatLng> points = new List<PointLatLng>();
                        points.Add(new PointLatLng(lastlat1, lastlng1));
                        points.Add(new PointLatLng(nowlat1, nowlng1));
                        GMapRoute r = new GMapRoute(points, "");
                        r.Stroke = new Pen(Color.Red, 2);
                        routesOverlay27.Routes.Add(r);

                    }
                    else if (lat > 30 && lng > 100)
                    {
                        nowlat1 = lat;
                        nowlng1 = lng;
                    }
                }
            }

            else if (RobotId == 28)
            {

                if (status == 65)
                {
                    double wglat, wglng;


                    double.TryParse(System.Text.Encoding.Default.GetString(latitude), out wglat);
                    double.TryParse(System.Text.Encoding.Default.GetString(longitude), out wglng);
                    //double.TryParse(System.Text.Encoding.Default.GetString(Azimuth), out azi);


                    wglat = (wglat - (int)wglat / 100 * 100) / 60 + (int)wglat / 100;
                    wglng = (wglng - (int)wglng / 100 * 100) / 60 + (int)wglng / 100;
                    EvilTransform.transform(wglat, wglng, out lat, out lng);

                    if (nowlat2 != 0 && lat > 30 && lng > 100)
                    {
                        lastlat2 = nowlat2;
                        lastlng2 = nowlng2;
                        nowlat2 = lat;
                        nowlng2 = lng;

                        List<PointLatLng> points = new List<PointLatLng>();
                        points.Add(new PointLatLng(lastlat2, lastlng2));
                        points.Add(new PointLatLng(nowlat2, nowlng2));
                        GMapRoute r = new GMapRoute(points, "");
                        r.Stroke = new Pen(Color.Red, 2);
                        routesOverlay28.Routes.Add(r);
                    }
                    else if (lat > 30 && lng > 100)
                    {
                        nowlat2 = lat;
                        nowlng2 = lng;
                    }
                }

            }

            else if (RobotId == 30)
            {
                if (status == 65)
                {
                    double wglat, wglng;


                    double.TryParse(System.Text.Encoding.Default.GetString(latitude), out wglat);
                    double.TryParse(System.Text.Encoding.Default.GetString(longitude), out wglng);
                    //double.TryParse(System.Text.Encoding.Default.GetString(Azimuth), out azi);


                    wglat = (wglat - (int)wglat / 100 * 100) / 60 + (int)wglat / 100;
                    wglng = (wglng - (int)wglng / 100 * 100) / 60 + (int)wglng / 100;
                    EvilTransform.transform(wglat, wglng, out lat, out lng);


                    if (nowlat3 != 0 && lat > 30 && lng > 100)
                    {
                        lastlat3 = nowlat3;
                        lastlng3 = nowlng3;
                        nowlat3 = lat;
                        nowlng3 = lng;

                        List<PointLatLng> points = new List<PointLatLng>();
                        points.Add(new PointLatLng(lastlat3, lastlng3));
                        points.Add(new PointLatLng(nowlat3, nowlng3));
                        GMapRoute r = new GMapRoute(points, "");

                        r.Stroke = new Pen(Color.Red, 2);

                        routesOverlay30.Routes.Add(r);
                    }
                    else if (lat > 30 && lng > 100)
                    {
                        nowlat3 = lat;
                        nowlng3 = lng;
                    }
                }


            }
            else if (RobotId == 32)
            {
                if (status == 65)
                {
                    double wglat, wglng;


                    double.TryParse(System.Text.Encoding.Default.GetString(latitude), out wglat);
                    double.TryParse(System.Text.Encoding.Default.GetString(longitude), out wglng);
                    //double.TryParse(System.Text.Encoding.Default.GetString(Azimuth), out azi);


                    wglat = (wglat - (int)wglat / 100 * 100) / 60 + (int)wglat / 100;
                    wglng = (wglng - (int)wglng / 100 * 100) / 60 + (int)wglng / 100;
                    EvilTransform.transform(wglat, wglng, out lat, out lng);


                    if (nowlat3 != 0 && lat > 30 && lng > 100)
                    {
                        lastlat4 = nowlat4;
                        lastlng4 = nowlng4;
                        nowlat4 = lat;
                        nowlng4 = lng;

                        List<PointLatLng> points = new List<PointLatLng>();
                        points.Add(new PointLatLng(lastlat3, lastlng3));
                        points.Add(new PointLatLng(nowlat3, nowlng3));
                        GMapRoute r = new GMapRoute(points, "");

                        r.Stroke = new Pen(Color.Red, 2);

                        routesOverlay32.Routes.Add(r);
                    }
                    else if (lat > 30 && lng > 100)
                    {
                        nowlat3 = lat;
                        nowlng3 = lng;
                    }
                }




            }

#endregion 
    
            markerOverlays.Markers.Clear();
            markOnePoint(nowlat1, nowlng1, 27);
            markOnePoint(nowlat2, nowlng2, 28);
            markOnePoint(nowlat3, nowlng3, 30);
            markOnePoint(nowlat4, nowlng4, 32);

         


        }

        private void btnOPenBarrier_Click(object sender, EventArgs e)
        {
            //btnOPenBarrier.Enabled = false;
            //btnCloseBarrier.Enabled = true;
            string s = "AAD18027AAAF0901016455";     //发送指令获取GPS
            //byte[] buffer = new byte[s.Length / 2];
            //for (int i = 0; i < s.Length; i += 2)
            //    buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            ////转换列表为数组后发送  
            //serialPort1.Write(buffer.ToArray(), 0, buffer.Length);
            sendmessage(s);
            for (int i = 0; i < 10000000; i++)
            {
                
            }
            sendmessage("AAD18030AAAF0901016455");
            for (int i = 0; i < 10000000; i++)
            {

            }
            sendmessage("AAD18028AAAF0901016455");
            for (int i = 0; i < 10000000; i++)
            {

            }
            sendmessage("AAD18032AAAF0901016455");
        }
        void sendmessage(string s)
        {
            byte[] buffer = new byte[s.Length / 2];
            for (int i = 0; i < s.Length; i += 2)
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            //转换列表为数组后发送  
            serialPort1.Write(buffer.ToArray(), 0, buffer.Length);
        }
        private void btnCloseBarrier_Click(object sender, EventArgs e)
        {
            //btnOPenBarrier.Enabled = true;
            //btnCloseBarrier.Enabled = false;
            string s = "AAD18027AAAF0901006355";     //发送指令获取GPS
            sendmessage(s);
            for (int i = 0; i < 10000000; i++)
            {

            }
            sendmessage("AAD18030AAAF0901006355");
            for (int i = 0; i < 10000000; i++)
            {

            }
            sendmessage("AAD18028AAAF0901006355");
            for (int i = 0; i < 10000000; i++)
            {

            }
            sendmessage("AAD18032AAAF0901006355");
        }


    }
}