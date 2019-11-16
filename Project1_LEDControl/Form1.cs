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
        string[] ports;
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
        }


        private void btnLed1_Click(object sender, EventArgs e)
        {
            tBoxLed1.BackColor = System.Drawing.Color.Red;
        }


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
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDisConnect.Enabled = false;
                btnConnect.Enabled = true;
                cBoxBaudRate.Enabled = true;
                cBoxCOMPORT.Enabled = true;
                cBoxDataSize.Enabled = true;
                cBoxParity.Enabled = true;
                cBoxStopBits.Enabled = true;
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
                    progressBar1.Value = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cBoxBaudRate.Enabled = false;
                cBoxCOMPORT.Enabled = false;
                cBoxDataSize.Enabled = false;
                cBoxParity.Enabled = false;
                cBoxStopBits.Enabled = false;
                btnDisConnect.Enabled = true;
                btnConnect.Enabled = false;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }
    }
}
