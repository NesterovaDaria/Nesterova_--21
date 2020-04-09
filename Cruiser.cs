using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAppCruiser
{
    public class Cruiser
    {
        /// Левая координата отрисовки 
        private float _startPosX;
        /// Правая кооридната отрисовки
        private float _startPosY;
        /// Ширина окна отрисовки
        private int _pictureWidth;
        /// Высота окна отрисовки
        private int _pictureHeight;
        /// Ширина отрисовки
        private const int avWidth = 100;
        /// Ширина отрисовки 
        private const int avHeight = 60;
        /// Максимальная скорость
        public int MaxSpeed { private set; get; }
        /// Вес 
        public float Weight { private set; get; }
        /// Основной цвет 
        public Color MainColor { private set; get; }
        /// Дополнительный цвет
        public Color DopColor { private set; get; }
        /// Дополнительный цвет
        public Color DopColor1 { private set; get; }
        /// Признак наличия орудий
        public bool Orudie { private set; get; }
        /// Признак наличия труб
        public bool Truba { private set; get; }
        //признак наличия окон
        public bool Window { private set; get; }
        //Признак наличия флага
        public bool Flag { private set; get; }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="firctLift">Признак наличия переднего лифта</param>
        /// <param name="secondLift">Признак наличия заднего лифта</param>
        public Cruiser(int maxSpeed, float weight, Color mainColor, Color dopColor, Color dopColor1,
       bool orudie, bool truba, bool window, bool flag)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            DopColor1 = dopColor1;
            Orudie = orudie;
            Truba = truba;
            Window = window;
            Flag = flag;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public void DrawTube(Graphics g)
        {
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 100, _startPosY, 10, 20);
        }
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - avWidth)
                    {
                        _startPosX = _startPosX + step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0 + 15)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - avHeight + 35)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// Отрисовка 
        public void DrawCruiser(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            Brush brush = new SolidBrush(MainColor);
            //палуба
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 90, _startPosY);
            g.DrawLine(pen, _startPosX + 90, _startPosY, _startPosX + 72, _startPosY + 15);
            g.DrawLine(pen, _startPosX + 12, _startPosY + 15, _startPosX + 72, _startPosY + 15);
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 12, _startPosY + 15);
            //рубка
            g.DrawLine(pen, _startPosX + 54, _startPosY, _startPosX + 54, _startPosY - 12);
            g.DrawLine(pen, _startPosX + 54, _startPosY - 12, _startPosX + 66, _startPosY - 12);
            g.DrawLine(pen, _startPosX + 66, _startPosY - 12, _startPosX + 66, _startPosY);

            if (Orudie)
            {
                Brush spoiler = new SolidBrush(DopColor);
                g.FillRectangle(spoiler, _startPosX + 78, _startPosY - 5, 5, 5);
            }
            if (Truba)
            {
                Brush spoiler = new SolidBrush(DopColor);
                for (int i = 0; i < 3; i++)
                {
                    g.FillRectangle(spoiler, _startPosX + 20 + (10 * i), _startPosY - 20, 5, 20);
                }
            }
            if (Window)
            {
               
                for (int i = 0; i < 3; i++)
                {
                    g.DrawEllipse(pen, _startPosX + 25 + (10 * i), _startPosY + 3, 5, 5);
                }

            }

            if (Flag)
            {
                Brush spoiler = new SolidBrush(DopColor1);
                Pen fp = new Pen(DopColor);
                g.DrawLine(fp, _startPosX + 6, _startPosY, _startPosX + 6, _startPosY - 18);
                g.FillRectangle(spoiler, _startPosX - 6, _startPosY - 18, 12, 9);
            }


        }
    }
}
