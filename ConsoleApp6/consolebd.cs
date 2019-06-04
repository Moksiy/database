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
        public const string SearchFile = "Файл";
        public const string AddCar = "Добавление";
        public const string Tabs = "Таблицы";
        public const string Search = "Поиск";
        public const string Redact = "Редактирование / удаление";
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
        public const string EditStreet = "Редактирование улиц";
        public const string EditParking = "Редактирование автостоянок";
        public const string EditAct = "Редактирование актов эвакуаций";
        public const string DeleteName = "Удаление по названию";
        public const string File = "Файл: ";


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
            Console.WriteLine(new string(' ', 84) + "║");
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
            Console.WriteLine(new string(' ', 63) + "║");
            Console.Write("║ " + " ");
            if (j == 6) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Сортировка");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 78) + "║");
            Console.Write("║ " + " ");
            if (j == 7) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Inform);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 78) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 8) { Console.BackgroundColor = ConsoleColor.DarkRed; }
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
            Console.Clear();
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
            Console.WriteLine(new string(' ', 61) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(DeleteName);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 68) + "║");
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
            string Add = "Добавить";

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
                if ((counttab - 1) >= (num - 1)) { st = data.OutPutSt(num - 1); } else { st = " "; }
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
                if (l == 11) { Console.BackgroundColor = ConsoleColor.Red; }
                Console.Write(Back); Console.ResetColor();
                Console.Write(new string(' ', 18));
                if (l == 1100) { Console.BackgroundColor = ConsoleColor.Red; }
                Console.Write(Add); Console.ResetColor();
                Console.Write(new string(' ', 18));
                if (l == 110000) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(Next); Console.ResetColor();
                Console.WriteLine(" ║");
                Console.WriteLine("╙" + new string('─', 60) + "╜");
            }

            void Table2(int num, int l, int counttab)
            {
                Console.WriteLine("╓" + new string('─', 60) + "╖");
                Console.WriteLine("║" + new string(' ', 15) + "         Выберите улицу       " + new string(' ', 15) + "║");
                string st;
                if ((counttab - 1) >= (num - 1)) { st = data.OutPutSt(num - 1); } else { st = " "; }
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
                Console.Write(new string(' ', 18));
                if (l == 1100) { Console.BackgroundColor = ConsoleColor.Red; }
                Console.Write(Add); Console.ResetColor();
                Console.Write(new string(' ', 18));
                if (l == 110000) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(Next); Console.ResetColor();
                Console.WriteLine(" ║");
                Console.WriteLine("╙" + new string('─', 60) + "╜");
            }
        }

        //Метод построения меню выбора автостоянки
        public void ChoiseParking(int j, int limit, int counttab3)
        {
            //Создание экземпляра класса с данными
            Data data = new Data();
            string Add = "Добавить";

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
                Console.Write(new string(' ', 18));
                if (l == 1100) { Console.BackgroundColor = ConsoleColor.Red; }
                Console.Write(Add); Console.ResetColor();
                Console.Write(new string(' ', 18));
                if (l == 110000) { Console.BackgroundColor = ConsoleColor.Blue; }
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
                Console.Write(new string(' ', 18));
                if (l == 1100) { Console.BackgroundColor = ConsoleColor.Red; }
                Console.Write(Add); Console.ResetColor();
                Console.Write(new string(' ', 18));
                if (l == 110000) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(Next); Console.ResetColor();
                Console.WriteLine(" ║");

                Console.WriteLine("╙" + new string('─', 60) + "╜");
            }
        }

        //Метод построения таблицы улиц
        public void StreetTable(int l, int num)
        {
            //Константы для пунктов выбора
            const string Next = "Далее";
            const string Main = " Выход в главное меню ";

            Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 52) + "╥" + new string('─', 52) + "╖");
            Console.WriteLine("║" + " № " + "║" + new string(' ', 19) + "Название улицы" + new string(' ', 19) + "║" + new string(' ', 21) + "Длина улицы" + new string(' ', 20) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╢");
            int count = data.CountTab2();
            for (int i = num - 1; i < (num + 19); i++)
            {
                string strname = " ";
                string strlength = " ";
                Console.Write("║");
                string number = Convert.ToString(i + 1);
                Console.Write(number);
                int g = 3 - number.Length;
                Console.Write(new string(' ', g) + "║ ");
                if ((count - 1) >= (i)) { strname = data.OutPutSt(i); } else { strname = " "; }
                int p = 50 - strname.Length;
                Console.Write(strname);
                Console.Write(new string(' ', p));
                Console.Write(" ║ ");
                if ((count - 1) >= (i)) { strlength = data.OutPutStl(i); } else { strlength = " "; }
                p = 51 - strlength.Length;
                Console.Write(strlength);
                Console.Write(new string(' ', p));
                Console.WriteLine("║");
                Console.WriteLine("╟" + "───╫" + new string('─', 52) + "╫" + new string('─', 52) + "╢");

            }
            Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 20) + "╥" + new string('─', 31) + "╨" + new string('─', 36) + "╥" + new string('─', 7) + "╥" + new string('─', 7) + "╢");
            Console.Write("║ ");
            if (l == 1) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(Main);
            Console.ResetColor();
            Console.Write(" ║");
            Console.Write(new string(' ', 67));
            Console.Write(" ║");
            if (l == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write("║ ");
            if (l == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Next);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 24) + "╨" + new string('─', 68) + "╨" + new string('─', 7) + "╨" + new string('─', 7) + "╜");
        }

        //Метод построения таблицы автостоянок
        public void ParkingTable(int l, int num)
        {
            //Константы для пунктов выбора
            const string Next = "Далее";
            const string Main = " Выход в главное меню ";

            Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 32) + "╥" + new string('─', 52) + "╥" + new string('─', 24) + "╖");
            Console.WriteLine("║" + " № " + "║" + new string(' ', 6) + "Название автостоянки" + new string(' ', 6) + "║" + new string(' ', 18) + "Адрес автостоянки" + new string(' ', 17) + "║" + new string(' ', 2) + "Телефон автостоянки" + new string(' ', 3) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
            int count = data.CountTab3();
            string prkadress = " ";
            string prkname = " ";
            string prknumber = " ";
            for (int i = num - 1; i < (num + 19); i++)
            {
                Console.Write("║");
                string number = Convert.ToString(i + 1);
                Console.Write(number);
                int g = 3 - number.Length;
                Console.Write(new string(' ', g) + "║ ");
                if ((count - 1) >= (i)) { prkname = data.OutPutPrkname(i); } else { prkname = " "; }
                int p = 30 - prkname.Length;
                Console.Write(prkname);
                Console.Write(new string(' ', p));
                Console.Write(" ║ ");
                if ((count - 1) >= (i)) { prkadress = data.OutPutPrkadress(i); } else { prkadress = " "; }
                p = 51 - prkadress.Length;
                Console.Write(prkadress);
                Console.Write(new string(' ', p));
                Console.Write("║ ");
                if ((count - 1) >= (i)) { prknumber = data.OutPutPrknumber(i); } else { prknumber = " "; }
                p = 23 - prknumber.Length;
                Console.Write(prknumber);
                Console.Write(new string(' ', p));
                Console.WriteLine("║");
                Console.WriteLine("╟" + "───╫" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
            }
            Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 20) + "╥" + new string('─', 11) + "╨" + new string('─', 52) + "╨" + new string('─', 8) + "╥" + new string('─', 7) + "╥" + new string('─', 7) + "╢");
            Console.Write("║ ");
            if (l == 1) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(Main);
            Console.ResetColor();
            Console.Write(" ║");
            Console.Write(new string(' ', 72));
            Console.Write(" ║");
            if (l == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write("║ ");
            if (l == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Next);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 24) + "╨" + new string('─', 73) + "╨" + new string('─', 7) + "╨" + new string('─', 7) + "╜");
        }

        //Метод построения таблицы актов эвакуации
        public void ActEvacuationTable(int l, int num)
        {
            Data data = new Data();
            //Константы для пунктов выбора
            const string Next = "Далее";
            const string Main = " Выход в главное меню ";
            //                                 №                           Улица                   Автостоянка                       GPS                Тип нарушения                 Номер машины                  Тип машины
            Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 52) + "╥" + new string('─', 52) + "╥" + new string('─', 32) + "╥" + new string('─', 43) + "╥" + new string('─', 12) + "╥" + new string('─', 30) + "╖");
            Console.WriteLine("║" + " № " + "║" + new string(' ', 23) + "Улица" + new string(' ', 24) + "║" + new string(' ', 20) + "Автостоянка" + new string(' ', 21) + "║" + new string(' ', 9) + "GPS-координаты" + new string(' ', 9) + "║" + new string(' ', 15) + "Тип нарушения" + new string(' ', 15) + "║" + new string(' ', 0) + "Номер машины" + new string(' ', 0) + "║" + new string(' ', 8) + "Тип автомобиля" + new string(' ', 8) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            int count = data.CountTab1();
            string street = " ";
            string parking = " ";
            string GPS = " ";
            string typeVio = " ";
            string carnum = " ";
            string cartype = " ";
            string number = " ";
            int p = 0;
            int num1 = 0;
            num1 = num - 1;
            num--;
            //Begin 1
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 1); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num)) { street = data.OutputStreetTab1(/**/num); } else { street = " "; }
            if (/**/l == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 100) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num)) { parking = data.OutputParkingTab1(/**/num); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num)) { GPS = data.OutPutGPS(/**/num); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num)) { typeVio = data.OutPutTypeVio(/**/num); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num)) { carnum = data.OutPutCarNum(/**/num); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num)) { cartype = data.OutPutCarType(/**/num); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 2
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 2); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 1)) { street = data.OutputStreetTab1(/**/num + 1); } else { street = " "; }
            if (/**/l == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 200) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 1)) { parking = data.OutputParkingTab1(/**/num + 1); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 1)) { GPS = data.OutPutGPS(/**/num + 1); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 1)) { typeVio = data.OutPutTypeVio(/**/num + 1); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 1)) { carnum = data.OutPutCarNum(/**/num + 1); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 1)) { cartype = data.OutPutCarType(/**/num + 1); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 3
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 3); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 2)) { street = data.OutputStreetTab1(/**/num + 2); } else { street = " "; }
            if (/**/l == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 300) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 2)) { parking = data.OutputParkingTab1(/**/num + 2); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 2)) { GPS = data.OutPutGPS(/**/num + 2); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 2)) { typeVio = data.OutPutTypeVio(/**/num + 2); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 2)) { carnum = data.OutPutCarNum(/**/num + 2); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 2)) { cartype = data.OutPutCarType(/**/num + 2); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 4
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 4); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 3)) { street = data.OutputStreetTab1(/**/num + 3); } else { street = " "; }
            if (/**/l == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 400) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 3)) { parking = data.OutputParkingTab1(/**/num + 3); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 3)) { GPS = data.OutPutGPS(/**/num + 3); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 3)) { typeVio = data.OutPutTypeVio(/**/num + 3); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 3)) { carnum = data.OutPutCarNum(/**/num + 3); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 3)) { cartype = data.OutPutCarType(/**/num + 3); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 5
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 5); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 4)) { street = data.OutputStreetTab1(/**/num + 4); } else { street = " "; }
            if (/**/l == 5) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 500) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 4)) { parking = data.OutputParkingTab1(/**/num + 4); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 4)) { GPS = data.OutPutGPS(/**/num + 4); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 4)) { typeVio = data.OutPutTypeVio(/**/num + 4); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 4)) { carnum = data.OutPutCarNum(/**/num + 4); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 4)) { cartype = data.OutPutCarType(/**/num + 4); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 6
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 6); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 5)) { street = data.OutputStreetTab1(/**/num + 5); } else { street = " "; }
            if (/**/l == 6) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 600) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 5)) { parking = data.OutputParkingTab1(/**/num + 5); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 5)) { GPS = data.OutPutGPS(/**/num + 5); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 5)) { typeVio = data.OutPutTypeVio(/**/num + 5); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 5)) { carnum = data.OutPutCarNum(/**/num + 5); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 5)) { cartype = data.OutPutCarType(/**/num + 5); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 7
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 7); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 6)) { street = data.OutputStreetTab1(/**/num + 6); } else { street = " "; }
            if (/**/l == 7) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 700) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 6)) { parking = data.OutputParkingTab1(/**/num + 6); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 6)) { GPS = data.OutPutGPS(/**/num + 6); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 6)) { typeVio = data.OutPutTypeVio(/**/num + 6); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 6)) { carnum = data.OutPutCarNum(/**/num + 6); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 6)) { cartype = data.OutPutCarType(/**/num + 6); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 8
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 8); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 7)) { street = data.OutputStreetTab1(/**/num + 7); } else { street = " "; }
            if (/**/l == 8) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 800) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 7)) { parking = data.OutputParkingTab1(/**/num + 7); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 7)) { GPS = data.OutPutGPS(/**/num + 7); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 7)) { typeVio = data.OutPutTypeVio(/**/num + 7); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 7)) { carnum = data.OutPutCarNum(/**/num + 7); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 7)) { cartype = data.OutPutCarType(/**/num + 7); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 9
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 9); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 8)) { street = data.OutputStreetTab1(/**/num + 8); } else { street = " "; }
            if (/**/l == 9) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 900) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 8)) { parking = data.OutputParkingTab1(/**/num + 8); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 8)) { GPS = data.OutPutGPS(/**/num + 8); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 8)) { typeVio = data.OutPutTypeVio(/**/num + 8); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 8)) { carnum = data.OutPutCarNum(/**/num + 8); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 8)) { cartype = data.OutPutCarType(/**/num + 8); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 10
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 10); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 9)) { street = data.OutputStreetTab1(/**/num + 9); } else { street = " "; }
            if (/**/l == 10) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1000) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 9)) { parking = data.OutputParkingTab1(/**/num + 9); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 9)) { GPS = data.OutPutGPS(/**/num + 9); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 9)) { typeVio = data.OutPutTypeVio(/**/num + 9); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 9)) { carnum = data.OutPutCarNum(/**/num + 9); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 9)) { cartype = data.OutPutCarType(/**/num + 9); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 11
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 11); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 10)) { street = data.OutputStreetTab1(/**/num + 10); } else { street = " "; }
            if (/**/l == 11) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1100) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 10)) { parking = data.OutputParkingTab1(/**/num + 10); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 10)) { GPS = data.OutPutGPS(/**/num + 10); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 10)) { typeVio = data.OutPutTypeVio(/**/num + 10); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 10)) { carnum = data.OutPutCarNum(/**/num + 10); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 10)) { cartype = data.OutPutCarType(/**/num + 10); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 12
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 12); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 11)) { street = data.OutputStreetTab1(/**/num + 11); } else { street = " "; }
            if (/**/l == 12) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1200) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 11)) { parking = data.OutputParkingTab1(/**/num + 11); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 11)) { GPS = data.OutPutGPS(/**/num + 11); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 11)) { typeVio = data.OutPutTypeVio(/**/num + 11); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 11)) { carnum = data.OutPutCarNum(/**/num + 11); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 11)) { cartype = data.OutPutCarType(/**/num + 11); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 13
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 13); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 12)) { street = data.OutputStreetTab1(/**/num + 12); } else { street = " "; }
            if (/**/l == 13) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1300) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 12)) { parking = data.OutputParkingTab1(/**/num + 12); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 12)) { GPS = data.OutPutGPS(/**/num + 12); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 12)) { typeVio = data.OutPutTypeVio(/**/num + 12); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 12)) { carnum = data.OutPutCarNum(/**/num + 12); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 12)) { cartype = data.OutPutCarType(/**/num + 12); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 14
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 14); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 13)) { street = data.OutputStreetTab1(/**/num + 13); } else { street = " "; }
            if (/**/l == 14) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1400) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 13)) { parking = data.OutputParkingTab1(/**/num + 13); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 13)) { GPS = data.OutPutGPS(/**/num + 13); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 13)) { typeVio = data.OutPutTypeVio(/**/num + 13); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 13)) { carnum = data.OutPutCarNum(/**/num + 13); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 13)) { cartype = data.OutPutCarType(/**/num + 13); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 15
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 15); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 14)) { street = data.OutputStreetTab1(/**/num + 14); } else { street = " "; }
            if (/**/l == 15) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1500) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 14)) { parking = data.OutputParkingTab1(/**/num + 14); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 14)) { GPS = data.OutPutGPS(/**/num + 14); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 14)) { typeVio = data.OutPutTypeVio(/**/num + 14); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 14)) { carnum = data.OutPutCarNum(/**/num + 14); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 14)) { cartype = data.OutPutCarType(/**/num + 14); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 16
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 16); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 15)) { street = data.OutputStreetTab1(/**/num + 15); } else { street = " "; }
            if (/**/l == 16) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1600) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 15)) { parking = data.OutputParkingTab1(/**/num + 15); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 15)) { GPS = data.OutPutGPS(/**/num + 15); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 15)) { typeVio = data.OutPutTypeVio(/**/num + 15); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 15)) { carnum = data.OutPutCarNum(/**/num + 15); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 15)) { cartype = data.OutPutCarType(/**/num + 15); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 17
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 17); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 16)) { street = data.OutputStreetTab1(/**/num + 16); } else { street = " "; }
            if (/**/l == 17) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1700) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 16)) { parking = data.OutputParkingTab1(/**/num + 16); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 16)) { GPS = data.OutPutGPS(/**/num + 16); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 16)) { typeVio = data.OutPutTypeVio(/**/num + 16); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 16)) { carnum = data.OutPutCarNum(/**/num + 16); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 16)) { cartype = data.OutPutCarType(/**/num + 16); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 18
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 18); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 17)) { street = data.OutputStreetTab1(/**/num + 17); } else { street = " "; }
            if (/**/l == 18) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1800) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 17)) { parking = data.OutputParkingTab1(/**/num + 17); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 17)) { GPS = data.OutPutGPS(/**/num + 17); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 17)) { typeVio = data.OutPutTypeVio(/**/num + 17); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 17)) { carnum = data.OutPutCarNum(/**/num + 17); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 17)) { cartype = data.OutPutCarType(/**/num + 17); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 19
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 19); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 18)) { street = data.OutputStreetTab1(/**/num + 18); } else { street = " "; }
            if (/**/l == 19) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 1900) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 18)) { parking = data.OutputParkingTab1(/**/num + 18); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 18)) { GPS = data.OutPutGPS(/**/num + 18); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 18)) { typeVio = data.OutPutTypeVio(/**/num + 18); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 18)) { carnum = data.OutPutCarNum(/**/num + 18); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 18)) { cartype = data.OutPutCarType(/**/num + 18); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            //Begin 20
            Console.Write("║");
            number = Convert.ToString(/**/num1 + 20); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
            if ((count - 1) >= (/**/num + 19)) { street = data.OutputStreetTab1(/**/num + 19); } else { street = " "; }
            if (/**/l == 20) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if (/**/l == 2000) { Console.BackgroundColor = ConsoleColor.Blue; }
            if ((count - 1) >= (/**/num + 19)) { parking = data.OutputParkingTab1(/**/num + 19); } else { parking = " "; }
            Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.Write(" ║ ");
            if ((count - 1) >= (/**/num + 19)) { GPS = data.OutPutGPS(/**/num + 19); } else { GPS = " "; }
            Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 19)) { typeVio = data.OutPutTypeVio(/**/num + 18); } else { typeVio = " "; }
            Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 19)) { carnum = data.OutPutCarNum(/**/num + 19); } else { carnum = " "; }
            Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
            if ((count - 1) >= (/**/num + 19)) { cartype = data.OutPutCarType(/**/num + 19); } else { cartype = " "; }
            Console.Write(cartype); p = 28 - cartype.Length; Console.WriteLine(new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            //End
            Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 20) + "╥" + new string('─', 31) + "╨" + new string('─', 52) + "╨" + new string('─', 32) + "╨" + new string('─', 43) + "╨" + new string('─', 12) + "╨" + new string('─', 14) + "╥" + new string('─', 7) + "╥" + new string('─', 7) + "╢");
            Console.Write("║ ");
            if (l == 21) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(Main);
            Console.ResetColor();
            Console.Write(" ║");
            Console.Write(new string(' ', 188));
            Console.Write(" ║");
            if (l == 2100) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write("║ ");
            if (l == 210000) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Next);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 24) + "╨" + new string('─', 189) + "╨" + new string('─', 7) + "╨" + new string('─', 7) + "╜");
            num1 = 0;
        }

        //Вывод подробной информации об улице
        public void PrintStreetMoreInfo(int ind)
        {
            //Экземпляр класса с данными
            Data data = new Data();

            string name = data.OutputStreetNameTab1(ind - 1);
            string len = data.OutputStreetLengthsTab1(ind - 1);
            string number = Convert.ToString(ind);
            int p = 0;

            Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 52) + "╥" + new string('─', 52) + "╖");
            Console.WriteLine("║" + " № " + "║" + new string(' ', 19) + "Название улицы" + new string(' ', 19) + "║" + new string(' ', 21) + "Длина улицы" + new string(' ', 20) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╢");
            p = 3 - number.Length;
            Console.Write("║" + number + new string(' ', p) + "║");
            p = 50 - name.Length;
            Console.Write(" " + name + new string(' ', p) + " ║ ");
            p = 50 - len.Length;
            Console.WriteLine(len + new string(' ', p) + " ║");
            Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 52) + "╨" + new string('─', 52) + "╢");
            Console.WriteLine("║" + new string(' ', 35) + "Нажмите любую клавишу чтобы закрыть окно" + new string(' ', 34) + "║");
            Console.WriteLine("╙" + new string('─', 3) + "─" + new string('─', 52) + "─" + new string('─', 52) + "╜");
            //╙ ╨ ╜
            Console.ReadKey();

        }

        //Вывод подробной информации об парковке
        public void PrintParkingMoreInfo(int ind)
        {
            //Экземпляр класса с данными
            Data data = new Data();

            string name = data.OutputParkingNameTab1(ind - 1);
            string adress = data.OutputParkingAdressTab1(ind - 1);
            string numberp = data.OutputParkingNumberTab1(ind - 1);
            string number = Convert.ToString(ind);
            int p = 0;

            Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 32) + "╥" + new string('─', 52) + "╥" + new string('─', 24) + "╖");
            Console.WriteLine("║" + " № " + "║" + new string(' ', 6) + "Название автостоянки" + new string(' ', 6) + "║" + new string(' ', 18) + "Адрес автостоянки" + new string(' ', 17) + "║" + new string(' ', 2) + "Телефон автостоянки" + new string(' ', 3) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
            Console.Write("║" + number);
            p = 3 - number.Length;
            Console.Write(new string(' ', p) + "║ ");
            p = 30 - name.Length;
            Console.Write(name);
            Console.Write(new string(' ', p));
            Console.Write(" ║ ");
            p = 51 - adress.Length;
            Console.Write(adress);
            Console.Write(new string(' ', p));
            Console.Write("║ ");
            p = 23 - numberp.Length;
            Console.Write(numberp);
            Console.Write(new string(' ', p));
            Console.WriteLine("║");
            Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 32) + "╨" + new string('─', 52) + "╨" + new string('─', 24) + "╢");
            Console.WriteLine("║" + new string(' ', 37) + "Нажмите любую клавишу чтобы закрыть окно" + new string(' ', 37) + "║");
            Console.WriteLine("╙" + new string('─', 3) + "─" + new string('─', 32) + "─" + new string('─', 52) + "─" + new string('─', 24) + "╜");
            //╙ ╨ ╜
            Console.ReadKey();
        }

        //Метод построения меню редактирования элементов
        public void EditElementsMenu(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "            Редактирование            " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(EditStreet);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 69) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(EditParking);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 62) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(EditAct);
            Console.ResetColor();
            Console.WriteLine(new string(' ', 58) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(BackBig);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню выбора улицы для редактирования
        public void EditStreetsMenu(int j, int num)
        {
            const string Next = "Далее";
            int k = 1;
            Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 52) + "╥" + new string('─', 52) + "╖");
            Console.WriteLine("║" + " № " + "║" + new string(' ', 19) + "Название улицы" + new string(' ', 19) + "║" + new string(' ', 21) + "Длина улицы" + new string(' ', 20) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╢");
            int count = data.CountTab2();
            for (int i = num - 1; i < (num + 19); i++)
            {
                string strname = " ";
                string strlength = " ";
                Console.Write("║");
                if (j == k) { Console.BackgroundColor = ConsoleColor.Blue; }
                string number = Convert.ToString(i + 1);
                Console.Write(number);
                int g = 3 - number.Length;
                Console.Write(new string(' ', g) + "║ ");
                if ((count - 1) >= (i)) { strname = data.OutPutSt(i); } else { strname = " "; }
                int p = 50 - strname.Length;
                Console.Write(strname);
                Console.Write(new string(' ', p));
                Console.Write(" ║ ");
                if ((count - 1) >= (i)) { strlength = data.OutPutStl(i); } else { strlength = " "; }
                p = 51 - strlength.Length;
                Console.Write(strlength);
                Console.Write(new string(' ', p));
                Console.ResetColor();
                Console.WriteLine("║");
                Console.WriteLine("╟" + "───╫" + new string('─', 52) + "╫" + new string('─', 52) + "╢");
                k++;
            }
            Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 20) + "╥" + new string('─', 31) + "╨" + new string('─', 36) + "╥" + new string('─', 7) + "╥" + new string('─', 7) + "╢");
            Console.Write("║ ");
            if (j == 21) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write("     Назад в меню     ");
            Console.ResetColor();
            Console.Write(" ║");
            Console.Write(new string(' ', 67));
            Console.Write(" ║");
            if (j == 2100) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write("║ ");
            if (j == 210000) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Next);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 24) + "╨" + new string('─', 68) + "╨" + new string('─', 7) + "╨" + new string('─', 7) + "╜");
        }

        //Метод построения меню выбора автостоянки для редактирования
        public void EditParkingMenu(int j, int num)
        {
            const string Next = "Далее";
            int k = 1;
            Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 32) + "╥" + new string('─', 52) + "╥" + new string('─', 24) + "╖");
            Console.WriteLine("║" + " № " + "║" + new string(' ', 6) + "Название автостоянки" + new string(' ', 6) + "║" + new string(' ', 18) + "Адрес автостоянки" + new string(' ', 17) + "║" + new string(' ', 2) + "Телефон автостоянки" + new string(' ', 3) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
            int count = data.CountTab3();
            string prkadress = " ";
            string prkname = " ";
            string prknumber = " ";
            for (int i = num - 1; i < (num + 19); i++)
            {
                Console.Write("║");
                string number = Convert.ToString(i + 1);
                if (j == k) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(number);
                int g = 3 - number.Length;
                Console.Write(new string(' ', g) + "║ ");
                if ((count - 1) >= (i)) { prkname = data.OutPutPrkname(i); } else { prkname = " "; }
                int p = 30 - prkname.Length;
                Console.Write(prkname);
                Console.Write(new string(' ', p));
                Console.Write(" ║ ");
                if ((count - 1) >= (i)) { prkadress = data.OutPutPrkadress(i); } else { prkadress = " "; }
                p = 51 - prkadress.Length;
                Console.Write(prkadress);
                Console.Write(new string(' ', p));
                Console.Write("║ ");
                if ((count - 1) >= (i)) { prknumber = data.OutPutPrknumber(i); } else { prknumber = " "; }
                p = 23 - prknumber.Length;
                Console.Write(prknumber);
                Console.Write(new string(' ', p));
                Console.ResetColor();
                Console.WriteLine("║");
                Console.WriteLine("╟" + "───╫" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
                k++;
            }
            Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 20) + "╥" + new string('─', 11) + "╨" + new string('─', 52) + "╨" + new string('─', 8) + "╥" + new string('─', 7) + "╥" + new string('─', 7) + "╢");
            Console.Write("║ ");
            if (j == 21) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write("     Назад в меню     ");
            Console.ResetColor();
            Console.Write(" ║");
            Console.Write(new string(' ', 72));
            Console.Write(" ║");
            if (j == 2100) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write("║ ");
            if (j == 210000) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Next);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 24) + "╨" + new string('─', 73) + "╨" + new string('─', 7) + "╨" + new string('─', 7) + "╜");
        }

        //Метод построения меню редактирования выбранной улицы
        public void EditStreetElement(int j, string stname, string stlen)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "          Редактирование улицы        " + new string(' ', 26) + "║");
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

        //Метод построения меню выбора автостоянки для редактирования
        public void EditParkingElement(int j, string prkname, string prkadress, string prknumber)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "       Редактирование автостоянки     " + new string(' ', 26) + "║");
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

        //Метод построения меню выбора акта эвакуации для редактирования
        public void EditActElement(int j, string gps, string typeviolation, string numberofcar, string typeofcar, string street, string parking)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "      Редактирование акта эвакуации   " + new string(' ', 26) + "║");
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

        //Метод потсроения меню акта эвакуации для редактирования
        public void EditActsMenu(int j, int num)
        {
            Data data = new Data();
            //Константы для пунктов выбора
            const string Next = "Далее";
            int k = 1;
            //                                 №                           Улица                   Автостоянка                       GPS                Тип нарушения                 Номер машины                  Тип машины
            Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 52) + "╥" + new string('─', 52) + "╥" + new string('─', 32) + "╥" + new string('─', 43) + "╥" + new string('─', 12) + "╥" + new string('─', 30) + "╖");
            Console.WriteLine("║" + " № " + "║" + new string(' ', 23) + "Улица" + new string(' ', 24) + "║" + new string(' ', 20) + "Автостоянка" + new string(' ', 21) + "║" + new string(' ', 9) + "GPS-координаты" + new string(' ', 9) + "║" + new string(' ', 15) + "Тип нарушения" + new string(' ', 15) + "║" + new string(' ', 0) + "Номер машины" + new string(' ', 0) + "║" + new string(' ', 8) + "Тип автомобиля" + new string(' ', 8) + "║");
            Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
            int count = data.CountTab1();
            string street = " ";
            string parking = " ";
            string GPS = " ";
            string typeVio = " ";
            string carnum = " ";
            string cartype = " ";
            string number = " ";
            int p = 0;
            int num1 = 0;
            num1 = num - 1;
            num--;

            for (int i = num - 1; i < (num + 19); i++)
            {
                Console.Write("║");
                if (/**/j == k) { Console.BackgroundColor = ConsoleColor.Blue; }
                number = Convert.ToString(/**/i + 2); Console.Write(number); p = 3 - number.Length; Console.Write(new string(' ', p) + "║ ");
                if ((count - 1) >= (/**/i + 1)) { street = data.OutputStreetTab1(/**/i + 1); } else { street = " "; }
                Console.Write(street); p = 50 - street.Length; Console.Write(new string(' ', p)); Console.Write(" ║ ");
                if ((count - 1) >= (/**/i + 1)) { parking = data.OutputParkingTab1(/**/i + 1); } else { parking = " "; }
                Console.Write(parking); p = 50 - parking.Length; Console.Write(new string(' ', p)); Console.Write(" ║ ");
                if ((count - 1) >= (/**/i + 1)) { GPS = data.OutPutGPS(/**/i + 1); } else { GPS = " "; }
                Console.Write(GPS); p = 30 - GPS.Length; Console.Write(new string(' ', p) + " ║ ");
                if ((count - 1) >= (/**/i + 1)) { typeVio = data.OutPutTypeVio(/**/i + 1); } else { typeVio = " "; }
                Console.Write(typeVio); p = 41 - typeVio.Length; Console.Write(new string(' ', p) + " ║ ");
                if ((count - 1) >= (/**/i + 1)) { carnum = data.OutPutCarNum(/**/i + 1); } else { carnum = " "; }
                Console.Write(carnum); p = 10 - carnum.Length; Console.Write(new string(' ', p) + " ║ ");
                if ((count - 1) >= (/**/i + 1)) { cartype = data.OutPutCarType(/**/i + 1); } else { cartype = " "; }
                Console.Write(cartype); p = 28 - cartype.Length; Console.Write(new string(' ', p)); Console.ResetColor(); Console.WriteLine(" ║");
                Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╫" + new string('─', 32) + "╫" + new string('─', 43) + "╫" + new string('─', 12) + "╫" + new string('─', 30) + "╢");
                k++;
            }
            Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 20) + "╥" + new string('─', 31) + "╨" + new string('─', 52) + "╨" + new string('─', 32) + "╨" + new string('─', 43) + "╨" + new string('─', 12) + "╨" + new string('─', 14) + "╥" + new string('─', 7) + "╥" + new string('─', 7) + "╢");
            Console.Write("║ ");
            if (j == 21) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write("     Назад в меню     ");
            Console.ResetColor();
            Console.Write(" ║");
            Console.Write(new string(' ', 188));
            Console.Write(" ║");
            if (j == 2100) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Back);
            Console.ResetColor();
            Console.Write("║ ");
            if (j == 210000) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(Next);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 24) + "╨" + new string('─', 189) + "╨" + new string('─', 7) + "╨" + new string('─', 7) + "╜");
            Console.WriteLine();
        }

        //Метод построения меню сортировки
        public void SortMenu(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "           Сортировка элементов       " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Сортировка улиц");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 73) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Сортировка автостоянок");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 66) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Сортировка актов эвакуаций");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 62) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(ExitMain);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню сортировки улиц
        public void SortStreets(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "              Сортировка улиц         " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Название улицы        А-Я");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 63) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Название улицы        Я-А");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 63) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Длина улицы           по возрастанию");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 52) + "║");
            Console.Write("║ " + " ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Длина улицы           по убыванию");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 55) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 5) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(BackBig);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");

        }

        //Метод построения меню сортировки улиц
        public void SortParkings(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "          Сортировка автостоянок      " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Название автостоянки        А-Я");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 57) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Название автостоянки        Я-А");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 57) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Адрес автостоянки           А-Я");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 57) + "║");
            Console.Write("║ " + " ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Адрес автостоянки           Я-А");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 57) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 5) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(BackBig);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню сортировки актов эвакуаций
        public void SortActs(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "        Сортировка актов эвакуаций    " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Улица            А-Я");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 68) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Улица            Я-А");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 68) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Автостоянка      А-Я");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 68) + "║");
            Console.Write("║ " + " ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Автостоянка      Я-А");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 68) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 5) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(BackBig);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения главного меню поиска
        public void SearchMenu(int j)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "              Поиск элементов         " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ " + " ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Поиск улиц");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 78) + "║");
            Console.Write("║ " + " ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Поиск автостоянок");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 71) + "║");
            Console.Write("║ " + " ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Поиск актов эвакуаций");
            Console.ResetColor();
            Console.WriteLine(new string(' ', 67) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(ExitMain);
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }

        //Метод построения меню поиска улиц
        public void SearchStreets(int j, string search, int num)
        {
            Console.WriteLine("╓" + new string('─', 109) + "╖");
            Console.WriteLine("║" + new string(' ', 35) + "                Поиск улиц            " + new string(' ', 36) + "║");
            Console.WriteLine("╟" + new string('─', 109) + "╢");
            Console.Write("║  "); if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            int p = 100 - search.Length;
            Console.Write("Ввод: " + search + new string(' ', p));
            Console.ResetColor();  Console.WriteLine(" ║");
            data.SearchStreet(search, num);
            Console.WriteLine("╟" + new string('─', 3) + "─" + new string('─', 20) + "─" + new string('─', 31) + "╨" + new string('─', 36) + "─" + new string('─', 7) + "─" + new string('─', 7) + "╢");
            Console.Write("║ ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write("  Назад в меню  ");
            Console.ResetColor();
            Console.Write(new string(' ', 69));
            if (j == 20) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(" Назад ");
            Console.ResetColor();
            Console.Write(new string(' ',8));
            if (j == 200) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(" Далее ");
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 109) + "╜");
        }

        //Метод построения меню поиска автостоянок
        public void SearchParkings(int j, string search, int num)
        {
            Console.WriteLine("╓" + new string('─', 110) + "╖");
            Console.WriteLine("║" + new string(' ', 36) + "            Поиск автостоянок         " + new string(' ', 36) + "║");
            Console.WriteLine("╟" + new string('─', 32) + "─" + new string('─', 52) + "─" + new string('─', 24) + "╢");
            Console.Write("║  "); if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            int p = 101 - search.Length;
            Console.Write("Ввод: " + search + new string(' ', p));
            Console.ResetColor(); Console.WriteLine(" ║");
            data.SearchParking(search, num);
            Console.WriteLine("║" + new string('─', 32) + "╨" + new string('─', 52) + "╨" + new string('─', 24) + "╢");
            Console.Write("║ ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write("  Назад в меню  ");
            Console.ResetColor();
            Console.Write(new string(' ', 69));
            if (j == 20) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(" Назад ");
            Console.ResetColor();
            Console.Write(new string(' ', 8));
            if (j == 200) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(" Далее ");
            Console.ResetColor();
            Console.WriteLine("  ║");
            Console.WriteLine("╙" + new string('─', 110) + "╜");

        }

        //Метод построения меню поиска актов эвакуаций
        public void SearchActs(int j, string search)
        {
            Console.WriteLine("╓" + new string('─', 226) + "╖");
            Console.WriteLine("║" + new string(' ', 94) + "          Поиск актов эвакуаций       " + new string(' ', 94) + "║");
            Console.WriteLine("╟" + new string('─', 226) + "╢");
            Console.Write("║  "); if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            int p = 217 - search.Length;
            Console.Write("Ввод: " + search + new string(' ',p));
            Console.ResetColor(); Console.WriteLine(" ║");
            data.SearchAct(search);
            Console.WriteLine("╟" + new string('─', 52) + "╨" + new string('─', 52) + "╨" + new string('─', 32) + "╨" + new string('─', 43) + "╨" + new string('─', 12) + "╨" + new string('─', 30) + "╢");
            Console.Write("║ ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.DarkRed; }
            Console.Write(new string(' ',68) + BackBig + new string(' ',68));
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 226) + "╜");
        }

        public void SearchFileMenu(int j, string name)
        {
            Console.WriteLine("╓" + new string('─', 90) + "╖");
            Console.WriteLine("║" + new string(' ', 26) + "             Загрузка файла           " + new string(' ', 26) + "║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 1) { Console.BackgroundColor = ConsoleColor.Blue; }
            int p = 82 - data.FileName.Length;
            Console.Write(File + data.FileName + new string(' ',p));
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Чтение"); Console.ResetColor(); Console.Write(new string(' ',82));            
            Console.WriteLine(" ║");
            Console.Write("║ ");
            if (j == 3) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write("Сохранение"); Console.ResetColor(); Console.Write(new string(' ', 78));
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╟" + new string('─', 90) + "╢");
            Console.Write("║ ");
            if (j == 4) { Console.BackgroundColor = ConsoleColor.Blue; }
            Console.Write(BackBig); Console.ResetColor();
            Console.ResetColor();
            Console.WriteLine(" ║");
            Console.WriteLine("╙" + new string('─', 90) + "╜");
        }
    }
}
