using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    //Класс для работы с таблицей 1
    //Основная
    //Таблица актов эвакуации
    class Tab1
    {
        //Строковая переменная для хранения типа нарушения
        private string typeofviolation;
        
        //Свойство переменной для хранения типа нарушения
        public string TypeOfViolation
        {
            get
            {
                return typeofviolation;
            }
            set
            {
                typeofviolation = value;
            }
        }

        //Строковая переменная для хранения типа автомобиля
        private string typeofcar;

        //Свойство перменной для хранения типа автомобиля
        public string TypeOfCar
        {
            get
            {
                return typeofcar;
            }
            set
            {
                typeofcar = value;
            }
        }

        //Строковая перменная для хранения номера автомобиля
        private string numberofcar;

        //Свойство переменной для хранения номера втомобиля
        public string NumberOfCar
        {
            get
            {
                return numberofcar;
            }
            set
            {
                numberofcar = value;
            }
        }

        //Строковая переменная для хранения названия улицы
        private string street;

        //Свойство переменной для хранения названия улицы
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        //Переменная для хранения длины улицы
        private double lengthofstreet;

        //Свойство переменной для хранения длины улицы
        public double LengthOfStreet
        {
            get
            {
                return lengthofstreet;
            }
            set
            {
                lengthofstreet = value;
            }
        }

    }

    //Класс для работы с таблицей 2
    //Второстепенная
    //Таблица штрафных автостоянок
    class Tab2
    {

    }

    //Класс для работы с таблицей 3
    //Второстепенная
    //Таблица улиц
    class Tab3
    {

    }

    class Data
    {
        private string FileName;

        public string filename
        {
            get
            {
                return FileName;
            }
            set
            {
                FileName = value;
            }
        }

        private int FileNameLength;

        public int filenamelength
        {
            get
            {
                return FileNameLength;
            }
            set
            {
                FileNameLength = FileName.Length;
            }
        }
    }
}
