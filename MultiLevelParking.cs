using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsAppCruiser
{
    class MultiLevelParking
    {
        /// Список с уровнями парковки 
        List<Parking<ITransport>> parkingStages;
        /// Сколько мест на каждом уровне 
        private const int countPlaces = 20;
        /// Ширина окна отрисовки
        /// </summary>
        private int pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int pictureHeight;
        public MultiLevelParking(int countStages, int pictureWidth, int pictureHeight)
        {
            parkingStages = new List<Parking<ITransport>>();
            for (int i = 0; i < countStages; ++i)
            {
                parkingStages.Add(new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        /// Индексатор 
        public Parking<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < parkingStages.Count)
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        //запись в файл
        public bool SaveData(string filename)
        {
            StreamWriter sw = new StreamWriter(filename);
            using (sw)
            {
                sw.WriteLine("CountLeveles:" + parkingStages.Count);
                foreach (var level in parkingStages)
                {
                    //Начинаем уровень
                    sw.Write("Level" + Environment.NewLine);
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var ship = level[i];
                        if (ship != null)
                        {
                            //если место не пустое
                            //Записываем тип мшаины
                            if (ship.GetType().Name == "Ship")
                            {
                                sw.Write(i + ":Ship:");
                            }
                            if (ship.GetType().Name == "Cruiser")
                            {
                                sw.Write(i + ":Cruiser:");
                            }
                            //Записываемые параметры
                            sw.Write(ship + Environment.NewLine);
                        }
                    }
                }
            }
            sw.Close();
            return true;
        }
        /// Загрузка информации из файла
        public bool LoadData(string filename)
        {
            Parking<ITransport> park = null;
            StreamReader sr = new StreamReader(filename);
            using (sr)
            {
                string line = sr.ReadLine();
                var strs = line.Split(':');
                if (strs[0] == "CountLeveles")
                {
                    int count = int.Parse(strs[1]);
                    parkingStages = new List<Parking<ITransport>>();
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        strs = line.Split(':');
                        if (line == "Level")
                        {
                            park = new Parking<ITransport>(countPlaces, pictureWidth, pictureHeight);
                            parkingStages.Add(park);
                        }
                        if ((strs.Length == 3) && (park != null))
                        {
                            var sss = strs[2].Split(';');
                            if (strs[1] == "Ship" && sss.Length == 3)
                            {
                                int n = park + new Ship(strs[2]);
                            }
                            else if (strs[1] == "Cruiser" && sss.Length == 9)
                            {
                                int n = park + new Cruiser(strs[2]);
                            }
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            sr.Close();
            return true;
        }
        public void clear()
        {
            parkingStages.Clear();
        }
        public int count()
        {
            return parkingStages.Count();
        }
    }
}
