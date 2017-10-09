using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1043337_13_2
{
    public partial class Form3 : Form
    {
        double R=0, G=0, B=0, A=0;
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            double R = trackBar1.Value;
           
            label1.Text = (R/10).ToString("f1");
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            double G = trackBar2.Value;
            label2.Text = (G/10).ToString("f1");
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            double B = trackBar3.Value;
   
            label3.Text = (B/10).ToString("f1");
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            double A = trackBar4.Value;
            label4.Text = (A/10).ToString("f1");
        }

 
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int getR()
        {
            return trackBar1.Value;
        }
        public int getG()
        {
            return trackBar2.Value;
        }
        public int getB()
        {
            return trackBar3.Value;
        }
        public int getA()
        {
            return trackBar4.Value;
        }

    
    }
}
