﻿using System;
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
    }
}
