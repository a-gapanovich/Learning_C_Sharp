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
        char[] spec_chars = new char[] { '#', '%', '@', '~', '&' };
        string password = "";
        Dictionary<string, double> metrica;

        public My_Form()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000 * 1000);
            metrica.Add("mile", 1609344);

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

        private void BTN_Password_Click(object sender, EventArgs e)
        {
            if (CLB_Password.CheckedItems.Count == 0) return;
            
            for (int i = 0; i < NUD_Password.Value; i++)
            {
                int n = rnd.Next(0, CLB_Password.CheckedItems.Count);
                string s = Convert.ToString(CLB_Password.CheckedItems[n]);
                switch(s)
                {
                    case "Цифры": password += Convert.ToString(rnd.Next(10));
                        break;

                    case "Прописные буквы":
                        password += Convert.ToChar(rnd.Next(65, 88));
                        break;
                    case "Строчные буквы":
                        password += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default:
                        password += spec_chars[rnd.Next(spec_chars.Length)];
                        break;
                }
                TD_Password.Text = password;
                
            }
            
        }

        private void TD_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Copy_password_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(password);
        }

        private void TB_Converter_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Convert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[CB_From.Text];
            double m2 = metrica[CB_To.Text];
            double n = Convert.ToDouble(TB_From.Text);
            TB_To.Text = Convert.ToString(n * m1 / m2);
        }

        private void BTN_Swap_Click(object sender, EventArgs e)
        {
            string t = CB_From.Text;
            CB_From.Text = CB_To.Text;
            CB_To.Text = t;

        }

        private void CB_Choise_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_Choise.Text)
            {
                case "Длина":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000 * 1000);
                    metrica.Add("mile", 1609344);
                    CB_From.Items.Clear();
                    CB_From.Items.Add("mm");
                    CB_From.Items.Add("cm");
                    CB_From.Items.Add("dm");
                    CB_From.Items.Add("m");
                    CB_From.Items.Add("km");
                    CB_From.Items.Add("mile");

                    CB_To.Items.Clear();
                    CB_To.Items.Add("mm");
                    CB_To.Items.Add("cm");
                    CB_To.Items.Add("dm");
                    CB_To.Items.Add("m");
                    CB_To.Items.Add("km");
                    CB_To.Items.Add("mile");

                    CB_From.Text = "mm";
                    CB_To.Text = "mm";
                    break;

                case "Вес":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000 * 1000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    CB_From.Items.Clear();
                    CB_From.Items.Add("g");
                    CB_From.Items.Add("kg");
                    CB_From.Items.Add("t");
                    CB_From.Items.Add("lb");
                    CB_From.Items.Add("oz");
                    

                    CB_To.Items.Clear();
                    CB_To.Items.Add("g");
                    CB_To.Items.Add("kg");
                    CB_To.Items.Add("t");
                    CB_To.Items.Add("lb");
                    CB_To.Items.Add("oz");
                    

                    CB_From.Text = "g";
                    CB_To.Text = "g";
                    break;
                default:
                    break;
            }
        }
    }
}
