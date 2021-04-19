using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class OrderDetails
    {
        public Commodity Commodities { get; set; }
        public uint Quantity { get; set; }

        public double Amount
        {
            get => Commodities.Price * Quantity;
        }

        public OrderDetails(Commodity commodities, uint quantity)
        {
            Commodities = commodities;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"OrderDetails : {Commodities}, CommodityQuantities:{Quantity}";
        }

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   details != null &&
                   EqualityComparer<Commodity>.Default.Equals(Commodities,details.Commodities);
        }

        public override int GetHashCode()
        {
            return 889810732 + EqualityComparer<Commodity>.Default.GetHashCode(Commodities);
        }
    }
}
