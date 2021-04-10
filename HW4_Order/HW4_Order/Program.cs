using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer( "zyc", 1001);
            Customer customer2 = new Customer("zzm", 1002);

            Commodity pen = new Commodity(1, "Pen", 88.8);
            Commodity notebook = new Commodity(2, "Notebook", 9.9);
            Commodity doll = new Commodity(33, "Doll", 188.8);
            Commodity iphone = new Commodity(188, "iPhone", 18888.8);


            Order order1 = new Order(1, customer1);
            order1.AddDetails(new OrderDetails(doll, 2));
            order1.AddDetails(new OrderDetails(iphone, 1));


            Order order2 = new Order(2, customer2);
            order2.AddDetails(new OrderDetails(pen, 5));
            order2.AddDetails(new OrderDetails(notebook, 15));

            Order order3 = new Order(3, customer2);
            order3.AddDetails(new OrderDetails(iphone, 1));

            OrderService orderService = new OrderService();
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            Console.WriteLine("******-Get All Orders-******");
            List<Order> orders = orderService.Query();
            orders.ForEach(e => Console.WriteLine(e));

            Console.WriteLine();
            Console.WriteLine("******-Get Orders By Customer Name: zzm-******");
            orders = orderService.QueryByCustomerName("zzm");
            orders.ForEach(e => Console.WriteLine(e));

            Console.WriteLine();
            Console.WriteLine("******-Get Orders By Commodity Name: iPhone-******");
            orders = orderService.QueryByCommodityName("iPhone");
            orders.ForEach(e => Console.WriteLine(e));

            Console.WriteLine();
            Console.WriteLine("******-Get Orders By Total Amount: 1000-******");
            orders = orderService.QueryByTotalAmount(1000);
            orders.ForEach(e => Console.WriteLine(e));

            Console.WriteLine();
            Console.WriteLine("******-Remove order(id = 3)-******");
            orderService.RemoveOrder(3);
            orderService.Query().ForEach(e => Console.WriteLine(e));
            Console.ReadKey();
        }
    }
}
