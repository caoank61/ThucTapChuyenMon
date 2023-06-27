namespace TTCM
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupdulieu = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtdulieu = new System.Windows.Forms.TextBox();
            this.caidat1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupcaidat = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.s3cb3 = new System.Windows.Forms.TextBox();
            this.s3cb2 = new System.Windows.Forms.TextBox();
            this.s3cb1 = new System.Windows.Forms.TextBox();
            this.groupchedo = new System.Windows.Forms.GroupBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cb_cheDo = new System.Windows.Forms.ComboBox();
            this.groupketnoi = new System.Windows.Forms.GroupBox();
            this.button_ngat = new System.Windows.Forms.Button();
            this.button_ketnoi = new System.Windows.Forms.Button();
            this.comboBox_Baudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.groupthietbi = new System.Windows.Forms.GroupBox();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupdulieu.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupcaidat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupchedo.SuspendLayout();
            this.groupketnoi.SuspendLayout();
            this.groupthietbi.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupdulieu
            // 
            this.groupdulieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupdulieu.Controls.Add(this.button2);
            this.groupdulieu.Controls.Add(this.button1);
            this.groupdulieu.Controls.Add(this.groupBox7);
            this.groupdulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupdulieu.Location = new System.Drawing.Point(377, 94);
            this.groupdulieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupdulieu.Name = "groupdulieu";
            this.groupdulieu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupdulieu.Size = new System.Drawing.Size(335, 171);
            this.groupdulieu.TabIndex = 18;
            this.groupdulieu.TabStop = false;
            this.groupdulieu.Text = "Nhiệt Độ";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(21, 683);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(169, 686);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.txtdulieu);
            this.groupBox7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(20, 49);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox7.Size = new System.Drawing.Size(269, 91);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Slave 1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(21, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Cảm biến ";
            // 
            // txtdulieu
            // 
            this.txtdulieu.Location = new System.Drawing.Point(109, 39);
            this.txtdulieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdulieu.Name = "txtdulieu";
            this.txtdulieu.Size = new System.Drawing.Size(100, 30);
            this.txtdulieu.TabIndex = 6;
            // 
            // caidat1
            // 
            this.caidat1.Location = new System.Drawing.Point(116, 46);
            this.caidat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.caidat1.Name = "caidat1";
            this.caidat1.Size = new System.Drawing.Size(100, 30);
            this.caidat1.TabIndex = 0;
            this.caidat1.Text = "28.00";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(959, 497);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 41);
            this.button3.TabIndex = 15;
            this.button3.Text = "Thoát";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TTCM.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // groupcaidat
            // 
            this.groupcaidat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupcaidat.Controls.Add(this.btn_Save);
            this.groupcaidat.Controls.Add(this.groupBox2);
            this.groupcaidat.Controls.Add(this.groupBox4);
            this.groupcaidat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupcaidat.Location = new System.Drawing.Point(729, 94);
            this.groupcaidat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupcaidat.Name = "groupcaidat";
            this.groupcaidat.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupcaidat.Size = new System.Drawing.Size(335, 222);
            this.groupcaidat.TabIndex = 19;
            this.groupcaidat.TabStop = false;
            this.groupcaidat.Text = "Tuỳ Chỉnh Nhiệt Độ";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_Save.Location = new System.Drawing.Point(111, 164);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(127, 41);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.caidat1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(269, 105);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Slave 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cảm biến 1";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.s3cb3);
            this.groupBox4.Controls.Add(this.s3cb2);
            this.groupBox4.Controls.Add(this.s3cb1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 492);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(269, 199);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Slave 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cảm biến 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cảm biến 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Cảm biến 1";
            // 
            // s3cb3
            // 
            this.s3cb3.Location = new System.Drawing.Point(149, 160);
            this.s3cb3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s3cb3.Name = "s3cb3";
            this.s3cb3.Size = new System.Drawing.Size(100, 30);
            this.s3cb3.TabIndex = 2;
            // 
            // s3cb2
            // 
            this.s3cb2.Location = new System.Drawing.Point(149, 100);
            this.s3cb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s3cb2.Name = "s3cb2";
            this.s3cb2.Size = new System.Drawing.Size(100, 30);
            this.s3cb2.TabIndex = 1;
            // 
            // s3cb1
            // 
            this.s3cb1.Location = new System.Drawing.Point(149, 38);
            this.s3cb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.s3cb1.Name = "s3cb1";
            this.s3cb1.Size = new System.Drawing.Size(100, 30);
            this.s3cb1.TabIndex = 0;
            // 
            // groupchedo
            // 
            this.groupchedo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupchedo.Controls.Add(this.btn_ok);
            this.groupchedo.Controls.Add(this.cb_cheDo);
            this.groupchedo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupchedo.Location = new System.Drawing.Point(4, 340);
            this.groupchedo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupchedo.Name = "groupchedo";
            this.groupchedo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupchedo.Size = new System.Drawing.Size(335, 151);
            this.groupchedo.TabIndex = 17;
            this.groupchedo.TabStop = false;
            this.groupchedo.Text = "Chế Độ";
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ok.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold);
            this.btn_ok.Location = new System.Drawing.Point(105, 101);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(127, 41);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // cb_cheDo
            // 
            this.cb_cheDo.FormattingEnabled = true;
            this.cb_cheDo.Items.AddRange(new object[] {
            "Auto",
            "Manual"});
            this.cb_cheDo.Location = new System.Drawing.Point(29, 38);
            this.cb_cheDo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_cheDo.Name = "cb_cheDo";
            this.cb_cheDo.Size = new System.Drawing.Size(289, 39);
            this.cb_cheDo.TabIndex = 0;
            // 
            // groupketnoi
            // 
            this.groupketnoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupketnoi.Controls.Add(this.button_ngat);
            this.groupketnoi.Controls.Add(this.button_ketnoi);
            this.groupketnoi.Controls.Add(this.comboBox_Baudrate);
            this.groupketnoi.Controls.Add(this.label2);
            this.groupketnoi.Controls.Add(this.label1);
            this.groupketnoi.Controls.Add(this.comboBox_COM);
            this.groupketnoi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupketnoi.Location = new System.Drawing.Point(4, 85);
            this.groupketnoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupketnoi.Name = "groupketnoi";
            this.groupketnoi.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupketnoi.Size = new System.Drawing.Size(335, 230);
            this.groupketnoi.TabIndex = 16;
            this.groupketnoi.TabStop = false;
            this.groupketnoi.Text = "COM Setting";
            // 
            // button_ngat
            // 
            this.button_ngat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_ngat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ngat.Location = new System.Drawing.Point(187, 172);
            this.button_ngat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ngat.Name = "button_ngat";
            this.button_ngat.Size = new System.Drawing.Size(133, 41);
            this.button_ngat.TabIndex = 4;
            this.button_ngat.Text = "Ngắt kết Nối";
            this.button_ngat.UseVisualStyleBackColor = false;
            this.button_ngat.Click += new System.EventHandler(this.button_ngat_Click);
            // 
            // button_ketnoi
            // 
            this.button_ketnoi.BackColor = System.Drawing.Color.Aquamarine;
            this.button_ketnoi.Location = new System.Drawing.Point(23, 172);
            this.button_ketnoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ketnoi.Name = "button_ketnoi";
            this.button_ketnoi.Size = new System.Drawing.Size(127, 41);
            this.button_ketnoi.TabIndex = 1;
            this.button_ketnoi.Text = "Kết Nối";
            this.button_ketnoi.UseVisualStyleBackColor = false;
            this.button_ketnoi.Click += new System.EventHandler(this.button_ketnoi_Click);
            // 
            // comboBox_Baudrate
            // 
            this.comboBox_Baudrate.FormattingEnabled = true;
            this.comboBox_Baudrate.Location = new System.Drawing.Point(133, 112);
            this.comboBox_Baudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_Baudrate.Name = "comboBox_Baudrate";
            this.comboBox_Baudrate.Size = new System.Drawing.Size(116, 28);
            this.comboBox_Baudrate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "BaudRate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cổng COM";
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(133, 49);
            this.comboBox_COM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(116, 28);
            this.comboBox_COM.TabIndex = 1;
            // 
            // groupthietbi
            // 
            this.groupthietbi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupthietbi.Controls.Add(this.txttrangthai);
            this.groupthietbi.Controls.Add(this.label4);
            this.groupthietbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupthietbi.Location = new System.Drawing.Point(729, 340);
            this.groupthietbi.Margin = new System.Windows.Forms.Padding(4);
            this.groupthietbi.Name = "groupthietbi";
            this.groupthietbi.Padding = new System.Windows.Forms.Padding(4);
            this.groupthietbi.Size = new System.Drawing.Size(335, 94);
            this.groupthietbi.TabIndex = 21;
            this.groupthietbi.TabStop = false;
            this.groupthietbi.Text = "Thiết bị";
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(136, 39);
            this.txttrangthai.Margin = new System.Windows.Forms.Padding(4);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(39, 38);
            this.txttrangthai.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.label4.Location = new System.Drawing.Point(39, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Trạng thái";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(208)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1068, 537);
            this.Controls.Add(this.groupthietbi);
            this.Controls.Add(this.groupdulieu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupcaidat);
            this.Controls.Add(this.groupchedo);
            this.Controls.Add(this.groupketnoi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupdulieu.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupcaidat.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupchedo.ResumeLayout(false);
            this.groupketnoi.ResumeLayout(false);
            this.groupketnoi.PerformLayout();
            this.groupthietbi.ResumeLayout(false);
            this.groupthietbi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupdulieu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox caidat1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupcaidat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox s3cb3;
        private System.Windows.Forms.TextBox s3cb2;
        private System.Windows.Forms.TextBox s3cb1;
        private System.Windows.Forms.GroupBox groupchedo;
        private System.Windows.Forms.TextBox txtdulieu;
        private System.Windows.Forms.GroupBox groupketnoi;
        private System.Windows.Forms.Button button_ngat;
        private System.Windows.Forms.Button button_ketnoi;
        private System.Windows.Forms.ComboBox comboBox_Baudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.ComboBox cb_cheDo;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupthietbi;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.Label label4;
    }
}