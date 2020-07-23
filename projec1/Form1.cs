using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace projec1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            long hour = Convert.ToInt64(textBox1.Text);
            long hourtomin = hour * 60;
            
            long min = Convert.ToInt64(textBox3.Text);
            long second = min * 60;
            
            if (hour > 0)
            {
                second = hourtomin * 60 + min * 60;
            }
            else if (min > 0)
            {
                second = min * 60 + hourtomin * 60;
            }
            textBox2.Text = second.ToString();

            Process.Start("cmd.exe", "/c" + "@shutdown /s /t " +second );
            MessageBox.Show("Timing will end after " + second / 60 + " minutes and will shut down the computer. ", "Warning");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c" + "shutdown /a");
            MessageBox.Show("The Timer has been canceled!", "Warning");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
