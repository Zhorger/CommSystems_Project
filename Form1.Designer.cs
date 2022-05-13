namespace ComPort
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnSendData = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tBoxDataIn = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA4 = new System.Windows.Forms.Button();
            this.btnA5 = new System.Windows.Forms.Button();
            this.btnA6 = new System.Windows.Forms.Button();
            this.btnA7 = new System.Windows.Forms.Button();
            this.btnA8 = new System.Windows.Forms.Button();
            this.btnA9 = new System.Windows.Forms.Button();
            this.btnA10 = new System.Windows.Forms.Button();
            this.btnA11 = new System.Windows.Forms.Button();
            this.btnA12 = new System.Windows.Forms.Button();
            this.btnB1 = new System.Windows.Forms.Button();
            this.btnB2 = new System.Windows.Forms.Button();
            this.btnB3 = new System.Windows.Forms.Button();
            this.btnB4 = new System.Windows.Forms.Button();
            this.btnB5 = new System.Windows.Forms.Button();
            this.btnB6 = new System.Windows.Forms.Button();
            this.btnB7 = new System.Windows.Forms.Button();
            this.btnB8 = new System.Windows.Forms.Button();
            this.btnB9 = new System.Windows.Forms.Button();
            this.btnB10 = new System.Windows.Forms.Button();
            this.btnB11 = new System.Windows.Forms.Button();
            this.btnB12 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.listPad = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUploadSequence = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSequenceAmt = new System.Windows.Forms.TextBox();
            this.btnSendSeq = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listCurrentSeq = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSleepTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearSample = new System.Windows.Forms.Button();
            this.listSample = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTransmitted = new System.Windows.Forms.TextBox();
            this.btnClearRecieved = new System.Windows.Forms.Button();
            this.btnClearTransmittion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.btnUploadSequence.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBoxCOMPORT);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(69, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM PORT";
            // 
            // cBoxCOMPORT
            // 
            this.cBoxCOMPORT.FormattingEnabled = true;
            this.cBoxCOMPORT.Location = new System.Drawing.Point(104, 30);
            this.cBoxCOMPORT.Name = "cBoxCOMPORT";
            this.cBoxCOMPORT.Size = new System.Drawing.Size(121, 24);
            this.cBoxCOMPORT.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnOpen);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(48, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(129, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(101, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(16, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(101, 32);
            this.btnOpen.TabIndex = 6;
            this.btnOpen.Text = "OPEN";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 57);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(214, 23);
            this.progressBar1.TabIndex = 5;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(300, 162);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(88, 61);
            this.btnSendData.TabIndex = 4;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // tBoxDataIn
            // 
            this.tBoxDataIn.Location = new System.Drawing.Point(11, 22);
            this.tBoxDataIn.Multiline = true;
            this.tBoxDataIn.Name = "tBoxDataIn";
            this.tBoxDataIn.Size = new System.Drawing.Size(460, 258);
            this.tBoxDataIn.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tBoxDataIn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 539);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(483, 286);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recieved";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTransmitted);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(22, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(483, 284);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transmitted";
            // 
            // btnA1
            // 
            this.btnA1.Enabled = false;
            this.btnA1.Location = new System.Drawing.Point(21, 33);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(47, 46);
            this.btnA1.TabIndex = 11;
            this.btnA1.Text = "A1";
            this.btnA1.UseVisualStyleBackColor = true;
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnA2
            // 
            this.btnA2.Enabled = false;
            this.btnA2.Location = new System.Drawing.Point(74, 33);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(47, 46);
            this.btnA2.TabIndex = 12;
            this.btnA2.Text = "A2";
            this.btnA2.UseVisualStyleBackColor = true;
            this.btnA2.Click += new System.EventHandler(this.btnA2_Click);
            // 
            // btnA3
            // 
            this.btnA3.Enabled = false;
            this.btnA3.Location = new System.Drawing.Point(127, 33);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(47, 46);
            this.btnA3.TabIndex = 13;
            this.btnA3.Text = "A3";
            this.btnA3.UseVisualStyleBackColor = true;
            this.btnA3.Click += new System.EventHandler(this.btnA3_Click);
            // 
            // btnA4
            // 
            this.btnA4.Enabled = false;
            this.btnA4.Location = new System.Drawing.Point(180, 33);
            this.btnA4.Name = "btnA4";
            this.btnA4.Size = new System.Drawing.Size(47, 46);
            this.btnA4.TabIndex = 14;
            this.btnA4.Text = "A4";
            this.btnA4.UseVisualStyleBackColor = true;
            this.btnA4.Click += new System.EventHandler(this.btnA4_Click);
            // 
            // btnA5
            // 
            this.btnA5.Enabled = false;
            this.btnA5.Location = new System.Drawing.Point(233, 33);
            this.btnA5.Name = "btnA5";
            this.btnA5.Size = new System.Drawing.Size(47, 46);
            this.btnA5.TabIndex = 15;
            this.btnA5.Text = "A5";
            this.btnA5.UseVisualStyleBackColor = true;
            this.btnA5.Click += new System.EventHandler(this.btnA5_Click);
            // 
            // btnA6
            // 
            this.btnA6.Enabled = false;
            this.btnA6.Location = new System.Drawing.Point(286, 33);
            this.btnA6.Name = "btnA6";
            this.btnA6.Size = new System.Drawing.Size(47, 46);
            this.btnA6.TabIndex = 16;
            this.btnA6.Text = "A6";
            this.btnA6.UseVisualStyleBackColor = true;
            this.btnA6.Click += new System.EventHandler(this.btnA6_Click);
            // 
            // btnA7
            // 
            this.btnA7.Enabled = false;
            this.btnA7.Location = new System.Drawing.Point(339, 33);
            this.btnA7.Name = "btnA7";
            this.btnA7.Size = new System.Drawing.Size(47, 46);
            this.btnA7.TabIndex = 17;
            this.btnA7.Text = "A7";
            this.btnA7.UseVisualStyleBackColor = true;
            this.btnA7.Click += new System.EventHandler(this.btnA7_Click);
            // 
            // btnA8
            // 
            this.btnA8.Enabled = false;
            this.btnA8.Location = new System.Drawing.Point(392, 33);
            this.btnA8.Name = "btnA8";
            this.btnA8.Size = new System.Drawing.Size(47, 46);
            this.btnA8.TabIndex = 18;
            this.btnA8.Text = "A8";
            this.btnA8.UseVisualStyleBackColor = true;
            this.btnA8.Click += new System.EventHandler(this.btnA8_Click);
            // 
            // btnA9
            // 
            this.btnA9.Enabled = false;
            this.btnA9.Location = new System.Drawing.Point(445, 33);
            this.btnA9.Name = "btnA9";
            this.btnA9.Size = new System.Drawing.Size(47, 46);
            this.btnA9.TabIndex = 19;
            this.btnA9.Text = "A9";
            this.btnA9.UseVisualStyleBackColor = true;
            this.btnA9.Click += new System.EventHandler(this.btnA9_Click);
            // 
            // btnA10
            // 
            this.btnA10.Enabled = false;
            this.btnA10.Location = new System.Drawing.Point(498, 33);
            this.btnA10.Name = "btnA10";
            this.btnA10.Size = new System.Drawing.Size(47, 46);
            this.btnA10.TabIndex = 20;
            this.btnA10.Text = "A10";
            this.btnA10.UseVisualStyleBackColor = true;
            this.btnA10.Click += new System.EventHandler(this.btnA10_Click);
            // 
            // btnA11
            // 
            this.btnA11.Enabled = false;
            this.btnA11.Location = new System.Drawing.Point(551, 33);
            this.btnA11.Name = "btnA11";
            this.btnA11.Size = new System.Drawing.Size(47, 46);
            this.btnA11.TabIndex = 21;
            this.btnA11.Text = "A11";
            this.btnA11.UseVisualStyleBackColor = true;
            this.btnA11.Click += new System.EventHandler(this.btnA11_Click);
            // 
            // btnA12
            // 
            this.btnA12.Enabled = false;
            this.btnA12.Location = new System.Drawing.Point(604, 33);
            this.btnA12.Name = "btnA12";
            this.btnA12.Size = new System.Drawing.Size(47, 46);
            this.btnA12.TabIndex = 22;
            this.btnA12.Text = "A12";
            this.btnA12.UseVisualStyleBackColor = true;
            this.btnA12.Click += new System.EventHandler(this.btnA12_Click);
            // 
            // btnB1
            // 
            this.btnB1.Enabled = false;
            this.btnB1.Location = new System.Drawing.Point(21, 92);
            this.btnB1.Name = "btnB1";
            this.btnB1.Size = new System.Drawing.Size(47, 46);
            this.btnB1.TabIndex = 23;
            this.btnB1.Text = "B1";
            this.btnB1.UseVisualStyleBackColor = true;
            this.btnB1.Click += new System.EventHandler(this.btnB1_Click);
            // 
            // btnB2
            // 
            this.btnB2.Enabled = false;
            this.btnB2.Location = new System.Drawing.Point(74, 92);
            this.btnB2.Name = "btnB2";
            this.btnB2.Size = new System.Drawing.Size(47, 46);
            this.btnB2.TabIndex = 24;
            this.btnB2.Text = "B2";
            this.btnB2.UseVisualStyleBackColor = true;
            this.btnB2.Click += new System.EventHandler(this.btnB2_Click);
            // 
            // btnB3
            // 
            this.btnB3.Enabled = false;
            this.btnB3.Location = new System.Drawing.Point(127, 92);
            this.btnB3.Name = "btnB3";
            this.btnB3.Size = new System.Drawing.Size(47, 46);
            this.btnB3.TabIndex = 25;
            this.btnB3.Text = "B3";
            this.btnB3.UseVisualStyleBackColor = true;
            this.btnB3.Click += new System.EventHandler(this.btnB3_Click);
            // 
            // btnB4
            // 
            this.btnB4.Enabled = false;
            this.btnB4.Location = new System.Drawing.Point(180, 92);
            this.btnB4.Name = "btnB4";
            this.btnB4.Size = new System.Drawing.Size(47, 46);
            this.btnB4.TabIndex = 26;
            this.btnB4.Text = "B4";
            this.btnB4.UseVisualStyleBackColor = true;
            this.btnB4.Click += new System.EventHandler(this.btnB4_Click);
            // 
            // btnB5
            // 
            this.btnB5.Enabled = false;
            this.btnB5.Location = new System.Drawing.Point(233, 92);
            this.btnB5.Name = "btnB5";
            this.btnB5.Size = new System.Drawing.Size(47, 46);
            this.btnB5.TabIndex = 27;
            this.btnB5.Text = "B5";
            this.btnB5.UseVisualStyleBackColor = true;
            this.btnB5.Click += new System.EventHandler(this.btnB5_Click);
            // 
            // btnB6
            // 
            this.btnB6.Enabled = false;
            this.btnB6.Location = new System.Drawing.Point(286, 92);
            this.btnB6.Name = "btnB6";
            this.btnB6.Size = new System.Drawing.Size(47, 46);
            this.btnB6.TabIndex = 28;
            this.btnB6.Text = "B6";
            this.btnB6.UseVisualStyleBackColor = true;
            this.btnB6.Click += new System.EventHandler(this.btnB6_Click);
            // 
            // btnB7
            // 
            this.btnB7.Enabled = false;
            this.btnB7.Location = new System.Drawing.Point(339, 92);
            this.btnB7.Name = "btnB7";
            this.btnB7.Size = new System.Drawing.Size(47, 46);
            this.btnB7.TabIndex = 29;
            this.btnB7.Text = "B7";
            this.btnB7.UseVisualStyleBackColor = true;
            this.btnB7.Click += new System.EventHandler(this.btnB7_Click);
            // 
            // btnB8
            // 
            this.btnB8.Enabled = false;
            this.btnB8.Location = new System.Drawing.Point(392, 92);
            this.btnB8.Name = "btnB8";
            this.btnB8.Size = new System.Drawing.Size(47, 46);
            this.btnB8.TabIndex = 30;
            this.btnB8.Text = "B8";
            this.btnB8.UseVisualStyleBackColor = true;
            this.btnB8.Click += new System.EventHandler(this.btnB8_Click);
            // 
            // btnB9
            // 
            this.btnB9.Enabled = false;
            this.btnB9.Location = new System.Drawing.Point(445, 92);
            this.btnB9.Name = "btnB9";
            this.btnB9.Size = new System.Drawing.Size(47, 46);
            this.btnB9.TabIndex = 31;
            this.btnB9.Text = "B9";
            this.btnB9.UseVisualStyleBackColor = true;
            this.btnB9.Click += new System.EventHandler(this.btnB9_Click);
            // 
            // btnB10
            // 
            this.btnB10.Enabled = false;
            this.btnB10.Location = new System.Drawing.Point(498, 92);
            this.btnB10.Name = "btnB10";
            this.btnB10.Size = new System.Drawing.Size(47, 46);
            this.btnB10.TabIndex = 32;
            this.btnB10.Text = "B10";
            this.btnB10.UseVisualStyleBackColor = true;
            this.btnB10.Click += new System.EventHandler(this.btnB10_Click);
            // 
            // btnB11
            // 
            this.btnB11.Enabled = false;
            this.btnB11.Location = new System.Drawing.Point(551, 92);
            this.btnB11.Name = "btnB11";
            this.btnB11.Size = new System.Drawing.Size(47, 46);
            this.btnB11.TabIndex = 33;
            this.btnB11.Text = "B11";
            this.btnB11.UseVisualStyleBackColor = true;
            this.btnB11.Click += new System.EventHandler(this.btnB11_Click);
            // 
            // btnB12
            // 
            this.btnB12.Enabled = false;
            this.btnB12.Location = new System.Drawing.Point(604, 92);
            this.btnB12.Name = "btnB12";
            this.btnB12.Size = new System.Drawing.Size(47, 46);
            this.btnB12.TabIndex = 34;
            this.btnB12.Text = "B12";
            this.btnB12.UseVisualStyleBackColor = true;
            this.btnB12.Click += new System.EventHandler(this.btnB12_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnA1);
            this.groupBox5.Controls.Add(this.btnB12);
            this.groupBox5.Controls.Add(this.btnA2);
            this.groupBox5.Controls.Add(this.btnB11);
            this.groupBox5.Controls.Add(this.btnA3);
            this.groupBox5.Controls.Add(this.btnB10);
            this.groupBox5.Controls.Add(this.btnA4);
            this.groupBox5.Controls.Add(this.btnB9);
            this.groupBox5.Controls.Add(this.btnA5);
            this.groupBox5.Controls.Add(this.btnB8);
            this.groupBox5.Controls.Add(this.btnA6);
            this.groupBox5.Controls.Add(this.btnB7);
            this.groupBox5.Controls.Add(this.btnA7);
            this.groupBox5.Controls.Add(this.btnB6);
            this.groupBox5.Controls.Add(this.btnA8);
            this.groupBox5.Controls.Add(this.btnB5);
            this.groupBox5.Controls.Add(this.btnA9);
            this.groupBox5.Controls.Add(this.btnB4);
            this.groupBox5.Controls.Add(this.btnA10);
            this.groupBox5.Controls.Add(this.btnB3);
            this.groupBox5.Controls.Add(this.btnA11);
            this.groupBox5.Controls.Add(this.btnB2);
            this.groupBox5.Controls.Add(this.btnA12);
            this.groupBox5.Controls.Add(this.btnB1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(728, 617);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(675, 160);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sample Grid";
            // 
            // listPad
            // 
            this.listPad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPad.FormattingEnabled = true;
            this.listPad.ItemHeight = 18;
            this.listPad.Location = new System.Drawing.Point(198, 45);
            this.listPad.Name = "listPad";
            this.listPad.Size = new System.Drawing.Size(73, 346);
            this.listPad.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 41;
            this.label5.Text = "Pad Positions:";
            // 
            // btnUploadSequence
            // 
            this.btnUploadSequence.Controls.Add(this.label3);
            this.btnUploadSequence.Controls.Add(this.txtSequenceAmt);
            this.btnUploadSequence.Controls.Add(this.btnSendSeq);
            this.btnUploadSequence.Controls.Add(this.label9);
            this.btnUploadSequence.Controls.Add(this.listCurrentSeq);
            this.btnUploadSequence.Controls.Add(this.label8);
            this.btnUploadSequence.Controls.Add(this.label7);
            this.btnUploadSequence.Controls.Add(this.txtSleepTime);
            this.btnUploadSequence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadSequence.Location = new System.Drawing.Point(1076, 200);
            this.btnUploadSequence.Name = "btnUploadSequence";
            this.btnUploadSequence.Size = new System.Drawing.Size(303, 411);
            this.btnUploadSequence.TabIndex = 42;
            this.btnUploadSequence.TabStop = false;
            this.btnUploadSequence.Text = "Running Sequence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 49;
            this.label3.Text = "Sequence Length";
            // 
            // txtSequenceAmt
            // 
            this.txtSequenceAmt.Location = new System.Drawing.Point(174, 27);
            this.txtSequenceAmt.Name = "txtSequenceAmt";
            this.txtSequenceAmt.Size = new System.Drawing.Size(100, 24);
            this.txtSequenceAmt.TabIndex = 48;
            this.txtSequenceAmt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSequenceAmt_KeyDown);
            // 
            // btnSendSeq
            // 
            this.btnSendSeq.Location = new System.Drawing.Point(174, 260);
            this.btnSendSeq.Name = "btnSendSeq";
            this.btnSendSeq.Size = new System.Drawing.Size(101, 59);
            this.btnSendSeq.TabIndex = 47;
            this.btnSendSeq.Text = "Prep Sequence";
            this.btnSendSeq.UseVisualStyleBackColor = true;
            this.btnSendSeq.Click += new System.EventHandler(this.btnSendSeq_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "Current Sequence:";
            // 
            // listCurrentSeq
            // 
            this.listCurrentSeq.FormattingEnabled = true;
            this.listCurrentSeq.ItemHeight = 18;
            this.listCurrentSeq.Location = new System.Drawing.Point(6, 184);
            this.listCurrentSeq.Name = "listCurrentSeq";
            this.listCurrentSeq.Size = new System.Drawing.Size(128, 220);
            this.listCurrentSeq.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 36);
            this.label8.TabIndex = 4;
            this.label8.Text = "NOTE: Please re-enter \"Sleep Time\" after selecting a sample pair:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sleep Time";
            // 
            // txtSleepTime
            // 
            this.txtSleepTime.Enabled = false;
            this.txtSleepTime.Location = new System.Drawing.Point(174, 115);
            this.txtSleepTime.Name = "txtSleepTime";
            this.txtSleepTime.Size = new System.Drawing.Size(100, 24);
            this.txtSleepTime.TabIndex = 2;
            this.txtSleepTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSleepTime_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = "Sample Positions:";
            // 
            // btnClearSample
            // 
            this.btnClearSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSample.Location = new System.Drawing.Point(998, 794);
            this.btnClearSample.Name = "btnClearSample";
            this.btnClearSample.Size = new System.Drawing.Size(101, 41);
            this.btnClearSample.TabIndex = 42;
            this.btnClearSample.Text = "Clear All";
            this.btnClearSample.UseVisualStyleBackColor = true;
            this.btnClearSample.Click += new System.EventHandler(this.btnClearSample_Click);
            // 
            // listSample
            // 
            this.listSample.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSample.FormattingEnabled = true;
            this.listSample.ItemHeight = 18;
            this.listSample.Location = new System.Drawing.Point(36, 45);
            this.listSample.Name = "listSample";
            this.listSample.Size = new System.Drawing.Size(73, 346);
            this.listSample.TabIndex = 43;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.listPad);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.listSample);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(749, 200);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(303, 411);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Positions";
            // 
            // txtTransmitted
            // 
            this.txtTransmitted.Location = new System.Drawing.Point(11, 23);
            this.txtTransmitted.Multiline = true;
            this.txtTransmitted.Name = "txtTransmitted";
            this.txtTransmitted.Size = new System.Drawing.Size(460, 258);
            this.txtTransmitted.TabIndex = 5;
            // 
            // btnClearRecieved
            // 
            this.btnClearRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRecieved.Location = new System.Drawing.Point(529, 680);
            this.btnClearRecieved.Name = "btnClearRecieved";
            this.btnClearRecieved.Size = new System.Drawing.Size(101, 41);
            this.btnClearRecieved.TabIndex = 46;
            this.btnClearRecieved.Text = "Clear Recieved";
            this.btnClearRecieved.UseVisualStyleBackColor = true;
            this.btnClearRecieved.Click += new System.EventHandler(this.btnClearRecieved_Click);
            // 
            // btnClearTransmittion
            // 
            this.btnClearTransmittion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTransmittion.Location = new System.Drawing.Point(529, 375);
            this.btnClearTransmittion.Name = "btnClearTransmittion";
            this.btnClearTransmittion.Size = new System.Drawing.Size(101, 41);
            this.btnClearTransmittion.TabIndex = 47;
            this.btnClearTransmittion.Text = "Clear Transmitted";
            this.btnClearTransmittion.UseVisualStyleBackColor = true;
            this.btnClearTransmittion.Click += new System.EventHandler(this.btnClearTransmittion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 870);
            this.Controls.Add(this.btnClearTransmittion);
            this.Controls.Add(this.btnClearRecieved);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnClearSample);
            this.Controls.Add(this.btnUploadSequence);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.btnUploadSequence.ResumeLayout(false);
            this.btnUploadSequence.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBoxCOMPORT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnSendData;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox tBoxDataIn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA4;
        private System.Windows.Forms.Button btnA5;
        private System.Windows.Forms.Button btnA6;
        private System.Windows.Forms.Button btnA7;
        private System.Windows.Forms.Button btnA8;
        private System.Windows.Forms.Button btnA9;
        private System.Windows.Forms.Button btnA10;
        private System.Windows.Forms.Button btnA11;
        private System.Windows.Forms.Button btnA12;
        private System.Windows.Forms.Button btnB1;
        private System.Windows.Forms.Button btnB2;
        private System.Windows.Forms.Button btnB3;
        private System.Windows.Forms.Button btnB4;
        private System.Windows.Forms.Button btnB5;
        private System.Windows.Forms.Button btnB6;
        private System.Windows.Forms.Button btnB7;
        private System.Windows.Forms.Button btnB8;
        private System.Windows.Forms.Button btnB9;
        private System.Windows.Forms.Button btnB10;
        private System.Windows.Forms.Button btnB11;
        private System.Windows.Forms.Button btnB12;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listPad;
        private System.Windows.Forms.GroupBox btnUploadSequence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSleepTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listCurrentSeq;
        private System.Windows.Forms.Button btnSendSeq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearSample;
        private System.Windows.Forms.ListBox listSample;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSequenceAmt;
        private System.Windows.Forms.TextBox txtTransmitted;
        private System.Windows.Forms.Button btnClearRecieved;
        private System.Windows.Forms.Button btnClearTransmittion;
    }
}

