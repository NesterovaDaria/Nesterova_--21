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
    public partial class FormShipConfig : Form
    {
        ITransport Ship = null;
        private event ShipDelegate eventAddShip;
        public FormShipConfig()
        {
            InitializeComponent();
            buttonnCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void Draw()
        {
            if (Ship != null)
            {
                
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                Ship.SetPosition(15, 25, pictureBox.Width, pictureBox.Height);
                Ship.SetMainColor(Color.FromName((Ship as ITransport).GetMainColor()));
                Ship.Draw(gr);
                pictureBox.Image = bmp;
            }
        }
        public void AddEvent(ShipDelegate ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new ShipDelegate(ev);
            }
            else
            {
                eventAddShip += ev;
            }
        }
        private void panelShip_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void panelShip_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Корабль":
                    Ship = new Ship(100, 500, Color.White);
                    break;
                case "Крейсер":
                    Ship = new Cruiser(100, 500, Color.White, Color.Black, Color.Black, true, true,
                   true, true);
                    break;
            }
            Draw();
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
           DragDropEffects.Move | DragDropEffects.Copy);
        }
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// Принимаем основной цвет
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (Ship != null)
            {

                Ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }

        /// Принимаем дополнительный цвет
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (Ship != null)
            {
                if (Ship is Cruiser)
                {
                    (Ship as
                   Cruiser).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }
        private void labelCruiser_MouseDown(object sender, MouseEventArgs e)
        {
            labelCruiser.DoDragDrop(labelCruiser.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(Ship);
            Close();
        }

        private void lablelShip_MouseDown(object sender, MouseEventArgs e)
        {
            labelShip.DoDragDrop(labelShip.Text, DragDropEffects.Move |
            DragDropEffects.Copy);
        }

    }
}
