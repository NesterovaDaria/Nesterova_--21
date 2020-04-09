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
    public partial class FormParking : Form
    {
        Parking<ITransport> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<ITransport>(15, pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }
        private void buttonSetShip_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(200, 1150, dialog.Color);
                int place = parking + ship;
                Draw();
            }
        }
        private void buttonSetCruiser_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new Cruiser(100, 1000, dialog.Color, dialogDop.Color, dialogDop.Color, true, true, true, true);
                    int place = parking + ship;
                    Draw();
                }
            }
        }
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var ship = parking - Convert.ToInt32(maskedTextBox.Text);
                if (ship != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    ship.SetPosition(15, 15, pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                    ship.Draw(gr);
                    pictureBoxTakeShip.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                    pictureBoxTakeShip.Image = bmp;
                }
                Draw();
            }
        }
    }
}
