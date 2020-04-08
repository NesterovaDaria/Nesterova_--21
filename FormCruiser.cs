using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCruiser
{
    public partial class FormCruiser : Form
    {
        private Cruiser avianos;
        public FormCruiser()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Graphics gr = Graphics.FromImage(bmp);
            avianos.DrawCruiser(gr);
            pictureBoxCruiser.Image = bmp;
        }
        /// Обработка нажатия кнопки "Создать"
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            avianos = new Cruiser(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Black, Color.Cyan, true, true, true, true);
            avianos.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Draw();
        }
        /// Обработка нажатия кнопок управления
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    avianos.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    avianos.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    avianos.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    avianos.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
