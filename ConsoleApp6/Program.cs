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

        //Метод для считывания клавиш для добавления элементов
        public static void AddCar1(int c)
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
                if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                {
                    //Очистка консоли
                    Console.Clear();

                    //оператор выбора
                    switch (key.Key)
                    {
                        case ConsoleKey.RightArrow:
                            c++;
                            if (c > 2) { c = 1; }
                            if (c < 1) { c = 2; }
                            break;

                        case ConsoleKey.LeftArrow:
                            c--;
                            if (c > 2) { c = 1; }
                            if (c < 1) { c = 2; }
                            break;
                    }

                    //Вызов метода построения меню подтверждения выхода
                    consolebd.Addcar(c);

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
                                AddCar();
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
            string tpvio;       //Тип нарушения
            string gps;         //GPS- координаты
            string carnum;      //Номер машины
            string cartp;       //Тип машины
            string strname;     //Название улицы
            string strlength;   //Длина улицы
            string prkname;     //Название автостоянки
            string prkadress;   //Адрес автостоянки
            string prknumber;   //Телефон автостоянки

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
                            case 1:
                                Console.Clear();

                                break;

                            case 2:
                                Console.Clear();

                                break;

                            case 3:
                                Console.Clear();

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
                int count = data.Count();
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
                int count = data.Count();
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
                int count = data.Count();
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

            int co = data.Count();

            if (co > 20)
            {
                Console.Clear();
                OutputTabAct2(c);
            }

            void OutputTabAct2(int c1)
            {
                //Константы для пунктов выбора
                const string Next = "Далее";
                const string Back = " Назад ";

                int count = data.Count();

                if (count > 40) { count = 40; }
                for (int i = 21; i < count; i++)
                {

                }
            }

            co = data.Count();

            if (co > 60)
            {
                Console.Clear();
                OutputTabAct3();
            }

            void OutputTabAct3()
            {
                //Константы для пунктов выбора
                const string Next = "Далее";
                const string Back = " Назад ";

                int count = data.Count();

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

                    //Вызов метода построения меню удаления элемента с передачей параметра
                    consolebd.DeleteMenu(j);

                    //Выбор пункта меню удаления
                    if (key.Key == ConsoleKey.Enter)
                    {
                        //Метод выбора
                        switch (j)
                        {
                            //1 ПУНКТ УДАЛЕНИЕ ПО ИНДЕКСУ
                            case 1:
                                //Очистка консоли
                                Console.Clear();

                                //Вызов метода построения меню удаления по индексу
                                DeleteElementIndex();
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
                                EditMenu();
                                break;
                        }
                    }
                }

            } while (key.Key != ConsoleKey.Enter);

        }

        //Метод меню удаления элемента по индексу
        public static void DeleteElementIndex()
        {
            //Создание экземпляра класса с построениями меню
            Consolebd consolebd = new Consolebd();

            //Создание экземпляра класса с данными
            Data data = new Data();

            //Создание переменной для хранения индекса элемента, введенного с клавиатуры
            int index;

            //Строка для конвертирования введенного значения с клавиатуры
            string indexstring;

            //Вызов метода построения меню
            consolebd.DeleteElementIndex();

            //Перемещение каретки в указанную точку
            Console.SetCursorPosition(27, 3);

            //Считывание с консоли
            indexstring = Console.ReadLine();

            //Проверка на правильность ввода
            if (!Int32.TryParse(indexstring, out index))
            {
                Console.Clear();
                consolebd.Attention();
                Main();
            }
            else
            {
                if (data.Count() < index)
                {
                    Console.Clear();
                    consolebd.Attention();
                    Console.Clear();
                    DeleteMenu();
                    index = 1;
                }
                else
                {
                    --index;

                    data.DeleteElement(index);

                    Console.ReadKey();
                    Console.Clear();
                    Main();
                }
            }





        }

        //Метод меню добаваления улицы
        public static void AddStreet()
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
                    switch(key.Key)
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
                    consolebd.AddElemStreet(j);

                    //Выбор пункта меню добавления улицы
                    if (key.Key == ConsoleKey.Enter)
                    {
                        //Выбор пункта мпню
                        switch(j)
                        {
                            case 1:
                                break;

                            case 2:
                                break;

                            case 3:
                                break;

                            case 300:
                                break;
                        }
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter);

        }

    }
}
