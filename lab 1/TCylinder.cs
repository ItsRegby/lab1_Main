using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class TCylinder : TCircle
    {
        private double height;
        private double volume;
        public TCylinder()
        {
            
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Висота не може бути 0, та менше 0.");
                }
                height = value;
                InitializeFigure();
            }
        }
        public new double Radius
        {
            get { return base.radius; }
            set
            {
                if (value > 0)
                {
                    base.radius = value;
                    InitializeFigure();
                }
            }
        }
        public double Volume
        {
            get { return volume; }
            private set { volume = value; }
        }

        public TCylinder(double radius,double height) : base(radius)
        {
            Radius = radius;
            Height = height;
        }
        public override string ToString()
        {
            return "Радіус дорівнює: " + Radius.ToString() + ", а висота дорівнює: "+Height.ToString()+". Об'єм циліндра дорівнює: " + Volume.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is TCylinder))
                return false;
            if (this.Radius == ((TCylinder)obj).Radius && this.Height == ((TCylinder)obj).Height)
                return true;
            else
                return false;
        }
        private new void InitializeFigure()
        {
            Volume = Math.Round(Math.PI*(radius*radius)*height,2);
        }
        public static TCylinder operator +(TCylinder cyl1, TCylinder cyl2)
        {
            TCylinder cyl3 = new TCylinder();
            cyl3.Height = cyl1.Height + cyl2.Height;
            cyl3.Radius = cyl1.Radius + cyl2.Radius;
            return cyl3;
        }
        public static TCylinder operator -(TCylinder cyl1, TCylinder cyl2)
        {
            TCylinder cyl3 = new TCylinder();
            cyl3.Height = cyl1.Height - cyl2.Height;
            cyl3.Radius = cyl1.Radius - cyl2.Radius;
            if (cyl3.Radius <= 0|| cyl3.Height <=0)
            {
                throw new ArgumentException("Параметри фігури не можуть бути 0, чи менше 0.");
            }
            return cyl3;
        }
        public static TCylinder operator *(TCylinder cyl1, double num)
        {
            TCylinder cyl3 = new TCylinder();
            if (num <= 0)
            {
                throw new ArgumentException("Значення не може бути 0, чи менше.");
            }
            cyl3.Height = cyl1.Height * num;
            cyl3.Radius = cyl1.radius * num;
            return cyl3;
        }
        public static TCylinder operator *(double num,TCylinder cyl1)
        {
            TCylinder cyl3 = new TCylinder();
            cyl3.Height = num * cyl1.Height;
            cyl3.Radius = num * cyl1.radius;
            return cyl3;
        }
    }
}
