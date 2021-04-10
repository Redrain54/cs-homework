using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Order
{
    class Commodity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        private double price;

        public double Price
        {
            get { return price; }
            set {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("the price must be a nonnegative number!");
                price = value; }
        }

        public Commodity(long id, string name, double price)
        {
            Id = id;
            Name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return $"CommodityId : {Id}, CommodityName:{Name}, CommodityPrice:{Price}";
        }

        public override bool Equals(object obj)
        {
            return obj is Commodity commodity &&
                   obj != null &&
                   Id == commodity.Id;
        }

        public override int GetHashCode()
        {
            return 889810732+Id.GetHashCode();
        }
    }
}
 