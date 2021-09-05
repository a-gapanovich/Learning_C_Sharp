using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Snake
{
    public partial class Form1 : Form
    {
        private int _width = 900;
        private int _height = 800;
        private int _sizeofsides = 40;
  
        public Form1()
        {
            InitializeComponent();
            this.Width = _width;
            this.Height = _height;

            __generateMap();

            this.KeyDown += new KeyEventHandler(OKP);

        }
        private void __generateMap()
        {
            for(int i=0; i<_width/_sizeofsides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0, _sizeofsides * i);
                pic.Size = new Size(_width - 100, 1);
                this.Controls.Add(pic);
            }

            for (int i = 0; i <= _height / _sizeofsides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(_sizeofsides * i, 0);
                pic.Size = new Size(1, _width);
                this.Controls.Add(pic);
            }
        }
        private void OKP (object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    cube.Location = new Point(cube.Location.X + _sizeofsides, cube.Location.Y);
                    break;
                case "Left":
                    cube.Location = new Point(cube.Location.X - _sizeofsides, cube.Location.Y);
                    break;
                case "Up":
                    cube.Location = new Point(cube.Location.X, cube.Location.Y-_sizeofsides);
                    break;
                case "Down":
                    cube.Location = new Point(cube.Location.X, cube.Location.Y+_sizeofsides);
                    break;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
