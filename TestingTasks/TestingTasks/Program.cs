using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class MyArr
    {
        //Координаты точки в трёхмерном пространстве
        public int x, y, z;

        public MyArr(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //Перегружаем бинарный оператор +
        public static MyArr operator +(MyArr obj1, MyArr obj2)
        {
            MyArr arr = new MyArr();
            arr.x = obj1.x + obj2.x;
            arr.y = obj1.y + obj2.y;
            arr.z = obj1.z + obj2.z;
            return arr;
        }
        public void Show()
        {
            Console.WriteLine(x + ", " + y + ", " + z);
        }
    }
    class Program
    {
        static void Main()
        {

            MyArr Point1 = new MyArr(1, 12, -4);
            MyArr Point2 = new MyArr(0, -3, 18);
            Console.Write("Координаты первой точки Point1: ");
            Point1.Show();
            Console.Write("Координаты второй точки Point2: ");
            Point2.Show();

            MyArr Point3 = Point1 + Point2;
            Console.WriteLine("\n Point1 + Point2 = " + Point3.x + ", " + Point3.y + ", " + Point3.z);
            Console.Write("\n Point1 + Point2 = ");
            Console.Write("\n Tania ");

            Point3.Show();

            Console.ReadLine();
        }
    }
}
