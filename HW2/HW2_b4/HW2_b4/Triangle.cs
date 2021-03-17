using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_b4
{
	public class Triangle : IShape
	{
        private double a;
        private double b;
        private double c;
        private double p;


        public Triangle(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public double A
        {
            get { return a; }
            set { a = value; }
        }
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        public double C
        {
            get { return c; }
            set { c = value; }
        }


        double getArea()
        {
            if (isLegal())
            {
                p = a + b + c;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
                return -1;
        }
        bool isLegal()
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                return false;
            else
                return true;

        }
    }
}