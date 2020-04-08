using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCruiser
{
    public class Ship : Vehicle, IComparable<Ship>, IEquatable<Ship>
    {
        /// Ширина отрисовки автомобиля
        protected const int avWidth = 100;
        /// Ширина отрисовки автомобиля
        protected const int avHeight = 60;
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

        // Конструктор
        //info-Информация по объекту
        public Ship(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
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
        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name;
        }
        public int CompareTo(Ship other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            return 0;
        }
        /// Метод интерфейса IEquatable для класса Ship
        public bool Equals(Ship other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
        /// Перегрузка метода от object
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Ship shepObj))
            {
                return false;
            }
            else
            {
                return Equals(shepObj);
            }
        }
        /// Перегрузка метода от object
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
