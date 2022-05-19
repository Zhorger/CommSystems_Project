using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace ComPort
{
    public partial class Form1 : Form
    {
        int ENDCASE = 0;
        int sequenceAmt = 0;
        int seqAmtMax;
        int totalClicks = 0;
        int clickAmt = 0;
        int sleepCase = 0;
        string dataOUT;
        string dataIN;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;

                serialPort1.Open();
                progressBar1.Value = 100;

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT = txtTransmitted.Text;
                // WriteLine() - can be used to write on every other line
                serialPort1.Write(dataOUT);

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            tBoxDataIn.Text = dataIN;
        }

        //FOR ALL BUTTONS
        //color MenuHighlight - sample
        //color ActiveCaption - PAD
        private void btnA1_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1)) 
            {
                listCurrentSeq.Items.Add("A1");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnA1.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnA1.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnA1.BackColor = Color.Green;
                        listSample.Items.Add("A1");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnA1.BackColor = Color.Red;
                        listPad.Items.Add("A1");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnA1.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("A2");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnA2.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnA2.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnA2.BackColor = Color.Green;
                        listSample.Items.Add("A2");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnA2.BackColor = Color.Red;
                        listPad.Items.Add("A2");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnA2.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("A3");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnA3.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnA3.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnA3.BackColor = Color.Green;
                        listSample.Items.Add("A3");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnA3.BackColor = Color.Red;
                        listPad.Items.Add("A3");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnA3.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("A4");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnA4.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnA4.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnA4.BackColor = Color.Green;
                        listSample.Items.Add("A4");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnA4.BackColor = Color.Red;
                        listPad.Items.Add("A4");
                        clickAmt = 0;
                    }
                txtSleepTime.Enabled = true;
                sleepCase = 1;
                }
            btnA4.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnA5_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("A5");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnA5.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnA5.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnA5.BackColor = Color.Green;
                        listSample.Items.Add("A5");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnA5.BackColor = Color.Red;
                        listPad.Items.Add("A5");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnA5.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnA6_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("A6");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnA6.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnA6.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnA6.BackColor = Color.Green;
                        listSample.Items.Add("A6");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnA6.BackColor = Color.Red;
                        listPad.Items.Add("A6");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnA6.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("A7");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnA7.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnA7.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnA7.BackColor = Color.Green;
                        listSample.Items.Add("A7");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnA7.BackColor = Color.Red;
                        listPad.Items.Add("A7");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnA7.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnA8_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("A8");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnA8.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnA8.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnA8.BackColor = Color.Green;
                        listSample.Items.Add("A8");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnA8.BackColor = Color.Red;
                        listPad.Items.Add("A8");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnA8.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("B1");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnB1.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnB1.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnB1.BackColor = Color.Green;
                        listSample.Items.Add("B1");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnB1.BackColor = Color.Red;
                        listPad.Items.Add("B1");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnB1.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("B2");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnB2.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnB2.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnB2.BackColor = Color.Green;
                        listSample.Items.Add("B2");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnB2.BackColor = Color.Red;
                        listPad.Items.Add("B2");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnB2.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("B3");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnB3.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnB3.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnB3.BackColor = Color.Green;
                        listSample.Items.Add("B3");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnB3.BackColor = Color.Red;
                        listPad.Items.Add("B3");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnB3.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1)) {
                listCurrentSeq.Items.Add("B4");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnB4.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnB4.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnB4.BackColor = Color.Green;
                        listSample.Items.Add("B4");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnB4.BackColor = Color.Red;
                        listPad.Items.Add("B4");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnB4.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1)) {
                listCurrentSeq.Items.Add("B5");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnB5.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnB5.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnB5.BackColor = Color.Green;
                        listSample.Items.Add("B5");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnB5.BackColor = Color.Red;
                        listPad.Items.Add("B5");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnB5.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("B6");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnB6.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnB6.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnB6.BackColor = Color.Green;
                        listSample.Items.Add("B6");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnB6.BackColor = Color.Red;
                        listPad.Items.Add("B6");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnB6.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("B7");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnB7.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnB7.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnB7.BackColor = Color.Green;
                        listSample.Items.Add("B7");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnB7.BackColor = Color.Red;
                        listPad.Items.Add("B7");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnB7.Enabled = false;
                sequenceAmt++;
            }
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            if ((sleepCase != 1) && (ENDCASE != 1))
            {
                listCurrentSeq.Items.Add("B8");
                if (sequenceAmt == seqAmtMax) //final case
                {
                    btnB8.BackColor = Color.Yellow; ENDCASE = 1;
                }
                else if (totalClicks == 0) //intial case
                {
                    btnB8.BackColor = Color.DodgerBlue;
                    totalClicks = 1;
                }
                else
                {
                    totalClicks++;
                    if (clickAmt == 0)
                    {
                        btnB8.BackColor = Color.Green;
                        listSample.Items.Add("B8");
                        clickAmt++;
                    }
                    else if (clickAmt == 1)
                    {
                        btnB8.BackColor = Color.Red;
                        listPad.Items.Add("B8");
                        clickAmt = 0;
                    }
                    txtSleepTime.Enabled = true;
                    sleepCase = 1;
                }
                btnB8.Enabled = false;
                sequenceAmt++;
            }
        }

        private void txtSleepTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listCurrentSeq.Items.Add(txtSleepTime.Text);
                txtSleepTime.Clear();
                sleepCase = 0; sequenceAmt++;
                txtSleepTime.Enabled = false;
            }
        }

        private void btnClearSample_Click(object sender, EventArgs e)
        {
            btnA1.BackColor = Control.DefaultBackColor;
            btnA2.BackColor = Control.DefaultBackColor;
            btnA3.BackColor = Control.DefaultBackColor;
            btnA4.BackColor = Control.DefaultBackColor;
            btnA5.BackColor = Control.DefaultBackColor;
            btnA6.BackColor = Control.DefaultBackColor;
            btnA7.BackColor = Control.DefaultBackColor;
            btnA8.BackColor = Control.DefaultBackColor;
            //btnA9.BackColor = Control.DefaultBackColor;
            //btnA10.BackColor = Control.DefaultBackColor;
            //btnA11.BackColor = Control.DefaultBackColor;
            //btnA12.BackColor = Control.DefaultBackColor;
            btnB1.BackColor = Control.DefaultBackColor;
            btnB2.BackColor = Control.DefaultBackColor;
            btnB3.BackColor = Control.DefaultBackColor;
            btnB4.BackColor = Control.DefaultBackColor;
            btnB5.BackColor = Control.DefaultBackColor;
            btnB6.BackColor = Control.DefaultBackColor;
            btnB7.BackColor = Control.DefaultBackColor;
            btnB8.BackColor = Control.DefaultBackColor;
            //btnB9.BackColor = Control.DefaultBackColor;
            //btnB10.BackColor = Control.DefaultBackColor;
            //btnB11.BackColor = Control.DefaultBackColor;
            //btnB12.BackColor = Control.DefaultBackColor; 
            btnA1.UseVisualStyleBackColor = true;
            btnA2.UseVisualStyleBackColor = true;
            btnA3.UseVisualStyleBackColor = true;
            btnA4.UseVisualStyleBackColor = true;
            btnA5.UseVisualStyleBackColor = true;
            btnA6.UseVisualStyleBackColor = true;
            btnA7.UseVisualStyleBackColor = true;
            btnA8.UseVisualStyleBackColor = true;
            //btnA9.UseVisualStyleBackColor = true;
            //btnA10.UseVisualStyleBackColor = true;
            //btnA11.UseVisualStyleBackColor = true;
            //btnA12.UseVisualStyleBackColor = true;
            btnB1.UseVisualStyleBackColor = true;
            btnB2.UseVisualStyleBackColor = true;
            btnB3.UseVisualStyleBackColor = true;
            btnB4.UseVisualStyleBackColor = true;
            btnB5.UseVisualStyleBackColor = true;
            btnB6.UseVisualStyleBackColor = true;
            btnB7.UseVisualStyleBackColor = true;
            btnB8.UseVisualStyleBackColor = true;
            //btnB9.UseVisualStyleBackColor = true;
            //btnB10.UseVisualStyleBackColor = true;
            //btnB11.UseVisualStyleBackColor = true;
            //btnB12.UseVisualStyleBackColor = true;
            btnA1.Enabled = false;
            btnA2.Enabled = false;
            btnA3.Enabled = false;
            btnA4.Enabled = false;
            btnA5.Enabled = false;
            btnA6.Enabled = false;
            btnA7.Enabled = false;
            btnA8.Enabled = false;
            //btnA9.Enabled = false;
            //btnA10.Enabled = false;
            //btnA11.Enabled = false;
            //btnA12.Enabled = false;
            btnB1.Enabled = false;
            btnB2.Enabled = false;
            btnB3.Enabled = false;
            btnB4.Enabled = false;
            btnB5.Enabled = false;
            btnB6.Enabled = false;
            btnB7.Enabled = false;
            btnB8.Enabled = false;
            //btnB9.Enabled = false;
            //btnB10.Enabled = false;
            //btnB11.Enabled = false;
            //btnB12.Enabled = false;
            txtSequenceAmt.Clear();
            txtSequenceAmt.Enabled = true;
            txtSleepTime.Enabled = false;
            listCurrentSeq.Items.Clear();
            listSample.Items.Clear();
            listPad.Items.Clear();
            totalClicks = 0; 
            clickAmt = 0;
            sequenceAmt = 0;
            seqAmtMax = 0;
        }

        private void txtSequenceAmt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Int32.TryParse(txtSequenceAmt.Text, out seqAmtMax);
                btnA1.Enabled = true;
                btnA2.Enabled = true;
                btnA3.Enabled = true;
                btnA4.Enabled = true;
                btnA5.Enabled = true;
                btnA6.Enabled = true;
                btnA7.Enabled = true;
                btnA8.Enabled = true;
                //btnA9.Enabled = true;
                //btnA10.Enabled = true;
                //btnA11.Enabled = true;
                //btnA12.Enabled = true;
                btnB1.Enabled = true;
                btnB2.Enabled = true;
                btnB3.Enabled = true;
                btnB4.Enabled = true;
                btnB5.Enabled = true;
                btnB6.Enabled = true;
                btnB7.Enabled = true;
                btnB8.Enabled = true;
                //btnB9.Enabled = true;
                //btnB10.Enabled = true;
                //btnB11.Enabled = true;
                //btnB12.Enabled = true;
                txtSequenceAmt.Enabled = false;
            }
        }

        private void btnSendSeq_Click(object sender, EventArgs e)
        {
            string sequence = string.Join(" ", listCurrentSeq.Items.OfType<object>());
            txtTransmitted.Text += (sequence + Environment.NewLine);
        }

        private void btnClearTransmittion_Click(object sender, EventArgs e)
        {
            txtTransmitted.Clear();
        }

        private void btnClearRecieved_Click(object sender, EventArgs e)
        {
            tBoxDataIn.Clear();
        }
    }

}