using NLog;
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
        MultiLevelParking parking;
        /// Форма для добавления
        FormShipConfig form;
        // Количество уровней-парковок 
        private const int countLevel = 5;
        /// Логгер
        private Logger logger;
        public FormParking()
        {
            InitializeComponent();
            logger = LogManager.GetCurrentClassLogger();
            parking = new MultiLevelParking(countLevel, pictureBoxParking.Width, pictureBoxParking.Height);
            //заполнение listBox
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
        }
        
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                //если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран
                //и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parking[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }
        private void buttonTakeShip_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox.Text != "")
                {
                    try
                    {
                        var shep = parking[listBoxLevels.SelectedIndex] - Convert.ToInt32(maskedTextBox.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        shep.SetPosition(15, 15, pictureBoxTakeShip.Width, pictureBoxTakeShip.Height);
                        shep.Draw(gr);
                        pictureBoxTakeShip.Image = bmp;
                        logger.Info("Изъят корабль " + shep.ToString() + " с места " + maskedTextBox.Text);
                        Draw();
                    }
                    catch (ParkingNotFoundException ex)
                    {
                        MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        logger.Error("Не найден корабль по месту " + maskedTextBox.Text);
                        Bitmap bmp = new Bitmap(pictureBoxTakeShip.Width,
                        pictureBoxTakeShip.Height);
                        pictureBoxTakeShip.Image = bmp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Неизвестная ошибка",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        logger.Error("Неизвестная ошибка");
                    }
                }
            }
        }
        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }
        private void buttonSet_Click(object sender, EventArgs e)
        {
            form = new FormShipConfig();
            form.AddEvent(AddShip);
            form.Show();
        }
        /// Метод добавления 
        private void AddShip(ITransport ship)
        {
            if (ship != null && listBoxLevels.SelectedIndex > -1)
            {
                try
                {
                    int place = parking[listBoxLevels.SelectedIndex] + ship;
                    logger.Info("Добавлен корабль " + ship.ToString() + " на место " + place);
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Error("Переполнение");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
                }
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    parking.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (ParkingOccupiedPlaceException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                    logger.Error("Занятое место");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Error("Неизвестная ошибка");
                }
                Draw();
            }
        }
    }
}
