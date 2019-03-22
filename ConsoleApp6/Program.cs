using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/*2-18 База данных эвакуированных автомобилей: Таблица улиц: название, длина. Таблица штрафных авто-
стоянок: название, адрес, телефон. Таблица актов эвакуации: улица, автостоянка, GPS-координаты, тип
нарушения (стоянка на проезжей части в месте запрета, стояна на тротуаре, стоянка на газоне), номер
автомобиля, тип автомобиля (легковой/грузовой малой тонажности/грузовой большой тонажности).*/


//Таблица улиц               |   Название улицы   |    Длина улицы      |

//Таблица автостоянок        |   Название автостоянки   |   Адрес автостоянки    |   Телефон автостоянки   |

//Таблица актов эвакуации    |   Улица   |   Автостоянка   |   GPS - координаты   |   Тип нарушения   |   Номер автомобиля   |   Тип автомобиля   |




//    ----->3140

namespace ConsoleApp6
{
    public class Program
    {
        //Метод для считывания клавиш в главном меню
        public static void Main()
        {
            //Очистка консоли
            Console.Clear();

            Consolebd consolebd = new Consolebd();

            //Инициализация переменной для считывания кливиши
            ConsoleKeyInfo key;

            int j = 1;
            //Вызов метода построения главного меню
            consolebd.MainMenu(j);

            //Цикл для главного меню
            do
            {
                //Считывание информации о нажатой клавише
                key = Console.ReadKey(true);

                //If для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                {
                    //Очистка консоли
                    Console.Clear();

                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            j--;
                            if (j < 1) { j = 7; }
                            if (j > 7) { j = 1; }
                            break;
                        case ConsoleKey.DownArrow:
                            j++;
                            if (j < 1) { j = 7; }
                            if (j > 7) { j = 1; }
                            break;
                    }

                    consolebd.MainMenu(j);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (j)
                        {
                            //Загрузка файла
                            case 1:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню добавления файла
                                consolebd.SearchFileMain();

                                //Вызов метода меню добавления файла для ввода имени файла
                                SearchFileMain();
                                break;

                            //Добавить элемент
                            case 2:
                                //объявление переменной для передачи параметра
                                int c = 1;

                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню добавления автомобиля
                                consolebd.AddElement(c);

                                //Вызов метода выбора
                                AddCar();
                                break;

                            //Таблицы
                            case 3:
                                //Очистка консоли
                                Console.Clear();

                                //Объявление переменной для передачи параметра
                                int C = 1;

                                //Вызов метода построения меню добавления автомобиля
                                consolebd.Tables(C);

                                //Вызов метода выбора
                                Tables(C);
                                break;

                            //Поиск
                            case 4:
                                //Очистка консоли
                                Console.Clear();
                                break;

                            //Редактирование
                            case 5:
                                //Очистка консоли
                                Console.Clear();
                                consolebd.EditMenu(j);
                                EditMenu();
                                break;

                            //Информация
                            case 6:
                                //Очистка консоли
                                Console.Clear();
                                break;

                            //Выход
                            case 7:
                                //Объявление переменной для передачи параметра
                                int e = 2;
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню подтверждения выхода
                                consolebd.ExitMenu(e);

                                //Вызов метода вабора
                                ExitMenu(e);
                                break;

                        }

                    }
                    //
                }

            }
            while (key.Key != ConsoleKey.Enter);

        }

        //Метод для считывания клавиш для подтверждения выхода из программы
        public static void ExitMenu(int e)
        {
            Consolebd consolebd = new Consolebd();

            ConsoleKeyInfo key;


            do
            {
                // Считывание нажатой клавиши
                key = Console.ReadKey(true);

                //If для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //оператор выбора
                    switch (key.Key)
                    {
                        case ConsoleKey.RightArrow:
                            e++;
                            if (e > 2) { e = 1; }
                            if (e < 1) { e = 2; }
                            break;

                        case ConsoleKey.LeftArrow:
                            e--;
                            if (e > 2) { e = 1; }
                            if (e < 1) { e = 2; }
                            break;
                    }

                    //Вызов метода построения меню подтверждения выхода
                    consolebd.ExitMenu(e);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (e)
                        {
                            case 1:

                                break;

                            case 2:
                                Console.Clear();
                                Main();
                                break;
                        }
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
        }

        //Метод для считывания клавиш в меню добавления элементов
        public static void AddCar()
        {

            //Объявление локальных переменных для передачи данных в список
            //string tpvio;       //Тип нарушения
            //string gps;         //GPS- координаты
            //string carnum;      //Номер машины
            //string cartp;       //Тип машины
            //string strname;     //Название улицы
            //string strlength;   //Длина улицы
            //string prkname;     //Название автостоянки
            //string prkadress;   //Адрес автостоянки
            //string prknumber;   //Телефон автостоянки

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Создание экземпляра класса с полями, свойствами и методами для возвращения значений
            Data data = new Data();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменная для передачи параметра пункта меню
            int j = 1;

            do
            {
                // Считывание нажатой клавиши
                key = Console.ReadKey(true);

                //If для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //оператор выбора
                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            j++;
                            if (j > 4) { j = 1; }
                            if (j < 1) { j = 4; }
                            break;

                        case ConsoleKey.UpArrow:
                            j--;
                            if (j > 4) { j = 1; }
                            if (j < 1) { j = 4; }
                            break;
                    }

                    //Вызов метода построения меню добавления элемента
                    consolebd.AddElement(j);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (j)
                        {
                            //Добавить улицу
                            case 1:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню добавления улицы
                                consolebd.AddElemStreet(j, "", "");

                                //Вызов метода для считывания клавиш
                                AddStreet();
                                break;

                            //Добавить автостоянку
                            case 2:
                                Console.Clear();

                                //Вызов метода построения меню добавления автостоянки
                                consolebd.AddElemParking(j, " ", " ", " ");

                                //Вызов метода для считывания клавиш
                                AddParking();
                                break;

                            //Добавить акт эвакуации
                            case 3:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню добавления автостоянки
                                AddAct();
                                break;

                            //Выход в главное меню
                            case 4:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов главного меню
                                Main();

                                break;
                        }
                    }
                }

            } while (key.Key != ConsoleKey.Enter);


        }

        //Метод для считывания клавиш в меню выбора таблицы
        public static void Tables(int c)
        {
            //Создание экземпляра класса
            Consolebd consolebd = new Consolebd();

            ConsoleKeyInfo key;

            //Цикл основного блока
            do
            {

                // Считывание нажатой клавиши
                key = Console.ReadKey(true);

                //If для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //оператор выбора
                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            c++;
                            if (c > 4) { c = 1; }
                            if (c < 1) { c = 4; }
                            break;

                        case ConsoleKey.UpArrow:
                            c--;
                            if (c > 4) { c = 1; }
                            if (c < 1) { c = 4; }
                            break;
                    }

                    //Вызов метода построения меню таблиц
                    consolebd.Tables(c);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (c)
                        {
                            case 1:
                                Console.Clear();
                                OutputTabStr();
                                break;

                            case 2:
                                Console.Clear();
                                OutputTabPrk();
                                break;

                            case 3:
                                Console.Clear();
                                OutputTabAct();
                                break;

                            case 4:
                                Console.Clear();
                                Main();
                                break;
                        }
                    }

                }
            } while (key.Key != ConsoleKey.Enter);
        }

        //Метод по выводу таблицы 1 таблицы улиц
        public static void OutputTabStr()
        {
            //Создание экземпляра класса со списками
            Data data = new Data();

            int c = 1;

            ConsoleKeyInfo key;

            //Цикл основного блока
            do
            {
                Console.Clear();

                OutputTabStr1(c);

                // Считывание нажатой клавиши
                key = Console.ReadKey(true);

                //If для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //оператор выбора
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            c++;
                            if (c > 2) { c = 1; }
                            if (c < 1) { c = 2; }
                            break;

                        case ConsoleKey.RightArrow:
                            c--;
                            if (c > 2) { c = 1; }
                            if (c < 1) { c = 2; }
                            break;
                    }

                    //Вызов метода построения меню подтверждения выхода
                    OutputTabStr1(c);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (c)
                        {
                            case 1:
                                Console.Clear();
                                Main();
                                break;

                            case 2:
                                Console.Clear();
                                //
                                //
                                // ПЕРЕДЕЛАТЬ
                                //
                                //
                                Main();
                                break;

                        }
                    }

                }
            } while (key.Key != ConsoleKey.Enter);
            //Console.ReadKey();

            //Метод вывода данных таблицы улиц
            void OutputTabStr1(int c1)
            {
                //Константы для пунктов выбора
                const string Next = "Далее";
                const string Main = " Выход в главное меню ";

                Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 52) + "╥" + new string('─', 52) + "╖");
                Console.WriteLine("║" + " № " + "║" + new string(' ', 19) + "Название улицы" + new string(' ', 19) + "║" + new string(' ', 21) + "Длина улицы" + new string(' ', 20) + "║");
                Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 52) + "╫" + new string('─', 52) + "╢");
                int count = data.CountTab2();
                if (count > 20) { count = 20; }
                for (int i = 0; i < count; i++)
                {
                    Console.Write("║");
                    string number = Convert.ToString(i + 1);
                    Console.Write(number);
                    int g = 3 - number.Length;
                    Console.Write(new string(' ', g) + "║ ");
                    string strname = data.OutPutSt(i);
                    int p = 50 - strname.Length;
                    Console.Write(strname);
                    Console.Write(new string(' ', p));
                    Console.Write(" ║ ");
                    string strlength = data.OutPutStl(i);
                    p = 51 - strlength.Length;
                    Console.Write(strlength);
                    Console.Write(new string(' ', p));
                    Console.WriteLine("║");
                    Console.WriteLine("╟" + "───╫" + new string('─', 52) + "╫" + new string('─', 52) + "╢");

                }
                Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 20) + "╥" + new string('─', 31) + "╨" + new string('─', 44) + "╥" + new string('─', 7) + "╢");
                Console.Write("║ ");
                if (c1 == 1) { Console.BackgroundColor = ConsoleColor.DarkRed; }
                Console.Write(Main);
                Console.ResetColor();
                Console.Write(" ║");
                Console.Write(new string(' ', 76));
                Console.Write("║ ");
                if (c1 == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(Next);
                Console.ResetColor();
                Console.WriteLine(" ║");
                Console.WriteLine("╙" + new string('─', 24) + "╨" + new string('─', 76) + "╨" + new string('─', 7) + "╜");
            }

        }

        //Метод по выводу таблицы 2 таблицы штрафных автостоянок
        public static void OutputTabPrk()
        {
            //Создание экземпляра класса со списками
            Data data = new Data();

            int c = 1;

            ConsoleKeyInfo key;

            //Цикл основного блока
            do
            {
                Console.Clear();

                OutputTabPrk1(c);

                // Считывание нажатой клавиши
                key = Console.ReadKey(true);

                //If для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //оператор выбора
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            c++;
                            if (c > 2) { c = 1; }
                            if (c < 1) { c = 2; }
                            break;

                        case ConsoleKey.RightArrow:
                            c--;
                            if (c > 2) { c = 1; }
                            if (c < 1) { c = 2; }
                            break;
                    }

                    //Вызов метода построения меню подтверждения выхода
                    OutputTabPrk1(c);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (c)
                        {
                            case 1:
                                Console.Clear();
                                Main();
                                break;

                            case 2:
                                Console.Clear();
                                //
                                //
                                // ПЕРЕДЕЛАТЬ
                                //
                                //
                                Main();
                                break;

                        }
                    }

                }
            } while (key.Key != ConsoleKey.Enter);

            void OutputTabPrk1(int c1)
            {
                //Константы для пунктов выбора
                const string Next = "Далее";
                const string Main = " Выход в главное меню ";

                Console.WriteLine("╓" + new string('─', 3) + "╥" + new string('─', 32) + "╥" + new string('─', 52) + "╥" + new string('─', 24) + "╖");
                Console.WriteLine("║" + " № " + "║" + new string(' ', 6) + "Название автостоянки" + new string(' ', 6) + "║" + new string(' ', 18) + "Адрес автостоянки" + new string(' ', 17) + "║" + new string(' ', 2) + "Телефон автостоянки" + new string(' ', 3) + "║");
                Console.WriteLine("╟" + new string('─', 3) + "╫" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
                int count = data.CountTab3();
                if (count > 20) { count = 20; }
                for (int i = 0; i < count; i++)
                {
                    Console.Write("║");
                    string number = Convert.ToString(i + 1);
                    Console.Write(number);
                    int g = 3 - number.Length;
                    Console.Write(new string(' ', g) + "║ ");
                    string prkname = data.OutPutPrkname(i);
                    int p = 30 - prkname.Length;
                    Console.Write(prkname);
                    Console.Write(new string(' ', p));
                    Console.Write(" ║ ");
                    string prkadress = data.OutPutPrkadress(i);
                    p = 51 - prkadress.Length;
                    Console.Write(prkadress);
                    Console.Write(new string(' ', p));
                    Console.Write("║ ");
                    string prknumber = data.OutPutPrknumber(i);
                    p = 23 - prknumber.Length;
                    Console.Write(prknumber);
                    Console.Write(new string(' ', p));
                    Console.WriteLine("║");
                    Console.WriteLine("╟" + "───╫" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
                }
                Console.WriteLine("╟" + new string('─', 3) + "╨" + new string('─', 20) + "╥" + new string('─', 11) + "╨" + new string('─', 52) + "╨" + new string('─', 16) + "╥" + new string('─', 7) + "╢");
                Console.Write("║ ");
                if (c1 == 1) { Console.BackgroundColor = ConsoleColor.DarkRed; }
                Console.Write(Main);
                Console.ResetColor();
                Console.Write(" ║");
                Console.Write(new string(' ', 81) + "║ ");
                if (c1 == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(Next);
                Console.ResetColor();
                Console.WriteLine(" ║");
                Console.WriteLine("╙" + new string('─', 24) + "╨" + new string('─', 81) + "╨" + new string('─', 7) + "╜");
            }
        }

        //Метод по выводу таблицы 3 таблицы актов эвакуации
        public static void OutputTabAct()
        {
            //Создание экземпляра класса со списками
            Data data = new Data();

            int c = 1;

            ConsoleKeyInfo key;

            //Цикл основного блока
            do
            {
                Console.Clear();

                OutputTabAct1(c);

                // Считывание нажатой клавиши
                key = Console.ReadKey(true);

                //If для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //оператор выбора
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            c++;
                            if (c > 2) { c = 1; }
                            if (c < 1) { c = 2; }
                            break;

                        case ConsoleKey.RightArrow:
                            c--;
                            if (c > 2) { c = 1; }
                            if (c < 1) { c = 2; }
                            break;
                    }

                    //Вызов метода построения меню подтверждения выхода
                    OutputTabAct1(c);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (c)
                        {
                            case 1:
                                Console.Clear();
                                Main();
                                break;

                            case 2:
                                Console.Clear();
                                //
                                //
                                // ПЕРЕДЕЛАТЬ
                                //
                                //
                                Main();
                                break;

                        }
                    }

                }
            } while (key.Key != ConsoleKey.Enter);

            void OutputTabAct1(int c1)
            {
                //Константы для пунктов выбора
                const string Next = "Далее";
                const string Main = " Выход в главное меню ";

                Console.WriteLine("╓" + new string('─', 32) + "╥" + new string('─', 52) + "╥" + new string('─', 24) + "╖");
                Console.WriteLine("║" + new string(' ', 6) + "Название автостоянки" + new string(' ', 6) + "║" + new string(' ', 18) + "Адрес автостоянки" + new string(' ', 17) + "║" + new string(' ', 2) + "Телефон автостоянки" + new string(' ', 3) + "║");
                Console.WriteLine("╟" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
                int count = data.CountTab3();
                if (count > 20) { count = 20; }
                for (int i = 0; i < count; i++)
                {
                    Console.Write("║ ");
                    string prkname = data.OutPutPrkname(i);
                    int p = 30 - prkname.Length;
                    Console.Write(prkname);
                    Console.Write(new string(' ', p));
                    Console.Write(" ║ ");
                    string prkadress = data.OutPutPrkadress(i);
                    p = 51 - prkadress.Length;
                    Console.Write(prkadress);
                    Console.Write(new string(' ', p));
                    Console.Write("║ ");
                    string prknumber = data.OutPutPrknumber(i);
                    p = 23 - prknumber.Length;
                    Console.Write(prknumber);
                    Console.Write(new string(' ', p));
                    Console.WriteLine("║");
                    Console.WriteLine("╟" + new string('─', 32) + "╫" + new string('─', 52) + "╫" + new string('─', 24) + "╢");
                }
                Console.Write("║" + new string(' ', 5));
                if (c1 == 1) { Console.BackgroundColor = ConsoleColor.DarkRed; }
                Console.Write(Main);
                Console.ResetColor();
                Console.Write(new string(' ', 5));
                Console.Write("║");
                Console.Write(new string(' ', 52) + "║");
                Console.Write(new string(' ', 9));
                if (c1 == 2) { Console.BackgroundColor = ConsoleColor.Blue; }
                Console.Write(Next);
                Console.ResetColor();
                Console.WriteLine(new string(' ', 10) + "║");
                Console.WriteLine("╙" + new string('─', 32) + "╨" + new string('─', 52) + "╨" + new string('─', 24) + "╜");
            }  //ПЕРЕДЕЛАТЬ

            int co = data.CountTab3();

            if (co > 20)
            {
                Console.Clear();
                OutputTabAct2(c);
            }

            void OutputTabAct2(int c1)
            {
                //Константы для пунктов выбора
                //const string Next = "Далее";
                //const string Back = " Назад ";

                int count = data.CountTab2();

                if (count > 40) { count = 40; }
                for (int i = 21; i < count; i++)
                {

                }
            }

            co = data.CountTab2();

            if (co > 60)
            {
                Console.Clear();
                OutputTabAct3();
            }

            void OutputTabAct3()
            {
                //Константы для пунктов выбора
                //const string Next = "Далее";
                //const string Back = " Назад ";

                int count = data.CountTab3();

                if (count > 40) { count = 40; }
                for (int i = 21; i < count; i++)
                {

                }
            }
        }

        //Метод меню добавления файла
        public static void SearchFileMain()
        {
            Console.Clear();

            //Создание экземпляра класса с консольными таблицами
            Consolebd consolebd = new Consolebd();

            consolebd.SearchFileMain();

            //Создание экземпляра класса с хранящимися данными
            Data data = new Data();

            //Передача имени файла через свойство 
            data.FileName = Console.ReadLine();

            int FileNameLength = data.FileName.Length;

            if (FileNameLength == 0)
            {
                AttentionSearchFile();
            }

            //Переменная, принимающая длину строки имени файла
            int leng = data.FilenameLength();

            //Проверка на длину строки

            if (leng > 50)
            {
                Console.Clear();

                consolebd.Attention();

                Console.Clear();

                consolebd.SearchFileMain();

                SearchFileMain();

            }

            //Очистка консоли
            Console.Clear();

            //Вызов метода построения меню 2 добавления файла
            consolebd.SearchFile1();


        }

        //Метод предупреждения в меню поиска файла
        public static void AttentionSearchFile()
        {
            Consolebd consolebd = new Consolebd();

            Console.Clear();

            consolebd.AttentionSerachFile();

            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        Console.Clear();
                        SearchFileMain();
                        break;

                }
            } while (key.Key != ConsoleKey.Enter);
        }

        //Метод меню редактирования элемента
        public static void EditMenu()
        {
            //Очистка консоли
            Console.Clear();

            //Экземпляр класса методов построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для хранения информации о нажатой кнопке
            ConsoleKeyInfo key;

            //Создание и инициализация переменной для выбора пункта меню
            int j = 1;

            //Вызов метода построения меню редактирования
            consolebd.EditMenu(j);

            //Цикл считывания клавиш
            do
            {
                //Считывание информации о нажатой кнопке
                key = Console.ReadKey(true);

                //Условие для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    //очистка консоли
                    Console.Clear();

                    switch (key.Key)
                    {
                        //UPARROW
                        case ConsoleKey.UpArrow:
                            j--;
                            if (j < 1) { j = 3; }
                            if (j > 3) { j = 1; }
                            break;

                        //DOWNARROW
                        case ConsoleKey.DownArrow:
                            j++;
                            if (j < 1) { j = 3; }
                            if (j > 3) { j = 1; }
                            break;

                    }

                    //Вызов метода построения меню редактирования с передачей параметра
                    consolebd.EditMenu(j);

                    //Выбор пункта меню редактирования
                    if (key.Key == ConsoleKey.Enter)
                    {
                        //Метод выбора
                        switch (j)
                        {
                            //1 ПУНКТ УДАЛЕНИЕ
                            case 1:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню удаления
                                DeleteMenu();
                                break;

                            //2 ПУНКТ РЕДАКТИРОВАНИЕ
                            case 2:
                                //Очистка консоли
                                Console.Clear();

                                break;

                            //3 ПУНКТ ВЫХОД В ГЛАВНОЕ МЕНЮ
                            case 3:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов главного меню
                                Main();
                                break;
                        }
                    }

                }

            } while (key.Key != ConsoleKey.Enter);
        }

        //Метод меню удаления элемента
        public static void DeleteMenu()
        {
            //Очистка консоли
            Console.Clear();

            //Создание экземпляра класса построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Создание и инициализация переменной для выбора пункта меню
            int j = 1;

            //Очистка консоли
            Console.Clear();

            //Вызов метода построения меню удаления элемента
            consolebd.DeleteMenu(j);

            //Цикл считывания клавиши
            do
            {
                //Считывание информации о нажатой клавише
                key = Console.ReadKey(true);

                //Условие для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    //очистка консоли
                    Console.Clear();

                    switch (key.Key)
                    {
                        //UPARROW
                        case ConsoleKey.UpArrow:
                            j--;
                            if (j < 1) { j = 4; }
                            if (j > 4) { j = 1; }
                            break;

                        //DOWNARROW
                        case ConsoleKey.DownArrow:
                            j++;
                            if (j < 1) { j = 4; }
                            if (j > 4) { j = 1; }
                            break;

                    }

                    //Вызов метода построения меню удаления элемента с передачей параметра
                    consolebd.DeleteMenu(j);

                    //Выбор пункта меню удаления
                    if (key.Key == ConsoleKey.Enter)
                    {
                        //Метод выбора
                        switch (j)
                        {
                            //1 ПУНКТ УДАЛЕНИЕ УЛИЦЫ
                            case 1:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов меню выбора способа удаления
                                consolebd.DeleteMenu(1);

                                //Вызов метода считывания нажатой клавиши
                                DeleteStreet();
                                break;

                            //2 ПУНКТ УДАЛЕНИЕ АВТОСТОЯНКИ
                            case 2:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов меню выбора способа удаления
                                consolebd.DeleteMenu(1);

                                //Вызов метода считывания нажатой клавиши
                                DeleteParking();
                                break;

                            //3 ПУНКТ УДАЛЕНИЕ АКТА ЭВАКУАЦИИ
                            case 3:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов меню выбора способа удаления
                                consolebd.DeleteMenu(1);

                                //Вызов метода считывания нажатой клавиши
                                DeleteAct();

                                break;

                            //4 ПУНКТ ВЫХОД В МЕНЮ РЕДАКТИРОВАНИЯ
                            case 4:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню редактирования
                                consolebd.EditMenu(1);

                                //Вызов метода считывания клавиш для меню редактирования
                                EditMenu();
                                break;
                        }
                    }
                }

            } while (key.Key != ConsoleKey.Enter);

        }        

        //Метод меню добаваления улицы
        public static void AddStreet()
        {
            //Переменные для считывания строки с клавиатуры, проверки, и далее передачи в список проверенной строки
            string strname = " ";     //Название улицы
            string strlength = " ";   //Длина улицы

            //Вызов вложенного метода
            AddStreetMain();

            //вложенный метод
            //используется для того, чтобы при добавлении элементов не обнулялись их значения
            void AddStreetMain()
            {

                //Очистка консоли
                Console.Clear();

                //Создание экземпляра класса построения меню
                Consolebd consolebd = new Consolebd();

                //Создание экземпляра класса с данными
                Data data = new Data();

                //Объявление переменно для хранения информации о нажатой клавише
                ConsoleKeyInfo key;

                //Объявление и инициализация переменной-счетчика для отображения выбранного пункта меню
                int j = 1;

                //Вывод меню добавления элемента
                consolebd.AddElemStreet(j, strname, strlength);

                //Основной цикл выполнения
                do
                {

                    //Считывание информации о нажатой клавише
                    key = Console.ReadKey(true);

                    //Условие для отсеивания ложных нажатий
                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                    {
                        //Очистка консоли
                        Console.Clear();

                        //оператор присвоения пункта меню
                        switch (key.Key)
                        {
                            //UPARROW
                            case ConsoleKey.UpArrow:
                                j--;
                                if (j < 1) { j = 3; }
                                if (j > 3) { j = 1; }
                                break;

                            //DOWNARROW
                            case ConsoleKey.DownArrow:
                                j++;
                                if (j < 1) { j = 3; }
                                if (j > 3) { j = 1; }
                                break;

                            //LEFTARROW
                            case ConsoleKey.LeftArrow:
                                if (j == 3 || j == 300)
                                {
                                    j /= 100;
                                    if (j < 3) { j = 300; }
                                    if (j > 300) { j = 3; }
                                }
                                break;

                            //RIGHTARROW
                            case ConsoleKey.RightArrow:
                                if (j == 3 || j == 300)
                                {
                                    j *= 100;
                                    if (j < 3) { j = 300; }
                                    if (j > 300) { j = 3; }
                                }
                                break;
                        }

                        //Вызов метода построения добавления улицы с передачей переменной в качестве параметра
                        consolebd.AddElemStreet(j, strname, strlength);

                        //Выбор пункта меню добавления улицы
                        if (key.Key == ConsoleKey.Enter)
                        {
                            //Выбор пункта мeню
                            switch (j)
                            {
                                //ввод названия улицы
                                case 1:
                                    //начало ввода названия улицы

                                    //Обнуление переменной названия улицы
                                    strname = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра 
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.AddElemStreet(0, strname, strlength);

                                    //Перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(20, 3);

                                    //Считывание строки
                                    strname = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (strname == " " || strname == null || strname.Length > 50 || strname == "")
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //Обнуление переменной названия улицы
                                        strname = " ";

                                        //Повторный вызов метода построения меню добавления улицы
                                        consolebd.AddElemStreet(1, strname, strlength);

                                        //Повторный вызов метода считывания клавиш
                                        AddStreetMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню 
                                        consolebd.AddElemStreet(1, strname, strlength);

                                        //Повторный вызов метода для считывания клавиш
                                        AddStreetMain();
                                    }

                                    break;

                                //Ввод длины улицы
                                case 2:
                                    //начало ввода длины улицы

                                    //Обнуление переменной длины улицы
                                    strlength = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра 
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.AddElemStreet(0, strname, strlength);

                                    //Перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(20, 5);

                                    //Считывание строки
                                    strlength = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (strlength == " " || strlength == null || strlength.Length > 50 || strlength == "")
                                    {
                                        //Обнуление переменной 
                                        strlength = " ";

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //Вызов метода построения меню добавления элемента
                                        consolebd.AddElemStreet(2, strname, strlength);

                                        //Вызов метода считывания нажатой клавиши
                                        AddStreetMain();

                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        double slen = 0;

                                        //дополнительная проверка на возможность конвертации значения 
                                        if (double.TryParse(strlength, out slen))
                                        {
                                            //Конвертация
                                            slen = Double.Parse(strlength);

                                            //Повторный вызов метода построения меню 
                                            consolebd.AddElemStreet(2, strname, strlength);

                                            //Повторный вызов метода для считывания клавиш
                                            AddStreetMain();
                                        }
                                        else
                                        {
                                            //обнуление введенного значения
                                            strlength = " ";

                                            //очистка консоли
                                            Console.Clear();

                                            //Вызов метода построения таблицы предупреждения
                                            consolebd.AttentionAddElement();

                                            //Повторный вызов меню добавления улицы
                                            consolebd.AddElemStreet(2, strname, strlength);

                                            //Вызов метода выбора пункта меню
                                            AddStreetMain();
                                        }
                                    }
                                    break;

                                //Назад
                                //Введенная информация не сохраняется
                                //Проиходит переход в меню добавления нового элемента
                                case 3:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов меню построения главного меню добавления элемента
                                    //С передачей в качестве параметра еденицы (для изначального отображения первого пункта меню)
                                    consolebd.AddElement(1);

                                    //Вызов метода по считыванию клавиш в главном меню добавления нового элемента
                                    AddCar();
                                    break;

                                //Сохранить
                                //Введенная информация сохраняется и записывается в список
                                //Далее проиходит переход в главное меню добавления нового элемента
                                case 300:
                                    //очистка консоли
                                    Console.Clear();

                                    //Проверка на то, что все поля заполнены

                                    //Объявление переменных для хранения промежуточного результата
                                    //Если поле удовлетворяет условиям заполнения и не пустое -> true, иначе false
                                    bool strlengthBool = false;
                                    bool strnameBool = false;
                                    bool IsAlreadyExistsStreet = false;

                                    //Проверка на пустое поле для переменной имени улицы
                                    if (strname == "" || strname == " ")
                                    {
                                        strnameBool = false;
                                    }
                                    else
                                    {
                                        strnameBool = true;
                                    }

                                    //Проверка на пустое поле для переменной длины улицы
                                    if (strlength == "" || strlength == " ")
                                    {
                                        strlengthBool = false;
                                    }
                                    else
                                    {
                                        strlengthBool = true;
                                    }

                                    //Вызов метода перебора всех элементов списка 
                                    //И присвоение результата булевой переменной
                                    IsAlreadyExistsStreet = data.IsAlreadyExistsStreet(strname);

                                    //Финальная проверка результата
                                    if (strlengthBool == false || strnameBool == false || IsAlreadyExistsStreet == false)
                                    {
                                        if (IsAlreadyExistsStreet == false)
                                        {
                                            //очистка консоли
                                            Console.Clear();

                                            //Вызов метода построения меню предупреждения
                                            consolebd.AttentionAlreadyHasStreet();

                                            //Повторный вызов метода добавления улицы
                                            consolebd.AddElemStreet(1, strname, strname);

                                            //Повторный вызов метода считывания клавиш
                                            AddStreetMain();
                                        }
                                        else
                                        {
                                            //Очистка консоли
                                            Console.Clear();

                                            //Вызов метода построения меню предупреждения
                                            consolebd.AttentionNullableFields();

                                            //Повторный вызов метода добавления улицы
                                            consolebd.AddElemStreet(1, strname, strlength);

                                            //Повторный вызов метода считывания клавиш
                                            AddStreetMain();
                                        }
                                    }
                                    else
                                    {
                                        //Добавление проверреных полей в список
                                        //Вызов метода создания нового элемента списка
                                        data.AddElementTab2();

                                        //Вызов метода, возвращающего количество элементов в списке
                                        //И присвоение этого значения переменной
                                        int ind = data.CountTab2() - 1;

                                        //Обращение к нужному элементу списка
                                        //Передача названия улицы и индекса элемента в качестве параметров
                                        data.AddElementStrname(strname, ind);

                                        //передача длины улицы и индекса элемента в качестве параметров
                                        data.AddElementStlength(strlength, ind);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Переход в главное меню добавления элемента

                                        //Вызов метода построения главного меню добовления нового элемента
                                        consolebd.AddElement(1);

                                        //Вызов метода считывания клавиши
                                        AddCar();
                                    }
                                    break;
                            }
                        }
                    }
                }
                while (key.Key != ConsoleKey.Enter);

            }
        }

        //Метод меню добавления автостоянки
        public static void AddParking()
        {
            //Переменные для считывания строки с клавиатуры, проверки, и далее передачи в список проверенной строки
            string prkname = " ";     //Название автостоянки
            string prkadress = " ";   //Адрес автостоянки
            string prknumber = " ";   //Телефон автостоянки

            //Вызов вложенного метода
            AddParkingMain();

            //вложенный метод
            //используется для того, чтобы при добавлении элементов не обнулялись их значения
            void AddParkingMain()
            {
                //Очистка консоли
                Console.Clear();

                //Создание экземпляра класса построения меню
                Consolebd consolebd = new Consolebd();

                //Создание экземпляра класса с данными
                Data data = new Data();

                //Объявление переменно для хранения информации о нажатой клавише
                ConsoleKeyInfo key;

                //Объявление и инициализация переменной-счетчика для отображения выбранного пункта меню
                int j = 1;

                //Вызов метода построения меню добавления автостоянки
                consolebd.AddElemParking(1, prkname, prkadress, prknumber);

                do
                {
                    //Считывание информации о нажатой клавише
                    key = Console.ReadKey(true);

                    //Условие для отвеивания ложных нажатий
                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                    {
                        //Очистка консоли
                        Console.Clear();

                        //Оператор присвоения пункта меню
                        switch (key.Key)
                        {
                            //UPARROW
                            case ConsoleKey.UpArrow:
                                j--;
                                if (j < 1) { j = 4; }
                                if (j > 4) { j = 1; }
                                break;

                            //DOWNARROW
                            case ConsoleKey.DownArrow:
                                j++;
                                if (j < 1) { j = 4; }
                                if (j > 4) { j = 1; }
                                break;

                            //LEFTARROW
                            case ConsoleKey.LeftArrow:
                                if (j == 4 || j == 400)
                                {
                                    j /= 100;
                                    if (j < 4) { j = 400; }
                                    if (j > 400) { j = 4; }
                                }
                                break;

                            //RIGHTARROW
                            case ConsoleKey.RightArrow:
                                if (j == 4 || j == 400)
                                {
                                    j *= 100;
                                    if (j < 4) { j = 400; }
                                    if (j > 400) { j = 4; }
                                }
                                break;
                        }

                        //Вызов метода построения добавления автостоянки с передачей переменной в качестве параметра
                        consolebd.AddElemParking(j, prkname, prkadress, prknumber);

                        //Выбор пункта меню добавления улицы
                        if (key.Key == ConsoleKey.Enter)
                        {
                            //Выбор пункта меню
                            switch (j)
                            {
                                //ввод названия автостоянки
                                case 1:
                                    //Начало ввода названия автостоянки

                                    //Обнуление переменной названия автостоянки
                                    prkname = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра 
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.AddElemParking(0, prkname, prkadress, prknumber);

                                    //перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(20, 3);

                                    //Считывание строки
                                    prkname = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (prkname == " " || prkname == null || prkname.Length > 50 || prkname == "")
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //обнуление переменной названия автостоянки
                                        prkname = " ";

                                        //Повторный вызов метода построения меню добавления автостоянки
                                        consolebd.AddElemParking(1, prkname, prkadress, prknumber);

                                        //Повторный вызов метода считывания клавиш
                                        AddParkingMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню добавления автостоянки
                                        consolebd.AddElemParking(1, prkname, prkadress, prknumber);

                                        //Повторный вызов метода для считывания клавиш
                                        AddParkingMain();
                                    }

                                    break;

                                //Ввод адреса автостоянки
                                case 2:
                                    //Начало ввода адреса автостоянки

                                    //обнуление переменной адреса автостоянки
                                    prkadress = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.AddElemParking(0, prkname, prkadress, prknumber);

                                    //Перемещение каретки в нужное положение в табоице
                                    Console.SetCursorPosition(20, 5);

                                    //Считывание строки
                                    prkadress = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (prkadress == " " || prkadress == null || prkadress.Length > 50 || prkadress == "")
                                    {
                                        //Обнуление переменной
                                        prkadress = " ";

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки 
                                        consolebd.AttentionAddElement();

                                        //Вызов метода построения меню добавления элемента
                                        consolebd.AddElemParking(2, prkname, prkadress, prknumber);

                                        //Вызов метода считывания нажатой клавиши
                                        AddParkingMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню
                                        consolebd.AddElemParking(2, prkname, prkadress, prknumber);

                                        //Повторный вызов метода для считывания клаваиш
                                        AddParkingMain();
                                    }

                                    break;

                                //Ввод номера автостоянки
                                case 3:
                                    //начало ввода номера автостоянки

                                    //Обнуление переменной номера автостоянки
                                    prknumber = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //с передачей нуля в качестве параметра
                                    //для того чтобы не было активных пунктов меню выбора
                                    consolebd.AddElemParking(0, prkname, prkadress, prknumber);

                                    //Перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(20, 7);

                                    //Считывание строки
                                    prknumber = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (prknumber == " " || prknumber == null || prknumber.Length > 50 || prknumber == "")
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов окошка ошибки
                                        consolebd.AttentionAddElement();

                                        //Обнуление переменной номера автостоянки
                                        prknumber = " ";

                                        //Повторный вызов метода построения меню добавления автостоянки
                                        consolebd.AddElemParking(1, prkname, prkadress, prknumber);

                                        //Повторный вызов метода считывания клавиш
                                        AddParkingMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню
                                        consolebd.AddElemParking(1, prkname, prkadress, prknumber);

                                        //Повторный вызов метода для считывания клавиш
                                        AddParkingMain();
                                    }
                                    break;

                                case 4:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов меню построения главного меню добавления элемента
                                    //С передачей в качестве параметра единицы
                                    consolebd.AddElement(1);

                                    //Вызов метода по считыванию клавиш в главном меню добавления нового элемента
                                    AddCar();
                                    break;

                                //Сохранить
                                //Введенная информация сохраняется и записывается в список
                                //Далее происходит переход в главное меню добавления нового элемента
                                case 400:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Проверка на то, что все поля заполнены

                                    //Объявление переменноых для хранения промежуточного результата
                                    //Если поле удовлетворяет условиям заполнения и не пустое -> true, иначе false
                                    bool prknameBool = false;
                                    bool prkadressBool = false;
                                    bool prknumberBool = false;
                                    bool IsAlreadyExistsParking = false;

                                    //Проверка на пустое поле для переменной названия автостоянки
                                    if (prkname == "" || prkname == " ")
                                    {
                                        prknameBool = false;
                                    }
                                    else
                                    {
                                        prknameBool = true;
                                    }

                                    //Проверка на пустое поле для переменной адреса автостоянки
                                    if (prkadress == "" || prkadress == " ")
                                    {
                                        prkadressBool = false;
                                    }
                                    else
                                    {
                                        prkadressBool = true;
                                    }

                                    //Проверка на пустое поле для переменной номера автостоянки
                                    if (prknumber == "" || prknumber == " ")
                                    {
                                        prknumberBool = false;
                                    }
                                    else
                                    {
                                        prknumberBool = true;
                                    }

                                    //Вызов метода перебора всех элементов списка
                                    //И присвоение результата булевой переменной
                                    IsAlreadyExistsParking = data.IsAlreadyExistsParking(prkname);

                                    //Финальная проверка результата
                                    if (prknameBool == false || prkadressBool == false || prknumberBool == false || IsAlreadyExistsParking == false)
                                    {
                                        if (IsAlreadyExistsParking == false)
                                        {
                                            //Очистка консоли
                                            Console.Clear();

                                            //Вызов метода построения меню предупреждения
                                            consolebd.AttentionAlreadyHasParking();

                                            //Повторный вызов метода добавления улицы
                                            consolebd.AddElemParking(1, prkname, prkadress, prknumber);

                                            //Повторный вызов метода считывания клавиш
                                            AddParkingMain();
                                        }
                                        else
                                        {
                                            //Очистка консоли
                                            Console.Clear();

                                            //Вызов метода построения меню предупреждения
                                            consolebd.AttentionNullableFields();

                                            //Повторный вызов метода добавления автостоянки
                                            consolebd.AddElemParking(1, prkname, prkadress, prknumber);

                                            //повторный вызов метода считывания клавиш
                                            AddParkingMain();
                                        }
                                    }
                                    else
                                    {
                                        //Добавление проверенных полей в список
                                        //Вызов метода создания нового элемента списка
                                        data.AddElementTab3();

                                        //Вызов метода, возвращающего количество элементов в списке
                                        //и присвоение этого значения переменной
                                        int ind = data.CountTab3() - 1;

                                        //Обращение к нужному элементу списка
                                        //Передача названия автостоянки и индекса элемента в качестве параметра
                                        data.Addparkingname(prkname, ind);

                                        //Передача адреса автостоянки и индекса элемента в качестве параметра
                                        data.Addparkingadress(prkadress, ind);

                                        //Передача номера автостоянки и индекса элемента в качестве параметра
                                        data.Addparkingnumber(prknumber, ind);

                                        //очистка консоли
                                        Console.Clear();

                                        //Переход в главное меню добавления элемента

                                        //Вызов метода построения главного меню добавления нового элемента
                                        consolebd.AddElement(1);

                                        //Вызов метода считывания клавиши
                                        AddCar();
                                    }
                                    break;
                            }
                        }
                    }
                } while (key.Key != ConsoleKey.Enter);
            }
        }

        //Метод меню добавления акта эвакуации
        public static void AddAct()
        {
            //Переменные для считывания строки с клавиатуры, проверки, и далее передачи в список проверенной строки
            string GPS = "";
            string typeviolation = "";
            string numberofcar = "";
            string typeofcar = "";
            string streetname = "";
            string parkingname = "";
            ElementsTab2 street;
            ElementsTab3 parking;

            //Вызов вложенного метода
            AddActEvacuation();

            //Вложенный метод
            //используется для того, чтобы при добавлении элементов не обнулялись поля
            void AddActEvacuation()
            {
                //Очистка консоли
                Console.Clear();

                //Создание экземпляра класса построения меню
                Consolebd consolebd = new Consolebd();

                //Создание экземпляра класса с данными
                Data data = new Data();

                //Объявление переменной для хранения информации о нажатой кнопке
                ConsoleKeyInfo key;

                //Объявление и инициализация переменной-счетчика для отображения выбранного пункта меню
                int j = 1;

                //Вызов метода построения меню добавления автостоянки
                consolebd.AddElemActEvacuation(1, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                do
                {
                    //Считывание информации о нажатой клавише
                    key = Console.ReadKey(true);

                    //Условие для отсеивания ложных нажатий
                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                    {
                        //Очистка консоли
                        Console.Clear();

                        //Оператор присваивания пункта меню
                        switch (key.Key)
                        {
                            //UPARROW
                            case ConsoleKey.UpArrow:
                                j--;
                                if (j < 1) { j = 7; }
                                if (j > 7) { j = 1; }
                                break;

                            //DOWNARROW
                            case ConsoleKey.DownArrow:
                                j++;
                                if (j < 1) { j = 7; }
                                if (j > 7) { j = 1; }
                                break;

                            //LEFTARROW
                            case ConsoleKey.LeftArrow:
                                if (j == 7 || j == 700)
                                {
                                    j /= 100;
                                    if (j < 7) { j = 700; }
                                    if (j > 700) { j = 7; }
                                }
                                break;

                            //RIGHTARROW
                            case ConsoleKey.RightArrow:
                                if (j == 7 || j == 700)
                                {
                                    j *= 100;
                                    if (j < 7) { j = 700; }
                                    if (j > 700) { j = 7; }
                                }
                                break;
                        }

                        //Вызов метода построения меню добавления нового акта эвакуации с передачей переменной в качестве параметра
                        consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);
                        
                        //Выбор пункта меню добавления акта эвакуации
                        if (key.Key == ConsoleKey.Enter)
                        {
                            //Выбор пункта меню
                            switch (j)
                            {
                                //Ввод GPS-координат
                                case 1:
                                    //Начало ввода gps-координат

                                    //обнуление переменной gps - координат
                                    GPS = "";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //с передачей нуля в качестве параметра
                                    //для того чтобы не было активных пунктов выбора ввода
                                    consolebd.AddElemActEvacuation(0, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                    //перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(22, 3);

                                    //Считывание строки
                                    GPS = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (GPS == " " || GPS == null || GPS == "" || GPS.Length > 50)
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //Обнуление переменной gps-координат
                                        GPS = " ";

                                        //Повторный вызов метода построения меню добавления акта эвакуации
                                        consolebd.AddElemActEvacuation(1, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                        //Повторный вызов метода считывания клавиш
                                        AddActEvacuation();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню добавления акта эвакуации
                                        consolebd.AddElemActEvacuation(1, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                        //Повторный вызов метода считывания клавиш в текущем меню
                                        AddActEvacuation();
                                    }

                                    break;

                                //Ввод типа нарушения
                                case 2:
                                    //начало ввода типа нарушения

                                    //Обнуление переменной типа нарушения
                                    typeviolation = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню выбора типа нарушения
                                    typeviolation = ChoiseTypeVoilation();

                                    //Очистка консоли
                                    Console.Clear();

                                    //Повторный вызов метода построения меню добавления акта эвакуации
                                    consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                    //Повторный вызов метода для считывания клавиш
                                    AddActEvacuation();
                                    break;

                                //Ввод номера автомобиля
                                case 3:
                                    //Начало ввода номера автомобиля

                                    //Обнуление переменной номера автомобиля
                                    numberofcar = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                    //Перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(22, 7);

                                    //Считывание строки
                                    numberofcar = Console.ReadLine();

                                    //проверка на правильность ввода
                                    if (numberofcar == "" || numberofcar == " " || numberofcar == null || numberofcar.Length > 50)
                                    {
                                        //обнуление переменной
                                        numberofcar = " ";

                                        //очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки 
                                        consolebd.AttentionAddElement();

                                        //Вызов метода построения меню для добавления акта эвакуации
                                        consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                        //Вызов метода считывания нажатой клавиши
                                        AddActEvacuation();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню
                                        consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                        //Повторный вызов метода для считывания клавиш
                                        AddActEvacuation();
                                    }

                                    break;

                                    //Добавление типа автомобиля
                                case 4:
                                    //начало ввода типа автомобиля

                                    //Обнуление переменной типа автомобиля
                                    typeofcar = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню выбора типа нарушения
                                    typeofcar = ChoiseTypeOfCar();

                                    //Очистка консоли
                                    Console.Clear();

                                    //Повторный вызов метода построения меню добавления акта эвакуации
                                    consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                    //Повторный вызов метода для считывания клавиш
                                    AddActEvacuation();
                                    break;

                                    //Улица
                                case 5:
                                    //Начало выбора улицы

                                    //обнуление переменной улицы
                                    streetname = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Переменная, принимающая значение количества элементов в списке
                                    int elementsintab = data.CountTab2();

                                    if (elementsintab > 0)
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода выбора улицы из существующих

                                    }
                                    else
                                    {
                                        //Переменные для считывания строки с клавиатуры, проверки, и далее передачи в список проверенной строки
                                        string strname = " ";     //Название улицы
                                        string strlength = " ";   //Длина улицы

                                        //Вызов вложенного метода
                                        AddStreetMain();

                                        //вложенный метод
                                        //используется для того, чтобы при добавлении элементов не обнулялись их значения
                                        void AddStreetMain()
                                        {

                                            //Очистка консоли
                                            Console.Clear();

                                            //Объявление переменно для хранения информации о нажатой клавише
                                            ConsoleKeyInfo key2;

                                            //Объявление и инициализация переменной-счетчика для отображения выбранного пункта меню
                                            int j1 = 1;

                                            //Вывод меню добавления элемента
                                            consolebd.AddElemStreet(j1, strname, strlength);

                                            //Основной цикл выполнения
                                            do
                                            {

                                                //Считывание информации о нажатой клавише
                                                key2 = Console.ReadKey(true);

                                                //Условие для отсеивания ложных нажатий
                                                if (key2.Key == ConsoleKey.UpArrow || key2.Key == ConsoleKey.DownArrow || key2.Key == ConsoleKey.Enter || key2.Key == ConsoleKey.LeftArrow || key2.Key == ConsoleKey.RightArrow)
                                                {
                                                    //Очистка консоли
                                                    Console.Clear();

                                                    //оператор присвоения пункта меню
                                                    switch (key2.Key)
                                                    {
                                                        //UPARROW
                                                        case ConsoleKey.UpArrow:
                                                            j1--;
                                                            if (j1 < 1) { j1 = 3; }
                                                            if (j1 > 3) { j1 = 1; }
                                                            break;

                                                        //DOWNARROW
                                                        case ConsoleKey.DownArrow:
                                                            j1++;
                                                            if (j1 < 1) { j1 = 3; }
                                                            if (j1 > 3) { j1 = 1; }
                                                            break;

                                                        //LEFTARROW
                                                        case ConsoleKey.LeftArrow:
                                                            if (j1 == 3 || j1 == 300)
                                                            {
                                                                j1 /= 100;
                                                                if (j1 < 3) { j1 = 300; }
                                                                if (j1 > 300) { j1 = 3; }
                                                            }
                                                            break;

                                                        //RIGHTARROW
                                                        case ConsoleKey.RightArrow:
                                                            if (j1 == 3 || j1 == 300)
                                                            {
                                                                j1 *= 100;
                                                                if (j1 < 3) { j1 = 300; }
                                                                if (j1 > 300) { j1 = 3; }
                                                            }
                                                            break;
                                                    }

                                                    //Вызов метода построения добавления улицы с передачей переменной в качестве параметра
                                                    consolebd.AddElemStreet(j1, strname, strlength);

                                                    //Выбор пункта меню добавления улицы
                                                    if (key2.Key == ConsoleKey.Enter)
                                                    {
                                                        //Выбор пункта мeню
                                                        switch (j1)
                                                        {
                                                            //ввод названия улицы
                                                            case 1:
                                                                //начало ввода названия улицы

                                                                //Обнуление переменной названия улицы
                                                                strname = " ";

                                                                //Очистка консоли
                                                                Console.Clear();

                                                                //Вызов метода построения текущего меню
                                                                //С передачей нуля в качестве параметра 
                                                                //Для того чтобы не было активных пунктов выбора меню
                                                                consolebd.AddElemStreet(0, strname, strlength);

                                                                //Перемещение каретки в нужное положение в таблице
                                                                Console.SetCursorPosition(20, 3);

                                                                //Считывание строки
                                                                strname = Console.ReadLine();

                                                                //Проверка на правильность ввода
                                                                if (strname == " " || strname == null || strname.Length > 50 || strname == "")
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Вызов меню ошибки
                                                                    consolebd.AttentionAddElement();

                                                                    //Обнуление переменной названия улицы
                                                                    strname = " ";

                                                                    //Повторный вызов метода построения меню добавления улицы
                                                                    consolebd.AddElemStreet(1, strname, strlength);

                                                                    //Повторный вызов метода считывания клавиш
                                                                    AddStreetMain();
                                                                }
                                                                else
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Повторный вызов метода построения меню 
                                                                    consolebd.AddElemStreet(1, strname, strlength);

                                                                    //Повторный вызов метода для считывания клавиш
                                                                    AddStreetMain();
                                                                }

                                                                break;

                                                            //Ввод длины улицы
                                                            case 2:
                                                                //начало ввода длины улицы

                                                                //Обнуление переменной длины улицы
                                                                strlength = " ";

                                                                //Очистка консоли
                                                                Console.Clear();

                                                                //Вызов метода построения текущего меню
                                                                //С передачей нуля в качестве параметра 
                                                                //Для того чтобы не было активных пунктов выбора меню
                                                                consolebd.AddElemStreet(0, strname, strlength);

                                                                //Перемещение каретки в нужное положение в таблице
                                                                Console.SetCursorPosition(20, 5);

                                                                //Считывание строки
                                                                strlength = Console.ReadLine();

                                                                //Проверка на правильность ввода
                                                                if (strlength == " " || strlength == null || strlength.Length > 50 || strlength == "")
                                                                {
                                                                    //Обнуление переменной 
                                                                    strlength = " ";

                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Вызов меню ошибки
                                                                    consolebd.AttentionAddElement();

                                                                    //Вызов метода построения меню добавления элемента
                                                                    consolebd.AddElemStreet(2, strname, strlength);

                                                                    //Вызов метода считывания нажатой клавиши
                                                                    AddStreetMain();

                                                                }
                                                                else
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    double slen = 0;

                                                                    //дополнительная проверка на возможность конвертации значения 
                                                                    if (double.TryParse(strlength, out slen))
                                                                    {
                                                                        //Конвертация
                                                                        slen = Double.Parse(strlength);

                                                                        //Повторный вызов метода построения меню 
                                                                        consolebd.AddElemStreet(2, strname, strlength);

                                                                        //Повторный вызов метода для считывания клавиш
                                                                        AddStreetMain();
                                                                    }
                                                                    else
                                                                    {
                                                                        //обнуление введенного значения
                                                                        strlength = " ";

                                                                        //очистка консоли
                                                                        Console.Clear();

                                                                        //Вызов метода построения таблицы предупреждения
                                                                        consolebd.AttentionAddElement();

                                                                        //Повторный вызов меню добавления улицы
                                                                        consolebd.AddElemStreet(2, strname, strlength);

                                                                        //Вызов метода выбора пункта меню
                                                                        AddStreetMain();
                                                                    }
                                                                }
                                                                break;

                                                            //Назад
                                                            //Введенная информация не сохраняется
                                                            //Проиходит переход в меню добавления нового элемента
                                                            case 3:
                                                                //Очистка консоли
                                                                Console.Clear();

                                                                //Вызов меню построения главного меню добавления элемента
                                                                //С передачей в качестве параметра еденицы (для изначального отображения первого пункта меню)
                                                                consolebd.AddElemActEvacuation(j1, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                                                //Вызов метода по считыванию клавиш в главном меню добавления нового элемента
                                                                AddActEvacuation();
                                                                break;

                                                            //Сохранить
                                                            //Введенная информация сохраняется и записывается в список
                                                            //Далее проиходит переход в главное меню добавления нового элемента
                                                            case 300:
                                                                //очистка консоли
                                                                Console.Clear();

                                                                //Проверка на то, что все поля заполнены

                                                                //Объявление переменных для хранения промежуточного результата
                                                                //Если поле удовлетворяет условиям заполнения и не пустое -> true, иначе false
                                                                bool strlengthBool = false;
                                                                bool strnameBool = false;
                                                                bool IsAlreadyExistsStreet = false;

                                                                //Проверка на пустое поле для переменной имени улицы
                                                                if (strname == "" || strname == " ")
                                                                {
                                                                    strnameBool = false;
                                                                }
                                                                else
                                                                {
                                                                    strnameBool = true;
                                                                }

                                                                //Проверка на пустое поле для переменной длины улицы
                                                                if (strlength == "" || strlength == " ")
                                                                {
                                                                    strlengthBool = false;
                                                                }
                                                                else
                                                                {
                                                                    strlengthBool = true;
                                                                }

                                                                //Вызов метода перебора всех элементов списка 
                                                                //И присвоение результата булевой переменной
                                                                IsAlreadyExistsStreet = data.IsAlreadyExistsStreet(strname);

                                                                //Финальная проверка результата
                                                                if (strlengthBool == false || strnameBool == false || IsAlreadyExistsStreet == false)
                                                                {
                                                                    if (IsAlreadyExistsStreet == false)
                                                                    {
                                                                        //очистка консоли
                                                                        Console.Clear();

                                                                        //Вызов метода построения меню предупреждения
                                                                        consolebd.AttentionAlreadyHasStreet();

                                                                        //Повторный вызов метода добавления улицы
                                                                        consolebd.AddElemStreet(1, strname, strname);

                                                                        //Повторный вызов метода считывания клавиш
                                                                        AddStreetMain();
                                                                    }
                                                                    else
                                                                    {
                                                                        //Очистка консоли
                                                                        Console.Clear();

                                                                        //Вызов метода построения меню предупреждения
                                                                        consolebd.AttentionNullableFields();

                                                                        //Повторный вызов метода добавления улицы
                                                                        consolebd.AddElemStreet(1, strname, strlength);

                                                                        //Повторный вызов метода считывания клавиш
                                                                        AddStreetMain();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    //Добавление проверреных полей в список
                                                                    //Вызов метода создания нового элемента списка
                                                                    data.AddElementTab2();

                                                                    //Вызов метода, возвращающего количество элементов в списке
                                                                    //И присвоение этого значения переменной
                                                                    int ind = data.CountTab2() - 1;

                                                                    //Обращение к нужному элементу списка
                                                                    //Передача названия улицы и индекса элемента в качестве параметров
                                                                    data.AddElementStrname(strname, ind);

                                                                    //передача длины улицы и индекса элемента в качестве параметров
                                                                    data.AddElementStlength(strlength, ind);

                                                                    //Присвоение переменной названия улицы
                                                                    streetname = strname;

                                                                    //Присвоение ссылки на элемент списка
                                                                    street = data.ReturnElementTab2(ind);

                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Вызов метода построения главного меню добовления нового элемента
                                                                    consolebd.AddElemActEvacuation(j1, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                                                    //Вызов метода считывания клавиши
                                                                    AddActEvacuation();
                                                                }
                                                                break;
                                                        }
                                                    }
                                                }
                                            }
                                            while (key2.Key != ConsoleKey.Enter);

                                        }
                                    }

                                    break;

                                    //Автостоянка
                                case 6:

                                    break;

                                    //Назад
                                case 7:

                                    break;

                                    //Сохранить
                                case 700:

                                    break;
                            }
                        }
                    }

                } while (key.Key != ConsoleKey.Enter);
            }

        }

        //Метод меню удаления улицы
        public static void DeleteStreet()
        {
            //Создание переменной для хранения номера выбранного пункта мпеню
            int j = 1;
 
            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Создание экземпляра класса с данными
            Data data = new Data();

            //Объявление переменной для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Очистка консоли
            Console.Clear();

            //Вызов метода построения меню удаления
            consolebd.ChoiseTypeOfDelete(j);

            do
            {

                //Считывание информации о нажатой клавише
                key = Console.ReadKey(true);

                //Условие для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //Оператор присваивания пункта меню
                    switch (key.Key)
                    {
                        //UPARROW
                        case ConsoleKey.UpArrow:
                            j--;
                            if (j < 1) { j = 4; }
                            if (j > 4) { j = 1; }
                            break;

                        //DOWNARROW
                        case ConsoleKey.DownArrow:
                            j++;
                            if (j < 1) { j = 4; }
                            if (j > 4) { j = 1; }
                            break;


                    }


                    //Вызов метода построения меню выбора типа удаления элемента
                    consolebd.ChoiseTypeOfDelete(j);

                    //Выбор пункта меню удаления элемента
                    if (key.Key == ConsoleKey.Enter)
                    {
                        //Выбор пункта меню
                        switch (j)
                        {
                            //Удаление элемента по индексу
                            case 1:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню удаления элемента по индексу
                                consolebd.DeleteElementIndex();

                                //Перемещение курсора в нужную позицию
                                Console.SetCursorPosition(27, 3);

                                //объявление переменной для хранения введенного индекса
                                int index = 0;

                                //Считывание введенного индекса
                                string ind = Console.ReadLine();

                                //Проверка на возможность конвертации в тип int
                                if (int.TryParse(ind, out index))
                                {
                                    //Присвоение 
                                    index = int.Parse(ind);
                                }
                                else
                                {
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вывод предупреждения 
                                    consolebd.Attention();

                                    //Очистка консоли
                                    Console.Clear();

                                    //обнуление переменной после неверного присвоения
                                    ind = " ";

                                    //Вызов метода повторного построения меню удаления 
                                    consolebd.DeleteElementIndex();

                                    //Повторный вызов текущего метода
                                    DeleteStreet();
                                }

                                //Дикремент для корректной работы
                                index--;

                                //Переменная для хранения количества элементов в списке таблицы 2
                                int count = data.CountTab2();
                                //Проверка на существование элемента по введенному индексу
                                if (index < count && index >= 0)
                                {

                                    //Удаление элемента списка после успешной проверки
                                    data.DeleteElementTab2(index);

                                    //Очистка консоли
                                    Console.Clear();

                                    //Выход в меню выбора удаления элемента
                                    consolebd.DeleteMenu(j);

                                    //Вызов метода считывания нажатых клавиш
                                    DeleteMenu();

                                }
                                else
                                {
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения окна предупреждения
                                    consolebd.AttentionDeleteElement();

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов меню удаления элемента
                                    consolebd.DeleteMenu(j);

                                    //Вызов меню считывания клавиш
                                    DeleteMenu();
                                }
                                break;

                            case 2:
                                //Очистка консоли
                                Console.Clear();


                                break;

                            case 3:

                                break;

                            //Выход в главное меню
                            case 4:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню удаления элементов
                                consolebd.DeleteMenu(1);

                                //Вызов метода считывания клавиш в главном меню удаления
                                DeleteMenu();
                                break;
                        }
                    }
                }

            } while (key.Key != ConsoleKey.Enter);
        }

        //Метод меню удаления автостоянки
        public static void DeleteParking()
        {
            //Очистка консоли
            Console.Clear();

            //Создание переменной для хранения номера выбранного пункта меню
            int j = 1;

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Создание экземпляра класса с данными
            Data data = new Data();

            //Объявление переменной для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //очистка консоли
            Console.Clear();

            //Вызов метода построения меню удаления
            consolebd.ChoiseTypeOfDelete(j);

            //основной блок выполнения
            do
            {

                //Считывание инормации о нажатой клавише
                key = Console.ReadKey(true);

                //Условие для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //оператор присвоения пункта меню
                    switch (key.Key)
                    {
                        //UPARROW
                        case ConsoleKey.UpArrow:
                            j--;
                            if (j < 1) { j = 4; }
                            if (j > 4) { j = 1; }
                            break;

                        //DOWNARROW
                        case ConsoleKey.DownArrow:
                            j++;
                            if (j < 1) { j = 4; }
                            if (j > 4) { j = 1; }
                            break;
                    }



                    //Вызов метода построения меню выбора типа удаления элемента
                    consolebd.ChoiseTypeOfDelete(j);

                    //Выбор пункта меню удаления элемента
                    if (key.Key == ConsoleKey.Enter)
                    {
                        //Выбор пункта меню
                        switch (j)
                        {
                            //Удаление элемента по индексу
                            case 1:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню удалени элемента по индексу
                                consolebd.DeleteElementIndex();

                                //Перемещение каретки в нужную позицию
                                Console.SetCursorPosition(27, 3);

                                //Объявление переменной для хранения введенного индекса
                                int index = 0;

                                //Считывание введенного индекса
                                string ind = Console.ReadLine();

                                //проверка на возможность конвертации в int
                                if (int.TryParse(ind, out index))
                                {
                                    //Присвоение
                                    index = int.Parse(ind);
                                }
                                else
                                {
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вывод предупреждения
                                    consolebd.Attention();

                                    //очистка консоли
                                    Console.Clear();

                                    //Обнуление переменной после некорректного присвоения
                                    ind = " ";

                                    //Вызов метода повторного построения меню удаления
                                    consolebd.DeleteElementIndex();

                                    //Повторный вызов текущего метода
                                    DeleteParking();
                                }
                                //Декремент для корректной работы
                                index--;

                                //переменная для хранения количества элементов в списке таблицы 3
                                int count = data.CountTab3();

                                //проверка на существование элемента повведенному индексу
                                if (index < count && index >= 0)
                                {
                                    //Удаление элемента списка после успешной проверки
                                    data.DeleteElementTab3(index);

                                    //очистка консоли
                                    Console.Clear();

                                    //Выход в меню выбора удаления элемента
                                    consolebd.DeleteMenu(j);

                                    //Вызов метода считывания нажатых клавиш
                                    DeleteMenu();
                                }
                                else
                                {
                                    //очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения окна предупреждения
                                    consolebd.AttentionDeleteElement();

                                    //очистка консоли
                                    Console.Clear();

                                    //Вызов меню удаления элемента
                                    consolebd.DeleteMenu(j);

                                    //Вызов меню считывания клавиш
                                    DeleteMenu();


                                }
                                break;

                            case 2:
                                break;

                            case 3:
                                break;

                            //Выход в главное меню удаления
                            case 4:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения главного меню удаления элемента
                                consolebd.DeleteMenu(1);

                                //Вызов метода считывания клавиш в главно меню
                                DeleteMenu();
                                break;
                        }
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
        }

        //Метод меню удаления акта эвакуации
        public static void DeleteAct()
        {
            //Очистка консоли
            Console.Clear();

            //Создание переменной для хранения номера выбранного пункта меню
            int j = 1;

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Создание экземпляра класса с данными
            Data data = new Data();

            //Объявление переменной для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //очистка консоли
            Console.Clear();

            //Вызов метода построения меню удаления
            consolebd.ChoiseTypeOfDelete(j);

            //Основной блок выполнения
            do
            {

                //Считывание информации о нажатой клавише
                key = Console.ReadKey(true);

                //Условие для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //Оператор присвоения пункта меню 
                    switch (key.Key)
                    {
                        //UPARROW
                        case ConsoleKey.UpArrow:
                            j--;
                            if (j < 1) { j = 4; }
                            if (j > 4) { j = 1; }
                            break;

                        //DOWNARROW
                        case ConsoleKey.DownArrow:
                            j++;
                            if (j < 1) { j = 4; }
                            if (j > 4) { j = 1; }
                            break;
                    }


                    //вызов метода построения меню выбора типа удаления элемента
                    consolebd.ChoiseTypeOfDelete(j);

                    //Выбор пункта меню удаления элемента
                    if (key.Key == ConsoleKey.Enter)
                    {
                        //Выбор пункта меню
                        switch (j)
                        {
                            //Удаление элемента по индексу
                            case 1:
                                //очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню удаления элемента по индексу
                                consolebd.DeleteElementIndex();

                                //перемещение каретки в нужную позицию
                                Console.SetCursorPosition(27, 3);

                                //Объявление переменной для хранения введенного индекса
                                int index = 0;

                                //Считывание введенного индекса
                                string ind = Console.ReadLine();

                                //проверка на возможность конвертации в int
                                if (int.TryParse(ind, out index))
                                {
                                    //Присвоение
                                    index = int.Parse(ind);
                                }
                                else
                                {
                                    //очистка консоли
                                    Console.Clear();

                                    //Вывод предупреждения
                                    consolebd.Attention();

                                    //Очистка консоли
                                    Console.Clear();

                                    //Обнуление переменной после некорректоного присвоения
                                    ind = " ";

                                    //Вызов метода повторного построения меню удаления элемента
                                    consolebd.DeleteElementIndex();

                                    //Повторный вызов текущего метода
                                    DeleteAct();
                                }

                                //Декремент для корректной работы
                                index--;

                                //переменная для хранения количества элементов в списке
                                int count = data.CountTab1();

                                //проверка на существование элементапо введенному индексу
                                if (index < count && index >= 0)
                                {
                                    //Удаление элемента списка после успешной проверки
                                    data.DeleteElementTab1(index);

                                    //Очистка консоли
                                    Console.Clear();

                                    //Выход в меню выбора удаления элемента
                                    consolebd.DeleteMenu(j);

                                    //Вызов метода считывания нажатых клавиш
                                    DeleteMenu();
                                }
                                else
                                {
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения окна предупреждения
                                    consolebd.AttentionDeleteElement();

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов меню удаления элемента
                                    consolebd.DeleteMenu(j);

                                    //Вызов меню считывания клавиш
                                    DeleteMenu();
                                }

                                break;

                            case 2:

                                break;

                            case 3:

                                break;

                            //Выход в главное меню
                            case 4:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов главного меню удаления элемента
                                consolebd.DeleteMenu(1);

                                //Вызов метода считывания клавиш в главном меню удаления
                                DeleteMenu();
                                break;
                        }
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
        }

        //Метод меню выбора типа нарушения
        public static string ChoiseTypeVoilation()
        {
            //переменная для хранения типа нарушения
            string tpvio = " ";

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменная для передачи параметра пункта меню
            int j = 1;

            //Очистка консоли
            Console.Clear();

            //Вызов метода построения меню
            consolebd.ChoiseTypeViolation(j);

            do
            {
                //Считывание нажатой клавиши
                key = Console.ReadKey(true);

                //Условие для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    //оператор выбора
                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            j++;
                            if (j > 4) { j = 1; }
                            if (j < 1) { j = 4; }
                            break;

                        case ConsoleKey.UpArrow:
                            j--;
                            if (j > 4) { j = 1; }
                            if (j < 1) { j = 4; }
                            break;
                    }

                    //Очистка консоли
                    Console.Clear();

                    //Вызов метода построения меню выбора типа нарушения
                    consolebd.ChoiseTypeViolation(j);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (j)
                        {
                            //Cтоянка на проезжей части в месте запрета
                            case 1:
                                //Очистка консоли
                                Console.Clear();

                                //присвоение переменной значения
                                tpvio = "Cтоянка на проезжей части в месте запрета";

                                break;

                            //Cтоянка на тротуаре
                            case 2:
                                //Очистка консоли
                                Console.Clear();

                                //присвоение переменной значения
                                tpvio = "Cтоянка на тротуаре";
                                break;

                            //Cтоянка на газоне
                            case 3:
                                //Очистка консоли
                                Console.Clear();

                                //присвоение переменной значения
                                tpvio = "Cтоянка на газоне";
                                break;

                            case 4:
                                break;
                        }
                    }
                }

            } while (key.Key != ConsoleKey.Enter);

            return tpvio;
        }

        //Метод меню выбора типа автомобиля
        public static string ChoiseTypeOfCar()
        {
            //Переменная для хранения типа автомобиля
            string cartp = " ";

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменная для передачи параметра пункта меню
            int j = 1;

            //Очистка консоли
            Console.Clear();

            //Вызов метода построения меню
            consolebd.ChoiseTypeOfCar(j);

            do
            {
                //Считывание нажатой клавиши
                key = Console.ReadKey(true);

                //Условие для отсеивания ложных нажатий
                if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter)
                {
                    //оператор выбора
                    switch (key.Key)
                    {
                        case ConsoleKey.DownArrow:
                            j++;
                            if (j > 4) { j = 1; }
                            if (j < 1) { j = 4; }
                            break;

                        case ConsoleKey.UpArrow:
                            j--;
                            if (j > 4) { j = 1; }
                            if (j < 1) { j = 4; }
                            break;
                    }

                    //Очистка консоли
                    Console.Clear();

                    //Вызов метода построения меню выбора типа автомобиля
                    consolebd.ChoiseTypeOfCar(j);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        switch (j)
                        {
                            //Легковой
                            case 1:
                                //Очистка консоли
                                Console.Clear();

                                //присвоение переменной значения
                                cartp = "Легковой";

                                break;

                            //Грузовой малой тонажности
                            case 2:
                                //Очистка консоли
                                Console.Clear();

                                //присвоение переменной значения
                                cartp = "Грузовой малой тонажности";
                                break;

                            //Грузовой большой тонажности
                            case 3:
                                //Очистка консоли
                                Console.Clear();

                                //присвоение переменной значения
                                cartp = "Грузовой большой тонажности";
                                break;

                            case 4:
                                break;
                        }
                    }
                }

            } while (key.Key != ConsoleKey.Enter);

            return cartp;
        }

        //Метод меню выбора улицы из уже добавленных
        public static string ChoiseStreet()
        {
            //переменная для хранения улицы
            string streetname = " ";

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Создание экземпляра класса с данными
            Data data = new Data();

            //Создание переменной для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //переменная, хранящая индекс
            int index = 0;

            //Вызов метода отрисовки таблицы

            

            //Очистка консоли
            Console.Clear();



            return streetname;
        }

        

    }
}
