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



//-------------->9811



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


                                Console.ReadKey();

                                //TEST
                                consolebd.EditActsMenu(2100, 1);
                                //УДАЛИТЬ
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
            //Очистка консоли
            Console.Clear();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //переменная для передачи номера элемента
            int index = 1;

            //Переменная для хранения пункта выюранного меню
            int j = 1;

            //Вызов метода построения меню
            consolebd.StreetTable(j, index);

            //Вызов вложенного метода
            OutputTabStrMain();

            //Вложенный метод
            void OutputTabStrMain()
            {
                //Основной блок выполнения программы
                do
                {
                    //Считывание нажатой клавиши
                    key = Console.ReadKey(true);

                    //условие для отсеивания ложных нажатий
                    if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                    {
                        //Очистка консоли
                        Console.Clear();

                        switch (key.Key)
                        {
                            case ConsoleKey.LeftArrow:
                                j--;
                                if (j > 3) { j = 1; }
                                if (j < 1) { j = 3; }
                                break;

                            case ConsoleKey.RightArrow:
                                j++;
                                if (j > 3) { j = 1; }
                                if (j < 1) { j = 3; }
                                break;
                        }

                        //Вызов метода построения меню
                        consolebd.StreetTable(j, index);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (j)
                            {
                                case 1:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    consolebd.MainMenu(1);

                                    //Вызов метода считывания клавиш
                                    Main();
                                    break;

                                case 2:
                                    index -= 20;
                                    if (index < 1) { index = 81; }
                                    if (index >= 100) { index = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    consolebd.StreetTable(j, index);

                                    //Вызов метода считывания клавиш
                                    OutputTabStrMain();
                                    break;

                                case 3:
                                    index += 20;
                                    if (index < 1) { index = 81; }
                                    if (index >= 100) { index = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    consolebd.StreetTable(j, index);

                                    //Вызов метода считывания клавиш
                                    OutputTabStrMain();
                                    break;
                            }
                        }
                    }

                } while (key.Key != ConsoleKey.Enter);
            }
        }

        //Метод по выводу таблицы 2 таблицы штрафных автостоянок
        public static void OutputTabPrk()
        {
            //Очистка консоли
            Console.Clear();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //переменная для передачи номера элемента
            int index = 1;

            //Переменная для хранения пункта выюранного меню
            int j = 1;

            //Вызов метода построения меню
            consolebd.ParkingTable(j, index);

            //Вызов вложенного метода
            OutputTabPrkMain();

            //Вложенный метод
            void OutputTabPrkMain()
            {
                //Основной блок выполнения программы
                do
                {
                    //Считывание нажатой клавиши
                    key = Console.ReadKey(true);

                    //условие для отсеивания ложных нажатий
                    if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                    {
                        //Очистка консоли
                        Console.Clear();

                        switch (key.Key)
                        {
                            case ConsoleKey.LeftArrow:
                                j--;
                                if (j > 3) { j = 1; }
                                if (j < 1) { j = 3; }
                                break;

                            case ConsoleKey.RightArrow:
                                j++;
                                if (j > 3) { j = 1; }
                                if (j < 1) { j = 3; }
                                break;
                        }

                        //Вызов метода построения меню
                        consolebd.ParkingTable(j, index);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (j)
                            {
                                case 1:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    consolebd.MainMenu(1);

                                    //Вызов метода считывания клавиш
                                    Main();
                                    break;

                                case 2:
                                    index -= 20;
                                    if (index < 1) { index = 81; }
                                    if (index >= 100) { index = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    consolebd.ParkingTable(j, index);

                                    //Вызов метода считывания клавиш
                                    OutputTabPrkMain();
                                    break;

                                case 3:
                                    index += 20;
                                    if (index < 1) { index = 81; }
                                    if (index >= 100) { index = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    consolebd.ParkingTable(j, index);

                                    //Вызов метода считывания клавиш
                                    OutputTabPrkMain();
                                    break;
                            }
                        }
                    }

                } while (key.Key != ConsoleKey.Enter);
            }
        }

        //Метод по выводу таблицы 3 таблицы актов эвакуации
        public static void OutputTabAct()
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            //Очистка консоли
            Console.Clear();

            //Переменная для хранения индекса
            int index = 1;

            //Переменная для хранения информации о нажатой кнопке
            ConsoleKeyInfo key;

            //Создание экземпляра класса с методами построения меню консоли
            Consolebd consolebd = new Consolebd();

            //Переменная для передачи номера элемента
            int num = 1;

            //Переменная для хранения пункта выбора меню
            int j = 1;

            //Вызов метода построения меню
            consolebd.ActEvacuationTable(j, index);

            //Вызов вложенного метода 
            OutputTabActMain();

            //Вложенный метод
            void OutputTabActMain()
            {
                //Основной блок выполнения программы
                do
                {
                    //Считывание нажатой клавиши
                    key = Console.ReadKey(true);

                    //Условие для отсеивания ложных нажатий
                    if (key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                    {
                        //Очистка консоли
                        Console.Clear();

                        switch (key.Key)
                        {
                            //UPARROW
                            case ConsoleKey.UpArrow:
                                if (j <= 21) { j--; if (j < 1) { j = 21; } if (j > 21) { j = 1; } }
                                if (j > 21 && j <= 2100) { j -= 100; if (j < 100) { j = 2100; } if (j > 2100) { j = 100; } }
                                break;

                            //DOWNARROW
                            case ConsoleKey.DownArrow:
                                if (j <= 21) { j++; if (j < 1) { j = 21; } if (j > 21) { j = 1; } }
                                if (j > 21 && j <= 2100) { j += 100; if (j < 100) { j = 2100; } if (j > 2100) { j = 100; } }
                                break;

                            //LEFTARROW
                            case ConsoleKey.LeftArrow:
                                if (j == 21) { j = 210000; }
                                else
                                {
                                    if (j == 210000) { j = 2100; }
                                    else
                                    {
                                        if (j <= 20) { j *= 100; }
                                        else { j /= 100; }
                                    }
                                }

                                break;

                            //RIGHTARROW
                            case ConsoleKey.RightArrow:
                                if (j == 21) { j = 2100; }
                                else if (j == 210000) { j = 21; }
                                else
     if (j == 2100) { j = 210000; }
                                else
                                {
                                    if (j == 210000) { j = 21; }
                                    else
                                    {
                                        if (j <= 20) { j *= 100; }
                                        else { j /= 100; }
                                    }
                                }
                                break;
                        }

                        //Вызов метода построения таблицы
                        consolebd.ActEvacuationTable(j, num);

                        if (key.Key == ConsoleKey.Enter)

                        {
                            switch (j)
                            {
                                case 1:
                                    if (num <= data.CountTab1())
                                    {
                                        index = num;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    index = 0;
                                    break;

                                case 2:
                                    if (num + 1 <= data.CountTab1())
                                    {
                                        index = num + 1;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    index = 0;
                                    break;

                                case 3:
                                    if (num + 2 <= data.CountTab1())
                                    {
                                        index = num + 2;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 4:
                                    if (num + 3 <= data.CountTab1())
                                    {
                                        index = num + 3;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 5:
                                    if (num + 4 <= data.CountTab1())
                                    {
                                        index = num + 4;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 6:
                                    if (num + 5 <= data.CountTab1())
                                    {
                                        index = num + 5;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 7:
                                    if (num + 6 <= data.CountTab1())
                                    {
                                        index = num + 6;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 8:
                                    if (num + 7 <= data.CountTab1())
                                    {
                                        index = num + 7;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 9:
                                    if (num + 8 <= data.CountTab1())
                                    {
                                        index = num + 8;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 10:
                                    if (num + 9 <= data.CountTab1())
                                    {
                                        index = num + 9;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 11:
                                    if (num + 10 <= data.CountTab1())
                                    {
                                        index = num + 10;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 12:
                                    if (num + 11 <= data.CountTab1())
                                    {
                                        index = num + 11;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 13:
                                    if (num + 12 <= data.CountTab1())
                                    {
                                        index = num + 12;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 14:
                                    if (num + 13 <= data.CountTab1())
                                    {
                                        index = num + 13;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 15:
                                    if (num + 14 <= data.CountTab1())
                                    {
                                        index = num + 14;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 16:
                                    if (num + 15 <= data.CountTab1())
                                    {
                                        index = num + 15;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 17:
                                    if (num + 16 <= data.CountTab1())
                                    {
                                        index = num + 16;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 18:
                                    if (num + 17 <= data.CountTab1())
                                    {
                                        index = num + 17;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 19:
                                    if (num + 18 <= data.CountTab1())
                                    {
                                        index = num + 18;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 20:
                                    if (num + 19 <= data.CountTab1())
                                    {
                                        index = num + 19;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintStreetMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 100:
                                    if (num <= data.CountTab1())
                                    {
                                        index = num;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 200:
                                    if (num + 1 <= data.CountTab1())
                                    {
                                        index = num + 1;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 300:
                                    if (num + 2 <= data.CountTab1())
                                    {
                                        index = num + 2;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 400:
                                    if (num + 3 <= data.CountTab1())
                                    {
                                        index = num + 3;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 500:
                                    if (num + 4 <= data.CountTab1())
                                    {
                                        index = num + 4;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 600:
                                    if (num + 5 <= data.CountTab1())
                                    {
                                        index = num + 5;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 700:
                                    if (num + 6 <= data.CountTab1())
                                    {
                                        index = num + 6;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 800:
                                    if (num + 7 <= data.CountTab1())
                                    {
                                        index = num + 7;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 900:
                                    if (num + 8 <= data.CountTab1())
                                    {
                                        index = num + 8;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1000:
                                    if (num + 9 <= data.CountTab1())
                                    {
                                        index = num + 9;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1100:
                                    if (num + 10 <= data.CountTab1())
                                    {
                                        index = num + 10;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1200:
                                    if (num + 11 <= data.CountTab1())
                                    {
                                        index = num + 11;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1300:
                                    if (num + 12 <= data.CountTab1())
                                    {
                                        index = num + 12;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1400:
                                    if (num + 13 <= data.CountTab1())
                                    {
                                        index = num + 13;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1500:
                                    if (num + 14 <= data.CountTab1())
                                    {
                                        index = num + 14;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1600:
                                    if (num + 15 <= data.CountTab1())
                                    {
                                        index = num + 15;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1700:
                                    if (num + 16 <= data.CountTab1())
                                    {
                                        index = num + 16;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1800:
                                    if (num + 17 <= data.CountTab1())
                                    {
                                        index = num + 17;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 1900:
                                    if (num + 18 <= data.CountTab1())
                                    {
                                        index = num + 18;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 2000:
                                    if (num + 19 <= data.CountTab1())
                                    {
                                        index = num + 19;

                                        //Вызов меню подробной информации об улице
                                        consolebd.PrintParkingMoreInfo(index);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        consolebd.ActEvacuationTable(j, num);
                                        OutputTabActMain();
                                    }
                                    break;

                                case 21:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    consolebd.MainMenu(1);

                                    //Вызов метода считывания клавиш
                                    Main();
                                    break;

                                case 2100:
                                    num -= 20;
                                    if (num < 1) { num = 81; }
                                    if (num >= 100) { num = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //ВЫзов метода построения меню
                                    consolebd.ActEvacuationTable(j, num);

                                    //Вызов метода считывания клавиш
                                    OutputTabActMain();

                                    break;

                                case 210000:
                                    num += 20;
                                    if (num < 1) { num = 81; }
                                    if (num >= 100) { num = 1; }

                                    //очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    consolebd.ActEvacuationTable(j, num);

                                    //Вызов метода считывания клавиш
                                    OutputTabActMain();
                                    break;
                            }
                        }
                    }

                } while (key.Key != ConsoleKey.Enter);
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

                                //Метод построения меню
                                EditElementsMenu();
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

            //Объявление и инициализация переменной-счетчика для отображения выбранного пункта меню
            int j = 1;

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
                                    if (strname == " " || strname == null || strname.Length > 50 || strname == "" || strname.Contains('\t'))
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //Обнуление переменной названия улицы
                                        strname = " ";

                                        //Повторный вызов метода построения меню добавления улицы
                                        consolebd.AddElemStreet(j, strname, strlength);

                                        //Повторный вызов метода считывания клавиш
                                        AddStreetMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню 
                                        consolebd.AddElemStreet(j, strname, strlength);

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
                                    if (strlength == " " || strlength == null || strlength.Length > 50 || strlength == "" || strlength.Contains('\t'))
                                    {
                                        //Обнуление переменной 
                                        strlength = " ";

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //Вызов метода построения меню добавления элемента
                                        consolebd.AddElemStreet(j, strname, strlength);

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
                                            consolebd.AddElemStreet(j, strname, strlength);

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
                                            consolebd.AddElemStreet(j, strname, strlength);

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
                                            consolebd.AddElemStreet(j, strname, strname);

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
                                            consolebd.AddElemStreet(j, strname, strlength);

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


            //Объявление и инициализация переменной-счетчика для отображения выбранного пункта меню
            int j = 1;

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

                //Вызов метода построения меню добавления автостоянки
                consolebd.AddElemParking(j, prkname, prkadress, prknumber);

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
                                    if (prkname == " " || prkname == null || prkname.Length > 50 || prkname == "" || prkname.Contains('\t'))
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //обнуление переменной названия автостоянки
                                        prkname = " ";

                                        //Повторный вызов метода построения меню добавления автостоянки
                                        consolebd.AddElemParking(j, prkname, prkadress, prknumber);

                                        //Повторный вызов метода считывания клавиш
                                        AddParkingMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню добавления автостоянки
                                        consolebd.AddElemParking(j, prkname, prkadress, prknumber);

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
                                    if (prkadress == " " || prkadress == null || prkadress.Length > 50 || prkadress == "" || prkadress.Contains('\t'))
                                    {
                                        //Обнуление переменной
                                        prkadress = " ";

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки 
                                        consolebd.AttentionAddElement();

                                        //Вызов метода построения меню добавления элемента
                                        consolebd.AddElemParking(j, prkname, prkadress, prknumber);

                                        //Вызов метода считывания нажатой клавиши
                                        AddParkingMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню
                                        consolebd.AddElemParking(j, prkname, prkadress, prknumber);

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
                                    if (prknumber == " " || prknumber == null || prknumber.Length > 50 || prknumber == "" || prknumber.Contains('\t'))
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов окошка ошибки
                                        consolebd.AttentionAddElement();

                                        //Обнуление переменной номера автостоянки
                                        prknumber = " ";

                                        //Повторный вызов метода построения меню добавления автостоянки
                                        consolebd.AddElemParking(j, prkname, prkadress, prknumber);

                                        //Повторный вызов метода считывания клавиш
                                        AddParkingMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню
                                        consolebd.AddElemParking(j, prkname, prkadress, prknumber);

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
                                            consolebd.AddElemParking(j, prkname, prkadress, prknumber);

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
                                            consolebd.AddElemParking(j, prkname, prkadress, prknumber);

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
            int indexStreet = 0;
            int indexParking = 0;
            ElementsTab2 street = new ElementsTab2();
            ElementsTab3 parking = new ElementsTab3();

            //Объявление и инициализация переменной-счетчика для отображения выбранного пункта меню
            int j = 1;

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

                //Вызов метода построения меню добавления автостоянки
                consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

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
                                    if (GPS == " " || GPS == null || GPS == "" || GPS.Length > 50 || GPS.Contains('\t'))
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //Обнуление переменной gps-координат
                                        GPS = " ";

                                        //Повторный вызов метода построения меню добавления акта эвакуации
                                        consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                        //Повторный вызов метода считывания клавиш
                                        AddActEvacuation();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню добавления акта эвакуации
                                        consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

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
                                    if (numberofcar == "" || numberofcar == " " || numberofcar == null || numberofcar.Length > 50 || numberofcar.Contains('\t'))
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

                                        //ChoiseStreet();

                                        //Вызов метода выбора улицы из существующих
                                        int index = ChoiseStreet();

                                        //передача индекса в переменную
                                        indexStreet = index - 1;

                                        //Присвоение 
                                        if (indexStreet < 0) { streetname = " "; } else { streetname = data.OutPutSt(index - 1); }

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения меню добавления акта эвакуации
                                        consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                        //Вызов метода считывания клавиш
                                        AddActEvacuation();
                                    }
                                    else
                                    {
                                        //Переменные для считывания строки с клавиатуры, проверки, и далее передачи в список проверенной строки
                                        string strname = " ";     //Название улицы
                                        string strlength = " ";   //Длина улицы

                                        //Объявление и инициализация переменной-счетчика для отображения выбранного пункта меню
                                        int j1 = 1;

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
                                                                if (strname == " " || strname == null || strname.Length > 50 || strname == "" || strname.Contains('\t'))
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Вызов меню ошибки
                                                                    consolebd.AttentionAddElement();

                                                                    //Обнуление переменной названия улицы
                                                                    strname = " ";

                                                                    //Повторный вызов метода построения меню добавления улицы
                                                                    consolebd.AddElemStreet(j1, strname, strlength);

                                                                    //Повторный вызов метода считывания клавиш
                                                                    AddStreetMain();
                                                                }
                                                                else
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Повторный вызов метода построения меню 
                                                                    consolebd.AddElemStreet(j1, strname, strlength);

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
                                                                if (strlength == " " || strlength == null || strlength.Length > 50 || strlength == "" || strlength.Contains('\t'))
                                                                {
                                                                    //Обнуление переменной 
                                                                    strlength = " ";

                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Вызов меню ошибки
                                                                    consolebd.AttentionAddElement();

                                                                    //Вызов метода построения меню добавления элемента
                                                                    consolebd.AddElemStreet(j1, strname, strlength);

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
                                                                        consolebd.AddElemStreet(j1, strname, strlength);

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
                                                                        consolebd.AddElemStreet(j1, strname, strlength);

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
                                                                consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

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
                                                                        consolebd.AddElemStreet(j1, strname, strname);

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
                                                                        consolebd.AddElemStreet(j1, strname, strlength);

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

                                                                    indexStreet = ind;

                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    streetname = strname;

                                                                    //Вызов метода построения главного меню добовления нового элемента
                                                                    consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

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

                                    //Очистка консоли
                                    Console.Clear();

                                    //Повторный вызов меню добавления акта эвакуации
                                    //consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                    //Повторый вызов метода считывания клавиш
                                    //AddActEvacuation();

                                    break;

                                //Автостоянка
                                case 6:
                                    //Начало выбора автостоянки

                                    //Обнуление переменной автостоянки
                                    parkingname = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //переменная, принимающая значение количества элементов в списке
                                    int elementsintab2 = data.CountTab3();

                                    if (elementsintab2 > 0)
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода выбора автостоянки из существующих
                                        int index = ChoiseParking();

                                        //передача индекса в переменную
                                        indexParking = index - 1;

                                        //Присвоение
                                        if (indexParking < 0) { parkingname = " "; } else { parkingname = data.OutPutPrkname(index - 1); }

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения меню добавления акта эвакуации
                                        consolebd.AddElemActEvacuation(j, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                        //Вызов метода считывания клавиш
                                        AddActEvacuation();
                                    }
                                    else
                                    {
                                        //Переменные для считывания строки с клавиатуры, проверки, и далее передачи в список проверенной строки
                                        string prkname = " ";     //Название автостоянки
                                        string prkadress = " ";   //Адрес автостоянки
                                        string prknumber = " ";   //Телефон автостоянки

                                        //Объявление и инициализация переменной-счетчика для отображения выбранного пункта меню
                                        int j3 = 1;

                                        //Вызов вложенного метода
                                        AddParkingMain();


                                        //вложенный метод
                                        //используется для того, чтобы при добавлении элементов не обнулялись их значения
                                        void AddParkingMain()
                                        {
                                            //Очистка консоли
                                            Console.Clear();

                                            //Объявление переменно для хранения информации о нажатой клавише
                                            ConsoleKeyInfo key2;

                                            //Вызов метода построения меню добавления автостоянки
                                            consolebd.AddElemParking(j3, prkname, prkadress, prknumber);

                                            do
                                            {
                                                //Считывание информации о нажатой клавише
                                                key2 = Console.ReadKey(true);

                                                //Условие для отвеивания ложных нажатий
                                                if (key2.Key == ConsoleKey.UpArrow || key2.Key == ConsoleKey.DownArrow || key2.Key == ConsoleKey.Enter || key2.Key == ConsoleKey.LeftArrow || key2.Key == ConsoleKey.RightArrow)
                                                {
                                                    //Очистка консоли
                                                    Console.Clear();

                                                    //Оператор присвоения пункта меню
                                                    switch (key2.Key)
                                                    {
                                                        //UPARROW
                                                        case ConsoleKey.UpArrow:
                                                            j3--;
                                                            if (j3 < 1) { j3 = 4; }
                                                            if (j3 > 4) { j3 = 1; }
                                                            break;

                                                        //DOWNARROW
                                                        case ConsoleKey.DownArrow:
                                                            j3++;
                                                            if (j3 < 1) { j3 = 4; }
                                                            if (j3 > 4) { j3 = 1; }
                                                            break;

                                                        //LEFTARROW
                                                        case ConsoleKey.LeftArrow:
                                                            if (j3 == 4 || j3 == 400)
                                                            {
                                                                j3 /= 100;
                                                                if (j3 < 4) { j3 = 400; }
                                                                if (j3 > 400) { j3 = 4; }
                                                            }
                                                            break;

                                                        //RIGHTARROW
                                                        case ConsoleKey.RightArrow:
                                                            if (j3 == 4 || j3 == 400)
                                                            {
                                                                j3 *= 100;
                                                                if (j3 < 4) { j3 = 400; }
                                                                if (j3 > 400) { j3 = 4; }
                                                            }
                                                            break;
                                                    }

                                                    //Вызов метода построения добавления автостоянки с передачей переменной в качестве параметра
                                                    consolebd.AddElemParking(j3, prkname, prkadress, prknumber);

                                                    //Выбор пункта меню добавления улицы
                                                    if (key2.Key == ConsoleKey.Enter)
                                                    {
                                                        //Выбор пункта меню
                                                        switch (j3)
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
                                                                if (prkname == " " || prkname == null || prkname.Length > 50 || prkname == "" || prkname.Contains('\t'))
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Вызов меню ошибки
                                                                    consolebd.AttentionAddElement();

                                                                    //обнуление переменной названия автостоянки
                                                                    prkname = " ";

                                                                    //Повторный вызов метода построения меню добавления автостоянки
                                                                    consolebd.AddElemParking(j3, prkname, prkadress, prknumber);

                                                                    //Повторный вызов метода считывания клавиш
                                                                    AddParkingMain();
                                                                }
                                                                else
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Повторный вызов метода построения меню добавления автостоянки
                                                                    consolebd.AddElemParking(j3, prkname, prkadress, prknumber);

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
                                                                if (prkadress == " " || prkadress == null || prkadress.Length > 50 || prkadress == "" || prkadress.Contains('\t'))
                                                                {
                                                                    //Обнуление переменной
                                                                    prkadress = " ";

                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Вызов меню ошибки 
                                                                    consolebd.AttentionAddElement();

                                                                    //Вызов метода построения меню добавления элемента
                                                                    consolebd.AddElemParking(j3, prkname, prkadress, prknumber);

                                                                    //Вызов метода считывания нажатой клавиши
                                                                    AddParkingMain();
                                                                }
                                                                else
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Повторный вызов метода построения меню
                                                                    consolebd.AddElemParking(j3, prkname, prkadress, prknumber);

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
                                                                if (prknumber == " " || prknumber == null || prknumber.Length > 50 || prknumber == "" || prknumber.Contains('\t'))
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Вызов окошка ошибки
                                                                    consolebd.AttentionAddElement();

                                                                    //Обнуление переменной номера автостоянки
                                                                    prknumber = " ";

                                                                    //Повторный вызов метода построения меню добавления автостоянки
                                                                    consolebd.AddElemParking(j3, prkname, prkadress, prknumber);

                                                                    //Повторный вызов метода считывания клавиш
                                                                    AddParkingMain();
                                                                }
                                                                else
                                                                {
                                                                    //Очистка консоли
                                                                    Console.Clear();

                                                                    //Повторный вызов метода построения меню
                                                                    consolebd.AddElemParking(j3, prkname, prkadress, prknumber);

                                                                    //Повторный вызов метода для считывания клавиш
                                                                    AddParkingMain();
                                                                }
                                                                break;

                                                            //Назад
                                                            case 4:
                                                                //Очистка консоли
                                                                Console.Clear();

                                                                //Вызов меню построения главного меню добавления элемента
                                                                //С передачей в качестве параметра единицы
                                                                consolebd.AddElemActEvacuation(j3, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                                                //Вызов метода по считыванию клавиш в главном меню добавления нового элемента
                                                                AddActEvacuation();
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

                                                                    //Присвоение переменной названия автостоянки
                                                                    parkingname = prkname;

                                                                    //Присвоение ссылки на элемент списка
                                                                    parking = data.ReturnElementTab3(ind);

                                                                    //очистка консоли
                                                                    Console.Clear();

                                                                    //Переход в главное меню добавления элемента

                                                                    //Вызов метода построения 
                                                                    consolebd.AddElemActEvacuation(j3, GPS, typeviolation, numberofcar, typeofcar, streetname, parkingname);

                                                                    //Вызов метода считывания клавиши
                                                                    AddActEvacuation();
                                                                }
                                                                break;
                                                        }
                                                    }
                                                }
                                            } while (key2.Key != ConsoleKey.Enter);
                                        }
                                    }

                                    //Очистка консоли
                                    Console.Clear();

                                    break;

                                //Назад
                                case 7:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов главного меню добавления элемента
                                    //с передачей в качестве параметра еденицы
                                    consolebd.AddElement(1);

                                    //Вызов метода по считыванию клавиш в главном меню добавления нового элемента
                                    AddCar();
                                    break;

                                //Сохранить
                                //Введенная информация сохраняется и записывается в список
                                //Далее происходит преход в главное меню добавления нового элемента
                                case 700:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Проверка на то, что все поля заполнены

                                    //Объявление переменных для сохранения промежуточного результата
                                    //Если поле удовлетворяет условиям заполнения и не пустое -> true, иначе false
                                    bool GPSBool = false;
                                    bool typevioBool = false;
                                    bool numofcarBool = false;
                                    bool typeofcarBool = false;
                                    bool streetBool = false;
                                    bool parkingBool = false;

                                    //Проверка на пустое поле для переменной gps
                                    if (GPS == " " || GPS == "")
                                    {
                                        GPSBool = false;
                                    }
                                    else
                                    {
                                        GPSBool = true;
                                    }

                                    //Проверка на пустое поле для переменной типа нарушения
                                    if (typeviolation == "" || typeviolation == " ")
                                    {
                                        typevioBool = false;
                                    }
                                    else
                                    {
                                        typevioBool = true;
                                    }

                                    //Проверка на пустое поле для переменной номера автомобиля
                                    if (numberofcar == "" || numberofcar == " ")
                                    {
                                        numofcarBool = false;
                                    }
                                    else
                                    {
                                        numofcarBool = true;
                                    }

                                    //Проверка на пустое поле для переменной типа автомобиля
                                    if (typeofcar == "" || typeofcar == " ")
                                    {
                                        typeofcarBool = false;
                                    }
                                    else
                                    {
                                        typeofcarBool = true;
                                    }

                                    //Проверка на пустое поле для переменной улицы
                                    if (streetname == "" || streetname == " ")
                                    {
                                        streetBool = false;
                                    }
                                    else
                                    {
                                        streetBool = true;
                                    }

                                    //Проверка на пустое поле для переменной парковки
                                    if (parkingname == "" || parkingname == " ")
                                    {
                                        parkingBool = false;
                                    }
                                    else
                                    {
                                        parkingBool = true;
                                    }

                                    if (GPSBool == false || typevioBool == false || numofcarBool == false || typeofcarBool == false || streetBool == false || parkingBool == false)
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.AttentionNullableFields();

                                        //Повторный вызов метода добавления акта эвакуации
                                        AddActEvacuation();
                                    }
                                    else
                                    {
                                        //Добавление проверенных полей в список
                                        //Вызов метода создания нового списка
                                        data.AddElementTab1();

                                        //Вызов метода, возвращающего количество элементов в списке
                                        //и присвоение этого значения переменной
                                        int ind = data.CountTab1() - 1;

                                        //Обращение к нужному элементу списка
                                        //Передача gps координат и индекса элемента в качестве параметра
                                        data.Addgps(GPS, ind);

                                        //передача типа нарушения в список
                                        data.AddTypeVio(typeviolation, ind);

                                        //передача номера автомобиля в список
                                        data.Addcarnumber(numberofcar, ind);

                                        //передача типа автомобиля в список
                                        data.AddTypeOfCar(typeofcar, ind);

                                        data.AddLinkTab2(indexStreet);

                                        data.AddlinkTab3(indexParking);

                                        //Очистка консоли
                                        Console.Clear();

                                        //переход в главное меню добавления элемента
                                        consolebd.AddElement(1);
                                        AddCar();
                                    }

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
                                    //consolebd.Attention();

                                    //Очистка консоли
                                    Console.Clear();

                                    //обнуление переменной после неверного присвоения
                                    ind = " ";

                                    //Вызов метода повторного построения меню удаления 
                                    //consolebd.DeleteElementIndex();

                                    //Повторный вызов текущего метода
                                    //DeleteStreet();
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

                            //Выход в главное меню
                            case 3:
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
                                    //consolebd.Attention();

                                    //очистка консоли
                                    Console.Clear();

                                    //Обнуление переменной после некорректного присвоения
                                    ind = " ";

                                    //Вызов метода повторного построения меню удаления
                                    //consolebd.DeleteElementIndex();

                                    //Повторный вызов текущего метода
                                    //DeleteParking();
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

                            //Выход в главное меню удаления
                            case 3:
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
                                    //consolebd.Attention();

                                    //Очистка консоли
                                    Console.Clear();

                                    //Обнуление переменной после некорректоного присвоения
                                    ind = " ";

                                    //Вызов метода повторного построения меню удаления элемента
                                    //consolebd.DeleteElementIndex();

                                    //Повторный вызов текущего метода
                                    //DeleteAct();
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

                            //Выход в главное меню
                            case 3:
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
        public static int ChoiseStreet()
        {
            Data data = new Data();

            ElementsTab2 str = new ElementsTab2();

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Создание переменной для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //переменная, хранящая индекс
            int index = 0;

            //Переменная для выбора пункта меню
            int j = 1;

            //Переменная для передачи в качества параметра в метод построения меню значения нижнего предела
            int num = 1;

            //переменная для хранения количества элементов в списке
            int counttab2 = data.CountTab2();

            consolebd.ChoiseStreet(1, num, counttab2);

            ChoiseStreetMain();

            //Вложенный метод
            void ChoiseStreetMain()
            {

                //Основной блок выполнения программы
                do
                {
                    //Считывание информации с нажатой клавиши
                    key = Console.ReadKey(true);

                    if (num == 91) { j = 11; }

                    //Условие для отсеивания ложных нажатий
                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                    {
                        //Оператор выбора 
                        switch (key.Key)
                        {
                            //UPARROW
                            case ConsoleKey.UpArrow:
                                j--;
                                if (j < 1) { j = 11; }
                                if (j > 11) { j = 1; }
                                break;

                            //DOWNARROW
                            case ConsoleKey.DownArrow:
                                j++;
                                if (j < 1) { j = 11; }
                                if (j > 11) { j = 1; }
                                break;

                            //LEFTARROW
                            case ConsoleKey.LeftArrow:
                                if (j == 11 || j == 1100)
                                {
                                    j /= 100;
                                    if (j < 11) { j = 1100; }
                                    if (j > 1100) { j = 11; }
                                    if (num == 91) { j = 11; }
                                    if (num == 101) { j = 11; }
                                }
                                break;

                            //RIGHTARROW
                            case ConsoleKey.RightArrow:
                                if (j == 11 || j == 1100)
                                {
                                    j *= 100;
                                    if (j < 11) { j = 1100; }
                                    if (j > 1100) { j = 11; }
                                    if (num == 91) { j = 11; }
                                    if (num == 101) { j = 11; }
                                }
                                break;
                        }

                        if (num == 91) { j = 11; }

                        //Вызов метода построения таблицы
                        consolebd.ChoiseStreet(j, num, counttab2);

                        //Выбор пункта меню
                        if (key.Key == ConsoleKey.Enter)
                        {
                            //Выбор пункта таблицы
                            switch (j)
                            {
                                case 1:
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 2:
                                    num += 1;
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 3:
                                    num += 2;
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 4:
                                    num += 3;
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 5:
                                    num += 4;
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 6:
                                    num += 5;
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 7:
                                    num += 6;
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 8:
                                    num += 7;
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 9:
                                    num += 8;
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 10:
                                    num += 9;
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;
                                        //data.AddLinkTab2(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 11:
                                    if (num == 91) { j = 11; }
                                    if (num >= 0 && num <= 11) { index = -1; }
                                    if (num == 101) { num = 91; }
                                    if (num == 11)
                                    {
                                        num = 1;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню
                                        consolebd.ChoiseStreet(j, num, counttab2);

                                        //Повторный вызов метода 
                                        ChoiseStreetMain();
                                    }
                                    if (num >= 20)
                                    {
                                        num -= 10;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню
                                        consolebd.ChoiseStreet(j, num, counttab2);

                                        //Повторный вызов метода 
                                        ChoiseStreetMain();
                                    }
                                    break;

                                case 1100:
                                    if (num == 91) { j = 11; }
                                    if (num <= 91 && num > 10) { num += 10; }
                                    if (num == 1) { num = 11; }
                                    if (num == 100) { num = 91; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов меню
                                    consolebd.ChoiseStreet(j, num, counttab2);

                                    //Повторный вызов метода 
                                    ChoiseStreetMain();
                                    break;
                            }
                        }
                    }

                }
                while (key.Key != ConsoleKey.Enter);

            }

            //Очистка консоли
            Console.Clear();



            return index;
        }

        //Метод меню выбора автостоянки из уже добавленных
        public static int ChoiseParking()
        {
            //Переменная для хранения индекса элемента списка
            int index = 0;

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Создание экземпляра класса с данными
            Data data = new Data();

            //Создание переменной для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменная для выбора пункта меню
            int j = 1;

            //Переменная для передачи в качества параметра в метод построения меню значения нижнего предела
            int num = 1;

            //переменная для хранения количества элементов в списке
            int counttab3 = data.CountTab3();

            //Вызов метода построения меню
            consolebd.ChoiseParking(1, num, counttab3);

            //Вызов вложенного метода
            ChoiseParkingMain();

            //Вложенный метод
            void ChoiseParkingMain()
            {
                //Основной блок выполнения программы
                do
                {
                    //Считывание информации о нажатой клавише
                    key = Console.ReadKey(true);

                    if (num == 91) { j = 11; }

                    //Условие для отсеивания ложных нажатий
                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow)
                    {
                        //Оператор выбора 
                        switch (key.Key)
                        {
                            //UPARROW
                            case ConsoleKey.UpArrow:
                                j--;
                                if (j < 1) { j = 11; }
                                if (j > 11) { j = 1; }
                                break;

                            //DOWNARROW
                            case ConsoleKey.DownArrow:
                                j++;
                                if (j < 1) { j = 11; }
                                if (j > 11) { j = 1; }
                                break;

                            //LEFTARROW
                            case ConsoleKey.LeftArrow:
                                if (j == 11 || j == 1100)
                                {
                                    j /= 100;
                                    if (j < 11) { j = 1100; }
                                    if (j > 1100) { j = 11; }
                                    if (num == 91) { j = 11; }
                                    if (num == 101) { j = 11; }
                                }
                                break;

                            //RIGHTARROW
                            case ConsoleKey.RightArrow:
                                if (j == 11 || j == 1100)
                                {
                                    j *= 100;
                                    if (j < 11) { j = 1100; }
                                    if (j > 1100) { j = 11; }
                                    if (num == 91) { j = 11; }
                                    if (num == 101) { j = 11; }
                                }
                                break;
                        }

                        if (num == 91) { j = 11; }

                        //Вызов метода построения таблицы
                        consolebd.ChoiseParking(j, num, counttab3);

                        //Выбор пункта меню
                        //Выбор пункта меню
                        if (key.Key == ConsoleKey.Enter)
                        {
                            //Выюор пункта таблицы
                            switch (j)
                            {
                                case 1:
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 2:
                                    num += 1;
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 3:
                                    num += 2;
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 4:
                                    num += 3;
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 5:
                                    num += 4;
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 6:
                                    num += 5;
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 7:
                                    num += 6;
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 8:
                                    num += 7;
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 9:
                                    num += 8;
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 10:
                                    num += 9;
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();
                                    }
                                    break;

                                case 11:
                                    if (num == 91) { j = 11; }
                                    if (num >= 0 && num <= 11) { index = -1; }
                                    if (num == 101) { num = 91; }
                                    if (num == 11)
                                    {
                                        num = 1;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню
                                        consolebd.ChoiseParking(j, num, counttab3);

                                        //Повторный вызов метода 
                                        ChoiseParkingMain();
                                    }
                                    if (num >= 21)
                                    {
                                        num -= 10;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню
                                        consolebd.ChoiseParking(j, num, counttab3);

                                        //Повторный вызов метода 
                                        ChoiseParkingMain();
                                    }
                                    break;

                                case 1100:
                                    if (num == 91) { j = 11; }
                                    if (num <= 91 && num > 10) { num += 10; }
                                    if (num == 1) { num = 11; }
                                    if (num == 100) { num = 91; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов меню
                                    consolebd.ChoiseParking(j, num, counttab3);

                                    //Повторный вызов метода 
                                    ChoiseParkingMain();
                                    break;
                            }
                        }


                    }

                } while (key.Key != ConsoleKey.Enter);
            }

            //Очистка консоли
            Console.Clear();

            return index;
        }

        //Метод меню редактирования элементов
        public static void EditElementsMenu()
        {
            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменная пункта меню
            int j = 1;

            //Вызов метода построения меню
            consolebd.EditElementsMenu(1);

            //Вызов вложенного метода
            EditElementsMenuMain();

            //Вложенный метод
            void EditElementsMenuMain()
            {

                do
                {
                    //Считывание информации нажатой клавиши
                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter || key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
                    {
                        //Очистка консоли
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

                        //Вызов метода построения меню
                        consolebd.EditElementsMenu(j);

                        //Выбор пункта меню редактирования
                        if (key.Key == ConsoleKey.Enter)
                        {
                            //Метод выбора
                            switch (j)
                            {
                                //1 РЕДАКТИРОВАНИЕ УЛИЦ
                                case 1:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню удаления
                                    EditStreets();
                                    break;

                                //2 РЕДАКТИРОВАНИЕ АВТОСТОЯНКИ
                                case 2:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Метод построения меню
                                    EditParkings();
                                    break;


                                //3 ПУНКТ РЕДАКТИРОВАНИЕ АКТА
                                case 3:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Метод построения меню
                                    EditActs();
                                    break;

                                //4 ПУНКТ ВЫХОД В ГЛАВНОЕ МЕНЮ
                                case 4:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов меню редактирования
                                    consolebd.EditMenu(1);

                                    //Вызов метода считывания клавиш
                                    EditMenu();
                                    break;
                            }
                        }
                    }

                } while (key.Key != ConsoleKey.Enter);

            }
        }

        //Метод меню редактирования улиц
        public static void EditStreets()
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменная пункта меню
            int j = 1;

            //Переменная для передачи индекса элемента
            int num = 1;

            //Переменная для хранения индекса элемента из списка
            int index = 0;

            //Вызов метода построения меню выбора улицы
            consolebd.EditStreetsMenu(1, 1);

            //Вызов вложенного метода
            EditStreetsMain();

            //Вложенный метод
            void EditStreetsMain()
            {
                //Очистка консоли
                Console.Clear();

                //Вызов метода построения меню
                consolebd.EditStreetsMenu(j, num);

                //основной блок выполнения
                do
                {
                    //Считывание информации о нажатой клавише
                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                    {
                        //Очистка консоли
                        Console.Clear();

                        //Оператор выбора 
                        switch (key.Key)
                        {
                            //UPARROW
                            case ConsoleKey.UpArrow:
                                if (j <= 21) { j--; if (j < 1) { j = 21; } if (j > 21) { j = 1; } }

                                break;

                            //DOWNARROW
                            case ConsoleKey.DownArrow:
                                if (j <= 21) { j++; if (j < 1) { j = 21; } if (j > 21) { j = 1; } }

                                break;

                            //LEFTARROW
                            case ConsoleKey.LeftArrow:
                                if (j == 21) { j = 210000; }
                                else
                                {
                                    if (j == 210000) { j = 2100; }
                                    else
                                    {
                                        if (j <= 20) { j *= 100; }
                                        else { j /= 100; }
                                    }
                                }

                                break;

                            //RIGHTARROW
                            case ConsoleKey.RightArrow:
                                if (j == 21) { j = 2100; }
                                else if (j == 210000) { j = 21; }
                                else
                                if (j == 2100) { j = 210000; }
                                else
                                {
                                    if (j == 210000) { j = 21; }
                                    else
                                    {
                                        if (j <= 20) { j *= 100; }
                                        else { j /= 100; }
                                    }
                                }
                                break;
                        }

                        //Вызов метоню построения 
                        consolebd.EditStreetsMenu(j, num);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (j)
                            {
                                case 1:
                                    if (num <= data.CountTab2())
                                    {
                                        index = num;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 2:
                                    if (num + 1 <= data.CountTab2())
                                    {
                                        index = num + 1;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 3:
                                    if (num + 2 <= data.CountTab2())
                                    {
                                        index = num + 2;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 4:
                                    if (num + 3 <= data.CountTab2())
                                    {
                                        index = num + 3;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 5:
                                    if (num + 4 <= data.CountTab2())
                                    {
                                        index = num + 4;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 6:
                                    if (num + 5 <= data.CountTab2())
                                    {
                                        index = num + 5;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 7:
                                    if (num + 6 <= data.CountTab2())
                                    {
                                        index = num + 6;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 8:
                                    if (num + 7 <= data.CountTab2())
                                    {
                                        index = num + 7;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 9:
                                    if (num + 8 <= data.CountTab2())
                                    {
                                        index = num + 8;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 10:
                                    if (num + 9 <= data.CountTab2())
                                    {
                                        index = num + 9;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 11:
                                    if (num + 10 <= data.CountTab2())
                                    {
                                        index = num + 10;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 12:
                                    if (num + 11 <= data.CountTab2())
                                    {
                                        index = num + 11;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 13:
                                    if (num + 12 <= data.CountTab2())
                                    {
                                        index = num + 12;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 14:
                                    if (num + 13 <= data.CountTab2())
                                    {
                                        index = num + 13;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 15:
                                    if (num + 14 <= data.CountTab2())
                                    {
                                        index = num + 14;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 16:
                                    if (num + 15 <= data.CountTab2())
                                    {
                                        index = num + 15;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 17:
                                    if (num + 16 <= data.CountTab2())
                                    {
                                        index = num + 16;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 18:
                                    if (num + 17 <= data.CountTab2())
                                    {
                                        index = num + 17;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 19:
                                    if (num + 18 <= data.CountTab2())
                                    {
                                        index = num + 18;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 20:
                                    if (num + 19 <= data.CountTab2())
                                    {
                                        index = num + 19;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementStreet(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditStreetsMain();
                                    }
                                    index = 0;
                                    break;

                                case 21:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    EditMenu();
                                    break;

                                case 2100:
                                    num -= 20;
                                    if (num < 1) { num = 81; }
                                    if (num >= 100) { num = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода считывания клавиш
                                    EditStreetsMain();
                                    break;

                                case 210000:
                                    num += 20;
                                    if (num < 1) { num = 81; }
                                    if (num >= 100) { num = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода считывания клавиш
                                    EditStreetsMain();
                                    break;
                            }
                        }
                    }
                } while (key.Key != ConsoleKey.Enter);
            }
        }

        //метод редактирования улицы
        public static void EditElementStreet(int index)
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            //Создание экземпляра класса с метода построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для выбора пункта меню
            int j = 1;

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменные для передачи в список
            string streetname = " ";
            string streetlength = " ";

            //Получение cтрок из списка
            streetname = data.OutPutSt(index - 1);

            streetlength = data.OutPutStl(index - 1);

            //Вызов вложенного метода
            EditElementStreetMain();

            //Вложенный метод
            void EditElementStreetMain()
            {
                //Очистка консоли
                Console.Clear();

                //Вызов метода построения меню редактирования улицы
                consolebd.EditStreetElement(j, streetname, streetlength);

                //Основной цикл выполнения
                do
                {

                    //Считывание информации о нажатой клавише
                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                    {
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

                        //Очистка консоли
                        Console.Clear();

                        //Вызов метода построения меню редактирования улиц
                        consolebd.EditStreetElement(j, streetname, streetlength);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (j)
                            {
                                //Ввод названия улицы
                                case 1:
                                    //начало ввода названия улицы

                                    //Обнуление переменной названия улицы
                                    streetname = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра 
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.EditStreetElement(0, streetname, streetlength);

                                    //Перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(20, 3);

                                    //Считывание строки
                                    streetname = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (streetname == " " || streetname == null || streetname.Length > 50 || streetname == "" || streetname.Contains('\t'))
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //Обнуление переменной названия улицы
                                        streetname = " ";

                                        //Повторный вызов метода построения меню добавления улицы
                                        consolebd.AddElemStreet(j, streetname, streetlength);

                                        //Повторный вызов метода считывания клавиш
                                        EditElementStreetMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню 
                                        consolebd.AddElemStreet(j, streetname, streetlength);

                                        //Повторный вызов метода для считывания клавиш
                                        EditElementStreetMain();
                                    }
                                    break;

                                //Ввод длины улицы
                                case 2:
                                    //начало ввода длины улицы

                                    //Обнуление переменной длины улицы
                                    streetlength = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра 
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.EditStreetElement(0, streetname, streetlength);

                                    //Перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(20, 5);

                                    //Считывание строки
                                    streetlength = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (streetlength == " " || streetlength == null || streetlength.Length > 50 || streetlength == "" || streetlength.Contains('\t'))
                                    {
                                        //Обнуление переменной 
                                        streetlength = " ";

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //Вызов метода построения меню добавления элемента
                                        consolebd.AddElemStreet(j, streetname, streetlength);

                                        //Вызов метода считывания нажатой клавиши
                                        EditElementStreetMain();

                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        double slen = 0;

                                        //дополнительная проверка на возможность конвертации значения 
                                        if (double.TryParse(streetlength, out slen))
                                        {
                                            //Конвертация
                                            slen = Double.Parse(streetlength);

                                            //Повторный вызов метода построения меню 
                                            consolebd.EditStreetElement(j, streetname, streetlength);

                                            //Повторный вызов метода для считывания клавиш
                                            EditElementStreetMain();
                                        }
                                        else
                                        {
                                            //обнуление введенного значения
                                            streetlength = " ";

                                            //очистка консоли
                                            Console.Clear();

                                            //Вызов метода построения таблицы предупреждения
                                            consolebd.AttentionAddElement();

                                            //Повторный вызов меню добавления улицы
                                            consolebd.AddElemStreet(j, streetname, streetlength);

                                            //Вызов метода выбора пункта меню
                                            EditElementStreetMain();
                                        }
                                    }
                                    break;

                                //Назад
                                case 3:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов меню построения главного меню добавления элемента
                                    //С передачей в качестве параметра еденицы (для изначального отображения первого пункта меню)
                                    EditMenu();
                                    break;

                                //Сохранить
                                case 300:
                                    //очистка консоли
                                    Console.Clear();

                                    //Проверка на то, что все поля заполнены

                                    //Объявление переменных для хранения промежуточного результата
                                    //Если поле удовлетворяет условиям заполнения и не пустое -> true, иначе false
                                    bool strlengthBool = false;
                                    bool strnameBool = false;

                                    //Проверка на пустое поле для переменной имени улицы
                                    if (streetname == "" || streetname == " ")
                                    {
                                        strnameBool = false;
                                    }
                                    else
                                    {
                                        strnameBool = true;
                                    }

                                    //Проверка на пустое поле для переменной длины улицы
                                    if (streetlength == "" || streetlength == " ")
                                    {
                                        strlengthBool = false;
                                    }
                                    else
                                    {
                                        strlengthBool = true;
                                    }

                                    //Финальная проверка результата
                                    if (strlengthBool == false || strnameBool == false)
                                    {

                                        //очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения меню предупреждения
                                        consolebd.AttentionAlreadyHasStreet();

                                        //Повторный вызов метода добавления улицы
                                        consolebd.AddElemStreet(j, streetname, streetlength);

                                        //Повторный вызов метода считывания клавиш
                                        EditElementStreetMain();

                                    }
                                    else
                                    {
                                        data.EditTab2(streetname, streetlength, index - 1);

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения главного меню добовления нового элемента
                                        EditMenu();
                                    }
                                    break;
                            }
                        }
                    }
                } while (key.Key != ConsoleKey.Enter);
            }
        }

        //Метод редактирования автостоянки
        public static void EditElementParking(int index)
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            //Создание экземпляра класса с метода построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для выбора пункта меню
            int j = 1;

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменные для передачи в список
            string parkingname = " ";
            string parkingadress = " ";
            string parkingnumber = " ";

            //Получение cтрок из списка
            parkingname = data.OutPutPrkname(index - 1);

            parkingadress = data.OutPutPrkadress(index - 1);

            parkingnumber = data.OutPutPrknumber(index - 1);

            //Вызов вложенного метода
            EditElementParkingMain();

            //Вложенный метод
            void EditElementParkingMain()
            {
                //Очистка консоли
                Console.Clear();

                //Вызов метода построения меню редактирования автостоянки
                consolebd.EditParkingElement(j, parkingname, parkingadress, parkingnumber);

                do
                {
                    //Считывание инорфмации о нажатой клавише
                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                    {
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
                                    if (j < 3) { j = 400; }
                                    if (j > 400) { j = 3; }
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

                        //Очистка консоли
                        Console.Clear();

                        //Вызов метода построения меню редактирования автостоянки
                        consolebd.EditParkingElement(j, parkingname, parkingadress, parkingnumber);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (j)
                            {
                                //ввод названия автостоянки
                                case 1:
                                    //Начало ввода названия автостоянки

                                    //Обнуление переменной названия автостоянки
                                    parkingname = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра 
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.EditParkingElement(0, parkingname, parkingadress, parkingnumber);

                                    //перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(20, 3);

                                    //Считывание строки
                                    parkingname = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (parkingname == " " || parkingname == null || parkingname.Length > 50 || parkingname == "" || parkingname.Contains('\t'))
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //обнуление переменной названия автостоянки
                                        parkingname = " ";

                                        //Повторный вызов метода построения меню добавления автостоянки
                                        consolebd.EditParkingElement(j, parkingname, parkingadress, parkingnumber);

                                        //Повторный вызов метода считывания клавиш
                                        EditElementParkingMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню добавления автостоянки
                                        consolebd.EditParkingElement(j, parkingname, parkingadress, parkingnumber);

                                        //Повторный вызов метода для считывания клавиш
                                        EditElementParkingMain();
                                    }

                                    break;

                                //Ввод адреса автостоянки
                                case 2:
                                    //Начало ввода адреса автостоянки

                                    //обнуление переменной адреса автостоянки
                                    parkingadress = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.EditParkingElement(0, parkingname, parkingadress, parkingnumber);

                                    //Перемещение каретки в нужное положение в табоице
                                    Console.SetCursorPosition(20, 5);

                                    //Считывание строки
                                    parkingadress = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (parkingadress == " " || parkingadress == null || parkingadress.Length > 50 || parkingadress == "" || parkingadress.Contains('\t'))
                                    {
                                        //Обнуление переменной
                                        parkingadress = " ";

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки 
                                        consolebd.AttentionAddElement();

                                        //Вызов метода построения меню добавления элемента
                                        consolebd.EditParkingElement(j, parkingname, parkingadress, parkingnumber);

                                        //Вызов метода считывания нажатой клавиши
                                        EditElementParkingMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню
                                        consolebd.EditParkingElement(j, parkingname, parkingadress, parkingnumber);

                                        //Повторный вызов метода для считывания клаваиш
                                        EditElementParkingMain();
                                    }

                                    break;

                                //Ввод номера автостоянки
                                case 3:
                                    //начало ввода номера автостоянки

                                    //Обнуление переменной номера автостоянки
                                    parkingnumber = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //с передачей нуля в качестве параметра
                                    //для того чтобы не было активных пунктов меню выбора
                                    consolebd.EditParkingElement(0, parkingname, parkingadress, parkingnumber);

                                    //Перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(20, 7);

                                    //Считывание строки
                                    parkingnumber = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (parkingnumber == " " || parkingnumber == null || parkingnumber.Length > 50 || parkingnumber == "" || parkingnumber.Contains('\t'))
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов окошка ошибки
                                        consolebd.AttentionAddElement();

                                        //Обнуление переменной номера автостоянки
                                        parkingnumber = " ";

                                        //Повторный вызов метода построения меню добавления автостоянки
                                        consolebd.EditParkingElement(j, parkingname, parkingadress, parkingnumber);

                                        //Повторный вызов метода считывания клавиш
                                        EditElementParkingMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню
                                        consolebd.EditParkingElement(j, parkingname, parkingadress, parkingnumber);

                                        //Повторный вызов метода для считывания клавиш
                                        EditElementParkingMain();
                                    }
                                    break;

                                case 4:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов меню построения главного меню добавления элемента
                                    //С передачей в качестве параметра единицы
                                    EditMenu();
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

                                    //Проверка на пустое поле для переменной названия автостоянки
                                    if (parkingname == "" || parkingname == " ")
                                    {
                                        prknameBool = false;
                                    }
                                    else
                                    {
                                        prknameBool = true;
                                    }

                                    //Проверка на пустое поле для переменной адреса автостоянки
                                    if (parkingadress == "" || parkingadress == " ")
                                    {
                                        prkadressBool = false;
                                    }
                                    else
                                    {
                                        prkadressBool = true;
                                    }

                                    //Проверка на пустое поле для переменной номера автостоянки
                                    if (parkingnumber == "" || parkingnumber == " ")
                                    {
                                        prknumberBool = false;
                                    }
                                    else
                                    {
                                        prknumberBool = true;
                                    }

                                    //Финальная проверка результата
                                    if (prknameBool == false || prkadressBool == false || prknumberBool == false)
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения меню предупреждения
                                        consolebd.AttentionAlreadyHasParking();

                                        //Повторный вызов метода добавления улицы
                                        consolebd.EditParkingElement(j, parkingname, parkingadress, parkingnumber);

                                        //Повторный вызов метода считывания клавиш
                                        EditElementParkingMain();

                                    }
                                    else
                                    {
                                        data.EditTab3(parkingname, parkingadress, parkingnumber, index - 1);

                                        //очистка консоли
                                        Console.Clear();

                                        //Переход в главное меню добавления элемента

                                        //Вызов метода построения главного меню добавления нового элемента
                                        EditMenu();
                                    }
                                    break;
                            }
                        }
                    }

                } while (key.Key != ConsoleKey.Enter);
            }
        }

        //Метод редактирования акта эвакуации
        public static void EditElementAct(int index)
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            //Создание экземпляра класса с метода построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для выбора пункта меню
            int j = 1;

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменные для передачи в список
            string gps = " ";
            string typevio = " ";
            string carnum = " ";
            string cartype = " ";
            string streetname = " ";
            string parkingname = " ";
            string streetlen = " ";
            string parkingadress = " ";
            string parkingnumber = " ";
            int indexStreet = 0;
            int indexParking = 0;

            //Получение строк из списка
            gps = data.OutPutGPS(index - 1);
            typevio = data.OutPutTypeVio(index - 1);
            carnum = data.OutPutCarNum(index - 1);
            cartype = data.OutPutCarType(index - 1);
            streetname = data.OutputStreetNameTab1(index - 1);
            parkingname = data.OutputParkingNameTab1(index - 1);

            //Вызов вложенного метода
            EditElementActMain();

            //Вложенный метод
            void EditElementActMain()
            {
                //Очистка консоли
                Console.Clear();

                //Вызов метода построения меню редактирования акта
                consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                do
                {
                    //Считывание информации о нажатой клавише
                    key = Console.ReadKey(true);

                    //Очистка консоли
                    Console.Clear();

                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                    {
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

                        //Вызов метода построения меню редактирования акта эвакуации
                        consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

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
                                    gps = "";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //с передачей нуля в качестве параметра
                                    //для того чтобы не было активных пунктов выбора ввода
                                    consolebd.EditActElement(0, gps, typevio, carnum, cartype, streetname, parkingname);

                                    //перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(22, 3);

                                    //Считывание строки
                                    gps = Console.ReadLine();

                                    //Проверка на правильность ввода
                                    if (gps == " " || gps == null || gps == "" || gps.Length > 50 || gps.Contains('\t'))
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки
                                        consolebd.AttentionAddElement();

                                        //Обнуление переменной gps-координат
                                        gps = " ";

                                        //Повторный вызов метода построения меню добавления акта эвакуации
                                        consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                                        //Повторный вызов метода считывания клавиш
                                        EditElementActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню добавления акта эвакуации
                                        consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                                        //Повторный вызов метода считывания клавиш в текущем меню
                                        EditElementActMain();
                                    }

                                    break;

                                //Ввод типа нарушения
                                case 2:
                                    //начало ввода типа нарушения

                                    //Обнуление переменной типа нарушения
                                    typevio = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню выбора типа нарушения
                                    typevio = ChoiseTypeVoilation();

                                    //Очистка консоли
                                    Console.Clear();

                                    //Повторный вызов метода построения меню добавления акта эвакуации
                                    consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                                    //Повторный вызов метода для считывания клавиш
                                    EditElementActMain();
                                    break;

                                //Ввод номера автомобиля
                                case 3:
                                    //Начало ввода номера автомобиля

                                    //Обнуление переменной номера автомобиля
                                    carnum = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения текущего меню
                                    //С передачей нуля в качестве параметра
                                    //Для того чтобы не было активных пунктов выбора меню
                                    consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                                    //Перемещение каретки в нужное положение в таблице
                                    Console.SetCursorPosition(22, 7);

                                    //Считывание строки
                                    carnum = Console.ReadLine();

                                    //проверка на правильность ввода
                                    if (carnum == "" || carnum == " " || carnum == null || carnum.Length > 50 || carnum.Contains('\t'))
                                    {
                                        //обнуление переменной
                                        carnum = " ";

                                        //очистка консоли
                                        Console.Clear();

                                        //Вызов меню ошибки 
                                        consolebd.AttentionAddElement();

                                        //Вызов метода построения меню для добавления акта эвакуации
                                        consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                                        //Вызов метода считывания нажатой клавиши
                                        EditElementActMain();
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Повторный вызов метода построения меню
                                        consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                                        //Повторный вызов метода для считывания клавиш
                                        EditElementActMain();
                                    }

                                    break;

                                //Добавление типа автомобиля
                                case 4:
                                    //начало ввода типа автомобиля

                                    //Обнуление переменной типа автомобиля
                                    cartype = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню выбора типа нарушения
                                    cartype = ChoiseTypeOfCar();

                                    //Очистка консоли
                                    Console.Clear();

                                    //Повторный вызов метода построения меню добавления акта эвакуации
                                    consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                                    //Повторный вызов метода для считывания клавиш
                                    EditElementActMain();
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


                                    //Очистка консоли
                                    Console.Clear();

                                    //ChoiseStreet();

                                    //Вызов метода выбора улицы из существующих
                                    int index2 = ChoiseStreet();

                                    //передача индекса в переменную
                                    indexStreet = index2 - 1;

                                    //Присвоение 
                                    if (indexStreet < 0) { streetname = " "; } else { streetname = data.OutPutSt(index2 - 1); }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню добавления акта эвакуации
                                    consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                                    //Вызов метода считывания клавиш
                                    EditElementActMain();


                                    //Очистка консоли
                                    Console.Clear();

                                    break;

                                //Автостоянка
                                case 6:
                                    //Начало выбора автостоянки

                                    //Обнуление переменной автостоянки
                                    parkingname = " ";

                                    //Очистка консоли
                                    Console.Clear();

                                    //переменная, принимающая значение количества элементов в списке
                                    int elementsintab2 = data.CountTab3();

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода выбора автостоянки из существующих
                                    int index1 = ChoiseParking();

                                    //передача индекса в переменную
                                    indexParking = index1 - 1;

                                    //Присвоение
                                    if (indexParking < 0) { parkingname = " "; } else { parkingname = data.OutPutPrkname(index1 - 1); }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню добавления акта эвакуации
                                    consolebd.EditActElement(j, gps, typevio, carnum, cartype, streetname, parkingname);

                                    //Вызов метода считывания клавиш
                                    EditElementActMain();

                                    //Очистка консоли
                                    Console.Clear();

                                    break;

                                //Назад
                                case 7:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов главного меню добавления элемента
                                    //с передачей в качестве параметра еденицы
                                    EditMenu();
                                    break;

                                //Сохранить
                                //Введенная информация сохраняется и записывается в список
                                //Далее происходит преход в главное меню добавления нового элемента
                                case 700:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Проверка на то, что все поля заполнены

                                    //Объявление переменных для сохранения промежуточного результата
                                    //Если поле удовлетворяет условиям заполнения и не пустое -> true, иначе false
                                    bool GPSBool = false;
                                    bool typevioBool = false;
                                    bool numofcarBool = false;
                                    bool typeofcarBool = false;
                                    bool streetBool = false;
                                    bool parkingBool = false;

                                    //Проверка на пустое поле для переменной gps
                                    if (gps == " " || gps == "")
                                    {
                                        GPSBool = false;
                                    }
                                    else
                                    {
                                        GPSBool = true;
                                    }

                                    //Проверка на пустое поле для переменной типа нарушения
                                    if (typevio == "" || typevio == " ")
                                    {
                                        typevioBool = false;
                                    }
                                    else
                                    {
                                        typevioBool = true;
                                    }

                                    //Проверка на пустое поле для переменной номера автомобиля
                                    if (carnum == "" || carnum == " ")
                                    {
                                        numofcarBool = false;
                                    }
                                    else
                                    {
                                        numofcarBool = true;
                                    }

                                    //Проверка на пустое поле для переменной типа автомобиля
                                    if (cartype == "" || cartype == " ")
                                    {
                                        typeofcarBool = false;
                                    }
                                    else
                                    {
                                        typeofcarBool = true;
                                    }

                                    //Проверка на пустое поле для переменной улицы
                                    if (streetname == "" || streetname == " ")
                                    {
                                        streetBool = false;
                                    }
                                    else
                                    {
                                        streetBool = true;
                                    }

                                    //Проверка на пустое поле для переменной парковки
                                    if (parkingname == "" || parkingname == " ")
                                    {
                                        parkingBool = false;
                                    }
                                    else
                                    {
                                        parkingBool = true;
                                    }

                                    if (GPSBool == false || typevioBool == false || numofcarBool == false || typeofcarBool == false || streetBool == false || parkingBool == false)
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.AttentionNullableFields();

                                        //Повторный вызов метода добавления акта эвакуации
                                        EditElementActMain();
                                    }
                                    else
                                    {
                                        streetlen = data.OutPutSt(indexStreet);

                                        parkingadress = data.OutPutPrkadress(indexParking);

                                        parkingnumber = data.OutPutPrknumber(indexParking);

                                        data.EditTab1(gps, typevio, carnum, cartype, streetname, streetlen, parkingname, parkingadress, parkingnumber, index, indexStreet, indexParking);

                                        //Очистка консоли
                                        Console.Clear();

                                        //переход в главное меню добавления элемента
                                        EditMenu();
                                    }

                                    break;

                            }
                        }

                    }

                } while (key.Key != ConsoleKey.Enter);
            }
        }

        //Метод меню редактирования автостоянок
        public static void EditParkings()
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменная пункта меню
            int j = 1;

            //Переменная для передачи индекса элемента
            int num = 1;

            //Переменная для хранения индекса элемента из списка
            int index = 0;

            //Вызов вложенного метода
            EditParkingsMain();

            //Вложенный метод
            void EditParkingsMain()
            {
                //Очистка консоли
                Console.Clear();

                //Вызов метода построения меню выбора улицы для редактирования
                consolebd.EditParkingMenu(j, num);

                do
                {
                    //Считывание информации о нажатой клавише
                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                    {
                        //Очистка консоли
                        Console.Clear();

                        //Оператор выбора 
                        switch (key.Key)
                        {
                            //UPARROW
                            case ConsoleKey.UpArrow:
                                if (j <= 21) { j--; if (j < 1) { j = 21; } if (j > 21) { j = 1; } }

                                break;

                            //DOWNARROW
                            case ConsoleKey.DownArrow:
                                if (j <= 21) { j++; if (j < 1) { j = 21; } if (j > 21) { j = 1; } }

                                break;

                            //LEFTARROW
                            case ConsoleKey.LeftArrow:
                                if (j == 21) { j = 210000; }
                                else
                                {
                                    if (j == 210000) { j = 2100; }
                                    else
                                    {
                                        if (j <= 20) { j *= 100; }
                                        else { j /= 100; }
                                    }
                                }

                                break;

                            //RIGHTARROW
                            case ConsoleKey.RightArrow:
                                if (j == 21) { j = 2100; }
                                else if (j == 210000) { j = 21; }
                                else
                                if (j == 2100) { j = 210000; }
                                else
                                {
                                    if (j == 210000) { j = 21; }
                                    else
                                    {
                                        if (j <= 20) { j *= 100; }
                                        else { j /= 100; }
                                    }
                                }
                                break;
                        }

                        consolebd.EditParkingMenu(j, num);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (j)
                            {
                                case 1:
                                    if (num <= data.CountTab3())
                                    {
                                        index = num;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 2:
                                    if (num + 1 <= data.CountTab3())
                                    {
                                        index = num + 1;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 3:
                                    if (num + 2 <= data.CountTab3())
                                    {
                                        index = num + 2;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 4:
                                    if (num + 3 <= data.CountTab3())
                                    {
                                        index = num + 3;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 5:
                                    if (num + 4 <= data.CountTab3())
                                    {
                                        index = num + 4;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 6:
                                    if (num + 5 <= data.CountTab3())
                                    {
                                        index = num + 5;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 7:
                                    if (num + 6 <= data.CountTab3())
                                    {
                                        index = num + 6;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 8:
                                    if (num + 7 <= data.CountTab3())
                                    {
                                        index = num + 7;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 9:
                                    if (num + 8 <= data.CountTab3())
                                    {
                                        index = num + 8;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 10:
                                    if (num + 9 <= data.CountTab3())
                                    {
                                        index = num + 9;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 11:
                                    if (num + 10 <= data.CountTab3())
                                    {
                                        index = num + 10;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 12:
                                    if (num + 11 <= data.CountTab3())
                                    {
                                        index = num + 11;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 13:
                                    if (num + 12 <= data.CountTab3())
                                    {
                                        index = num + 12;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 14:
                                    if (num + 13 <= data.CountTab3())
                                    {
                                        index = num + 13;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 15:
                                    if (num + 14 <= data.CountTab3())
                                    {
                                        index = num + 14;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 16:
                                    if (num + 15 <= data.CountTab3())
                                    {
                                        index = num + 15;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 17:
                                    if (num + 16 <= data.CountTab3())
                                    {
                                        index = num + 16;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 18:
                                    if (num + 17 <= data.CountTab3())
                                    {
                                        index = num + 17;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 19:
                                    if (num + 18 <= data.CountTab3())
                                    {
                                        index = num + 18;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 20:
                                    if (num + 19 <= data.CountTab3())
                                    {
                                        index = num + 19;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementParking(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditParkingsMain();
                                    }
                                    index = 0;
                                    break;

                                case 21:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    EditMenu();
                                    break;

                                case 2100:
                                    num -= 20;
                                    if (num < 1) { num = 81; }
                                    if (num >= 100) { num = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода считывания клавиш
                                    EditParkingsMain();
                                    break;

                                case 210000:
                                    num += 20;
                                    if (num < 1) { num = 81; }
                                    if (num >= 100) { num = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода считывания клавиш
                                    EditParkingsMain();
                                    break;
                            }
                        }
                    }

                } while (key.Key != ConsoleKey.Enter);
            }
        }

        //Метод меню редактирования актов эвакуации
        public static void EditActs()
        {
            //Создание экземпляра класса с данными
            Data data = new Data();

            //Создание экземпляра класса с методами построения меню
            Consolebd consolebd = new Consolebd();

            //Переменная для хранения информации о нажатой клавише
            ConsoleKeyInfo key;

            //Переменная пункта меню
            int j = 1;

            //Переменная для передачи индекса элемента
            int num = 1;

            //Переменная для хранения индекса элемента из списка
            int index = 0;

            //Вызов вложенного метода
            EditActsMain();

            //Вложенный метод
            void EditActsMain()
            {
                //Очистка консоли
                Console.Clear();

                //Вызов метода построения меню выбора акта эвакуации для редактирования
                consolebd.EditActsMenu(j, num);

                do
                {
                    //Считывание информации о нажатой клавише
                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.LeftArrow || key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.Enter)
                    {
                        //Очистка консоли
                        Console.Clear();

                        //Оператор выбора 
                        switch (key.Key)
                        {
                            //UPARROW
                            case ConsoleKey.UpArrow:
                                if (j <= 21) { j--; if (j < 1) { j = 21; } if (j > 21) { j = 1; } }

                                break;

                            //DOWNARROW
                            case ConsoleKey.DownArrow:
                                if (j <= 21) { j++; if (j < 1) { j = 21; } if (j > 21) { j = 1; } }

                                break;

                            //LEFTARROW
                            case ConsoleKey.LeftArrow:
                                if (j == 21) { j = 210000; }
                                else
                                {
                                    if (j == 210000) { j = 2100; }
                                    else
                                    {
                                        if (j <= 20) { j *= 100; }
                                        else { j /= 100; }
                                    }
                                }

                                break;

                            //RIGHTARROW
                            case ConsoleKey.RightArrow:
                                if (j == 21) { j = 2100; }
                                else if (j == 210000) { j = 21; }
                                else
                                if (j == 2100) { j = 210000; }
                                else
                                {
                                    if (j == 210000) { j = 21; }
                                    else
                                    {
                                        if (j <= 20) { j *= 100; }
                                        else { j /= 100; }
                                    }
                                }
                                break;
                        }

                        //Вызов метода построения меню выбора акта для редактирования
                        consolebd.EditActsMenu(j, num);

                        if (key.Key == ConsoleKey.Enter)
                        {
                            switch (j)
                            {
                                case 1:
                                    if (num <= data.CountTab1())
                                    {
                                        index = num;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 2:
                                    if (num + 1 <= data.CountTab1())
                                    {
                                        index = num + 1;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 3:
                                    if (num + 2 <= data.CountTab1())
                                    {
                                        index = num + 2;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 4:
                                    if (num + 3 <= data.CountTab1())
                                    {
                                        index = num + 3;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 5:
                                    if (num + 4 <= data.CountTab1())
                                    {
                                        index = num + 4;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 6:
                                    if (num + 5 <= data.CountTab1())
                                    {
                                        index = num + 5;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 7:
                                    if (num + 6 <= data.CountTab1())
                                    {
                                        index = num + 6;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 8:
                                    if (num + 7 <= data.CountTab1())
                                    {
                                        index = num + 7;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 9:
                                    if (num + 8 <= data.CountTab1())
                                    {
                                        index = num + 8;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 10:
                                    if (num + 9 <= data.CountTab1())
                                    {
                                        index = num + 9;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 11:
                                    if (num + 10 <= data.CountTab1())
                                    {
                                        index = num + 10;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 12:
                                    if (num + 11 <= data.CountTab1())
                                    {
                                        index = num + 11;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 13:
                                    if (num + 12 <= data.CountTab1())
                                    {
                                        index = num + 12;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 14:
                                    if (num + 13 <= data.CountTab1())
                                    {
                                        index = num + 13;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 15:
                                    if (num + 14 <= data.CountTab1())
                                    {
                                        index = num + 14;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 16:
                                    if (num + 15 <= data.CountTab1())
                                    {
                                        index = num + 15;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 17:
                                    if (num + 16 <= data.CountTab1())
                                    {
                                        index = num + 16;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 18:
                                    if (num + 17 <= data.CountTab1())
                                    {
                                        index = num + 17;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 19:
                                    if (num + 18 <= data.CountTab1())
                                    {
                                        index = num + 18;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 20:
                                    if (num + 19 <= data.CountTab1())
                                    {
                                        index = num + 19;

                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода редактирования улицы
                                        EditElementAct(index);
                                    }
                                    else
                                    {
                                        //Очистка консоли
                                        Console.Clear();

                                        //Вызов метода построения окна предупреждения
                                        consolebd.Attention();

                                        //Повторный вызов
                                        EditActsMain();
                                    }
                                    index = 0;
                                    break;

                                case 21:
                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода построения меню
                                    EditMenu();
                                    break;

                                case 2100:
                                    num -= 20;
                                    if (num < 1) { num = 81; }
                                    if (num >= 100) { num = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода считывания клавиш
                                    EditActsMain();
                                    break;

                                case 210000:
                                    num += 20;
                                    if (num < 1) { num = 81; }
                                    if (num >= 100) { num = 1; }

                                    //Очистка консоли
                                    Console.Clear();

                                    //Вызов метода считывания клавиш
                                    EditActsMain();
                                    break;
                            }

                        }
                    }

                } while (key.Key != ConsoleKey.Enter);
            }
        }

    }
}
