using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 11; i+=2)
            {
                listBox1.Items.Add(i);
            }
            


        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 1; i < 11; i++)
            {
                toplam = toplam + i;
            }
            label1.Text = toplam.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            for (int i = 2; i <= 10; i+=2)
            {
                toplam = toplam + i;
                label3.Text = toplam.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i% 5 == 0 && i% 7 ==0 )
                        {
                    listBox2.Items.Add(i);     
                        }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox1.Text);
            for (int i = 1; i <=sayi; i++)
            {
                listBox3.Items.Add(i);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(textBox2.Text);

            for (int i = 1; i <= sayi; i++)
            {
                if( sayi% i == 0)
                {
                listBox4.Items.Add(i);
                }
            }

        }
    }
}
