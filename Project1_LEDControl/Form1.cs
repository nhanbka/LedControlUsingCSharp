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

namespace Project1_LEDControl
{
    public partial class Form1 : Form
    {
        private string[] ports;
        private byte[] byteBuffer;
        private byte[] dataToSend;
        private int[] statusLED;
        private int first_load;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);

            btnConnect.Enabled = true;
            btnDisConnect.Enabled = false;
            btnLed1.Enabled = false;
            btnLed2.Enabled = false;
            btnLed3.Enabled = false;
            btnLed4.Enabled = false;
            btnLed5.Enabled = false;
            btnLed6.Enabled = false;
            btnLed7.Enabled = false;
            btnLed8.Enabled = false;
            statusLED = new int[8];
            for (int i = 0; i < 8; i++)
                statusLED[i] = 0;
            first_load = 0;
        }


        /*
         *
         * ----------- Handle btnLed Click ----------- 
         *
         */
        private void btnLed1_Click(object sender, EventArgs e)
        {
            if(tBoxLed1.BackColor == Color.Red)
            {
                statusLED[0] = 0;
            }
            else
            {
                statusLED[0] = 1;
            }
            sendData();
        }

        private void btnLed2_Click(object sender, EventArgs e)
        {
            if (tBoxLed2.BackColor == Color.Red)
            {
                statusLED[1] = 0;
            }
            else
            {
                statusLED[1] = 1;
            }
            sendData();
        }

        private void btnLed3_Click(object sender, EventArgs e)
        {
            if (tBoxLed3.BackColor == Color.Red)
            {
                statusLED[2] = 0;
            }
            else
            {
                statusLED[2] = 1;
            }
            sendData();
        }

        private void btnLed4_Click(object sender, EventArgs e)
        {
            if (tBoxLed4.BackColor == Color.Red)
            {
                statusLED[3] = 0;
            }
            else
            {
                statusLED[3] = 1;
            }
            sendData();
        }

        private void btnLed5_Click(object sender, EventArgs e)
        {
            if (tBoxLed5.BackColor == Color.Red)
            {
                statusLED[4] = 0;
            }
            else
            {
                statusLED[4] = 1;
            }
            sendData();
        }

        private void btnLed6_Click(object sender, EventArgs e)
        {
            if (tBoxLed6.BackColor == Color.Red)
            {
                statusLED[5] = 0;
            }
            else
            {
                statusLED[5] = 1;
            }
            sendData();
        }

        private void btnLed7_Click(object sender, EventArgs e)
        {
            if (tBoxLed7.BackColor == Color.Red)
            {
                statusLED[6] = 0;
            }
            else
            {
                statusLED[6] = 1;
            }
            sendData();
        }

        private void btnLed8_Click(object sender, EventArgs e)
        {
            if (tBoxLed8.BackColor == Color.Red)
            {
                statusLED[7] = 0;
            }
            else
            {
                statusLED[7] = 1;
            }
            sendData();
        }

        /* 
         * 
         * ------------ End Handle btnLed Click--------
         *
         */


        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // Setup Serial Port Properties
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBaudRate.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDataSize.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBits.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);
                
                // Connect To Serial Port
                serialPort1.Open();
                cBoxBaudRate.Enabled = false;
                cBoxCOMPORT.Enabled = false;
                cBoxDataSize.Enabled = false;
                cBoxParity.Enabled = false;
                cBoxStopBits.Enabled = false;
                btnDisConnect.Enabled = true;
                btnConnect.Enabled = false;
                btnLed1.Enabled = true;
                btnLed2.Enabled = true;
                btnLed3.Enabled = true;
                btnLed4.Enabled = true;
                btnLed5.Enabled = true;
                btnLed6.Enabled = true;
                btnLed7.Enabled = true;
                btnLed8.Enabled = true;
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    btnDisConnect.Enabled = false;
                    btnConnect.Enabled = true;
                    cBoxBaudRate.Enabled = true;
                    cBoxCOMPORT.Enabled = true;
                    cBoxDataSize.Enabled = true;
                    cBoxParity.Enabled = true;
                    cBoxStopBits.Enabled = true;
                    btnLed1.Enabled = false;
                    btnLed2.Enabled = false;
                    btnLed3.Enabled = false;
                    btnLed4.Enabled = false;
                    btnLed5.Enabled = false;
                    btnLed6.Enabled = false;
                    btnLed7.Enabled = false;
                    btnLed8.Enabled = false;
                    for(int i = 100; i >= 0; i -= 1)
                    {
                        progressBar1.Value = i;
                        for (int j = 500; j > 0; j--)
                            j = j * 1 + i - i;
                    }
                        
                    
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int intBuffer;
            intBuffer = serialPort1.BytesToRead;
            byteBuffer = new byte[intBuffer];
            serialPort1.Read(byteBuffer, 0, intBuffer);
            this.Invoke(new EventHandler(ShowData));
            if(first_load++ == 0)
                getStatusLED();
        }

        private void sendData()
        {
            string output = "";
            dataToSend = new byte[1];
            dataToSend[0] = 0;
            if (statusLED[0] == 1)
                dataToSend[0]++;
            if (statusLED[1] == 1)
                dataToSend[0] += 2;
            if (statusLED[2] == 1)
                dataToSend[0] += 4;
            if (statusLED[3] == 1)
                dataToSend[0] += 8;
            if (statusLED[4] == 1)
                dataToSend[0] += 16;
            if (statusLED[5] == 1)
                dataToSend[0] += 32;
            if (statusLED[6] == 1)
                dataToSend[0] += 64;
            if (statusLED[7] == 1)
                dataToSend[0] += 128;
            serialPort1.Write(dataToSend, 0, 1);
            int temp = dataToSend[0];
            while (output.Length < 8)
            {
                if (temp % 2 == 0)
                {
                    output = "0" + output;
                }
                else
                {
                    output = "1" + output;
                }
                temp /= 2;
            }
            tBoxDataSend.Text = output;
        }

        private void ShowData(object sender, EventArgs e)
        {
            string output = "";
            int temp = (int)byteBuffer[0];
            int i = 1;
            while(output.Length < 8)
            {
                if(temp % 2 == 0)
                {
                    output = "0" + output;
                    changeLedStatus(i++, 0);
                }
                else
                {
                    output = "1" + output;
                    changeLedStatus(i++, 1);
                }
                temp /= 2;
            }
            tBoxDataReceive.Text = output;
            output = "";
        }

        private void changeLedStatus(int number, int status)
        {
            if (number == 1)
            {
                if (status == 1)
                {
                    tBoxLed1.BackColor = System.Drawing.Color.Red;
                    btnLed1.Text = "OFF";
                }
                else
                {
                    tBoxLed1.BackColor = System.Drawing.Color.Gray;
                    btnLed1.Text = "ON";
                }
            }
            else if (number == 2)
            {
                if (status == 1)
                {
                    tBoxLed2.BackColor = System.Drawing.Color.Red;
                    btnLed2.Text = "OFF";
                }
                else
                {
                    tBoxLed2.BackColor = System.Drawing.Color.Gray;
                    btnLed2.Text = "ON";
                }
            }
            else if (number == 3)
            {
                if (status == 1)
                {
                    tBoxLed3.BackColor = System.Drawing.Color.Red;
                    btnLed3.Text = "OFF";
                }
                else
                {
                    tBoxLed3.BackColor = System.Drawing.Color.Gray;
                    btnLed3.Text = "ON";
                }
            }
            else if (number == 4)
            {
                if (status == 1)
                {
                    tBoxLed4.BackColor = System.Drawing.Color.Red;
                    btnLed4.Text = "OFF";
                }
                else
                {
                    tBoxLed4.BackColor = System.Drawing.Color.Gray;
                    btnLed4.Text = "ON";
                }
            }
            else if (number == 5)
            {
                if (status == 1)
                {
                    tBoxLed5.BackColor = System.Drawing.Color.Red;
                    btnLed5.Text = "OFF";
                }
                else
                {
                    tBoxLed5.BackColor = System.Drawing.Color.Gray;
                    btnLed5.Text = "ON";
                }
            }
            else if (number == 6)
            {
                if (status == 1)
                {
                    tBoxLed6.BackColor = System.Drawing.Color.Red;
                    btnLed6.Text = "OFF";
                }
                else
                {
                    tBoxLed6.BackColor = System.Drawing.Color.Gray;
                    btnLed6.Text = "ON";
                }
            }
            else if (number == 7)
            {
                if (status == 1)
                {
                    tBoxLed7.BackColor = System.Drawing.Color.Red;
                    btnLed7.Text = "OFF";
                }
                else
                {
                    tBoxLed7.BackColor = System.Drawing.Color.Gray;
                    btnLed7.Text = "ON";
                }
            }
            else if (number == 8)
            {
                if (status == 1)
                {
                    tBoxLed8.BackColor = System.Drawing.Color.Red;
                    btnLed8.Text = "OFF";
                }
                else
                {
                    tBoxLed8.BackColor = System.Drawing.Color.Gray;
                    btnLed8.Text = "ON";
                }
            }
        }

        private void getStatusLED()
        {
            if (tBoxLed1.BackColor == Color.Red)
                statusLED[0] = 1;
            if (tBoxLed2.BackColor == Color.Red)
                statusLED[1] = 1;
            if (tBoxLed3.BackColor == Color.Red)
                statusLED[2] = 1;
            if (tBoxLed4.BackColor == Color.Red)
                statusLED[3] = 1;
            if (tBoxLed5.BackColor == Color.Red)
                statusLED[4] = 1;
            if (tBoxLed6.BackColor == Color.Red)
                statusLED[5] = 1;
            if (tBoxLed7.BackColor == Color.Red)
                statusLED[6] = 1;
            if (tBoxLed8.BackColor == Color.Red)
                statusLED[7] = 1;
        }
    }
}
