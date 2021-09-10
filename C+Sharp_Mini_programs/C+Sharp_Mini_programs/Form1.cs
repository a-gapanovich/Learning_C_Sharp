using System;
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
    public partial class Form1 : Form
    {
        int count = 0;
        Random rnd;
       
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здесь может быть Ваша реклама!", "О программе.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = Convert.ToString(count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count--;
            lblCount.Text = Convert.ToString(count);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnReser_Click(object sender, EventArgs e)
        {
            count = 0;
            lblCount.Text = Convert.ToString(count);
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bntRand_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown3.Value));
            lblOut.Text = Convert.ToString(n);
            if (cbRandom.Checked)
            {
                if (tbRand.Text.IndexOf(n.ToString()) == -1) tbRand.AppendText(Convert.ToString(n) + " ");
            }
            else tbRand.AppendText(Convert.ToString(n) + " ");


        }

        private void lblOut_Click(object sender, EventArgs e)
        {

        }

        private void tbRand_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbRand.Clear();
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbRand.Text);
        }
    }
}
