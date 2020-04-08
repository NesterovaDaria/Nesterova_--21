using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAppCruiser
{
    public class Cruiser : Ship, IComparable<Cruiser>, IEquatable<Cruiser>
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
        /// 
       
        public Cruiser(int maxSpeed, float weight,Color mainColor, Color dopColor, Color dopColor1,
       bool orudie, bool truba, bool window, bool flag) :
            base(maxSpeed, weight, mainColor)
        {
            DopColor = dopColor;
            DopColor1 = dopColor1;
            Orudie = orudie;
            Truba = truba;
            Window = window;
            Flag = flag;

            Random rnd = new Random();

        }

        public Cruiser(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 9)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                DopColor1 = Color.FromName(strs[4]);
                Orudie = Convert.ToBoolean(strs[5]);
                Truba = Convert.ToBoolean(strs[6]);
                Window = Convert.ToBoolean(strs[7]);
                Flag = Convert.ToBoolean(strs[8]);
                
            }
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
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + DopColor1.Name + ";" +
           Orudie + ";" + Truba + ";" + Window + ";" + Flag;
        }
        public int CompareTo(Cruiser other)
        {
            var res = (this is Ship).CompareTo(other is Ship);
            if (res != 0)
            {
                return res;
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (DopColor1 != other.DopColor1)
            {
                DopColor1.Name.CompareTo(other.DopColor1.Name);
            }
            if (Orudie != other.Orudie)
            {
                return Orudie.CompareTo(other.Orudie);
            }
            if (Truba != other.Truba)
            {
                return Truba.CompareTo(other.Truba);
            }
            if (Window != other.Window)
            {
                return Window.CompareTo(other.Window);
            }
            if (Flag != other.Flag)
            {
                return Flag.CompareTo(other.Flag);
            }
            return 0;
        }
        public bool Equals(Cruiser other)
        {
            var res = (this as Ship).Equals(other as Ship);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (DopColor1 != other.DopColor1)
            {
                return false;
            }
                         
            if (Orudie != other.Orudie)
            {
                return false;
            }
            if (Truba != other.Truba)
            {
                return false;
            }
            if (Window != other.Window)
            {
                return false;
            }
            if (Flag != other.Flag)
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
            if (!(obj is Cruiser shepObj))
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
