using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppCruiser
{
    public class Parking<T>:  IEnumerator<T>, IEnumerable<T>, IComparable<Parking<T>> where T : class, ITransport
    {
        private Dictionary<int, T> _places;
        private int _maxCount;
        private int PictureWidth { get; set; }
        private int PictureHeight { get; set; }
        private const int _placeSizeWidth = 210;
        private const int _placeSizeHeight = 55;
        /// Текущий элемент для вывода через IEnumerator (будет обращаться по своему 
        /// индексу к ключу словаря, по которму будет возвращаться запись)
        private int _currentIndex;

        /// Получить порядковое место на парковке
        public int GetKey
        {
            get
            {
                return _places.Keys.ToList()[_currentIndex];
            }
        }
        public Parking(int sizes, int pictureWidth, int pictureHeight)
        {
            _maxCount = sizes;
            _places = new Dictionary<int, T>();
            PictureWidth = pictureWidth;
            PictureHeight = pictureHeight;
        }
        public static int operator +(Parking<T> p, T ship)
        {
            if (p._places.Count == p._maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (p._places.ContainsValue(ship))
            {
                throw new ParkingAlreadyHaveException();
            }
            for (int i = 0; i < p._maxCount; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    p._places.Add(i, ship);
                    p._places[i].SetPosition(10 + i / 5 * _placeSizeWidth + 5, i % 5 * _placeSizeHeight + 30, p.PictureWidth, p.PictureHeight);
                    return i;
                }
            }
            return -1;
        }
        public static T operator -(Parking<T> p, int index)
        {
            if (!p.CheckFreePlace(index))
            {
                T shep = p._places[index];
                p._places.Remove(index);
                return shep;
            }
            throw new ParkingNotFoundException(index);
        }
        private bool CheckFreePlace(int index)
        {
            return !_places.ContainsKey(index);
        }
        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = _places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                _places[keys[i]].Draw(g);
            }
        }
        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            //границы праковки
            g.DrawRectangle(pen, 0, 0, (_maxCount / 5) * _placeSizeWidth, 480);
            for (int i = 0; i < _maxCount / 5; i++)
            {
                //отрисовываем, по 5 мест на линии 
                for (int j = 0; j < 6; ++j)
                {
                    //линия рамзетки места 
                    g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight,
                        i * _placeSizeWidth + 100, j * _placeSizeHeight);
                }
                g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, 400);
            }
        }
        /// Индексатор
        public T this[int ind]
        {
            get
            {
                if (_places.ContainsKey(ind))
                {
                    return _places[ind];
                }
                throw new ParkingNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    _places.Add(ind, value);
                    _places[ind].SetPosition(5 + ind / 5 * _placeSizeWidth + 5, ind % 5
                    * _placeSizeHeight + 15, PictureWidth, PictureHeight);
                }
                else
                {
                    throw new ParkingOccupiedPlaceException(ind);
                }
            }
        }
        /// Метод интерфейса IEnumerator для получения текущего элемента
        public T Current
        {
            get
            {
                return _places[_places.Keys.ToList()[_currentIndex]];
            }
        }
        /// Метод интерфейса IEnumerator для получения текущего элемента
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        /// Метод интерфейса IEnumerator, вызываемый при удалении объекта
        public void Dispose()
        {

        }
        /// Метод интерфейса IEnumerator для перехода к следующему элементу или началу коллекции
        public bool MoveNext()
        {
            if (_currentIndex + 1 >= _places.Count)
            {
                Reset();
                return false;
            }
            _currentIndex++;
            return true;
        }
        /// Метод интерфейса IEnumerator для сброса и возврата к началу коллекции
        public void Reset()
        {
            _currentIndex = -1;
        }
        /// Метод интерфейса IEnumerable
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        /// Метод интерфейса IEnumerable
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /// Метод интерфейса IComparable
        public int CompareTo(Parking<T> other)
        {
            if (_places.Count > other._places.Count)
            {
                return -1;
            }
            else if (_places.Count < other._places.Count)
            {
                return 1;
            }
            else if (_places.Count > 0)
            {
                var thisKeys = _places.Keys.ToList();
                var otherKeys = other._places.Keys.ToList();
                for (int i = 0; i < _places.Count; ++i)
                {
                    if (_places[thisKeys[i]] is Ship && other._places[thisKeys[i]] is
                   Cruiser)
                    {
                        return 1;
                    }
                    if (_places[thisKeys[i]] is Cruiser && other._places[thisKeys[i]]
                    is Ship)
                    {
                        return -1;
                    }
                    if (_places[thisKeys[i]] is Ship && other._places[thisKeys[i]] is
                    Ship)
                    {
                        return (_places[thisKeys[i]] is
                       Ship).CompareTo(other._places[thisKeys[i]] is Ship);
                    }
                    if (_places[thisKeys[i]] is Cruiser && other._places[thisKeys[i]]
                    is Cruiser)
                    {
                        return (_places[thisKeys[i]] is
                       Cruiser).CompareTo(other._places[thisKeys[i]] is Cruiser);
                    }
                }
            }
            return 0;
        }
    }
}
