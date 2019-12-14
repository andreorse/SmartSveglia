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

namespace radio_sveglia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SerialPort COM = null;
            COM = new SerialPort("COM3", 9600);
            COM.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex += 3;
        }

        private void buttonHome1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
        }

        private void buttonHome2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 2;
        }

        private void buttonHome3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex -= 3;
        }

        private void buttonFatto1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex--;
            //invia ora e giorno attuali a arduino
        }
    }
}
