using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Order
{
    class Order
    {
        public long Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime DealTime { get; set; }

        public double TotalAmount { get; set; }

        public List<OrderDetails> Details { get; } = new List<OrderDetails>();

        public Order(long id, Customer customer)
        {
            Id = id;
            Customer = customer;
            DealTime = DateTime.Now;
        }

        public void AddDetails(OrderDetails orderDetails)
        {
            if (this.Details.Contains(orderDetails))
            {
                throw new ApplicationException($"The commodities ({orderDetails.Commodities.Name}) exist in order {Id}");
            }
            Details.Add(orderDetails);
        }

        public void RemoveDetails(int index)
        {
            Details.RemoveAt(index);
        }
        public override string ToString()
        {
            String result = $"OrderId:{Id}, Customer:{Customer}";
            Details.ForEach(detail => result += "\n\t" + detail);
            return  result;
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   obj != null &&
                   Id == order.Id;
        }

        public override int GetHashCode()
        {
            return 889810732 + Id.GetHashCode();
        }

        public int CompareTo(Order another)
        {
            if (another == null)
                return 1;
            return Convert.ToInt32(Id - another.Id);
        }
    }
}
