using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    //Значки псевдографики, используемые для построения таблицы ╓ ╥ ╖ ╟ ╫ ╢ ╙ ╨ ╜ ─ ║

    public class Consolebd 
    {
        Data data = new Data();

        //Поля для хранения пунктов меню
        public const string SearchFile = "Загрузка файла";
        public const string AddCar = "Добавить эвакуированный автомобиль";
        public const string Tabs = "Таблицы";
        public const string Search = "Поиск";
        public const string Redact = "Редактирование";
        public const string Inform = "Информация";
        public const string Exit1 = "                                        Выход                                           ";
        public const string Yes = "  Да   ";
        public const string No = "  Нет  ";
        public const string StreetName = "Название улицы: ";
        public const string StreetLength = "Длина улицы: ";
        public const string ParkingName = "Название автостоянки: ";
        public const string ParkingAdress = "Адрес автостоянки: ";
        public const string ParkingNumber = "Телефон автостоянки: ";
        public const string GPS = "GPS-координаты: ";
        public const string TypeViolation = "Тип нарушения: ";
        public const string CarNumber = "Номер автомобиля: ";
        public const string Cartype = "Тип автомобиля: ";
        public const string Next = " Далее ";
        public const string Back = " Назад ";
        public const string Tablest = "Таблица улиц";
        public const string Tableprk = "Таблица автостоянок";
        public const string Tableev = "Таблица актов эвакуации";
        public const string Delete = "Удаление";
        public const string Edit = "Редактирование";
        public const string ExitMain = "                                 Выход в главное меню                                   ";
        public const string Deleteind = "Удаление по номеру элемента";
        public const string BackBig = "                                         Выход                                          ";


        //Метод построения главного меню 1
        public void MainMenu(int j)
        {
            //Методы построения таблицы

            Console.WriteLine("╓" + new string ('─', 90) + "╖");
            Console.WriteLine("║" + new string (' ', 26) + "База данных эвакуированных автомобилей" + new string(' ',26) + "║");
            Console.WriteLine("╟" + new string ('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; } 
            Console.Write(SearchFile);
            Console.ResetColor();
            Console.WriteLine(new string ( ' ', 74) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(AddCar);
            Console.ResetColor();
            Console.WriteLine(new string (' ', 54) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Tabs);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 81) + "║");
            Console.Write("║ " + " ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Search);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 83) + "║");
            Console.Write("║ " + " ");
            if (j == 5) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Redact);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 74) + "║");
            Console.Write("║ " + " ");
            if (j == 6) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Inform);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 78) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 7) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(Exit1);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string ('─', 90) + "╜");
        }

        //Метод для построения меню подтверждения выхода
        public void ExitMenu(int e)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("║" + new string(' ', 90) + "║");
            }
            Console.WriteLine("║" + new string(' ', 24) + "Вы уверены, что хотите выйти из программы?" + new string(' ', 24) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.Write("║" + new string (' ', 33));
            if (e == 1) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(Yes);
            Console.ResetColor();
            Console.Write(new string (' ', 10));
            if (e == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(No);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 33) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        
        //Метод для построения меню добавления авто
        public void Addcar(int c)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Ввод информации:                    " + new string(' ', 53) + "║");
            Console.WriteLine("║ " + "      -Название улицы               " + new string(' ', 53) + "║");
            Console.WriteLine("║ " + "      -Длина улицы                  " + new string(' ', 53) + "║");
            Console.WriteLine("║ " + "      -Название автостоянки         " + new string(' ', 53) + "║");
            Console.WriteLine("║ " + "      -Адрес автостоянки            " + new string(' ', 53) + "║");
            Console.WriteLine("║ " + "      -Телефон автостоянки          " + new string(' ', 53) + "║");
            Console.WriteLine("║ " + "      -GPS-координаты               " + new string(' ', 53) + "║");
            Console.WriteLine("║ " + "      -Тип нарушения                " + new string(' ', 53) + "║");
            Console.WriteLine("║ " + "      -Номер автомобиля             " + new string(' ', 53) + "║");
            Console.WriteLine("║ " + "      -Тип автомобиля               " + new string(' ', 53) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.Write("║" + new string (' ',5));
            if (c == 1) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write(new string (' ', 66));
            if (c == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Next);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 5) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню 2-2 добавления авто
        public void Addcar3(string sname)
        {
            int p = 0;
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.Write("║ " + "      -Название улицы: ");
            Console.Write(sname);
            int len = sname.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("Введите длину улицы: ");

        }

        //Метод построения меню 2 добавления авто
        public void Addcar2()
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("Введите название улицы: ");
        }

        //Метод построения меню 4 добавления авто
        public void Addcar4(string sname, string stlength)
        {
            int p = 0;
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.Write("║ " + "      -Название улицы: ");
            Console.Write(sname);
            int len = sname.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Длина улицы: ");
            Console.Write(stlength);
            len = stlength.Length;
            p = 69 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("Введите название автостоянки: ");

        }

        //Метод построения меню 5 добавления авто
        public void Addcar5(string sname, string stlength, string pname)
        {
            int p = 0;
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.Write("║ " + "      -Название улицы: ");
            Console.Write(sname);
            int len = sname.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Длина улицы: ");
            Console.Write(stlength);
            len = stlength.Length;
            p = 69 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Название автостоянки: ");
            Console.Write(pname);
            len = pname.Length;
            p = 60 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("Введите адрес автостоянки: ");
        }

        //Метод построения меню 6 добавления авто
        public void Addcar6(string sname, string stlength, string pname, string padress)
        {
            int p = 0;
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.Write("║ " + "      -Название улицы: ");
            Console.Write(sname);
            int len = sname.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Длина улицы: ");
            Console.Write(stlength);
            len = stlength.Length;
            p = 69 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Название автостоянки: ");
            Console.Write(pname);
            len = pname.Length;
            p = 60 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Адрес автостоянки: ");
            Console.Write(padress);
            len = padress.Length;
            p = 63 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("Введите телефон автостоянки: ");
        }

        //Метод построения меню 7 добавления авто
        public void Addcar7(string sname, string stlength, string pname, string padress, string pnumber)
        {
            int p = 0;
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.Write("║ " + "      -Название улицы: ");
            Console.Write(sname);
            int len = sname.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Длина улицы: ");
            Console.Write(stlength);
            len = stlength.Length;
            p = 69 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Название автостоянки: ");
            Console.Write(pname);
            len = pname.Length;
            p = 60 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Адрес автостоянки: ");
            Console.Write(padress);
            len = padress.Length;
            p = 63 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Телефон автостоянки: ");
            Console.Write(pnumber);
            len = pnumber.Length;
            p = 61 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("Введите GPS-координаты: ");
        }

        //Метод построения меню 8 добавления авто
        public void Addcar8(string sname, string stlength, string pname, string padress, string pnumber, string GPS)
        {
            int p = 0;
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.Write("║ " + "      -Название улицы: ");
            Console.Write(sname);
            int len = sname.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Длина улицы: ");
            Console.Write(stlength);
            len = stlength.Length;
            p = 69 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Название автостоянки: ");
            Console.Write(pname);
            len = pname.Length;
            p = 60 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Адрес автостоянки: ");
            Console.Write(padress);
            len = padress.Length;
            p = 63 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Телефон автостоянки: ");
            Console.Write(pnumber);
            len = pnumber.Length;
            p = 61 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -GPS-координаты: ");
            Console.Write(GPS);
            len = GPS.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("║" + new string('─', 90) + "║");
            Console.WriteLine("║" + " Выберите тип нарушения:" + new string (' ', 66) + "║");
            Console.WriteLine("║" + " 1. Стоянка на проезжей части в месте запрета" + new string(' ', 45) + "║");
            Console.WriteLine("║" + " 2. Стоянка на тротуаре  " + new string(' ', 65) + "║");
            Console.WriteLine("║" + " 3. Стоянка на газоне  " + new string(' ', 67) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("Выберите тип нарушения: ");
        }

        //Метод построения меню 8 добавления авто
        public void Addcar9(string sname, string stlength, string pname, string padress, string pnumber, string GPS, string vio)
        {
            int p = 0;
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.Write("║ " + "      -Название улицы: ");
            Console.Write(sname);
            int len = sname.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Длина улицы: ");
            Console.Write(stlength);
            len = stlength.Length;
            p = 69 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Название автостоянки: ");
            Console.Write(pname);
            len = pname.Length;
            p = 60 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Адрес автостоянки: ");
            Console.Write(padress);
            len = padress.Length;
            p = 63 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Телефон автостоянки: ");
            Console.Write(pnumber);
            len = pnumber.Length;
            p = 61 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -GPS-координаты: ");
            Console.Write(GPS);
            len = GPS.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Тип нарушения: ");
            Console.Write(vio);
            len = vio.Length;
            p = 67 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("Введите номер автомобиля: ");
        }

        //Метод построения меню 8 добавления авто
        public void Addcar10(string sname, string stlength, string pname, string padress, string pnumber, string GPS, string vio, string carnm)
        {
            int p = 0;
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.Write("║ " + "      -Название улицы: ");
            Console.Write(sname);
            int len = sname.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Длина улицы: ");
            Console.Write(stlength);
            len = stlength.Length;
            p = 69 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Название автостоянки: ");
            Console.Write(pname);
            len = pname.Length;
            p = 60 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Адрес автостоянки: ");
            Console.Write(padress);
            len = padress.Length;
            p = 63 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Телефон автостоянки: ");
            Console.Write(pnumber);
            len = pnumber.Length;
            p = 61 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -GPS-координаты: ");
            Console.Write(GPS);
            len = GPS.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Тип нарушения: ");
            Console.Write(vio);
            len = vio.Length;
            p = 67 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Номер автомобиля: ");
            Console.Write(carnm);
            len = carnm.Length;
            p = 64 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("║" + new string('─', 90) + "║");
            Console.WriteLine("║" + " Выберите тип автомобиля:" + new string(' ', 65) + "║");
            Console.WriteLine("║" + " 1. Легковой" + new string(' ', 78) + "║");
            Console.WriteLine("║" + " 2. Грузовой малой тонажности" + new string(' ', 61) + "║");
            Console.WriteLine("║" + " 3. Грузовой большой тонажности" + new string(' ', 59) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("Выберете тип автомобиля: ");
        }

        //Метод построения меню 8 добавления авто
        public void Addcar11(string sname, string stlength, string pname, string padress, string pnumber, string GPS, string vio, string carnm, string cart)
        {
            int p = 0;
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Введенная информация:               " + new string(' ', 53) + "║");
            Console.Write("║ " + "      -Название улицы: ");
            Console.Write(sname);
            int len = sname.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Длина улицы: ");
            Console.Write(stlength);
            len = stlength.Length;
            p = 69 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Название автостоянки: ");
            Console.Write(pname);
            len = pname.Length;
            p = 60 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Адрес автостоянки: ");
            Console.Write(padress);
            len = padress.Length;
            p = 63 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Телефон автостоянки: ");
            Console.Write(pnumber);
            len = pnumber.Length;
            p = 61 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -GPS-координаты: ");
            Console.Write(GPS);
            len = GPS.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Тип нарушения: ");
            Console.Write(vio);
            len = vio.Length;
            p = 67 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Номер автомобиля: ");
            Console.Write(carnm);
            len = carnm.Length;
            p = 64 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.Write("║ " + "      -Тип автомобиля: ");
            Console.Write(cart);
            len = cart.Length;
            p = 66 - len;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("                       Нажмите Enter чтобы выйти в главное меню  ");
        }

        //Метод построения меню предупреждения
        public void Attention()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "                 ОШИБКА               " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + "     Некорректный ввод данных         " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + " Нажмите любую клавишу для продолжения" + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.ReadKey();
        }

        //Метод построения главного меню ввода имени файла
        public void SearchFileMain()
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + " Добавление эвакуированного автомобиля" + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 26) + "             Загрузка файла           " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ " + "Загруженный файл: " + new string (' ', 71) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.Write("  Введите имя файла: ");

        }

        //Метод построения второго меню добавления файла
        public void SearchFile1()
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "             Загрузка файла           " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + "Загруженный файл: ");
            Console.Write(data.FileName);
            int p = 71 - data.FilenameLength();
            Console.WriteLine( new string(' ', p) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню вывода таблиц
        public void Tables(int c)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "                 Таблицы              " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (c == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Tablest);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 76) + "║");
            Console.Write("║ " + " ");
            if (c == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Tableprk);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 69) + "║");
            Console.Write("║ " + " ");
            if (c == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Tableev);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 65) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (c == 4) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(Exit1);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод вывода предупреждения при неккоректном вводе имени файла
        public void AttentionSerachFile()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "                 ОШИБКА               " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + "       Некорректный ввод данных         " + new string(' ', 24) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 30) + " Нажмите Enter для продолжения" + new string(' ', 30) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.ReadKey();
        }

        //Метод построения меню редактирования
        public void EditMenu(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "            Редактирование            " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Delete);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 80) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Edit);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 74) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(ExitMain);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");

        }

        //Метод построения меню удаления элементов
        public void DeleteMenu(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "               Удаление               " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Deleteind);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 61) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Edit);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 74) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(BackBig);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");

        }
    }
}
