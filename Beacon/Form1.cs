using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beacon
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort = null;
        bool bReadPort = false;
        bool bWritePort = false;
        int bType = 0;
        public Form1()
        {
            InitializeComponent();
            string[] portnames = SerialPort.GetPortNames();
            bReadPort = false;
            bWritePort = false;
            foreach (string name in portnames)
            {
                comboBoxSerialPort.Items.Add(name);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
/*            this.checkBoxWriteGoToSleepMode.Checked = true;
            this.checkReadBoxGoToSleepMode.Checked = true;*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

    }
}