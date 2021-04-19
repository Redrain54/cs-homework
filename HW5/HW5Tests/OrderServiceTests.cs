using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace HW5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService orderService = new OrderService();

        Customer customer1 = new Customer("zyc", 1001);
        Customer customer2 = new Customer("zzm", 1002);

        Commodity pen = new Commodity(1, "Pen", 88.8);
        Commodity notebook = new Commodity(2, "Notebook", 9.9);
        Commodity doll = new Commodity(33, "Doll", 188.8);
        Commodity iphone = new Commodity(188, "iPhone", 18888.8);

     [TestInitialize]
     public void Init()
        {
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
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Order order4 = new Order(4, customer2);
            order4.AddDetails(new OrderDetails(doll, 3));
            orderService.AddOrder(order4);
            List<Order> orders = orderService.Query();
            Assert.AreEqual(4, orders.Count);
            CollectionAssert.Contains(orders, order4);
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Order order3 = new Order(3, customer1);
            order3.AddDetails(new OrderDetails(doll, 5));
            orderService.Update(order3);

            List<Order> orders = orderService.Query();
            Assert.AreEqual(3, orders.Count);
            Order der = orderService.GetById(3);
            Assert.AreEqual(customer1, der.Customer);
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            orderService.RemoveOrder(3);
            List<Order> orders = orderService.Query();
            Assert.AreEqual(2, orders.Count);
            orderService.RemoveOrder(100);
            Assert.AreEqual(2, orders.Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            Order order2 = orderService.GetById(2);
            Assert.IsNotNull(order2);
            Assert.AreEqual(2, order2.Id);
            Assert.AreEqual(customer2, order2.Customer);
            List<OrderDetails> details = new List<OrderDetails>()
            {
                new OrderDetails(pen,88),new OrderDetails(notebook,99),
            };
            CollectionAssert.AreEqual(details, order2.Details);
            Order order4 = orderService.GetById(4);
            Assert.IsNull(order4);
        }

        [TestMethod()]
        public void QueryByCommodityNameTest()
        {
            Assert.AreEqual(2, orderService.QueryByCommodityName("pen").Count);
            Assert.AreEqual(2, orderService.QueryByCommodityName("notebook").Count);
            Assert.AreEqual(33, orderService.QueryByCommodityName("iphone").Count);
            Assert.AreEqual(0, orderService.QueryByCommodityName("huawei").Count);
        }

        [TestMethod()]
        public void QueryByCustomerNameTest()
        {
            Assert.AreEqual(1002, orderService.QueryByCustomerName("zzm").Count);
            Assert.AreEqual(1001, orderService.QueryByCustomerName("zyc").Count);
            Assert.AreEqual(1000, orderService.QueryByCustomerName("zhy").Count);

        }

        [TestMethod()]
        public void ImportTest()
        {
            List<Order> expect = orderService.Query();
            orderService.Import("../../expectedOrders,xml");
            List<Order> result = orderService.Query();
            CollectionAssert.Equals(expect, result);

            orderService.Import("../../newOrders,xml");
            result = orderService.Query();
            Assert.AreEqual(4, result.Count);
            Assert.IsTrue(result.Any(e => e.Id == 4));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ImportTest2()
        {
            OrderService os = new OrderService();
            os.Import("../../invalidXML.xml");
        }

        [TestMethod()]
        public void ExportTest()
        {
            String file = "temp.xml";
            orderService.Export(file);
            Assert.IsTrue(File.Exists(file));
            String result = File.ReadAllText(file);
            String expect = File.ReadAllText("../../expectedOrders.xml");
            Assert.AreEqual(expect, result);
            File.Delete(file);
        }
    }
}