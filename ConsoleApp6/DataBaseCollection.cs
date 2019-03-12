﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    public class ElementsTab1
    {
        public string GPS { get; set; }
        public string TypeViolation { get; set; }
        public string CarNumber { get; set; }
        public string CarType { get; set; }
    }
    public class ElementsTab2
    {
        public string StreetName { get; set; }
        public string StreetLength { get; set; }
    }

    public class ElementsTab3
    {
        public string ParkingName { get; set; }
        public string ParkingAdress { get; set; }
        public string ParkingNumber { get; set; }
    }

    public class Data
    {
        //Создание списка таблицы 1
        static List<ElementsTab1> Tab1List = new List<ElementsTab1>(100);

        //Создание списка таблицы 2
        static List<ElementsTab2> Tab2List = new List<ElementsTab2>(100);

        //Создание списка таблицы 3
        static List<ElementsTab3> Tab3List = new List<ElementsTab3>(100);
        
        //Поле имени файла
        private static string filename;

        //Свойство поля имени файла
        public string FileName
        {
            get
            {
                return filename;
            }
            set
            {
                filename = value;
            }
        }

        //Метод, возвращающий длину строки имений файла
        public int FilenameLength()
        {
            return filename.Length;
        }

        //string tpvio;
        //string gps;
        //string carnum;
        //string cartp;
        //string strname;
        //double strlength;
        //string prkname;
        //string prkadress;
        //string prknumber;

            //Метод для ввода названия улицы в список
        public void AddElementStrname(string sname, int ind)
        {
            Tab2List[ind].StreetName = sname;
        }

        //Метод для ввода длины улицы в список
        public void AddElementStlength(string slength, int ind)
        {
            Tab2List[ind].StreetLength = slength;
        }

        //Метод для ввода типа нарушения в список
        public void AddElementtpvio(string tpvio, int ind)
        {
            Tab1List[ind].TypeViolation = tpvio;
        }

        //Метод для ввода GPS-координат в список
        public void AddElementgps(string gp, int ind)
        {
            Tab1List[ind].GPS = gp;
        }

        //Метод для ввода типа автомобиля в список
        public void Addcartype(string crtp, int ind)
        {
            Tab1List[ind].CarType = crtp;
        }

        //Метод для ввода номера автомобиля в список
        public void Addcarnumber(string crnum, int ind)
        {
            Tab1List[ind].CarNumber = crnum;
        }

        //Метод для ввода адреса автостоянки в список
        public void Addparkingadress(string prkadress, int ind)
        {
            Tab3List[ind].ParkingAdress = prkadress;
        }

        //Метод для ввода названия автостоянки в список
        public void Addparkingname(string prkname, int ind)
        {
            Tab3List[ind].ParkingName = prkname;
        }

        //Метод для ввода телефона автостоянки в список
        public void Addparkingnumber(string prknum, int ind)
        {
            Tab3List[ind].ParkingNumber = prknum;
        }

        //Метод, возвращающий количество элементов в списке
        public int Count()
        {
            return Tab2List.Count;
        }

        //Метод, возвращающий название улицы
        public string OutPutSt(int i)
        {
            return Tab2List[i].StreetName; 
        }

        //Метод, возвращающий длину улицы
        public string OutPutStl(int i)
        {
            return Tab2List[i].StreetLength;
        }

        //Метод, возвращающий название автостоянки
        public string OutPutPrkname(int i)
        {
            return Tab3List[i].ParkingName;
        }

        //Метод, возвращающий адрес автостоянки
        public string OutPutPrkadress(int i)
        {
            return Tab3List[i].ParkingAdress;
        }

        //Метод, возвращающий телефон автостоянки
        public string OutPutPrknumber(int i)
        {
            return Tab3List[i].ParkingNumber;
        }

        //Метод, возвращающий GPS-координаты
        public string OutPutGPS(int i)
        {
            return Tab1List[i].GPS;
        }

        //Метод, возвращающий тип нарушения
        public string OutPutTypeVio(int i)
        {
            return Tab1List[i].TypeViolation;
        }

        //Метод, возвращающий номер автомобиля
        public string OutPutCarNum(int i)
        {
            return Tab1List[i].CarNumber;
        }

        //Метод, возвращающий тип автомобиля
        public string OutPutCarType(int i)
        {
            return Tab1List[i].CarType;
        }

        //Метод создания новых элементов в списках
        public void AddElement()
        {
            Tab1List.Add(new ElementsTab1());
            Tab2List.Add(new ElementsTab2());
            Tab3List.Add(new ElementsTab3());
        }

        //Метод удаления элементов по индексам
        public void DeleteElement(int i)
        {
            Tab1List.RemoveAt(i);
            Tab2List.RemoveAt(i);
            Tab3List.RemoveAt(i);
        }

    }
   

}

