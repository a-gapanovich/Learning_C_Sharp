﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Mini_programs
{
    public partial class My_Form : Form
    {
        int count = 0;
        Random rnd;

        public My_Form()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void TSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тестовое приложение, в котором пытаюсь понять идею работы с Window Forms и C# \nАвтор: Александр Гапанович, сентябрь 2021 г.","О программе");
        }

        private void BTN_plus_Click(object sender, EventArgs e)
        {
            count++;
            LB_counter.Text = Convert.ToString(count);
        }

        private void BTN_mimus_Click(object sender, EventArgs e)
        {
            count--;
            LB_counter.Text = Convert.ToString(count);
        }

        private void BTN_reset_Click(object sender, EventArgs e)
        {
            count = 0;
            LB_counter.Text = Convert.ToString(count);
        }

        private void BTN_Generate_Click(object sender, EventArgs e)
        {
            int n = rnd.Next(Convert.ToInt32(NUD_down.Value), Convert.ToInt32(NUD_up.Value))+1;
            LB_genWrite.Text = Convert.ToString(n);
        }
    }
}
