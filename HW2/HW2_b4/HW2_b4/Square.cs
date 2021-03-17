using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_b4
{
	public class Square : IShape
	{
        private double length;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public Square(double length)
		{
            this.length = length;
		}

        double getArea()
        {
            if (isLegal())
                return length*length;
            
            else
                return -1;
        }
        bool isLegal()
        {
            if (length <= 0)
                return false;
            else
                return true;

        }
    }
}
