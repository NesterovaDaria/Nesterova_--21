using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCruiser
{
    public class Ship : Vehicle
    {
        /// Ширина отрисовки автомобиля
        protected const int avWidth = 100;
        /// Ширина отрисовки автомобиля
        protected const int avHeight = 60;
        // Дополнительный цвет
       
        /// Конструктор
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Ship(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        public override void MoveTransport(Direction direction)
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
        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(MainColor);
            //палуба
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 90, _startPosY);
            g.DrawLine(pen, _startPosX + 90, _startPosY, _startPosX + 72, _startPosY + 15);
            g.DrawLine(pen, _startPosX + 12, _startPosY + 15, _startPosX + 72, _startPosY + 15);
            g.DrawLine(pen, _startPosX, _startPosY, _startPosX + 12, _startPosY + 15);
            //рубка
            g.DrawLine(pen, _startPosX + 54, _startPosY, _startPosX + 54, _startPosY - 12);
            g.DrawLine(pen, _startPosX + 54, _startPosY - 12, _startPosX + 66, _startPosY - 12);
            g.DrawLine(pen, _startPosX + 66, _startPosY - 12, _startPosX + 66, _startPosY);
        }
    }
}
