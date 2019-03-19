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
        public const string AddCar = "Добавление";
        public const string Tabs = "Таблицы";
        public const string Search = "Поиск";
        public const string Redact = "Редактирование";
        public const string Inform = "Информация";
        public const string Exit1 = "                                        Выход                                           ";
        public const string Yes = "  Да   ";
        public const string No = "  Нет  ";
        public const string StreetName = "Название улицы ";
        public const string StreetLength = "Длина улицы ";
        public const string ParkingName = "Название ";
        public const string ParkingAdress = "Адрес ";
        public const string ParkingNumber = "Телефон ";
        public const string GPS = "GPS-координаты ";
        public const string TypeViolation = "Тип нарушения ";
        public const string CarNumber = "Номер автомобиля ";
        public const string Cartype = "Тип автомобиля ";
        public const string Next = " Далее ";
        public const string Back = " Назад ";
        public const string Tablest = "Таблица улиц";
        public const string Tableprk = "Таблица автостоянок";
        public const string Tableev = "Таблица актов эвакуации";
        public const string Delete = "Удаление";
        public const string Edit = "Редактирование";
        public const string ExitMain = "                                 Выход в главное меню                                   ";
        public const string Deleteind = "Удаление по номеру элемента";
        public const string BackBig = "                                         Назад                                          ";
        public const string AddStreet = "Добавить улицу";
        public const string AddCarparking = "Добавить автостоянку";
        public const string AddAct = "Добавить акт эвакуации";
        public const string Save = " Сохранить ";


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
            Console.WriteLine(new string (' ', 78) + "║");
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

        //Метод для построения меню добавления нового элемента
        //Главное меню добавления элемента
        public void AddElement(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "             Добавление               " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(AddStreet);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 74) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(AddCarparking);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 68) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(AddAct);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 66) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(ExitMain);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
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

        //Метод построения меню удаления элемента по индексу
        public void DeleteElementIndex()
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "     Удаление элемента по индексу     " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.WriteLine("║ Введите индекс элемента: " + new string (' ',64) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню добавления улицы
        public void AddElemStreet(int j, string stname, string stlen)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "            Добавление улицы          " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 17) + "╥" + new string('─', 72)+ "╢");
            Console.Write("║ ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(StreetName);
            Console.ResetColor();
            Console.Write(" ║ ");
            Console.Write(stname);
            int p = 71 - stname.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 17) + "╫" + new string('─', 72) + "╢");
            Console.Write("║ ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(StreetLength);
            Console.ResetColor();
            Console.Write("    ║ " + stlen);
            p = 71 - stlen.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 17) + "╨" + new string('─', 72) + "╢");
            Console.Write("║" + new string(' ', 10));
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Red; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write(new string(' ', 12) + "║ Выберете пункт для ввода ║" + new string(' ', 12));
            if (j == 300) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Save);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 10) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод вывода предупреждения в случае пустого поля при добавлении элемента
        public void AttentionAddElement()
        {
            //Отступ
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
            }
            //Прорисовка самой таблицы
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "                 ОШИБКА               " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + "        Некорректный ввод данных      " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + " Нажмите любую клавишу для продолжения" + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.ReadKey();

        }

        //Метод вывода предупреждения о том, что не все поля заполены
        public void AttentionNullableFields()
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "                 ОШИБКА               " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + "        Некорректный ввод данных      " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 24) + "    Присутствуют незаполненные строки     " + new string(' ', 24) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + " Нажмите любую клавишу для продолжения" + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.ReadKey();
        }

        //Метод вывода предупреждения о том, что введенная улица уже существует
        public void AttentionAlreadyHasStreet()
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "                 ОШИБКА               " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + "        Некорректный ввод данных      " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 24) + "      Введенная улица уже добавлена       " + new string(' ', 24) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + " Нажмите любую клавишу для продолжения" + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.ReadKey();
        }

        //Метод вывод предупреждения о том, что введенная автостоянка уже существует
        public void AttentionAlreadyHasParking()
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "                 ОШИБКА               " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + "        Некорректный ввод данных      " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 24) + "   Введенная автостоянка уже добавлена    " + new string(' ', 24) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + " Нажмите любую клавишу для продолжения" + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.ReadKey();
        }

        //Метод построения меню добавления автостоянки
        public void AddElemParking(int j, string prkname, string prkadress, string prknumber)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "         Добавление автостоянки       " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 17) + "╥" + new string('─', 72) + "╢");
            Console.Write("║ ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(ParkingName);
            Console.ResetColor();
            Console.Write(new string(' ',6) + " ║ ");
            Console.Write(prkname);
            int p = 71 - prkname.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 17) + "╫" + new string('─', 72) + "╢");
            Console.Write("║ ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(ParkingAdress);
            Console.ResetColor();
            Console.Write(new string(' ',9) + " ║ " + prkadress);
            p = 71 - prkadress.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 17) + "╫" + new string('─', 72) + "╢");
            Console.Write("║ ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(ParkingNumber);
            Console.ResetColor();
            Console.Write(new string(' ', 7) + " ║ " + prknumber);
            p = 71 - prknumber.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 17) + "╨" + new string('─', 72) + "╢");
            Console.Write("║" + new string(' ', 10));
            if (j == 4) { Console.BackgroundColor = ConsoleColor.Red; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write(new string(' ', 12) + "║ Выберете пункт для ввода ║" + new string(' ', 12));
            if (j == 400) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Save);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 10) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }
    }
}
