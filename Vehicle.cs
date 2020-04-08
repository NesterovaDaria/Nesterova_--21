using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCruiser
{
    public abstract class Vehicle : ITransport
    {
        // Левая координата отрисовки
        protected float _startPosX;
        // Правая кооридната отрисовки
        protected float _startPosY;
        // Ширина окна отрисовки
        protected int _pictureWidth;
        //Высота окна отрисовки
        protected int _pictureHeight;
        // Максимальная скорость
        public int MaxSpeed { protected set; get; }
        // Вес 
        public float Weight { protected set; get; }
        // Основной цвет 
        public Color MainColor { protected set; get; }
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        public abstract void Draw(Graphics g);
        public abstract void MoveTransport(Direction direction);
        public void SetMainColor(Color color)
        {
            MainColor = color;
        }
       // public abstract void DrawShep(Graphics g);
       // public abstract void MoveTransport(Direction direction);
        public String GetMainColor()
        {
            return MainColor.Name;
        }
    }
}
