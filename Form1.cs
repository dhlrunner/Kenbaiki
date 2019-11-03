using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.IO.Ports;

namespace kenbaiki
{
    public partial class Form1 : Form
    {            
        static Form1 frm;
        string last_studentID = "";
        bool tokai_student = false;
        private IntPtr pasorip = IntPtr.Zero;
        private IntPtr felicap = IntPtr.Zero;
        int inserted_credit_coin = 0;
        int inserted_credit_bill = 0;
        int return_credit = 0;
        int total_pay_credit = 0;
        bool end_return = false;
        bool end_return_bill = false;
        bool escrow = false;
        bool escrow_2000 = false;
        int print_count = 0;
        int[] cmcontrol_return_typedata = new int[7];
        //bool isTokaiStudent = false;
        int settedpaper = 0;
        int count = 0;
        int will_return_credit = 0;
        public enum op
        {
            addAdmin,
            readID,
        }
        List<string> pages = new List<string>();
        JObject items = new JObject();
        public JArray admin = new JArray();
        public Form1()
        {
            InitializeComponent(); 
        }
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }
        public static byte ToBcd(int value)
        {
            if (value < 0 || value > 99999999)
                throw new ArgumentOutOfRangeException("value");
            byte ret = new byte();

            ret = (byte)(value % 10);
            value /= 10;
            ret |= (byte)((value % 10) << 4);
            value /= 10;

            return ret;
        }
        int getfcc(int bc, int dc, byte[] data)
        {
            int fcc = 0;
            fcc = bc;
            fcc = fcc ^ dc;
            for (int i = 0; i < bc - 1; i++)
            {
                fcc = fcc ^ data[i];
            }
            return fcc;
        }
        public static int getCRC(byte[] bytes)
        {
            int crc = 0xFFFF;          // initial value
            int polynomial = 0x1021;   // 0001 0000 0010 0001  (0, 5, 12) 

            foreach (byte b in bytes)
            {
                for (int i = 0; i < 8; i++)
                {
                    Boolean bit = ((b >> (7 - i) & 1) == 1);
                    Boolean c15 = ((crc >> 15 & 1) == 1);
                    crc <<= 1;
                    if (c15 ^ bit) crc ^= polynomial;
                }
            }

            crc &= 0xffff;
            //System.out.println("CRC16-CCITT = " + Integer.toHexString(crc));
            return crc;
        }
        public string isTokaiStudent()
        {
            IDreadform form = new IDreadform(idserialport.Text);
            if (form.ShowDialog() == DialogResult.OK)
            {
                return form.IDvalue;     
            }
            else
            {
                return string.Empty;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;           
            frm = this;
            indicator_rx_timer.Start();
            indicator_tx_timer.Start();
            tabControl1.SelectedTab = tabPage2;
            items = JObject.Parse(File.ReadAllText(@"items.json"));
            admin = JArray.Parse(File.ReadAllText(@"list.json"));
            PrintDocument pd = new PrintDocument();
            foreach(var a in admin)
            {
                adminlist.Items.Add(a.ToString());
            }
            foreach(System.Drawing.Printing.PaperSize a in pd.PrinterSettings.PaperSizes)
            {
                printerpaper.Items.Add(a.ToString());
            }
            foreach(string port in SerialPort.GetPortNames())
            {
                idserialport.Items.Add(port);
            }
            foreach (string port in SerialPort.GetPortNames())
            {
                creditport.Items.Add(port);
            }
            //creditport.SelectedIndex = 0;
            //idserialport.SelectedIndex = 0;
        }
        void addpopcorns(Control c)
        {
            string codename = c.Name.Split('_')[1];
            count++;
            if (tokai_student)
            {
                listView1.Items.AddRange(new ListViewItem[] { new ListViewItem(new string[] { count.ToString(), items[codename]["name"].ToString(), "\\" + items[codename]["price"].ToString(), items[codename]["price"].ToString() =="100"?"":"\\-50"}) });
                total_pay_credit += 100;
            }
            
            else
            {
                paywithcoupon.Enabled = true;
                button3.Enabled = false;
                listView1.Items.AddRange(new ListViewItem[] { new ListViewItem(new string[] { count.ToString(), items[codename]["name"].ToString(), "\\" + items[codename]["price"].ToString() }) });
                total_pay_credit += Convert.ToInt16( items[codename]["price"]);
            }
            datachanged();
            pages.Add(codename);
            //GenerateMealTicket(items[codename]["name"].ToString(), "\\"+items[codename]["price"].ToString(),"0");
            //print_label();
        }
        private void GenerateMealTicket(string menu, string number ,string Sign,bool idcard)
        {
            string imageFilePath = @"picture.bmp";
            System.IO.FileInfo fi = new System.IO.FileInfo(imageFilePath);
            if (fi.Exists)
            {
                //pictureBox1.Dispose();
                fi.Delete();
            }
            Image logo = Image.FromFile(@"logo.png");
            string firstText = menu;
            string secondText = number;
            string watermark = "Tokai Univ. Takanawa Campus\nハイテクアートファクトリー部";
            string sign = Sign;
            string datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            PointF firstLocation = new PointF(50f, 10f);
            PointF secondLocation = new PointF(0f, 120f);
            PointF logoLocation = new PointF(230f,130f);
            PointF watermarkLocation = new PointF(15f, 150f);
            PointF datetimeLocation = new PointF(170f, 0f);
            PointF signLocation = new PointF(15f, 0f);
            Bitmap bitmap = new Bitmap(302, 211);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                Rectangle rec = new Rectangle(1, 1, bitmap.Width, bitmap.Height);
                Font Titlefont = new Font("MS UI Gothic", 26, FontStyle.Regular);
                Font Secondfont = new Font("UD Digi Kyokasho NP-B", 20,FontStyle.Regular);
                Font watermarkfont = new Font("MS UI Gothic",10);
                Font datetimefont = new Font("MS UI Gothic", 9);
                Font signfont = new Font("MS UI Gothic", 9);
                //graphics.DrawString(firstText, new Font("Arial", 30,FontStyle.Bold), Brushes.Black, firstLocation);               
                SizeF stringSize = new SizeF();
                stringSize = graphics.MeasureString(firstText, Titlefont);
                graphics.DrawRectangle(Pens.Transparent, rec.X, rec.Y, rec.Width, rec.Height);
                int leftMargin = (int)(rec.X + (rec.Width / 2 - stringSize.Width / 2));
                graphics.DrawString(firstText, Titlefont, Brushes.Black, leftMargin,30);
                stringSize = graphics.MeasureString(secondText, Secondfont);
                leftMargin = (int)(rec.X + (rec.Width / 2 - stringSize.Width / 2));
                graphics.DrawImage(logo,logoLocation);
                graphics.DrawString(secondText, Secondfont, Brushes.Black, leftMargin, 110);
                graphics.DrawString(watermark, watermarkfont, Brushes.Black, watermarkLocation);
                graphics.DrawString(datetime, datetimefont, Brushes.Black, datetimeLocation);
                graphics.DrawString(sign, signfont, Brushes.Black, signLocation);
            }

            bitmap.Save(imageFilePath);//save the image file
            bitmap.Save(@"sales_log/tickets/" + datetime.Replace(".","_").Replace(":", "_")+".bmp");
            bitmap.Dispose();
            //日付,商品名,金額,支払い方法,学生証有無,学籍番号
            addcsv(string.Format("{0},{1},{2},{3},{4},{5}",datetime.Replace("-","/"),menu.Replace("\n",""),number,Sign,idcard.ToString(),idcard ? last_studentID: ""));
            //pictureBox1.Image = LoadBitmap(imageFilePath); 
        }
        void addcsv(string data)
        {
            string csv = File.ReadAllText(@"sales_log/sales_data.csv");
            csv += Environment.NewLine + data;
            File.WriteAllText(@"sales_log/sales_data.csv", csv, Encoding.UTF8);
        }
        private void PrintPage(object o, PrintPageEventArgs e)
        {
            Image img = Image.FromFile("picture.bmp");
            Point loc = new Point(-15, 0);
            e.Graphics.DrawImage(img, loc);
            img.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            print_label();
        }
        protected void print_label()
        {
            PrintDocument pd = new PrintDocument();
            pd.EndPrint += printCompleted;
            pd.DefaultPageSettings.PaperSize = pd.PrinterSettings.PaperSizes[settedpaper];
            pd.PrintPage += PrintPage;
            pd.Print();
            pd.Dispose();
        }
        void printCompleted(object sender,PrintEventArgs e)
        {
           // MessageBox.Show("competed");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {           
            Random rand = new Random();
            int num = rand.Next(0,99999);
            //byte[] hash = MD5HashFunc(textBox1.Text);
            //int pass = rand.Next(0, hash.Length);
          //  string sign = Convert.ToBase64String(Encoding.UTF8.GetBytes(hash[pass].ToString() + num.ToString() + pass.ToString()));
            //GenerateMealTicket(textBox1.Text, num.ToString("X2"), sign);
        }
        public byte[] MD5HashFunc(string str)
        {
            StringBuilder MD5Str = new StringBuilder();
            byte[] byteArr = Encoding.ASCII.GetBytes(str);
            byte[] resultArr = (new System.Security.Cryptography.MD5CryptoServiceProvider()).ComputeHash(byteArr);

            //for (int cnti = 1; cnti < resultArr.Length; cnti++) (2010.06.27)
            for (int cnti = 0; cnti < resultArr.Length; cnti++)
            {
                MD5Str.Append(resultArr[cnti].ToString("X2"));
            }
            return resultArr;
        }
        public Bitmap LoadBitmap(string path)
        {
            if (File.Exists(path))
            {
                using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                // get a binary reader for the file stream
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    // copy the content of the file into a memory stream
                    var memoryStream = new MemoryStream(reader.ReadBytes((int)stream.Length));
                    // make a new Bitmap object the owner of the MemoryStream
                    return new Bitmap(memoryStream);
                }
            }
            else
            {
                MessageBox.Show("Error Loading File.", "Error!", MessageBoxButtons.OK);
                return null;
            }
        }

        private void Menu_plane_Click(object sender, EventArgs e)
        {
            addpopcorns((Control)sender);            
         }

        private void Menu_salt_Click(object sender, EventArgs e)
        {
            addpopcorns((Control)sender);
        }
        private void Menu_saltpepper_Click(object sender, EventArgs e)
        {
            addpopcorns((Control)sender);
        }
      
        private void Menu_caramel_Click(object sender, EventArgs e)
        {
            addpopcorns((Control)sender);
        }

        private void Menu_curry_Click(object sender, EventArgs e)
        {
            addpopcorns((Control)sender);
        }

        private void Play_music_Click(object sender, EventArgs e)
        {
            //WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            //wplayer.URL = "My MP3 file.mp3";
            //wplayer.Controls.Play();
        }

        private void Paywithmoney_Click(object sender, EventArgs e)
        {            
            if (total_pay_credit > 0)
            {
                int willreturn = will_return_credit;
                if (willreturn != 0)
                {
                    if (return_price(willreturn))
                    {
                        Delay(500);
                        writeBvcm(BVCM_bytes.insertclear_bv);
                        writeBvcm(BVCM_bytes.insertclear_cm);
                        Delay(500);
                        writeBvcm(BVCM_bytes.start_bv);
                        writeBvcm(BVCM_bytes.start_cm);
                        will_return_credit = 0;
                        total_pay_credit = 0;
                        inserted_credit_bill = 0;
                        inserted_credit_coin = 0;
                        bvcm_add_log("決済が終わりました。");
                        listView1.Items.Clear();
                        datachanged();
                    }
                }
                else
                {
                    Delay(500);
                    writeBvcm(BVCM_bytes.insertclear_bv);
                    writeBvcm(BVCM_bytes.insertclear_cm);
                    Delay(500);
                    writeBvcm(BVCM_bytes.start_bv);
                    writeBvcm(BVCM_bytes.start_cm);
                    bvcm_add_log("決済が終わりました。釣銭はありません。");
                    inserted_credit_bill = 0;
                    inserted_credit_coin = 0;
                    return_credit = 0;
                    total_pay_credit = 0;
                    listView1.Items.Clear();
                    datachanged();
                }
                foreach (string n in pages)
                {
                    string pr = items[n]["price"].ToString();
                    if (tokai_student)
                    {
                        if (pr != "100")
                        {
                            pr = "100";
                        }
                        GenerateMealTicket(items[n]["name"].ToString(), "\\" + pr, "現金支払い(東海学割)",true);
                    }
                    else
                    {
                        GenerateMealTicket(items[n]["name"].ToString(), "\\" + pr, "現金支払い",false);
                    }
                    print_label();
                }
            }
            pages.Clear();
            count = 0;
            paywithmoney.Enabled = false;
            button3.Enabled = true;
            button3.Text = "学生認証";
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Printerpaper_SelectedIndexChanged(object sender, EventArgs e)
        {
            settedpaper = printerpaper.SelectedIndex;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            IDcardTest.RunWorkerAsync();
            idteststop.Enabled = true;
        }

        private void Idserialport_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDreader.PortName = idserialport.Text;
        }

        private void IDcardTest_DoWork(object sender, DoWorkEventArgs e)
        {
            //e.Cancel = true;
            idserialport.Enabled = false;
            IDreader.Open();
            button1.Text = "リーダー応答テスト中…";
            IDreader.Write(new byte[] { 0x01 }, 0, 1);
            //string a = IDreader.ReadLine();
            try
            {
                if (IDreader.ReadLine() == "OK\r")
                {
                    button1.Text = "カードをかざして下さい…";
                    try
                    {
                        string stID = IDreader.ReadLine().Split(',')[1];
                        string satID = IDreader.ReadLine().Split(',')[2];
                        button1.Text = stID + Environment.NewLine + satID;
                        
                    }
                    catch (IndexOutOfRangeException)
                    {
                        button1.Text = "カードからデータを読み込めません。";
                    }
                }
                else
                {
                    button1.Text = "リーダーエラー発生";
                }
                IDreader.Close();
                idteststop.Enabled = false;
                idserialport.Enabled = true;
            }
            catch (IOException)
            {
                button1.Text = "キャンセルされました。";
            }
        }

        private void Idteststop_Click(object sender, EventArgs e)
        {
            IDcardTest.CancelAsync();
            IDreader.Close();
            idteststop.Enabled = false;
            idserialport.Enabled = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            IDreadform form = new IDreadform(idserialport.Text);
            if (form.ShowDialog() == DialogResult.OK)
            {
                string id = form.IDvalue.Split(',')[1];
                if (!admin.ToString().Contains(id))
                {
                    admin.Add(id);
                    adminlist.Items.Add(id);
                }
                else
                {
                    MessageBox.Show("登録済みの管理者です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            passwordform pwd = new passwordform();
            if(pwd.ShowDialog() != DialogResult.OK)
            {
                e.Cancel = true;
            }
            else
            {
                File.WriteAllText("list.json", admin.ToString());
            }
            
        }

       

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabPage2)
            {
                passwordform pwd = new passwordform();
                if (pwd.ShowDialog() == DialogResult.OK)
                {
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                    tabControl1.SelectedTab = tabPage1;
            }
        }

        private void Bvcm_openport_Click(object sender, EventArgs e)
        {
            try
            {
                bvcm.PortName = creditport.Text;
                bvcm.Open();
                creditport.Enabled = false;
                credit_clear.Enabled = true;
                bvcm_closeport.Enabled = true;
                bvcm_openport.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Port Open Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (bvcm.IsOpen)
            {
                bvcm_add_log("ポートOPENに成功しました。");
                writeBvcm(BVCM_bytes.standby_bv);
                writeBvcm(BVCM_bytes.standby_cm);
                bvcm_add_log("Stand-by指令を送信しました。");
                bvcm_add_log("受入可能指令を送信しました。");
                writeBvcm(BVCM_bytes.start_bv);
                writeBvcm(BVCM_bytes.start_cm);
                timer1.Start();
                timer2.Start();
            }
        }

        private void Bvcm_closeport_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            writeBvcm(BVCM_bytes.inhibit_bv);
            writeBvcm(BVCM_bytes.inhibit_cm);
            bvcm.Close();
            creditport.Enabled = true;
            bvcm_closeport.Enabled = false;
            bvcm_openport.Enabled = true;
            credit_clear.Enabled = false;
        }
        public void bvcm_add_log(string text)
        {
            bvcm_log.AppendText(string.Format("[{0}]{1}", DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"), text+Environment.NewLine));
            bvcm_log.SelectionStart = bvcm_log.Text.Length;
            bvcm_log.ScrollToCaret();
        }
        private void Bvcm_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            comm_RX.BackColor = Color.Red;
            int recsize = bvcm.BytesToRead;
            byte[] buff_raw = new byte[recsize];
            List<byte> buff = new List<byte>();
            bvcm.Read(buff_raw, 0, recsize);

            for (int i = 0; i < recsize; i++)
            {
                buff.Add(buff_raw[i]);
            }

            if (buff.Count > 6)
            {
                if (buff[3] == 0xEE)
                {
                    bvcm_add_log("NAKを受信しました。");                   
                }
                else if (buff[3] == 0x44)
                {
                    timer1.Stop();
                    timer2.Stop();
                    bvcm_add_log("ACK4を受信しました。先にステンバイ状況に移行して下さい。");
                }

                for (int i = 1; i < buff.Count - 1; i++)
                {
                    if (buff[i] == 0x7d && buff[i + 1] == 0xe3)
                    {
                        buff[i] = 0x03;
                        buff.RemoveAt(i + 1);
                    }
                    else if (buff[i] == 0x7d && buff[i + 1] == 0xe2)
                    {
                        buff[i] = 0x02;
                        buff.RemoveAt(i + 1);
                    }
                }

                for (int i = 0; i < buff.Count; i++)
                {
                    if (i > 2)
                    {
                        if (buff[i] == 0x18 && escrow == false)
                        {
                            if (buff[i - 1] == 0x06)
                            {
                                if (buff[i + 5] > 0)
                                {
                                    inserted_credit_bill += Convert.ToInt16(buff[i + 5]) * 2000;
                                    escrow = true;
                                    escrow_2000 = true;
                                }
                                if (buff[i + 1] > 0)
                                {
                                    inserted_credit_bill += Convert.ToInt16(buff[i + 1]) * 1000;
                                    escrow = true;
                                }

                            }
                            else if (buff[i - 1] == 0x05)
                            {
                                if (buff[i + 1] > 0)
                                {
                                    inserted_credit_bill += Convert.ToInt16(buff[i + 1]) * 1000;
                                    escrow = true;
                                }

                            }

                        }
                        if (buff[i] == 0x08 && buff[i - 1] == 0x05)
                        {
                            inserted_credit_coin = (Convert.ToInt32(buff[i + 1].ToString("X2")) * 10) + (Convert.ToInt32(buff[i + 2].ToString("X2")) * 50) + (Convert.ToInt32(buff[i + 3].ToString("X2")) * 100) + (Convert.ToInt32(buff[i + 4].ToString("X2")) * 500);
                        }
                        if (buff[i] == 0x0b && buff[i - 1] == 0x02)
                        {
                            end_return = GetBit(buff[i + 1], 4);
                        }
                        if (buff[i] == 0x1b && buff[i - 1] == 0x04)
                        {
                            end_return_bill = GetBit(buff[i + 1], 3);
                        }
                        if (escrow == true)
                        {
                            if (buff[i] == 0x1b)
                            {
                                if (GetBit(buff[i + 1], 5))
                                {
                                    escrow = false;
                                    escrow_2000 = false;
                                    writeBvcm(BVCM_bytes.insertclear_bv);

                                    //byte[] laststate = new byte[last_state.Count];
                                    //for (int j = 0; j < last_state.Count; j++)
                                    //{
                                    //    laststate[j] = last_state[j];
                                    //}
                                    //bvcm.Write(laststate, 0, laststate.Length);

                                }
                            }
                        }

                    }
                }
            }
            datachanged();
        }
        public static bool GetBit(byte b, int bitNumber)
        {
            return (b & (1 << bitNumber)) != 0;
        }
        void datachanged()
        {
            inserted_credit.Text = (inserted_credit_coin + inserted_credit_bill).ToString();
            will_return_credit = (inserted_credit_coin + inserted_credit_bill) - total_pay_credit;
            total_change.Text = will_return_credit.ToString();
            total_price.Text = total_pay_credit.ToString();
            if((inserted_credit_coin + inserted_credit_bill) >= total_pay_credit && total_pay_credit != 0)
            {
                paywithmoney.Enabled = true;
                if (!tokai_student)
                    paywithcoupon.Enabled = true;

            }
            else if((inserted_credit_coin + inserted_credit_bill) <= total_pay_credit && total_pay_credit != 0)
            {
                paywithmoney.Enabled = false;
            }
        }
        void writeBvcm(byte[] data)
        {
            comm_TX.BackColor = Color.LimeGreen;
            bvcm.Write(data, 0, data.Length);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            writeBvcm(BVCM_bytes.inreq_bv);           
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            writeBvcm(BVCM_bytes.inreq_cm);
        }

        private void Indicator_tx_timer_Tick(object sender, EventArgs e)
        {
            comm_TX.BackColor = SystemColors.Control;
        }

        private void Indicator_rx_timer_Tick(object sender, EventArgs e)
        {
            comm_RX.BackColor = SystemColors.Control;
        }

        private void Credit_clear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("投入金をクリアしますか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                inserted_credit_coin = 0;
                inserted_credit_bill = 0;
                escrow = false;
                escrow_2000 = false;
                writeBvcm(BVCM_bytes.insertclear_bv);
                writeBvcm(BVCM_bytes.insertclear_cm);
                datachanged();
            }          
        }
        bool return_price(int returnprice)
        {
            bvcm_add_log("釣銭を払出しています。");
            int yen2000 = 0;
            int yen1000 = 0;
            int yen500 = 0;
            int yen100 = 0;
            int yen50 = 0;
            int yen10 = 0;
            timer1.Stop();
            timer2.Stop();
            writeBvcm(BVCM_bytes.inhibit_bv);
            writeBvcm(BVCM_bytes.inhibit_cm);
            Delay(1000);
            if (returnprice >= 1000 && returnprice < 2000)
            {
                if (escrow && escrow_2000 == false)
                {
                    writeBvcm(BVCM_bytes.bill_return_1000);                   
                    while (end_return_bill == false)
                    {
                        writeBvcm(BVCM_bytes.inreq_bv);                       
                        Delay(100);
                    }
                    yen1000++;
                    returnprice = returnprice - 1000;
                }
            }
            else if (returnprice >= 2000)
            {
                if (escrow && escrow_2000 == false)
                {
                    writeBvcm(BVCM_bytes.bill_return_1000);
                    while (end_return_bill == false)
                    {
                        writeBvcm(BVCM_bytes.inreq_bv);
                        Delay(100);
                    }
                    yen1000++;
                    returnprice = returnprice - 1000;
                }
                else if (escrow_2000)
                {
                    writeBvcm(BVCM_bytes.bill_return_2000);                  
                    while (end_return_bill == false)
                    {
                        writeBvcm(BVCM_bytes.inreq_bv);
                        Delay(100);
                    }
                    yen2000++;
                    returnprice = returnprice - 2000;
                }
            }

            yen500 = returnprice / 500;
            returnprice = returnprice - (yen500 * 500);
            yen100 = returnprice / 100;
            returnprice = returnprice - (yen100 * 100);
            yen50 = returnprice / 50;
            returnprice = returnprice - (yen50 * 50);
            yen10 = returnprice / 10;
            returnprice = returnprice - (yen10 * 10);
            bvcm_add_log("払出し金額：￥2000 x " + yen2000 + ", ￥1000 x " + yen1000 + ", ￥500 x " + yen500.ToString() + ", ￥100 x " + yen100.ToString() + ", ¥50 x " + yen50.ToString() + ", ¥10 x " + yen10.ToString() + "\n");           

            {
                cmcontrol_return_typedata[0] = 0x05; //BC
                cmcontrol_return_typedata[1] = 0x02; //DC
                cmcontrol_return_typedata[2] = ToBcd(yen10);
                cmcontrol_return_typedata[3] = ToBcd(yen50);
                cmcontrol_return_typedata[4] = ToBcd(yen100);
                cmcontrol_return_typedata[5] = ToBcd(yen500);
                byte[] temp = new byte[4];
                for (int i = 0; i < 4; i++)
                {
                    temp[i] = Convert.ToByte(cmcontrol_return_typedata[i + 2]);
                }
                cmcontrol_return_typedata[6] = Convert.ToByte(getfcc(cmcontrol_return_typedata[0], cmcontrol_return_typedata[1], temp));
            }
            {
                List<byte> packet = new List<byte>();
                byte[] CRC = new byte[2];
                byte[] Rawdata = { 0x00, 0x20, 0x63, (byte)cmcontrol_return_typedata[0], (byte)cmcontrol_return_typedata[1], (byte)cmcontrol_return_typedata[2], (byte)cmcontrol_return_typedata[3], (byte)cmcontrol_return_typedata[4], (byte)cmcontrol_return_typedata[5], (byte)cmcontrol_return_typedata[6] };
                packet.Add(0x02); //start bit
                packet.Add(0x00); //SID
                packet.Add(0x20); //RID
                packet.Add(0x63); //Command
                for (int i = 0; i < cmcontrol_return_typedata.Length; i++)
                {
                    packet.Add(Convert.ToByte(cmcontrol_return_typedata[i]));
                }
                CRC = BitConverter.GetBytes(getCRC(Rawdata));
                packet.Add(CRC[1]);
                packet.Add(CRC[0]);
                for (int i = 3; i < packet.Count; i++)
                {
                    if (packet[i] == 0x03)
                    {
                        packet[i] = 0x7D;
                        packet.Insert(i + 1, 0xE3);
                    }
                    else if (packet[i] == 0x02)
                    {
                        packet[i] = 0x7D;
                        packet.Insert(i + 1, 0xE2);
                    }
                }
                packet.Add(0x03); //end bit
                byte[] sendpacketdata = new byte[packet.Count];
                for (int i = 0; i < packet.Count; i++)
                {
                    sendpacketdata[i] = packet[i];
                    //richTextBox1.Text += packet[i].ToString("X2") + " ";
                }
                // richTextBox1.Text += "\r\n";
                writeBvcm(sendpacketdata);
            }
            while (end_return == false)
            {
                writeBvcm(BVCM_bytes.inreq_cm);
                Delay(100);
            }
            end_return = false;
            if (returnprice != 0)
                return false;
            escrow = false;
            escrow_2000 = false;
            timer1.Start();
            timer2.Start();
            bvcm_add_log("払出し完了。金額をお確かめて下さい。");
            return true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string value = isTokaiStudent();
            if(value != string.Empty)
            {
                string id = value.Split(',')[1];
                last_studentID = id;
                button3.Text = "学生認証済み"+Environment.NewLine+"("+id+")";
                button3.Enabled = false;
                tokai_student = true;
                if (!vaild_timer.Enabled)
                {
                    vaild_timer.Start();
                }
            }
        }

        private void Vaild_timer_Tick(object sender, EventArgs e)
        {
            tokai_student = false;
            cancelpay();
            vaild_timer.Stop();
        }
        void cancelpay()
        {
            count = 0;
            pages.Clear();
            
            if (will_return_credit != 0)
            {
                bvcm_add_log("決済を取消します。");
                return_price(inserted_credit_bill + inserted_credit_coin);

                Delay(500);
                writeBvcm(BVCM_bytes.insertclear_bv);
                writeBvcm(BVCM_bytes.insertclear_cm);
                Delay(500);
                writeBvcm(BVCM_bytes.start_bv);
                writeBvcm(BVCM_bytes.start_cm);
                inserted_credit_bill = 0;
                inserted_credit_coin = 0;
                will_return_credit = 0;
                total_pay_credit = 0;
                listView1.Items.Clear();
                datachanged();
            }
            else
            {
                bvcm_add_log("決済を取消します。返金金額はありません。");
                inserted_credit_bill = 0;
                inserted_credit_coin = 0;
                will_return_credit = 0;
                total_pay_credit = 0;
                listView1.Items.Clear();
                datachanged();
            }
        }

        private void Cancel_pay_Click(object sender, EventArgs e)
        {
            cancelpay();
            button3.Text = "学生認証";
            tokai_student = false;
            button3.Enabled = true;
            paywithmoney.Enabled = false;
            paywithcoupon.Enabled = false;
        }

        private void Paywithcoupon_Click(object sender, EventArgs e)
        {
            Couponadmincheck c = new Couponadmincheck(idserialport.Text,admin.ToString());
            if(c.ShowDialog() == DialogResult.OK)
            {
                
                foreach (string n in pages)
                {
                    string pr = items[n]["price"].ToString();                  
                    GenerateMealTicket(items[n]["name"].ToString(), "\\" + pr, "金券支払い",false);
                    print_label();
                }            
                pages.Clear();
                count = 0;
                tokai_student = false;              
                cancelpay();
                button3.Text = "学生認証";
                button3.Enabled = true;
                paywithcoupon.Enabled = false;
                paywithmoney.Enabled = false;
            }
            
        }

        private void Bvcm_reset_Click(object sender, EventArgs e)
        {
            writeBvcm(BVCM_bytes.reset);
        }
    }
}
