﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Класс с авто-свойствами для таблицы 1 "акты эвакуации"
    public class ElementsTab1
    {
        public string GPS { get; set; }
        public string TypeViolation { get; set; }
        public string CarNumber { get; set; }
        public string CarType { get; set; }
        public ElementsTab2 Street { get; set; }
        public ElementsTab3 Parking { get; set; }
    }

    //Класс с авто-свойствами для таблицы 2 "улицы"
    public class ElementsTab2
    {
        public string StreetName { get; set; }
        public string StreetLength { get; set; }
        //public int Link { get; set; } = -1;         
    }

    //Класс с авто-свойствами для таблицы 3 "автостоянки"
    public class ElementsTab3
    {
        public string ParkingName { get; set; }
        public string ParkingAdress { get; set; }
        public string ParkingNumber { get; set; }
        //public int Link { get; set; } = -1;
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

        //Метод для добавления ссылки на улицу в таблицу 1
        public void AddStreet(int ind1, int ind2)
        {
            Tab1List[ind1].Street = Tab2List[ind2];
        }

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

        //Метод, возвращающий количество элементов в списке 2
        public int CountTab2()
        {
            return Tab2List.Count;
        }

        //Метод, возвращающий количество элементов в списке 3
        public int CountTab3()
        {
            return Tab3List.Count;
        }

        //Метод, возвращающий количество элементов в списке 1
        public int CountTab1()
        {
            return Tab1List.Count;
        }

        //Метод, возвращающий название улицы
        public string OutPutSt(int i)
        {
            if (CountTab2() > i && Tab2List[i] != null)
            {
                return Tab2List[i].StreetName;
            }
            else { return " "; }
        }

        //Метод, возвращающий длину улицы
        public string OutPutStl(int i)
        {
            if (CountTab2() > i && Tab2List[i] != null)
            {
                return Tab2List[i].StreetLength;
            }
            else { return " "; }

        }

        //Метод, возвращающий название автостоянки
        public string OutPutPrkname(int i)
        {
            if (CountTab3() > i && Tab3List[i] != null)
            {
                return Tab3List[i].ParkingName;
            }
            else { return " "; }
        }

        //Метод, возвращающий адрес автостоянки
        public string OutPutPrkadress(int i)
        {
            if (CountTab3() > i && Tab3List[i] != null)
            {
                return Tab3List[i].ParkingAdress;
            }
            else { return " "; }
        }

        //Метод, возвращающий телефон автостоянки
        public string OutPutPrknumber(int i)
        {
            if (CountTab3() > i && Tab3List[i] != null)
            {
                return Tab3List[i].ParkingNumber;
            }
            else { return " "; }
        }

        //Метод, возвращающий GPS-координаты
        public string OutPutGPS(int i)
        {
            if (CountTab1() > i && Tab1List[i] != null)
            {
                return Tab1List[i].GPS;
            }
            else { return " "; }
        }

        //Метод, возвращающий тип нарушения
        public string OutPutTypeVio(int i)
        {
            if (CountTab1() > i && Tab1List[i] != null)
            {
                return Tab1List[i].TypeViolation;
            }
            else { return " "; }
        }

        //Метод, возвращающий номер автомобиля
        public string OutPutCarNum(int i)
        {
            if (CountTab1() > i && Tab1List[i] != null)
            {
                return Tab1List[i].CarNumber;
            }
            else { return " "; }
        }

        //Метод, возвращающий тип автомобиля
        public string OutPutCarType(int i)
        {
            if (CountTab1() > i && Tab1List[i] != null)
            {
                return Tab1List[i].CarType;
            }
            else { return " "; }
        }

        //Метод, возвращающий улицу из таблицы 1
        public string OutputStreetTab1(int i)
        {
            if (Tab1List[i].Street.StreetName != null)
            {
                return Tab1List[i].Street.StreetName;
            }
            else { return " "; }
        }

        //Метод, возвращающий автостоянку из таблицы 1
        public string OutputParkingTab1(int i)
        {
            if (Tab1List[i].Street != null)
            {
                return Tab1List[i].Parking.ParkingName;
            }
            else { return " "; }
        }

        //Метод создания новых элементов в списке 1
        public void AddElementTab1()
        {
            Tab1List.Add(new ElementsTab1());
        }

        //Метод создания новых элементов в списке 1
        public void AddElementTab2()
        {
            Tab2List.Add(new ElementsTab2());
        }

        //Метод создания новых элементов в списке 1
        public void AddElementTab3()
        {
            Tab3List.Add(new ElementsTab3());
        }


        //Метод удаления элементов по индексам из списка 1
        public void DeleteElementTab1(int i)
        {
            Tab1List.RemoveAt(i);
        }

        //Метод удаления элементов по индексам из списка 2
        public void DeleteElementTab2(int i)
        {
            //int j = Tab2List[i].Link;
            //if (Tab2List[i].Link != -1)
            // {
            //  Tab1List[j].Street.StreetLength = " ";
            //  Tab1List[j].Street.StreetName = " ";                
            // }
            Tab2List.RemoveAt(i);

        }

        //Метод удаления элементов по индексам из списка 3
        public void DeleteElementTab3(int i)
        {
            // int j = Tab3List[i].Link;
            // if (Tab3List[i].Link != -1)
            ////{
            //   Tab1List[j].Parking.ParkingAdress = " ";
            //    Tab1List[j].Parking.ParkingName = " ";
            //    Tab1List[j].Parking.ParkingNumber = " ";               
            // }
            Tab3List.RemoveAt(i);
        }

        //Метод, возвращающий элемент списка таблицы 2 УЛИЦЫ
        public ElementsTab2 ReturnElementTab2(int i)
        {
            return Tab2List[i];
        }

        //Метод, возвращающий элемент из списка таблицы 3 АВТОСТОЯНКИ
        public ElementsTab3 ReturnElementTab3(int i)
        {
            return Tab3List[i];
        }

        //Метод проверки на уже существующую улицу
        public bool IsAlreadyExistsStreet(string streetname)
        {
            //Объявление переменной для вывода результата проверки на уже существующую улицу
            bool result = true;

            //Основной цикл перебора элементов
            foreach (ElementsTab2 Tab2 in Tab2List)
            {
                if (streetname == Tab2.StreetName)
                {
                    result = false;
                }
            }

            return result;
        }

        //Метод проверки на уже существующую автостоянку
        public bool IsAlreadyExistsParking(string prkname)
        {
            //Объявление переменной для вывода результата проверки 
            bool result = true;

            //основной цикл перебора элементов
            foreach (ElementsTab3 Tab3 in Tab3List)
            {
                if (prkname == Tab3.ParkingName)
                {
                    result = false;
                }
            }

            return result;
        }

        //Метод для добавления gps-координат в список
        public void Addgps(string gps, int ind)
        {
            Tab1List[ind].GPS = gps;
        }

        //Метод для добавления типа нарушения в список
        public void AddTypeVio(string tpvio, int ind)
        {
            Tab1List[ind].TypeViolation = tpvio;
        }

        //Метод для добавления номера автомобиля в список
        public void AddCarNumber(string carnum, int ind)
        {
            Tab1List[ind].CarNumber = carnum;
        }

        //Метод для добавления типа автомобиля в список
        public void AddTypeOfCar(string cartp, int ind)
        {
            Tab1List[ind].CarType = cartp;
        }

        //Метод добавления ссылки на элемент таблицы 2
        public void AddLinkTab2(int i)
        {
            int count = CountTab1() - 1;
            Tab1List[count].Street = Tab2List[i];
            //Tab2List[i].Link = count;
        }

        //Метод добавления ссылки на элемент таблицы 3
        public void AddlinkTab3(int i)
        {
            int count = CountTab1() - 1;
            Tab1List[count].Parking = Tab3List[i];
            //Tab3List[i].Link = count;
        }

        //Метод вывода названия улицы из таблицы 1
        public string OutputStreetNameTab1(int ind)
        {
            return Tab1List[ind].Street.StreetName;
        }

        //Метод вывода длины улицы из таблицы 1
        public string OutputStreetLengthsTab1(int ind)
        {
            return Tab1List[ind].Street.StreetLength;
        }

        //Метод вывода названия автостоянки из таблицы 1
        public string OutputParkingNameTab1(int ind)
        {
            return Tab1List[ind].Parking.ParkingName;
        }

        //Метод вывода адреса автостоянки из таблицы 1
        public string OutputParkingAdressTab1(int ind)
        {
            return Tab1List[ind].Parking.ParkingAdress;
        }

        //Метод вывода номера автостоянки из таблицы 1
        public string OutputParkingNumberTab1(int ind)
        {
            return Tab1List[ind].Parking.ParkingNumber;
        }

        //Метод редактирования элементов в таблице 2
        public void EditTab2(string strname, string strlen, int ind)
        {
            Tab2List[ind].StreetName = strname;
            Tab2List[ind].StreetLength = strlen;
        }

        //Метод редактирования элементов в таблице 3
        public void EditTab3(string prkname, string prkadress, string prknumber, int ind)
        {
            Tab3List[ind].ParkingName = prkname;
            Tab3List[ind].ParkingAdress = prkadress;
            Tab3List[ind].ParkingNumber = prknumber;
        }

        //Метод редактирования элементов таблицы 3
        public void EditTab1(string GPS, string tpvio, string carnum, string cartp, string streetname, string streetlen, string parkingname, string parkingadress, string parkingnumber, int ind, int ind1, int ind2)
        {
            ind--;
            Tab1List[ind].GPS = GPS;
            Tab1List[ind].TypeViolation = tpvio;
            Tab1List[ind].CarNumber = carnum;
            Tab1List[ind].CarType = cartp;
            Tab1List[ind].Street = Tab2List[ind1];
            Tab1List[ind].Parking = Tab3List[ind2];
            //Tab2List[ind1].Link = ind;
            //Tab3List[ind2].Link = ind;
        }

        //Метод сортировки элементов таблицы улиц по названию улицы А-Я
        public void SortStreetsNameA()
        {
            //ДОДЕЛАТЬ
            int n = Tab2List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (true)
                    {
                        ElementsTab2 p = Tab2List[i];
                        Tab2List[i] = Tab2List[j];
                        Tab2List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки элементов таблицы улиц по названию улицы Я-А
        public void SortStreetsNameZ()
        {
            //ДОДЕЛАТЬ
            int n = Tab2List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (true)
                    {
                        ElementsTab2 p = Tab2List[i];
                        Tab2List[i] = Tab2List[j];
                        Tab2List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки элементов таблицы улиц по длине улицы по возрастанию
        public void SortStreetsLengthsIncrease()
        {
            int n = Tab2List.Count-1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i+1; j < n+1; j++)
                {
                    if (int.Parse(Tab2List[j].StreetLength) < int.Parse(Tab2List[i].StreetLength))
                    {
                        ElementsTab2 p = Tab2List[i];
                        Tab2List[i] = Tab2List[j];
                        Tab2List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки элементов таблицы улиц по длине улицы по убыванию
        public void SortStreetsLengthsDecrease()
        {
            int n = Tab2List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (int.Parse(Tab2List[j].StreetLength) > int.Parse(Tab2List[i].StreetLength))
                    {
                        ElementsTab2 p = Tab2List[i];
                        Tab2List[i] = Tab2List[j];
                        Tab2List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки элементов таблицы автостоянок по названию автостоянки А-Я
        public void SortParkingsNameA()
        {

        }

        //Метод сортировки элементов таблицы автостоянок по названию автостоянки Я-А
        public void SortParkingsNameZ()
        {

        }

        //Метод сортировки элементов таблицы автостоянок по адресу автостоянки А-Я
        public void SortParkingsAdressA()
        {

        }

        //Метод сортировки элементов таблицы автостоянок по адресу автостоянки Я-А
        public void SortParkingsAdressZ()
        {

        }

        //Метод сортировки таблицы актов эвакуации по названию улицы А-Я
        public void SortActsStreetnameA()
        {

        }

        //Метод сортировки таблицы актов эвакуации по названию улицы Я-А
        public void SortActsStreetnameZ()
        {

        }

        //Метод сортировки таблицы актов эвакуации по названию автостоянки А-Я
        public void SortActsParkingnameA()
        {

        }

        //Метод сортировки таблицы актов эвакуации по названию автостоянки Я-А
        public void SortActsParkingnameZ()
        {

        }

        //Метод поиска улицы
        public void SearchStreet(string streetname)
        {
            int p = 0;
            Console.WriteLine("║" + new string('─', 3) + "─" + new string('─', 52) + "╥" + new string('─', 52) + "║");
            Console.WriteLine("║" + "   " + " " + new string(' ', 19) + "Название улицы" + new string(' ', 19) + "║" + new string(' ', 21) + "Длина улицы" + new string(' ', 20) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "─" + new string('─', 52) + "╫" + new string('─', 52) + "╢");
            foreach (var street in Tab2List)
            {
                if (street.StreetName.Contains(streetname))
                {
                    p = 55 - street.StreetName.Length;
                    Console.Write("║ " + street.StreetName + new string(' ', p) + "║ ");
                    p = 51 - street.StreetLength.Length;
                    Console.Write(street.StreetLength + new string(' ', p));
                    Console.WriteLine("║");
                    Console.WriteLine("╟" + "────" + new string('─', 52) + "╫" + new string('─', 52) + "╢");
                }
            }
        }

        //Метод поиска автостоянки
        public void SearchParking(string parkingname)
        {
            int p = 0;
            Console.WriteLine("║" + new string('─', 32) + "╥" + new string('─', 52) + "╥" + new string('─', 24) + "║");
            Console.WriteLine("║" + new string(' ', 6) + "Название автостоянки" + new string(' ', 6) + "║" + new string(' ', 18) + "Адрес автостоянки" + new string(' ', 17) + "║" + new string(' ', 2) + "Телефон автостоянки" + new string(' ', 3) + "║");
            Console.WriteLine("║" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
            foreach (var parking in Tab3List)
            {
                if (parking.ParkingName.Contains(parkingname) || parking.ParkingAdress.Contains(parkingname))
                {
                    p = 31 - parking.ParkingName.Length;
                    Console.Write("║ " + parking.ParkingName + new string(' ', p) + "║ ");
                    p = 51 - parking.ParkingAdress.Length;
                    Console.Write(parking.ParkingAdress + new string(' ', p) + "║ ");
                    p = 23 - parking.ParkingNumber.Length;
                    Console.Write(parking.ParkingNumber + new string(' ', p));
                    Console.WriteLine("║");
                    Console.WriteLine("║" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
                }
            }
        }

        //Метод поиска актов эвакуации
        public void SearchAct(string actname)
        {
            int p = 0;
            Console.WriteLine("╟" + new string('─', 52) + "╥" + new string('─', 52) + "╥" + new string('─', 32) + "╥" + new string('─', 43) + "╥" + new string('─', 12) + "╥" + new string('─', 30) + "╢");
            Console.WriteLine("║" + new string(' ', 23) + "Улица" + new string(' ', 24) + "║" + new string(' ', 20) + "Автостоянка" + new string(' ', 21) + "║" + new string(' ', 9) + "GPS-координаты" + new string(' ', 9) + "║" + new string(' ', 15) + "Тип нарушения" + new string(' ', 15) + "║" + new string(' ', 0) + "Номер машины" + new string(' ', 0) + "║" + new string(' ', 8) + "Тип автомобиля" + new string(' ', 8) + "║");
            Console.WriteLine("╟" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            foreach (var act in Tab1List)
            {
                if (act.Street.StreetName.Contains(actname) || act.Parking.ParkingName.Contains(actname) || act.GPS.Contains(actname))
                {
                    p = 51 - act.Street.StreetName.Length;
                    Console.Write("║ " + act.Street.StreetName + new string(' ', p) + "║ ");
                    p = 51 - act.Parking.ParkingName.Length;
                    Console.Write(act.Parking.ParkingName + new string(' ', p) + "║ ");
                    p = 31 - act.GPS.Length;
                    Console.Write(act.GPS + new string(' ', p) + "║ ");
                    p = 42 - act.TypeViolation.Length;
                    Console.Write(act.TypeViolation + new string(' ', p) + "║ ");
                    p = 11 - act.CarNumber.Length;
                    Console.Write(act.CarNumber + new string(' ', p) + "║ ");
                    p = 29 - act.CarType.Length;
                    Console.WriteLine(act.CarType + new string(' ', p) + "║");
                    Console.WriteLine("╟" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
                }
            }
        }
    }



}

