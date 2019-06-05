using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public int LinkStreet { get; set; } = -1;
        public int LinkParking { get; set; } = -1;
    }

    //Класс с авто-свойствами для таблицы 2 "улицы"
    public class ElementsTab2
    {
        public string StreetName { get; set; }
        public string StreetLength { get; set; }
    }

    //Класс с авто-свойствами для таблицы 3 "автостоянки"
    public class ElementsTab3
    {
        public string ParkingName { get; set; }
        public string ParkingAdress { get; set; }
        public string ParkingNumber { get; set; }
    }

    public class Data
    {
        //Создание списка таблицы 1
        public static List<ElementsTab1> Tab1List = new List<ElementsTab1>(100);

        //Создание списка таблицы 2
        public static List<ElementsTab2> Tab2List = new List<ElementsTab2>(100);

        //Создание списка таблицы 3
        public static List<ElementsTab3> Tab3List = new List<ElementsTab3>(100);

        //Создание списка для поиска таблицы 1
        public static List<ElementsTab1> SearchTab1 = new List<ElementsTab1>(100);

        //Создание списка для поиска улиц
        public static List<ElementsTab2> SearchStreetTab = new List<ElementsTab2>(100);

        //Метод добавления в список поиска
        public void AddElementsToSearchList(ElementsTab1 act)
        {
            SearchTab1.Add(act);
        }

        //Удаление из списка поиска таблицы 1
        public void RemoveSearchList1()
        {
            for (int j = 0; j < SearchTab1.Count(); j++)
            {
                SearchTab1.RemoveAt(j);
            }
        }

        public int MoreInfoStreet(int index)
        {
            string streetname = "     ";
            int indexstreet = 0;
            if (SearchTab1.Count > index)
            {
                streetname = SearchTab1[index].Street.StreetName;
                for (int i = 0; i < Tab2List.Count(); i++)
                {
                    if (Tab2List[i].StreetName == streetname)
                    {
                        indexstreet = i;
                    }
                }

                return indexstreet;
            } else { return -1; }
        }

        public int MoreInfoParking(int index)
        {
            string parkingname = "        ";
            int indexparking = 0;
            if (SearchTab1.Count > index)
            {
                parkingname = SearchTab1[index].Parking.ParkingName;
                for(int i = 0; i < Tab3List.Count(); i++)
                {
                    if (Tab3List[i].ParkingName == parkingname)
                    {
                        indexparking = i;
                    }
                }
                return indexparking;
            }else { return -1; }
        }

        //Поле имени файла
        private static string filename = " ";

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

        //Метод для добавления ссылки на автостоянку в таблицу 1
        public void AddParking(int ind1, int ind2)
        {
            Tab1List[ind1].Parking = Tab3List[ind2];
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
            if (CountTab2() > i && i >=0)
            {
                return Tab2List[i].StreetName;
            }
            else { return " "; }
        }

        //Метод, возвращающий длину улицы
        public string OutPutStl(int i)
        {
            if (CountTab2() > i && i >= 0)
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
            foreach (var Tab1 in Tab1List)
            {
                if (Tab1.Street.StreetName == Tab2List[i - 1].StreetName)
                {
                    Tab1.Street.StreetName = " ";
                    Tab1.Street.StreetLength = " ";
                    Tab1.LinkStreet = -1;
                }
            }
            Tab2List.RemoveAt(i - 1);

        }

        //Метод удаления элементов по индексам из списка 3
        public void DeleteElementTab3(int i)
        {
            foreach (var Tab1 in Tab1List)
            {
                if (Tab1.Parking.ParkingName == Tab3List[i].ParkingName && Tab1.Parking.ParkingAdress == Tab3List[i].ParkingAdress && Tab1.Parking.ParkingNumber == Tab3List[i].ParkingNumber)
                {
                    Tab1.Parking.ParkingAdress = " ";
                    Tab1.Parking.ParkingName = " ";
                    Tab1.Parking.ParkingNumber = " ";
                    Tab1.LinkParking = -1;
                }
            }
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
        public void AddLinkTab2(int index2, int index1)
        {
            Tab1List[index1].LinkStreet = index2;
        }

        //Метод добавления ссылки на элемент таблицы 3
        public void AddlinkTab3(int index3, int index1)
        {
            Tab1List[index1].LinkParking = index3;
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

        //Метод возвращающий ссылку на улицу
        public int OutputTab1LinkStreet(int ind)
        {
            return Tab1List[ind].LinkStreet;
        }

        //Метод возвращающий ссылку на автостоянку
        public int OutputTab1LinkParking(int ind)
        {
            return Tab1List[ind].LinkParking;
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
        public void EditTab1(string GPS, string tpvio, string carnum, string cartp, string streetname, string streetlen, string parkingname, string parkingadress, string parkingnumber, int ind, int inds, int indp)
        {
            ind--;
            Tab1List[ind].GPS = GPS;
            Tab1List[ind].TypeViolation = tpvio;
            Tab1List[ind].CarNumber = carnum;
            Tab1List[ind].CarType = cartp;
            Tab1List[ind].Street = Tab2List[inds];
            Tab1List[ind].Parking = Tab3List[indp];
            Tab1List[ind].LinkStreet = inds;
            Tab1List[ind].LinkParking = indp;
        }

        //Метод сортировки элементов таблицы улиц по названию улицы А-Я
        public void SortStreetsNameA()
        {
            int n = Tab2List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab2List[j].StreetName[0] < Tab2List[i].StreetName[0])
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
            int n = Tab2List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab2List[j].StreetName[0] > Tab2List[i].StreetName[0])
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
            int n = Tab2List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (double.Parse(Tab2List[j].StreetLength) < double.Parse(Tab2List[i].StreetLength))
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
                    if (double.Parse(Tab2List[j].StreetLength) > double.Parse(Tab2List[i].StreetLength))
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

            int n = Tab3List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab3List[j].ParkingName[0] < Tab3List[i].ParkingName[0])
                    {
                        ElementsTab3 p = Tab3List[i];
                        Tab3List[i] = Tab3List[j];
                        Tab3List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки элементов таблицы автостоянок по названию автостоянки Я-А
        public void SortParkingsNameZ()
        {
            int n = Tab3List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab3List[j].ParkingName[0] > Tab3List[i].ParkingName[0])
                    {
                        ElementsTab3 p = Tab3List[i];
                        Tab3List[i] = Tab3List[j];
                        Tab3List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки элементов таблицы автостоянок по адресу автостоянки А-Я
        public void SortParkingsAdressA()
        {
            int n = Tab3List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab3List[j].ParkingAdress[0] < Tab3List[i].ParkingAdress[0])
                    {
                        ElementsTab3 p = Tab3List[i];
                        Tab3List[i] = Tab3List[j];
                        Tab3List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки элементов таблицы автостоянок по адресу автостоянки Я-А
        public void SortParkingsAdressZ()
        {
            int n = Tab3List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab3List[j].ParkingAdress[0] > Tab3List[i].ParkingAdress[0])
                    {
                        ElementsTab3 p = Tab3List[i];
                        Tab3List[i] = Tab3List[j];
                        Tab3List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки таблицы актов эвакуации по названию улицы А-Я
        public void SortActsStreetnameA()
        {
            int n = Tab1List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab1List[j].Street.StreetName[0] < Tab1List[i].Street.StreetName[0])
                    {
                        ElementsTab1 p = Tab1List[i];
                        Tab1List[i] = Tab1List[j];
                        Tab1List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки таблицы актов эвакуации по названию улицы Я-А
        public void SortActsStreetnameZ()
        {
            int n = Tab1List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab1List[j].Street.StreetName[0] > Tab1List[i].Street.StreetName[0])
                    {
                        ElementsTab1 p = Tab1List[i];
                        Tab1List[i] = Tab1List[j];
                        Tab1List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки таблицы актов эвакуации по названию автостоянки А-Я
        public void SortActsParkingnameA()
        {
            int n = Tab1List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab1List[j].Parking.ParkingName[0] < Tab1List[i].Parking.ParkingName[0])
                    {
                        ElementsTab1 p = Tab1List[i];
                        Tab1List[i] = Tab1List[j];
                        Tab1List[j] = p;
                    }
                }
            }
        }

        //Метод сортировки таблицы актов эвакуации по названию автостоянки Я-А
        public void SortActsParkingnameZ()
        {
            int n = Tab1List.Count - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (Tab1List[j].Parking.ParkingName[0] > Tab1List[i].Parking.ParkingName[0])
                    {
                        ElementsTab1 p = Tab1List[i];
                        Tab1List[i] = Tab1List[j];
                        Tab1List[j] = p;
                    }
                }
            }
        }

        //Метод поиска улицы
        public void SearchStreet(string streetname, int num)
        {
            Data data = new Data();
            List<ElementsTab2> streets = new List<ElementsTab2>();
            foreach (var st in Tab2List)
            {
                if (st.StreetName.Contains(streetname) || st.StreetLength.Contains(streetname))
                {
                    streets.Add(st);
                }
            }
            int p = 0;
            Console.WriteLine("║" + new string('─', 3) + "─" + new string('─', 52) + "╥" + new string('─', 52) + "║");
            Console.WriteLine("║" + "   " + " " + new string(' ', 19) + "Название улицы" + new string(' ', 19) + "║" + new string(' ', 21) + "Длина улицы" + new string(' ', 20) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "─" + new string('─', 52) + "╫" + new string('─', 52) + "╢");
            for (int i = num; i < num + 20; i++)
            {
                if (streets.Count() > i)
                {
                    p = 55 - streets[i].StreetName.Length;
                    Console.Write("║ " + streets[i].StreetName + new string(' ', p) + "║ ");
                    p = 51 - streets[i].StreetLength.Length;
                    Console.Write(streets[i].StreetLength + new string(' ', p));
                    Console.WriteLine("║");
                    Console.WriteLine("╟" + "────" + new string('─', 52) + "╫" + new string('─', 52) + "╢");
                }
            }

        }

        //Метод поиска автостоянки
        public void SearchParking(string parkingname, int num)
        {
            Data data = new Data();
            List<ElementsTab3> parkings = new List<ElementsTab3>();
            foreach (var pr in Tab3List)
            {
                if (pr.ParkingName.Contains(parkingname) || pr.ParkingAdress.Contains(parkingname) || pr.ParkingNumber.Contains(parkingname))
                {
                    parkings.Add(pr);
                }
            }
            int p = 0;
            Console.WriteLine("║" + new string('─', 32) + "╥" + new string('─', 52) + "╥" + new string('─', 24) + "║");
            Console.WriteLine("║" + new string(' ', 6) + "Название автостоянки" + new string(' ', 6) + "║" + new string(' ', 18) + "Адрес автостоянки" + new string(' ', 17) + "║" + new string(' ', 2) + "Телефон автостоянки" + new string(' ', 3) + "║");
            Console.WriteLine("║" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
            for (int i = num; i < num + 20; i++)
            {
                if (parkings.Count() >= i)
                {
                    p = 31 - parkings[i - 1].ParkingName.Length;
                    Console.Write("║ " + parkings[i - 1].ParkingName + new string(' ', p) + "║ ");
                    p = 51 - parkings[i - 1].ParkingAdress.Length;
                    Console.Write(parkings[i - 1].ParkingAdress + new string(' ', p) + "║ ");
                    p = 23 - parkings[i - 1].ParkingNumber.Length;
                    Console.Write(parkings[i - 1].ParkingNumber + new string(' ', p));
                    Console.WriteLine("║");
                    Console.WriteLine("║" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
                }
            }
        }

        //
        public void SearchStreet(string street)
        {
            foreach(var elem in Tab2List)
            {
                if(elem.StreetName == street) { SearchStreetTab.Add(elem); }
            }
        }

        public void AddSearchTab(string s)
        {
            foreach(var elem in Tab1List)
            {
                if (elem.CarNumber.Contains(s) || elem.CarType.Contains(s) || elem.GPS.Contains(s) || elem.Parking.ParkingAdress.Contains(s) || elem.Parking.ParkingName.Contains(s) || elem.Parking.ParkingNumber.Contains(s) || elem.Street.StreetName.Contains(s) || elem.Street.StreetLength.Contains(s) || elem.TypeViolation.Contains(s))
                {
                    SearchTab1.Add(elem);
                }
            }
        }

        public void DeleteSearchTab1()
        {
            for(int i = 0; i <  SearchTab1.Count(); i++)
            {
                SearchTab1.RemoveAt(i);
            }
        }

        public int CountSearchStreets()
        {
            return SearchTab1.Count();
        }

        //Метод поиска актов эвакуации
        public void SearchAct(string actname, int num, int j)
        {
            int k = 1;
            Data data = new Data();
            int p = 0;
            Console.WriteLine("╟" + new string('─', 52) + "╥" + new string('─', 52) + "╥" + new string('─', 32) + "╥" + new string('─', 43) + "╥" + new string('─', 12) + "╥" + new string('─', 30) + "╢");
            Console.WriteLine("║" + new string(' ', 23) + "Улица" + new string(' ', 24) + "║" + new string(' ', 20) + "Автостоянка" + new string(' ', 21) + "║" + new string(' ', 9) + "GPS-координаты" + new string(' ', 9) + "║" + new string(' ', 15) + "Тип нарушения" + new string(' ', 15) + "║" + new string(' ', 0) + "Номер машины" + new string(' ', 0) + "║" + new string(' ', 8) + "Тип автомобиля" + new string(' ', 8) + "║");
            Console.WriteLine("╟" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            for (int i = num; i < num + 20; i++)
            {

                if (SearchTab1.Count() >= i)
                {
                    p = 51 - SearchTab1[i - 1].Street.StreetName.Length;
                    Console.Write("║ "); if (j == k) { Console.BackgroundColor = ConsoleColor.Blue; }
                    Console.Write(SearchTab1[i - 1].Street.StreetName + new string(' ', p - 1)); Console.ResetColor(); Console.Write(" ║ ");
                    if (j == k * 100) { Console.BackgroundColor = ConsoleColor.Blue; }
                    p = 51 - SearchTab1[i - 1].Parking.ParkingName.Length;
                    Console.Write(SearchTab1[i - 1].Parking.ParkingName + new string(' ', p - 1)); Console.ResetColor(); Console.Write(" ║ ");
                    p = 31 - SearchTab1[i - 1].GPS.Length;
                    Console.Write(SearchTab1[i - 1].GPS + new string(' ', p) + "║ ");
                    p = 42 - SearchTab1[i - 1].TypeViolation.Length;
                    Console.Write(SearchTab1[i - 1].TypeViolation + new string(' ', p) + "║ ");
                    p = 11 - SearchTab1[i - 1].CarNumber.Length;
                    Console.Write(SearchTab1[i - 1].CarNumber + new string(' ', p) + "║ ");
                    p = 29 - SearchTab1[i - 1].CarType.Length;
                    Console.WriteLine(SearchTab1[i - 1].CarType + new string(' ', p) + "║");
                    Console.WriteLine("╟" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
                }
                else
                {
                    Console.Write("║ "); if (j == k) { Console.BackgroundColor = ConsoleColor.Yellow; }
                    Console.Write(new string(' ', 50));
                    Console.ResetColor(); Console.Write(" ║ ");
                    if (j == k * 100) { Console.BackgroundColor = ConsoleColor.Yellow; }
                    Console.Write(new string(' ', 50));
                    Console.ResetColor(); Console.Write(" ║ ");
                    Console.WriteLine(new string(' ', 31) + "║ " + new string(' ', 42) + "║ " + new string(' ', 11) + "║ " + new string(' ', 29) + "║");
                    Console.WriteLine("╟" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
                }
                k++;
            }
        }

        //Запись в файл
        public void Writer()
        {
            Data data = new Data();
            var file = new FileInfo(data.FileName);
            StreamWriter writer = file.CreateText();
            //Запись 2Й таблицы
            foreach (var tab2 in Tab2List)
            {
                writer.WriteLine(tab2.StreetName);
                writer.WriteLine(tab2.StreetLength);
            }
            writer.WriteLine(new string('|', 50));
            //Запись 3й таблицы
            foreach (var tab3 in Tab3List)
            {
                writer.WriteLine(tab3.ParkingName);
                writer.WriteLine(tab3.ParkingAdress);
                writer.WriteLine(tab3.ParkingNumber);
            }
            writer.WriteLine(new string('|', 50));
            //Запись 1й таблицы
            foreach (var tab1 in Tab1List)
            {
                writer.WriteLine(tab1.GPS);
                writer.WriteLine(tab1.TypeViolation);
                writer.WriteLine(tab1.CarNumber);
                writer.WriteLine(tab1.CarType);
                writer.WriteLine(tab1.LinkStreet);
                writer.WriteLine(tab1.LinkParking);
            }
            writer.Close();
        }

        //Чтение с файла
        public void Reader()
        {
            Consolebd consolebd = new Consolebd();
            Data data = new Data();
            //Очистка списков
            this.ClearTab1();
            this.ClearTab2();
            this.ClearTab3();
            StreamReader reader;
            reader = File.OpenText(data.FileName);
            string input;
            while ((input = reader.ReadLine()) != null && input != "||||||||||||||||||||||||||||||||||||||||||||||||||")
            {
                Tab2List.Add(new ElementsTab2());
                Tab2List[Tab2List.Count - 1].StreetName = input;
                input = reader.ReadLine();
                Tab2List[Tab2List.Count - 1].StreetLength = input;
            }
            while ((input = reader.ReadLine()) != null && input != "||||||||||||||||||||||||||||||||||||||||||||||||||")
            {
                Tab3List.Add(new ElementsTab3());
                Tab3List[Tab3List.Count - 1].ParkingName = input;
                input = reader.ReadLine();
                Tab3List[Tab3List.Count - 1].ParkingAdress = input;
                input = reader.ReadLine();
                Tab3List[Tab3List.Count - 1].ParkingNumber = input;
            }
            while ((input = reader.ReadLine()) != null && input != "||||||||||||||||||||||||||||||||||||||||||||||||||")
            {
                Tab1List.Add(new ElementsTab1());
                Tab1List[Tab1List.Count - 1].GPS = input;
                input = reader.ReadLine();
                Tab1List[Tab1List.Count - 1].TypeViolation = input;
                input = reader.ReadLine();
                Tab1List[Tab1List.Count - 1].CarNumber = input;
                input = reader.ReadLine();
                Tab1List[Tab1List.Count - 1].CarType = input;
                input = reader.ReadLine();
                Tab1List[Tab1List.Count - 1].LinkStreet = Convert.ToInt32(input);
                Tab1List[Tab1List.Count - 1].Street = Tab2List[Convert.ToInt32(input)];
                input = reader.ReadLine();
                Tab1List[Tab1List.Count - 1].LinkParking = Convert.ToInt32(input);
                Tab1List[Tab1List.Count - 1].Parking = Tab3List[Convert.ToInt32(input)];
            }
            reader.Close();

        }

        //Очистка 1 таблицы
        public void ClearTab1()
        {
            int count = Tab1List.Count;
            if (count >= 1)
            {
                for (int i = count - 1; i > 0 - 1; i--)
                {
                    Tab1List.RemoveAt(0);
                }
            }
        }

        //Очистка 2 таблицы
        public void ClearTab2()
        {
            int count = Tab2List.Count;
            if (count >= 1)
            {
                for (int i = count - 1; i > 0 - 1; i--)
                {
                    Tab2List.RemoveAt(0);
                }
            }
        }

        //Очистка 3 таблицы
        public void ClearTab3()
        {
            int count = Tab3List.Count;
            if (count >= 1)
            {
                for (int i = count - 1; i > 0 - 1; i--)
                {
                    Tab3List.RemoveAt(0);
                }
            }
        }



    }
}

