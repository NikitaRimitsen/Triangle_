using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle_Rimitsen
{
    class Triangle
    {
        public double a;// первая сторона
        public double b;// вторая сторона
        public double c;// третья сторона
        public double h;// высота
        public double cosa;//угол а
        public double z;//средняя линия

        public Triangle(double A, double B, double C)// Конструктор для переменных a, b, c
        {
            a = A;// создаем с заданными длинами сторон согласно заданию
            b = B;
            c = C;
            
        }
        public Triangle()
        {

        }
        public Triangle(double A, double H)//Конструктор для переменных a, b
        {
            a = A;
            h = H;
        }
        public Triangle(double Z)//Конструктор для переменной средной линии
        {
            z = Z;
        }

        public string outputA()
        {
            return Convert.ToString(a);
        }
        public string outputB()
        {
            return Convert.ToString(b);
        }
        public string outputC()
        {
            return Convert.ToString(c);
        }
        public string outputH()
        {
            return Convert.ToString(h);
        }
        public double Perimeter()//Функция для поиска периметра
        {
            double p = 0;
            p = a + b + c;
            return p;
        }
        public double Surface()//Функция для поиска площади
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;
        }
        public double Surface_Ploshad()
        {
            double plos = 0;
            plos = (a + h / 2);

            return plos;

        }

        public double Vesota()//Функция для поиска высоты
        {
            double ha = 0;
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            ha = Math.Sqrt((2 * s) / a);

            return ha;
        }
        
        public double Sredanjalinija()//Функция для поиска средной линии
        {
            double z = 0;
            z = a / 2;
            return z;
        }

        public double Ugol()//Функция для поиска угла
        {
            double cosa = 0;
            cosa = Math.Cos(((c * c) + (b * b) - (a * a)) / 2 * b * c);
            return cosa;
        }
        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }

        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }

        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }

        public bool ExistTriange
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                    return true;
                else return false;
            }
        }

        public string TriangleType//Функция, которая определяет вид треугольника, либо он ломаный, равносторонний, равнобедренный или разносторонний 
        {
            get
            {

                if (a == b && a == c && b == c)
                    return "Это равносторонний";
                else if (a == b || a == c || b == c)
                    return "Это равнобедренный";
                else if (ExistTriange != false)
                    return "Это ломаная";
                else if (a == 0 || b == 0 || c == 0)
                    return "Нет такого треугольника";
                else return "Это разносторонний";

            }
        }
    }
}
