using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvgCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //calc
        {
            float sum, avg, value;
            sum = 0;

            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    value = Convert.ToSingle(((TextBox)control).Text);
                    sum += value;
                }
                avg = sum / 3;
                this.Controls["label6"].Text = avg.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control control in this.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
            this.Controls["label6"].Text = "...";
        }
    }
}
