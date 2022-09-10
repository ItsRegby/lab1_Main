using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class TCircle
    {
        protected double radius;
        private double square;
        private double length;
        public TCircle()
        {

        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0)
                    radius = value;
                InitializeFigure();
            }
        }
        public double Lenght
        {
            get { return length; }
        }
        public double Square
        {
            get { return square; }
        }
        public TCircle(double radius)
        {
            Radius = radius;
        }
        public TCircle(TCircle previousCircle)
        {
            Radius = previousCircle.Radius;
        }
        protected void InitializeFigure()
        {
            square = Math.Round(Math.PI*(radius*radius),2);
            length = Math.Round(2 * Math.PI*radius,2);
        }
        public override string ToString()
        {
            return "Заданий радіус: " + Radius.ToString() + ". Площа круга: " + Square.ToString() + " та довжина кола: " + Lenght.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is TCircle))
                return false;
            return (this.Radius == ((TCircle)obj).Radius);
        }
        public static TCircle operator +(TCircle cr1, TCircle cr2)
        {
            TCircle cr3 = new TCircle();
            cr3.Radius = cr1.radius + cr2.radius;
            return cr3;
        }
        public static TCircle operator -(TCircle cr1, TCircle cr2)
        {
            TCircle cr3 = new TCircle();
            cr3.Radius = cr1.radius - cr2.radius;
            if (cr3.radius <= 0)
            {
                throw new ArgumentException("Радіус не може бути 0, чи менше.", nameof(cr3.radius));
            }
            return cr3;
        }
        public static TCircle operator *(TCircle cr1, double num)
        {
            TCircle cr3 = new TCircle();
            cr3.Radius = cr1.radius * num;
            return cr3;
        }
        public static TCircle operator *(double num, TCircle cr1)
        {
            TCircle cr3 = new TCircle();
            cr3.Radius = num * cr1.radius;
            return cr3;
        }
    }
}
