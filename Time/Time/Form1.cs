﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }
        int count = 0;
        int phut;
        int giay;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            btnDongY.Enabled = false;
            if (phut > 0)
            {
                timer1.Start();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnDongY.Enabled = true;
        }
        int soPhut = 0;
        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            var f = new SetMinute();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                soPhut = f.SoPhut;
                lbDongHo.Text = convert(soPhut * 60);
            }
        }
        
        string convert(int soGiay)
        {
            int p = soGiay / 60;
            int s = soGiay % 60;
            phut = p;
            giay = s;
            return $"{p:0#}:{s:0#}";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (giay == 0 && phut == 0)
            {
                timer1.Stop();
                DialogResult result = MessageBox.Show("Hết thời gian", "Thông báo");
            }
            else if (giay == -1)
            {
                phut--;
                giay = 0;
            }
            else giay--;
            lbDongHo.Text = convert((phut * 60) + giay);
        }
    }

}
