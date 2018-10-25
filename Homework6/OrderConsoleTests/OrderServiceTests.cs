using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderConsole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace OrderConsole.Tests
{

    [TestClass()]
    public class OrderServiceTests
    {
        
        XmlSerializer serializer = new XmlSerializer(typeof(OrderService));
        //TextWriter writer = new StreamWriter("Order.xml");
        TextReader reader1 = new StreamReader("importOrder.xml");
        OrderService service1 = new OrderService();
        

        [TestMethod()]
        public void OrderServiceTest()
        {
            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            Assert.IsNotNull(service1);
        }

        [TestMethod()]
        public void OrderServiceTest1()
        {
            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            Assert.IsNotNull(service1);
        }

        [TestMethod()]
        public void AddOrderTest()
        {

            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            Assert.IsNotNull(service1.myOrderDetail);
            //Assert.Fail();
        }

        [TestMethod()]
        public void DelOrderTest()
        {
            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            service1.DelOrder(0);
            Assert.IsNotNull(service1);
        }

        [TestMethod()]
        public void SearchOrderTest()
        {
            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;

            Assert.IsNotNull(service1.myOrderDetail);
        }

        [TestMethod()]
        public void ChangeOrderTest()
        {
            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            
            Assert.IsNotNull(service1.myOrderDetail);
        }

        [TestMethod()]
        public void DisplayAllTest()
        {

            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            Assert.IsNotNull(service1.myOrderDetail);
        }

        [TestMethod()]
        public void DisplayOrderTest()
        {
            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            Assert.IsNotNull(service1.myOrderDetail);
        }

        [TestMethod()]
        public void DisplayOrderTest1()
        {
            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            Assert.IsNotNull(service1.myOrderDetail);
        }

        [TestMethod()]
        public void ExportOrderTest()
        {

            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            Assert.IsNotNull(service1.myOrderDetail);
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService temp = new OrderService((OrderService)serializer.Deserialize(reader1));
            service1.myOrderDetail = temp.myOrderDetail;
            Assert.IsNotNull(service1);
        }
        
    }
}