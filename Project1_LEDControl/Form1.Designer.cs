namespace Project1_LEDControl
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxStopBits = new System.Windows.Forms.ComboBox();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.cBoxDataSize = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tBoxLed5 = new System.Windows.Forms.TextBox();
            this.tBoxLed6 = new System.Windows.Forms.TextBox();
            this.tBoxLed7 = new System.Windows.Forms.TextBox();
            this.tBoxLed8 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnLed8 = new System.Windows.Forms.Button();
            this.btnLed7 = new System.Windows.Forms.Button();
            this.btnLed6 = new System.Windows.Forms.Button();
            this.btnLed5 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnLed4 = new System.Windows.Forms.Button();
            this.tBoxLed4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnLed3 = new System.Windows.Forms.Button();
            this.tBoxLed3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnLed2 = new System.Windows.Forms.Button();
            this.tBoxLed2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnLed1 = new System.Windows.Forms.Button();
            this.tBoxLed1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tBoxDataReceive = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.tBoxDataSend = new System.Windows.Forms.TextBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxStopBits);
            this.groupBox1.Controls.Add(this.cBoxParity);
            this.groupBox1.Controls.Add(this.cBoxDataSize);
            this.groupBox1.Controls.Add(this.cBoxBaudRate);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 154);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup COM PORT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "STOP BITS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "PARITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "DATA SIZE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COMPORT";
            // 
            // cBoxStopBits
            // 
            this.cBoxStopBits.FormattingEnabled = true;
            this.cBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBits.Location = new System.Drawing.Point(95, 127);
            this.cBoxStopBits.Name = "cBoxStopBits";
            this.cBoxStopBits.Size = new System.Drawing.Size(100, 21);
            this.cBoxStopBits.TabIndex = 4;
            this.cBoxStopBits.Text = "One";
            // 
            // cBoxParity
            // 
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.cBoxParity.Location = new System.Drawing.Point(95, 100);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(100, 21);
            this.cBoxParity.TabIndex = 3;
            this.cBoxParity.Text = "None";
            // 
            // cBoxDataSize
            // 
            this.cBoxDataSize.FormattingEnabled = true;
            this.cBoxDataSize.Items.AddRange(new object[] {
            "7",
            "8"});
            this.cBoxDataSize.Location = new System.Drawing.Point(95, 73);
            this.cBoxDataSize.Name = "cBoxDataSize";
            this.cBoxDataSize.Size = new System.Drawing.Size(100, 21);
            this.cBoxDataSize.TabIndex = 2;
            this.cBoxDataSize.Text = "8";
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.cBoxBaudRate.Location = new System.Drawing.Point(95, 46);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(100, 21);
            this.cBoxBaudRate.TabIndex = 1;
            this.cBoxBaudRate.Text = "9600";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(95, 19);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(100, 21);
            this.cBoxCOMPORT.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDisConnect);
            this.groupBox2.Controls.Add(this.btnConnect);
            this.groupBox2.Location = new System.Drawing.Point(6, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 119);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisConnect.Location = new System.Drawing.Point(6, 64);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(186, 36);
            this.btnDisConnect.TabIndex = 0;
            this.btnDisConnect.Text = "DISCONNECT";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(6, 13);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(186, 36);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "LED5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "LED6";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "LED7";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(47, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "LED8";
            // 
            // tBoxLed5
            // 
            this.tBoxLed5.BackColor = System.Drawing.Color.Gray;
            this.tBoxLed5.Enabled = false;
            this.tBoxLed5.Location = new System.Drawing.Point(38, 14);
            this.tBoxLed5.Multiline = true;
            this.tBoxLed5.Name = "tBoxLed5";
            this.tBoxLed5.Size = new System.Drawing.Size(44, 35);
            this.tBoxLed5.TabIndex = 23;
            // 
            // tBoxLed6
            // 
            this.tBoxLed6.BackColor = System.Drawing.Color.Gray;
            this.tBoxLed6.Enabled = false;
            this.tBoxLed6.Location = new System.Drawing.Point(36, 14);
            this.tBoxLed6.Multiline = true;
            this.tBoxLed6.Name = "tBoxLed6";
            this.tBoxLed6.Size = new System.Drawing.Size(44, 35);
            this.tBoxLed6.TabIndex = 24;
            // 
            // tBoxLed7
            // 
            this.tBoxLed7.BackColor = System.Drawing.Color.Gray;
            this.tBoxLed7.Enabled = false;
            this.tBoxLed7.Location = new System.Drawing.Point(41, 14);
            this.tBoxLed7.Multiline = true;
            this.tBoxLed7.Name = "tBoxLed7";
            this.tBoxLed7.Size = new System.Drawing.Size(44, 35);
            this.tBoxLed7.TabIndex = 25;
            // 
            // tBoxLed8
            // 
            this.tBoxLed8.BackColor = System.Drawing.Color.Gray;
            this.tBoxLed8.Enabled = false;
            this.tBoxLed8.Location = new System.Drawing.Point(42, 13);
            this.tBoxLed8.Multiline = true;
            this.tBoxLed8.Name = "tBoxLed8";
            this.tBoxLed8.Size = new System.Drawing.Size(44, 35);
            this.tBoxLed8.TabIndex = 26;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btnLed8
            // 
            this.btnLed8.Location = new System.Drawing.Point(26, 73);
            this.btnLed8.Name = "btnLed8";
            this.btnLed8.Size = new System.Drawing.Size(76, 27);
            this.btnLed8.TabIndex = 30;
            this.btnLed8.Text = "ON";
            this.btnLed8.UseVisualStyleBackColor = true;
            this.btnLed8.Click += new System.EventHandler(this.btnLed8_Click);
            // 
            // btnLed7
            // 
            this.btnLed7.Location = new System.Drawing.Point(22, 73);
            this.btnLed7.Name = "btnLed7";
            this.btnLed7.Size = new System.Drawing.Size(76, 27);
            this.btnLed7.TabIndex = 29;
            this.btnLed7.Text = "ON";
            this.btnLed7.UseVisualStyleBackColor = true;
            this.btnLed7.Click += new System.EventHandler(this.btnLed7_Click);
            // 
            // btnLed6
            // 
            this.btnLed6.Location = new System.Drawing.Point(20, 73);
            this.btnLed6.Name = "btnLed6";
            this.btnLed6.Size = new System.Drawing.Size(76, 27);
            this.btnLed6.TabIndex = 28;
            this.btnLed6.Text = "ON";
            this.btnLed6.UseVisualStyleBackColor = true;
            this.btnLed6.Click += new System.EventHandler(this.btnLed6_Click);
            // 
            // btnLed5
            // 
            this.btnLed5.Location = new System.Drawing.Point(21, 73);
            this.btnLed5.Name = "btnLed5";
            this.btnLed5.Size = new System.Drawing.Size(76, 27);
            this.btnLed5.TabIndex = 27;
            this.btnLed5.Text = "ON";
            this.btnLed5.UseVisualStyleBackColor = true;
            this.btnLed5.Click += new System.EventHandler(this.btnLed5_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnLed5);
            this.groupBox4.Controls.Add(this.tBoxLed5);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(16, 144);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(116, 119);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnLed6);
            this.groupBox5.Controls.Add(this.tBoxLed6);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Location = new System.Drawing.Point(138, 144);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(116, 118);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLed7);
            this.groupBox6.Controls.Add(this.tBoxLed7);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Location = new System.Drawing.Point(260, 144);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(123, 118);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnLed8);
            this.groupBox7.Controls.Add(this.tBoxLed8);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Location = new System.Drawing.Point(389, 144);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(123, 118);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnLed4);
            this.groupBox8.Controls.Add(this.tBoxLed4);
            this.groupBox8.Controls.Add(this.label6);
            this.groupBox8.Location = new System.Drawing.Point(389, 29);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(123, 118);
            this.groupBox8.TabIndex = 38;
            this.groupBox8.TabStop = false;
            // 
            // btnLed4
            // 
            this.btnLed4.Location = new System.Drawing.Point(26, 73);
            this.btnLed4.Name = "btnLed4";
            this.btnLed4.Size = new System.Drawing.Size(76, 27);
            this.btnLed4.TabIndex = 30;
            this.btnLed4.Text = "ON";
            this.btnLed4.UseVisualStyleBackColor = true;
            this.btnLed4.Click += new System.EventHandler(this.btnLed4_Click);
            // 
            // tBoxLed4
            // 
            this.tBoxLed4.BackColor = System.Drawing.Color.Gray;
            this.tBoxLed4.Enabled = false;
            this.tBoxLed4.Location = new System.Drawing.Point(42, 13);
            this.tBoxLed4.Multiline = true;
            this.tBoxLed4.Name = "tBoxLed4";
            this.tBoxLed4.Size = new System.Drawing.Size(44, 35);
            this.tBoxLed4.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "LED4";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnLed3);
            this.groupBox9.Controls.Add(this.tBoxLed3);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Location = new System.Drawing.Point(260, 29);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(123, 118);
            this.groupBox9.TabIndex = 37;
            this.groupBox9.TabStop = false;
            // 
            // btnLed3
            // 
            this.btnLed3.Location = new System.Drawing.Point(22, 73);
            this.btnLed3.Name = "btnLed3";
            this.btnLed3.Size = new System.Drawing.Size(76, 27);
            this.btnLed3.TabIndex = 29;
            this.btnLed3.Text = "ON";
            this.btnLed3.UseVisualStyleBackColor = true;
            this.btnLed3.Click += new System.EventHandler(this.btnLed3_Click);
            // 
            // tBoxLed3
            // 
            this.tBoxLed3.BackColor = System.Drawing.Color.Gray;
            this.tBoxLed3.Enabled = false;
            this.tBoxLed3.Location = new System.Drawing.Point(41, 14);
            this.tBoxLed3.Multiline = true;
            this.tBoxLed3.Name = "tBoxLed3";
            this.tBoxLed3.Size = new System.Drawing.Size(44, 35);
            this.tBoxLed3.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "LED3";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnLed2);
            this.groupBox10.Controls.Add(this.tBoxLed2);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Location = new System.Drawing.Point(138, 29);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(116, 118);
            this.groupBox10.TabIndex = 36;
            this.groupBox10.TabStop = false;
            // 
            // btnLed2
            // 
            this.btnLed2.Location = new System.Drawing.Point(20, 73);
            this.btnLed2.Name = "btnLed2";
            this.btnLed2.Size = new System.Drawing.Size(76, 27);
            this.btnLed2.TabIndex = 28;
            this.btnLed2.Text = "ON";
            this.btnLed2.UseVisualStyleBackColor = true;
            this.btnLed2.Click += new System.EventHandler(this.btnLed2_Click);
            // 
            // tBoxLed2
            // 
            this.tBoxLed2.BackColor = System.Drawing.Color.Gray;
            this.tBoxLed2.Enabled = false;
            this.tBoxLed2.Location = new System.Drawing.Point(36, 14);
            this.tBoxLed2.Multiline = true;
            this.tBoxLed2.Name = "tBoxLed2";
            this.tBoxLed2.Size = new System.Drawing.Size(44, 35);
            this.tBoxLed2.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "LED2";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnLed1);
            this.groupBox11.Controls.Add(this.tBoxLed1);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Location = new System.Drawing.Point(16, 29);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(116, 119);
            this.groupBox11.TabIndex = 35;
            this.groupBox11.TabStop = false;
            // 
            // btnLed1
            // 
            this.btnLed1.Location = new System.Drawing.Point(21, 73);
            this.btnLed1.Name = "btnLed1";
            this.btnLed1.Size = new System.Drawing.Size(76, 27);
            this.btnLed1.TabIndex = 27;
            this.btnLed1.Text = "ON";
            this.btnLed1.UseVisualStyleBackColor = true;
            this.btnLed1.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // tBoxLed1
            // 
            this.tBoxLed1.BackColor = System.Drawing.Color.Gray;
            this.tBoxLed1.Enabled = false;
            this.tBoxLed1.Location = new System.Drawing.Point(38, 14);
            this.tBoxLed1.Multiline = true;
            this.tBoxLed1.Name = "tBoxLed1";
            this.tBoxLed1.Size = new System.Drawing.Size(44, 35);
            this.tBoxLed1.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "LED1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(217, 14);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(529, 25);
            this.progressBar1.TabIndex = 39;
            // 
            // tBoxDataReceive
            // 
            this.tBoxDataReceive.Enabled = false;
            this.tBoxDataReceive.Location = new System.Drawing.Point(7, 19);
            this.tBoxDataReceive.Name = "tBoxDataReceive";
            this.tBoxDataReceive.Size = new System.Drawing.Size(186, 20);
            this.tBoxDataReceive.TabIndex = 40;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBoxDataReceive);
            this.groupBox3.Location = new System.Drawing.Point(6, 289);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 45);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Receive";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.tBoxDataSend);
            this.groupBox12.Location = new System.Drawing.Point(6, 340);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(201, 45);
            this.groupBox12.TabIndex = 42;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Data Send";
            // 
            // tBoxDataSend
            // 
            this.tBoxDataSend.Enabled = false;
            this.tBoxDataSend.Location = new System.Drawing.Point(7, 19);
            this.tBoxDataSend.Name = "tBoxDataSend";
            this.tBoxDataSend.Size = new System.Drawing.Size(186, 20);
            this.tBoxDataSend.TabIndex = 40;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.groupBox8);
            this.groupBox13.Controls.Add(this.groupBox9);
            this.groupBox13.Controls.Add(this.groupBox10);
            this.groupBox13.Controls.Add(this.groupBox11);
            this.groupBox13.Controls.Add(this.groupBox7);
            this.groupBox13.Controls.Add(this.groupBox6);
            this.groupBox13.Controls.Add(this.groupBox5);
            this.groupBox13.Controls.Add(this.groupBox4);
            this.groupBox13.Location = new System.Drawing.Point(217, 55);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(529, 279);
            this.groupBox13.TabIndex = 43;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "LED Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(758, 395);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "LED Control Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBoxStopBits;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.ComboBox cBoxDataSize;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBoxLed5;
        private System.Windows.Forms.TextBox tBoxLed6;
        private System.Windows.Forms.TextBox tBoxLed7;
        private System.Windows.Forms.TextBox tBoxLed8;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnLed8;
        private System.Windows.Forms.Button btnLed7;
        private System.Windows.Forms.Button btnLed6;
        private System.Windows.Forms.Button btnLed5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btnLed4;
        private System.Windows.Forms.TextBox tBoxLed4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btnLed3;
        private System.Windows.Forms.TextBox tBoxLed3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnLed2;
        private System.Windows.Forms.TextBox tBoxLed2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnLed1;
        private System.Windows.Forms.TextBox tBoxLed1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox tBoxDataReceive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox tBoxDataSend;
        private System.Windows.Forms.GroupBox groupBox13;
    }
}

