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
            MessageBox.Show("Тестовое приложение, в котором пытаюсь понять идею работы с Window Forms и C# \nАвтор: Александр Гапанович, сентябрь 2021 г.", "О программе");
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
            int n = rnd.Next(Convert.ToInt32(NUD_down.Value), Convert.ToInt32(NUD_up.Value)) + 1;
            LB_genWrite.Text = Convert.ToString(n);
            if (CB_Rand.Checked == true)
            {
                if (TB_Random.Text.IndexOf(n.ToString()) == -1) TB_Random.AppendText(n + " \n");
            }
            else
            {
                TB_Random.AppendText(n + " \n");
            }
        }

        private void BT_Rand_clear_Click(object sender, EventArgs e)
        {
            TB_Random.Clear();
        }

        private void BT_RandCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TB_Random.Text);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TSMI_Data_Click(object sender, EventArgs e)
        {
            RTB_Notepad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void TSMI_Time_Click(object sender, EventArgs e)
        {
            RTB_Notepad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RTB_Notepad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении!");
            }
        }
        void LoadNotepad()
        {
            try
            {
                RTB_Notepad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке!");
            }
        }
        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadNotepad();
        }

        private void My_Form_Load(object sender, EventArgs e)
        {
            LoadNotepad();
        }
    }
}
