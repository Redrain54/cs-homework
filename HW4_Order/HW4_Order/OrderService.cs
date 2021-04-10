using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Order
{
    class OrderService
    {
        private List<Order> orderList = new List<Order>();

        public OrderService()
        {

        }

        public void AddOrder(Order order)
        {
            if (orderList.Contains(order))
            {
                throw new ApplicationException($"the order {order.Id} has already existed");
            }
            orderList.Add(order);
        }

        public void Update(Order order)
        {
            orderList.Add(order);
            RemoveOrder(order.Id);
        }

        public void RemoveOrder(long orderId)
        {
            orderList.RemoveAll(e => e.Id == orderId);
        }

        public Order GetById(long orderId)
        {
            return orderList.Where(e => e.Id == orderId).FirstOrDefault();
        }

        public List<Order> Query()
        {
            return orderList;
        }

        public void Sort(Comparison<Order> comparison)
        {
            orderList.Sort(comparison);
        }

        public List<Order> QueryByTotalAmount(double totalAmount)
        {
            var query = orderList.Where(e => e.TotalAmount >= totalAmount);
            return query.ToList();
        }
        
        public List<Order> QueryByCommodityName(string commodityName)
        {
            var query = orderList.Where(e => e.Details.Any(o => o.Commodities.Name == commodityName));
            return query.ToList();
        }

        public List<Order> QueryByCustomerName(string customerName)
        {
            var query = orderList.Where(e => e.Customer.Name == customerName);
            return query.ToList();
        }
    }
}
