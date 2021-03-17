using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW2_b4
{
	public class Rectangle : IShape
	{
        private double width;
        private double length;

        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        double getArea()
        {
            if (isLeagal())
            {
                return length * width;
            }
            else
                return -1;
        }

		bool isLeagal()
        {
            if (width > 0 && length > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}