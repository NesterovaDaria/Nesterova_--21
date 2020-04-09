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
        private ITransport _ship;
        public FormCruiser()
        {
            InitializeComponent();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Graphics gr = Graphics.FromImage(bmp);
            _ship.Draw(gr);
            pictureBoxCruiser.Image = bmp;
        }

        private void CreateShip_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _ship = new Ship(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue);
            _ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Draw();
        }
        private void CreateCruiser_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _ship = new Cruiser(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Blue, Color.Black, Color.Yellow, true, true, true, true);
            _ship.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxCruiser.Width, pictureBoxCruiser.Height);
            Draw();
        }
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    _ship.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    _ship.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    _ship.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    _ship.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }
    }
}
