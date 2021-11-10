using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_vorm
{
    class Triangle
    {
        int a, b, c;


        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle() { }

        // Методы, позволяющие: вывести длины сторон треугольника на экран;
        public void Output() { Console.WriteLine("Треугольник со сторонами а = {0}, b = {1}, c = {2}", a, b, c); }

        //расчитать периметр треугольника;
        public int Perimeter() { return a + b + c; }

        // расчитать площадь треугольника
        public double Surface()
        {
            double HalfPerim = (double)(a + b + c) / 2;
            return Math.Sqrt(HalfPerim * (HalfPerim - a) * (HalfPerim - b) * (HalfPerim - c));
        }
        // Свойства: позволяющее получить-установить длины сторон треугольника (доступное для чтения и записи);

        public int A//свойсвто позволяющее установить или изменить значение стороны a
        {
            get { return a; }//устанавливаем
            set { a = value; }//меняем
        }

        public int B//свойсвто позволяющее установить или изменить значение стороны b
        {
            get { return b; }
            set { b = value; }
        }

        public int C//свойсвто позволяющее установить или изменить значение стороны c
        {
            get { return c; }
            set { c = value; }
        }
        public bool ExistTriangle//свойство позволяющее установить,сущесвует ли треугольник с заданными сторонами
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))//сумма 2 сторон должна быть больше третьей
                    return false;
                    else return true;
            }
        }

    }
}
