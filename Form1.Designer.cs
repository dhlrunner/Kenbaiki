namespace kenbaiki
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader price;
            this.paywithcoupon = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.off = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menu_saltpepper = new System.Windows.Forms.Button();
            this.menu_plane = new System.Windows.Forms.Button();
            this.menu_caramel = new System.Windows.Forms.Button();
            this.menu_salt = new System.Windows.Forms.Button();
            this.menu_norisalt = new System.Windows.Forms.Button();
            this.menu_consomme = new System.Windows.Forms.Button();
            this.menu_curry = new System.Windows.Forms.Button();
            this.cancel_pay = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.comm_TX = new System.Windows.Forms.ToolStripStatusLabel();
            this.comm_RX = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.total_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.total_change = new System.Windows.Forms.Label();
            this.inserted_credit = new System.Windows.Forms.Label();
            this.paywithmoney = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.credit_clear = new System.Windows.Forms.Button();
            this.bvcm_log = new System.Windows.Forms.TextBox();
            this.bvcm_closeport = new System.Windows.Forms.Button();
            this.bvcm_openport = new System.Windows.Forms.Button();
            this.creditport = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sd = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.adminlist = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idteststop = new System.Windows.Forms.Button();
            this.idserialport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printersett = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.printerpaper = new System.Windows.Forms.ComboBox();
            this.play_music = new System.Windows.Forms.Button();
            this.IDreader = new System.IO.Ports.SerialPort(this.components);
            this.IDcardTest = new System.ComponentModel.BackgroundWorker();
            this.bvcm = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.indicator_tx_timer = new System.Windows.Forms.Timer(this.components);
            this.indicator_rx_timer = new System.Windows.Forms.Timer(this.components);
            this.vaild_timer = new System.Windows.Forms.Timer(this.components);
            this.bvcm_reset = new System.Windows.Forms.Button();
            price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.sd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.printersett.SuspendLayout();
            this.SuspendLayout();
            // 
            // price
            // 
            price.Text = "単価";
            // 
            // paywithcoupon
            // 
            this.paywithcoupon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paywithcoupon.BackColor = System.Drawing.Color.Transparent;
            this.paywithcoupon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paywithcoupon.Enabled = false;
            this.paywithcoupon.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paywithcoupon.Location = new System.Drawing.Point(1091, 454);
            this.paywithcoupon.Name = "paywithcoupon";
            this.paywithcoupon.Size = new System.Drawing.Size(245, 114);
            this.paywithcoupon.TabIndex = 1;
            this.paywithcoupon.Text = "確定/支払い\r\n(金券)";
            this.paywithcoupon.UseVisualStyleBackColor = false;
            this.paywithcoupon.Click += new System.EventHandler(this.Paywithcoupon_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.number,
            this.name,
            price,
            this.off});
            this.listView1.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(841, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(495, 263);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // number
            // 
            this.number.Text = "No.";
            this.number.Width = 40;
            // 
            // name
            // 
            this.name.Text = "商品名";
            this.name.Width = 300;
            // 
            // off
            // 
            this.off.Text = "割引";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.menu_saltpepper, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_plane, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_caramel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menu_salt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_norisalt, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu_consomme, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.menu_curry, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 384);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1001, 286);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // menu_saltpepper
            // 
            this.menu_saltpepper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_saltpepper.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menu_saltpepper.Location = new System.Drawing.Point(503, 3);
            this.menu_saltpepper.Name = "menu_saltpepper";
            this.menu_saltpepper.Size = new System.Drawing.Size(244, 137);
            this.menu_saltpepper.TabIndex = 1;
            this.menu_saltpepper.Text = "ポップコーン\r\nしおコショー味\r\n\\150";
            this.menu_saltpepper.UseVisualStyleBackColor = true;
            this.menu_saltpepper.Click += new System.EventHandler(this.Menu_saltpepper_Click);
            // 
            // menu_plane
            // 
            this.menu_plane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_plane.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menu_plane.Location = new System.Drawing.Point(3, 3);
            this.menu_plane.Name = "menu_plane";
            this.menu_plane.Size = new System.Drawing.Size(244, 137);
            this.menu_plane.TabIndex = 0;
            this.menu_plane.Text = "ポップコーン\r\nプレーン\r\n\\100";
            this.menu_plane.UseVisualStyleBackColor = true;
            this.menu_plane.Click += new System.EventHandler(this.Menu_plane_Click);
            // 
            // menu_caramel
            // 
            this.menu_caramel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_caramel.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menu_caramel.Location = new System.Drawing.Point(3, 146);
            this.menu_caramel.Name = "menu_caramel";
            this.menu_caramel.Size = new System.Drawing.Size(244, 137);
            this.menu_caramel.TabIndex = 1;
            this.menu_caramel.Text = "ポップコーン\r\nキャラメル味\r\n\\150";
            this.menu_caramel.UseVisualStyleBackColor = true;
            this.menu_caramel.Click += new System.EventHandler(this.Menu_caramel_Click);
            // 
            // menu_salt
            // 
            this.menu_salt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_salt.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menu_salt.Location = new System.Drawing.Point(253, 3);
            this.menu_salt.Name = "menu_salt";
            this.menu_salt.Size = new System.Drawing.Size(244, 137);
            this.menu_salt.TabIndex = 0;
            this.menu_salt.Text = "ポップコーン\r\nしお味\r\n\\150";
            this.menu_salt.UseVisualStyleBackColor = true;
            this.menu_salt.Click += new System.EventHandler(this.Menu_salt_Click);
            // 
            // menu_norisalt
            // 
            this.menu_norisalt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_norisalt.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menu_norisalt.Location = new System.Drawing.Point(753, 3);
            this.menu_norisalt.Name = "menu_norisalt";
            this.menu_norisalt.Size = new System.Drawing.Size(245, 137);
            this.menu_norisalt.TabIndex = 1;
            this.menu_norisalt.Text = "ポップコーン\r\nのりしお味\r\n\\150";
            this.menu_norisalt.UseVisualStyleBackColor = true;
            this.menu_norisalt.Click += new System.EventHandler(this.Menu_saltpepper_Click);
            // 
            // menu_consomme
            // 
            this.menu_consomme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_consomme.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menu_consomme.Location = new System.Drawing.Point(503, 146);
            this.menu_consomme.Name = "menu_consomme";
            this.menu_consomme.Size = new System.Drawing.Size(244, 137);
            this.menu_consomme.TabIndex = 1;
            this.menu_consomme.Text = "ポップコーン\r\nコンソメ味\r\n\\150";
            this.menu_consomme.UseVisualStyleBackColor = true;
            this.menu_consomme.Click += new System.EventHandler(this.Menu_saltpepper_Click);
            // 
            // menu_curry
            // 
            this.menu_curry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu_curry.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menu_curry.Location = new System.Drawing.Point(253, 146);
            this.menu_curry.Name = "menu_curry";
            this.menu_curry.Size = new System.Drawing.Size(244, 137);
            this.menu_curry.TabIndex = 1;
            this.menu_curry.Text = "ポップコーン\r\nカレー味\r\n\\150";
            this.menu_curry.UseVisualStyleBackColor = true;
            this.menu_curry.Click += new System.EventHandler(this.Menu_curry_Click);
            // 
            // cancel_pay
            // 
            this.cancel_pay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_pay.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cancel_pay.Location = new System.Drawing.Point(1091, 574);
            this.cancel_pay.Name = "cancel_pay";
            this.cancel_pay.Size = new System.Drawing.Size(243, 96);
            this.cancel_pay.TabIndex = 6;
            this.cancel_pay.Text = "取り消し";
            this.cancel_pay.UseVisualStyleBackColor = true;
            this.cancel_pay.Click += new System.EventHandler(this.Cancel_pay_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comm_TX,
            this.comm_RX});
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1350, 24);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // comm_TX
            // 
            this.comm_TX.BackColor = System.Drawing.Color.White;
            this.comm_TX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.comm_TX.Name = "comm_TX";
            this.comm_TX.Size = new System.Drawing.Size(24, 19);
            this.comm_TX.Text = "TX";
            // 
            // comm_RX
            // 
            this.comm_RX.BackColor = System.Drawing.Color.White;
            this.comm_RX.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.comm_RX.Name = "comm_RX";
            this.comm_RX.Size = new System.Drawing.Size(25, 19);
            this.comm_RX.Text = "RX";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1350, 729);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.total_price);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.total_change);
            this.tabPage1.Controls.Add(this.inserted_credit);
            this.tabPage1.Controls.Add(this.cancel_pay);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.paywithmoney);
            this.tabPage1.Controls.Add(this.paywithcoupon);
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1342, 702);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "券売画面";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(19, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(332, 82);
            this.button3.TabIndex = 11;
            this.button3.Text = "学生認証";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Font = new System.Drawing.Font("Digital-7", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_price.Location = new System.Drawing.Point(283, 14);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(59, 64);
            this.total_price.TabIndex = 10;
            this.total_price.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(15, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(640, 48);
            this.label2.TabIndex = 9;
            this.label2.Text = "東海大学の学生証をお持ちの方は、下のボタンを押してください。\r\n認証後、全商品が100円で買えます。";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(9, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 55);
            this.label7.TabIndex = 8;
            this.label7.Text = "合計金額: \\";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(457, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(240, 55);
            this.label8.TabIndex = 8;
            this.label8.Text = "お釣り: \\";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("UD Digi Kyokasho N-R", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(9, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 55);
            this.label1.TabIndex = 8;
            this.label1.Text = "投入金額: \\";
            // 
            // total_change
            // 
            this.total_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.total_change.AutoSize = true;
            this.total_change.Font = new System.Drawing.Font("Digital-7", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_change.Location = new System.Drawing.Point(683, 11);
            this.total_change.Name = "total_change";
            this.total_change.Size = new System.Drawing.Size(59, 64);
            this.total_change.TabIndex = 7;
            this.total_change.Text = "0";
            // 
            // inserted_credit
            // 
            this.inserted_credit.AutoSize = true;
            this.inserted_credit.Font = new System.Drawing.Font("Digital-7", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserted_credit.Location = new System.Drawing.Point(283, 104);
            this.inserted_credit.Name = "inserted_credit";
            this.inserted_credit.Size = new System.Drawing.Size(59, 64);
            this.inserted_credit.TabIndex = 7;
            this.inserted_credit.Text = "0";
            // 
            // paywithmoney
            // 
            this.paywithmoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paywithmoney.BackColor = System.Drawing.Color.Transparent;
            this.paywithmoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.paywithmoney.Enabled = false;
            this.paywithmoney.Font = new System.Drawing.Font("UD Digi Kyokasho NP-B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.paywithmoney.Location = new System.Drawing.Point(1091, 334);
            this.paywithmoney.Name = "paywithmoney";
            this.paywithmoney.Size = new System.Drawing.Size(245, 114);
            this.paywithmoney.TabIndex = 1;
            this.paywithmoney.Text = "確定/支払い\r\n(現金)";
            this.paywithmoney.UseVisualStyleBackColor = false;
            this.paywithmoney.Click += new System.EventHandler(this.Paywithmoney_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.sd);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.printersett);
            this.tabPage2.Controls.Add(this.play_music);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1342, 702);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "システム設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bvcm_reset);
            this.groupBox2.Controls.Add(this.credit_clear);
            this.groupBox2.Controls.Add(this.bvcm_log);
            this.groupBox2.Controls.Add(this.bvcm_closeport);
            this.groupBox2.Controls.Add(this.bvcm_openport);
            this.groupBox2.Controls.Add(this.creditport);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(492, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 404);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "金銭設定";
            // 
            // credit_clear
            // 
            this.credit_clear.Enabled = false;
            this.credit_clear.Location = new System.Drawing.Point(18, 63);
            this.credit_clear.Name = "credit_clear";
            this.credit_clear.Size = new System.Drawing.Size(109, 32);
            this.credit_clear.TabIndex = 8;
            this.credit_clear.Text = "投入金クリア";
            this.credit_clear.UseVisualStyleBackColor = true;
            this.credit_clear.Click += new System.EventHandler(this.Credit_clear_Click);
            // 
            // bvcm_log
            // 
            this.bvcm_log.Location = new System.Drawing.Point(6, 219);
            this.bvcm_log.Multiline = true;
            this.bvcm_log.Name = "bvcm_log";
            this.bvcm_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bvcm_log.Size = new System.Drawing.Size(631, 179);
            this.bvcm_log.TabIndex = 7;
            // 
            // bvcm_closeport
            // 
            this.bvcm_closeport.Enabled = false;
            this.bvcm_closeport.Location = new System.Drawing.Point(260, 22);
            this.bvcm_closeport.Name = "bvcm_closeport";
            this.bvcm_closeport.Size = new System.Drawing.Size(75, 23);
            this.bvcm_closeport.TabIndex = 6;
            this.bvcm_closeport.Text = "close";
            this.bvcm_closeport.UseVisualStyleBackColor = true;
            this.bvcm_closeport.Click += new System.EventHandler(this.Bvcm_closeport_Click);
            // 
            // bvcm_openport
            // 
            this.bvcm_openport.Location = new System.Drawing.Point(179, 22);
            this.bvcm_openport.Name = "bvcm_openport";
            this.bvcm_openport.Size = new System.Drawing.Size(75, 23);
            this.bvcm_openport.TabIndex = 5;
            this.bvcm_openport.Text = "open";
            this.bvcm_openport.UseVisualStyleBackColor = true;
            this.bvcm_openport.Click += new System.EventHandler(this.Bvcm_openport_Click);
            // 
            // creditport
            // 
            this.creditport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.creditport.FormattingEnabled = true;
            this.creditport.Location = new System.Drawing.Point(53, 23);
            this.creditport.Name = "creditport";
            this.creditport.Size = new System.Drawing.Size(108, 22);
            this.creditport.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Port";
            // 
            // sd
            // 
            this.sd.Controls.Add(this.button2);
            this.sd.Controls.Add(this.label5);
            this.sd.Controls.Add(this.adminlist);
            this.sd.Location = new System.Drawing.Point(8, 214);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(478, 196);
            this.sd.TabIndex = 4;
            this.sd.TabStop = false;
            this.sd.Text = "管理者登録";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "新規登録";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "登録済みの管理者";
            // 
            // adminlist
            // 
            this.adminlist.FormattingEnabled = true;
            this.adminlist.ItemHeight = 14;
            this.adminlist.Location = new System.Drawing.Point(352, 34);
            this.adminlist.Name = "adminlist";
            this.adminlist.Size = new System.Drawing.Size(120, 144);
            this.adminlist.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idteststop);
            this.groupBox1.Controls.Add(this.idserialport);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(8, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(478, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "カードリーダー設定";
            // 
            // idteststop
            // 
            this.idteststop.Enabled = false;
            this.idteststop.Location = new System.Drawing.Point(417, 16);
            this.idteststop.Name = "idteststop";
            this.idteststop.Size = new System.Drawing.Size(55, 74);
            this.idteststop.TabIndex = 5;
            this.idteststop.Text = "中止";
            this.idteststop.UseVisualStyleBackColor = true;
            this.idteststop.Click += new System.EventHandler(this.Idteststop_Click);
            // 
            // idserialport
            // 
            this.idserialport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idserialport.FormattingEnabled = true;
            this.idserialport.Location = new System.Drawing.Point(53, 24);
            this.idserialport.Name = "idserialport";
            this.idserialport.Size = new System.Drawing.Size(108, 22);
            this.idserialport.TabIndex = 4;
            this.idserialport.SelectedIndexChanged += new System.EventHandler(this.Idserialport_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 74);
            this.button1.TabIndex = 2;
            this.button1.Text = "テスト";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // printersett
            // 
            this.printersett.Controls.Add(this.label3);
            this.printersett.Controls.Add(this.printerpaper);
            this.printersett.Location = new System.Drawing.Point(8, 6);
            this.printersett.Name = "printersett";
            this.printersett.Size = new System.Drawing.Size(478, 95);
            this.printersett.TabIndex = 1;
            this.printersett.TabStop = false;
            this.printersett.Text = "プリンター設定";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "用紙設定";
            // 
            // printerpaper
            // 
            this.printerpaper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerpaper.FormattingEnabled = true;
            this.printerpaper.Location = new System.Drawing.Point(76, 20);
            this.printerpaper.Name = "printerpaper";
            this.printerpaper.Size = new System.Drawing.Size(377, 22);
            this.printerpaper.TabIndex = 0;
            this.printerpaper.SelectedIndexChanged += new System.EventHandler(this.Printerpaper_SelectedIndexChanged);
            // 
            // play_music
            // 
            this.play_music.Location = new System.Drawing.Point(1141, 6);
            this.play_music.Name = "play_music";
            this.play_music.Size = new System.Drawing.Size(166, 37);
            this.play_music.TabIndex = 0;
            this.play_music.Text = "呼び込み君 再生";
            this.play_music.UseVisualStyleBackColor = true;
            this.play_music.Click += new System.EventHandler(this.Play_music_Click);
            // 
            // IDreader
            // 
            this.IDreader.BaudRate = 115200;
            this.IDreader.PortName = "0";
            // 
            // IDcardTest
            // 
            this.IDcardTest.WorkerSupportsCancellation = true;
            this.IDcardTest.DoWork += new System.ComponentModel.DoWorkEventHandler(this.IDcardTest_DoWork);
            // 
            // bvcm
            // 
            this.bvcm.BaudRate = 38400;
            this.bvcm.PortName = "0";
            this.bvcm.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Bvcm_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // indicator_tx_timer
            // 
            this.indicator_tx_timer.Interval = 50;
            this.indicator_tx_timer.Tick += new System.EventHandler(this.Indicator_tx_timer_Tick);
            // 
            // indicator_rx_timer
            // 
            this.indicator_rx_timer.Interval = 50;
            this.indicator_rx_timer.Tick += new System.EventHandler(this.Indicator_rx_timer_Tick);
            // 
            // vaild_timer
            // 
            this.vaild_timer.Interval = 60000;
            this.vaild_timer.Tick += new System.EventHandler(this.Vaild_timer_Tick);
            // 
            // bvcm_reset
            // 
            this.bvcm_reset.Location = new System.Drawing.Point(18, 101);
            this.bvcm_reset.Name = "bvcm_reset";
            this.bvcm_reset.Size = new System.Drawing.Size(109, 32);
            this.bvcm_reset.TabIndex = 9;
            this.bvcm_reset.Text = "Reset";
            this.bvcm_reset.UseVisualStyleBackColor = true;
            this.bvcm_reset.Click += new System.EventHandler(this.Bvcm_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("UD Digi Kyokasho NP-R", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Name = "Form1";
            this.Text = "ハイテク_券売機 Ver 1.0 by Dohyung Lee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sd.ResumeLayout(false);
            this.sd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.printersett.ResumeLayout(false);
            this.printersett.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button paywithcoupon;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button menu_salt;
        private System.Windows.Forms.Button menu_caramel;
        private System.Windows.Forms.Button cancel_pay;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel comm_TX;
        private System.Windows.Forms.ToolStripStatusLabel comm_RX;
        private System.Windows.Forms.Button menu_saltpepper;
        private System.Windows.Forms.Button menu_plane;
        private System.Windows.Forms.Button menu_curry;
        private System.Windows.Forms.Button menu_norisalt;
        private System.Windows.Forms.Button menu_consomme;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button play_music;
        private System.Windows.Forms.Button paywithmoney;
        private System.Windows.Forms.Label inserted_credit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader off;
        private System.Windows.Forms.GroupBox printersett;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox printerpaper;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort IDreader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker IDcardTest;
        private System.Windows.Forms.Button idteststop;
        private System.Windows.Forms.GroupBox sd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox adminlist;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox idserialport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox creditport;
        private System.Windows.Forms.Label label6;
        private System.IO.Ports.SerialPort bvcm;
        private System.Windows.Forms.Button bvcm_closeport;
        private System.Windows.Forms.Button bvcm_openport;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox bvcm_log;
        private System.Windows.Forms.Timer indicator_tx_timer;
        private System.Windows.Forms.Timer indicator_rx_timer;
        private System.Windows.Forms.Button credit_clear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label total_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer vaild_timer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label total_change;
        private System.Windows.Forms.Button bvcm_reset;
    }
}

