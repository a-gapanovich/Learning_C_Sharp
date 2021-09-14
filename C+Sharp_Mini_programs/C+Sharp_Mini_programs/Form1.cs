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
        public Form1()
        {
            InitializeComponent();
        }

        private void TSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Тестовое приложение, в котором пытаюсь понять идею работы с Window Forms и C# \nАвтор: Александр Гапанович, сентябрь 2021 г.","О программе");
        }
    }
}
