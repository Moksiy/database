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
        public const string Deleteind = " Удаление по номеру элемента ";
        public const string BackBig = "                                         Назад                                          ";
        public const string AddStreet = "Добавить улицу";
        public const string AddCarparking = "Добавить автостоянку";
        public const string AddAct = "Добавить акт эвакуации";
        public const string Save = " Сохранить ";
        public const string DeleteStreet = " Удалить улицу ";
        public const string DeleteParking = " Удалить автостоянку ";
        public const string DeleteAct = " Удалить акт эвакуации ";
        public const string Street = "Улица";
        public const string Parking = "Автостоянка";
        public const string Violation1 = "Cтоянка на проезжей части в месте запрета";
        public const string Violation2 = "Cтоянка на тротуаре";
        public const string Violation3 = "Cтоянка на газоне";
        public const string CarType1 = "Легковой";
        public const string CarType2 = "Грузовой малой тонажности";
        public const string CarType3 = "Грузовой большой тонажности";


        //Метод построения главного меню 1
        public void MainMenu(int j)
        {
            //Методы построения таблицы

            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "База данных эвакуированных автомобилей" + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(SearchFile);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 74) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(AddCar);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 78) + "║");
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
            Console.WriteLine("╙" + new string('─', 90) + "╜");
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
            Console.Write("║" + new string(' ', 33));
            if (e == 1) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(Yes);
            Console.ResetColor();
            Console.Write(new string(' ', 10));
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
            Console.WriteLine("║ " + "Загруженный файл: " + new string(' ', 71) + "║");
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
            Console.WriteLine(new string(' ', p) + "║");
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
            Console.Write(DeleteStreet);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 73) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(DeleteParking);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 67) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(DeleteAct);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 65) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(BackBig);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");

        }

        //Метод построения меню выбора типа удаления элемента
        public void ChoiseTypeOfDelete(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "        Выберите тип удаления         " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Deleteind);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 59) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(DeleteParking);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 67) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(DeleteAct);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 65) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.DarkRed; }
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
            Console.WriteLine("║ Введите индекс элемента: " + new string(' ', 64) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню добавления улицы
        public void AddElemStreet(int j, string stname, string stlen)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "            Добавление улицы          " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 17) + "╥" + new string('─', 72) + "╢");
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
            Console.Write(new string(' ', 6) + " ║ ");
            Console.Write(prkname);
            int p = 71 - prkname.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 17) + "╫" + new string('─', 72) + "╢");
            Console.Write("║ ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(ParkingAdress);
            Console.ResetColor();
            Console.Write(new string(' ', 9) + " ║ " + prkadress);
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

        //Метод построения окна предупреждения несуществуещего элемента
        public void AttentionDeleteElement()
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "                 ОШИБКА               " + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 23) + "Элемента по введенному индексу не существует" + new string(' ', 23) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("║" + new string(' ', 26) + " Нажмите любую клавишу для продолжения" + new string(' ', 26) + "║");
            Console.WriteLine("║" + new string(' ', 90) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
            Console.ReadKey();
        }

        //Метод построения меню добавления акта эвакуации
        public void AddElemActEvacuation(int j, string gps, string typeviolation, string numberofcar, string typeofcar, string street, string parking)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "        Добавление акта эвакуации     " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 19) + "╥" + new string('─', 70) + "╢");
            Console.Write("║ ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(GPS);
            Console.ResetColor();
            Console.Write("   ║ ");
            Console.Write(gps);
            int p = 69 - gps.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 19) + "╫" + new string('─', 70) + "╢");
            Console.Write("║ ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(TypeViolation);
            Console.ResetColor();
            Console.Write(new string(' ', 3) + " ║ ");
            Console.Write(typeviolation);
            p = 69 - typeviolation.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 19) + "╫" + new string('─', 70) + "╢");
            Console.Write("║ ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(CarNumber);
            Console.ResetColor();
            Console.Write(" ║ ");
            Console.Write(numberofcar);
            p = 69 - numberofcar.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 19) + "╫" + new string('─', 70) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Cartype);
            Console.ResetColor();
            Console.Write(new string(' ', 2) + " ║ ");
            Console.Write(typeofcar);
            p = 69 - typeofcar.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 19) + "╫" + new string('─', 70) + "╢");
            Console.Write("║ ");
            if (j == 5) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Street);
            Console.ResetColor();
            Console.Write(new string(' ', 12) + " ║ ");
            Console.Write(street);
            p = 69 - street.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 19) + "╫" + new string('─', 70) + "╢");
            Console.Write("║ ");
            if (j == 6) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Parking);
            Console.ResetColor();
            Console.Write(new string(' ', 6) + " ║ ");
            Console.Write(parking);
            p = 69 - parking.Length;
            Console.WriteLine(new string(' ', p) + "║");
            Console.WriteLine("╟" + new string('─', 19) + "╨" + new string('─', 70) + "╢");
            Console.Write("║" + new string(' ', 10));
            if (j == 7) { Console.BackgroundColor = ConsoleColor.Red; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write(new string(' ', 12) + "║ Выберете пункт для ввода ║" + new string(' ', 12));
            if (j == 700) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Save);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 10) + "║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню выбора типа нарушения
        public void ChoiseTypeViolation(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "       Выберите тип нарушения         " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Violation1);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 47) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Violation2);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 69) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Violation3);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 71) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(BackBig);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню выбора типа автомобиля
        public void ChoiseTypeOfCar(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "      Выберите тип автомобиля         " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(CarType1);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 80) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(CarType2);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 63) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(CarType3);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 61) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(BackBig);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню выбора улицы
        public void ChoiseStreet(int j, int limit, int counttab2)
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            //объявление переменной для хранения количества элементов в списке
            int count = data.CountTab2();

            if (limit <= 81)
            {
                //Очистка консоли
                Console.Clear();

                //Построение таблицы 
                Table1(limit, j, counttab2);
            }
            else
            {
                //Очистка консоли
                Console.Clear();

                //Построение таблицы
                Table2(limit, j, counttab2);
            }

            void Table1(int num, int l, int counttab)
            {
                Console.WriteLine("╓" + new string('─', 60) + "╖");
                Console.WriteLine("║" + new string(' ', 15) + "         Выберите улицу       " + new string(' ', 15) + "║");
                string st;
                if ((counttab - 1) >= (num -1)) { st = data.OutPutSt(num-1); } else { st = " "; }
                int p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num)) { st = data.OutPutSt(num); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 1)) { st = data.OutPutSt(num + 1); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 2)) { st = data.OutPutSt(num + 2); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 3)) { st = data.OutPutSt(num + 3); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 5) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 4)) { st = data.OutPutSt(num + 4); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 6) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 5)) { st = data.OutPutSt(num + 5); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 7) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 6)) { st = data.OutPutSt(num + 6); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 8) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 7)) { st = data.OutPutSt(num + 7); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 9) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 8)) { st = data.OutPutSt(num + 8); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 10) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 9)) { st = data.OutPutSt(num + 9); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 11) { Console.BackgroundColor = ConsoleColor.Red; } Console.Write(Back); Console.ResetColor();
                Console.Write(new string (' ',44));
                if (l == 1100) { Console.BackgroundColor = ConsoleColor.Blue; } Console.Write(Next); Console.ResetColor();
                Console.WriteLine(" ║");
                Console.WriteLine("╙" + new string('─',60) + "╜");
            }

            void Table2(int num, int l, int counttab)
            {
                Console.WriteLine("╓" + new string('─', 60) + "╖");
                Console.WriteLine("║" + new string(' ', 15) + "         Выберите улицу       " + new string(' ', 15) + "║");
                string st;
                if ((counttab - 1) >= (num -1)) { st = data.OutPutSt(num - 1); } else { st = " "; }
                int p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num)) { st = data.OutPutSt(num); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 1)) { st = data.OutPutSt(num + 1); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 2)) { st = data.OutPutSt(num + 2); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 3)) { st = data.OutPutSt(num + 3); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 5) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 4)) { st = data.OutPutSt(num + 4); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 6) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 5)) { st = data.OutPutSt(num + 5); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 7) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 6)) { st = data.OutPutSt(num + 6); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 8) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 7)) { st = data.OutPutSt(num + 7); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 9) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 8)) { st = data.OutPutSt(num + 8); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 10) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 9)) { st = data.OutPutSt(num + 9); } else { st = " "; }
                p = 58 - st.Length;
                if (l == 1100) { l = 11; }
                Console.Write("║ ");
                if (l == 11) { Console.BackgroundColor = ConsoleColor.Red; }
                Console.Write(Back); Console.ResetColor();
                Console.Write(new string(' ', 51));
                Console.WriteLine(" ║");
                Console.WriteLine("╙" + new string('─', 60) + "╜");
            }
        }

        //Метод построения меню выбора автостоянки
        public void ChoiseParking(int j, int limit, int counttab3)
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            //Объявление переменной для хранения количества элементов в списке
            int count = data.CountTab3();

            if (limit <= 81)
            {
                //очистка консоли
                Console.Clear();

                //Построение таблицы 
                Table1(limit, j, counttab3);
            }
            else
            {
                //Очистка консоли
                Console.Clear();

                //Построение таблицы
                Table2(limit, j, counttab3);
            }

            void Table1(int num, int l, int counttab)
            {
                Console.WriteLine("╓" + new string('─', 60) + "╖");
                Console.WriteLine("║" + new string(' ', 15) + "      Выберите автостоянку    " + new string(' ', 15) + "║");
                string st;
                if ((counttab - 1) >= (num - 1)) { st = data.OutPutPrkname(num - 1); } else { st = " "; }
                int p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num)) { st = data.OutPutPrkname(num); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 1)) { st = data.OutPutPrkname(num + 1); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 2)) { st = data.OutPutPrkname(num + 2); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 3)) { st = data.OutPutPrkname(num + 3); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 5) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 4)) { st = data.OutPutPrkname(num + 4); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 6) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 5)) { st = data.OutPutPrkname(num + 5); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 7) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 6)) { st = data.OutPutPrkname(num + 6); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 8) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 7)) { st = data.OutPutPrkname(num + 7); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 9) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 8)) { st = data.OutPutPrkname(num + 8); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 10) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 9)) { st = data.OutPutPrkname(num + 9); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 11) { Console.BackgroundColor = ConsoleColor.Red; }
                Console.Write(Back); Console.ResetColor();
                Console.Write(new string(' ', 44));
                if (l == 1100) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(Next); Console.ResetColor();
                Console.WriteLine(" ║");
                Console.WriteLine("╙" + new string('─', 60) + "╜");
            }

            void Table2(int num, int l, int counttab)
            {
                Console.WriteLine("╓" + new string('─', 60) + "╖");
                Console.WriteLine("║" + new string(' ', 15) + "      Выберите автостоянку    " + new string(' ', 15) + "║");
                string st;
                if ((counttab - 1) >= (num - 1)) { st = data.OutPutPrkname(num - 1); } else { st = " "; }
                int p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num)) { st = data.OutPutPrkname(num); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 1)) { st = data.OutPutPrkname(num + 1); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 2)) { st = data.OutPutPrkname(num + 2); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 3)) { st = data.OutPutPrkname(num + 3); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 5) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 4)) { st = data.OutPutPrkname(num + 4); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 6) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 5)) { st = data.OutPutPrkname(num + 5); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 7) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 6)) { st = data.OutPutPrkname(num + 6); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 8) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 7)) { st = data.OutPutPrkname(num + 7); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 9) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 8)) { st = data.OutPutPrkname(num + 8); } else { st = " "; }
                p = 58 - st.Length;
                Console.Write("║ ");
                if (l == 10) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(st + new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                if ((counttab - 1) >= (num + 9)) { st = data.OutPutPrkname(num + 9); } else { st = " "; }
                p = 58 - st.Length;
                if (l == 1100) { l = 11; }
                Console.Write("║ ");
                if (l == 11) { Console.BackgroundColor = ConsoleColor.Red; }
                Console.Write(Back); Console.ResetColor();
                Console.Write(new string(' ', 51));
                Console.WriteLine(" ║");

                Console.WriteLine("╙" + new string('─', 60) + "╜");
            }
        }
    }
}
