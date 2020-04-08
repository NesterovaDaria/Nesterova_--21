using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAppCruiser
{
    public class Cruiser : Ship
    {
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
       bool orudie, bool truba, bool window, bool flag) :
            base(maxSpeed, weight, mainColor)
        {
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
        
        /// Отрисовка 
        public override void Draw(Graphics g)
        {
            //переопределение
            base.Draw(g);
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
                 Pen pen = new Pen(DopColor);
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
