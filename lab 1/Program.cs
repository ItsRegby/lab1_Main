using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TEST 1*/

            /*Triangle tri = new Triangle(2, 3, 4);
            Console.WriteLine(tri);
            Console.WriteLine(tri[0] + " " + tri[1] + " " + tri[2]);
            *//*tri[0] = 10; //Exception
            Console.WriteLine(tri);*//*
            tri[0] = 5;
            Console.WriteLine(tri);
            tri[1] = 5;
            Console.WriteLine(tri[0] + " " + tri[1] + " " + tri[2]);
            Console.WriteLine(tri);
            Console.WriteLine(tri.Perimetr);
            Console.WriteLine(tri.Square);
            tri[2] = 5;
            Console.WriteLine(tri[0] + " " + tri[1] + " " + tri[2]);
            Console.WriteLine(tri);
            Console.WriteLine(tri.Perimetr);
            Console.WriteLine(tri.Square);*/

            /*TEST 2*/
            TCircle circle = new TCircle(5.1);
            Console.WriteLine(circle);
            circle.Radius = 2;
            Console.WriteLine(circle.Radius);
            Console.WriteLine(circle.Square);
            Console.WriteLine(circle.Lenght);
            TCircle circle1 = new TCircle(5);
            Console.WriteLine(circle.Equals(circle1));
            circle1.Radius = 2;
            Console.WriteLine(circle.Equals(circle1));
            TCircle circle2 = new TCircle();
            circle.Radius = 5;
            circle2 = circle + circle1;
            Console.WriteLine(circle2);
            circle2 = circle - circle1;
            Console.WriteLine(circle2);
            /*circle2 = circle1 - circle; //Exception check*/
            circle2 = circle * 2;
            Console.WriteLine(circle2);
            circle2 = 2.5*circle;
            Console.WriteLine(circle2);
            Console.WriteLine("\nCylinder\n");
            TCylinder cylinder = new TCylinder(3.1, 2.5);
            Console.WriteLine(cylinder);
            cylinder.Radius = 3;
            cylinder.Height = 4;
            Console.WriteLine(cylinder.Radius);
            Console.WriteLine(cylinder.Height);
            Console.WriteLine(cylinder);
            TCylinder cylinder1 = new TCylinder(5, 4);
            Console.WriteLine(cylinder.Equals(cylinder1));
            cylinder.Radius = 5;
            Console.WriteLine(cylinder.Equals(cylinder1));
            cylinder.Radius = 6;
            cylinder.Height = 6;
            TCylinder cylinder2 = new TCylinder();
            cylinder2 = cylinder + cylinder1;
            Console.WriteLine(cylinder2);
            cylinder2 = cylinder - cylinder1;
            Console.WriteLine(cylinder2);
            /* cylinder2 = cylinder1 - cylinder; //Exception check
             Console.WriteLine(cylinder2);*/
            cylinder2 = cylinder * 3;
            Console.WriteLine(cylinder2);
            cylinder2 = 2.5 * cylinder;
            Console.WriteLine(cylinder2);
        }
    }
}
