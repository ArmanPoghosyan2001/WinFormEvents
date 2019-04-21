using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitializeTimer();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value++;

            if (progressBar2.Value < 100)
                progressBar2.Value++;

        }

        private void InitializeTimer()
        {
            timer1.Interval = 100;

            timer1.Start();

            timer1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
