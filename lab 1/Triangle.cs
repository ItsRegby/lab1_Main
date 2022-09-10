using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    class Triangle
    {
        private double perimetr;
        private double square;
        private double[] sides = new double[3];

        public Triangle(double a, double b, double c)
        {
            sides[0] = a;
            sides[1] = b;
            sides[2] = c;
            InitializeFigure();
        }
        public double this[int key]
        {
            get { return sides[key]; }
            set
            {
                sides[key] = value;
                if (sides[0] + sides[1] < sides[2] || sides[1] + sides[2] < sides[0] || sides[0] + sides[2] < sides[1])
                {
                    throw new ArgumentException("Сума двох сторін не може бути меншою від значення третьої сторони.");
                }
                InitializeFigure();
            }
        }
        public double Perimetr
        {
            get { return perimetr; }
        }
        public double Square
        {
            get { return square; }
        }
        private void InitializeFigure()
        {
            perimetr = sides[0] + sides[1] + sides[2];
            double halfP = perimetr / 2.0;
            square = Math.Round(Math.Sqrt(halfP * (halfP - sides[0]) * (halfP - sides[1]) * (halfP - sides[2])), 2);
        }
        public override string ToString()
        {
            return "Сторони трикутника: " + sides[0].ToString() + ", " + sides[1].ToString() + ", " + sides[2].ToString()+". Периметр трикутника: " + Perimetr.ToString() +". " +"Площа трикутника : " + Square.ToString();
        }
    }
}
