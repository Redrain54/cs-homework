using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_b4
{
	public class Factory
	{
		public IShape GetShape(String shape)
        {
			//利用Guid转换为字节数组转换来的整数作为Random的种子，生成[0,100）以内的不重复随机数
			double a = new Random(BitConverter.ToInt32(new Guid().ToByteArray(), 0)).Next(0, 100);
			double b = new Random(BitConverter.ToInt32(new Guid().ToByteArray(), 0)).Next(0, 100);
			double c = new Random(BitConverter.ToInt32(new Guid().ToByteArray(), 0)).Next(0, 100);

			if (shape.Equals("square", StringComparison.InvariantCultureIgnoreCase))
			{
				return new Square(a);
			}
			else if (shape.Equals("rectangle", StringComparison.InvariantCultureIgnoreCase))
			{
				return new Rectangle(a, b);
			}
			else if (shape.Equals("triangle", StringComparison.InvariantCultureIgnoreCase))
			{
				return new Triangle(a, b, c);
			}
			else
				return null;
		}
	}
}
