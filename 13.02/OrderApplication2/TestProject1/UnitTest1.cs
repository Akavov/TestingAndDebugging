using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly Mock<IBuilderOrder> builderOrder;
        private readonly OrderPay curOrder;
        private readonly Mock<IPayOrder> payOrder;
        [TestMethod]
        public void TestOderBuilder()
        {
            var builderOrder = new Mock<IBuilderOrder>();
            builderOrder.Setup(m => m.GetOrder()).Returns(new List<Product>
                                                              {
                                                                  new Product(),
                                                                  new Product(),

                                                              }
                                                            );
            var payOrder = new Mock<IPayOrder>();
            var curOrder = new OrderPay(builderOrder.Object,payOrder.Object);
            var countOrder = curOrder.GetOrder();
            Assert.AreEqual(2,countOrder);
        }
        [TestMethod]
        public void TestPayAllOrder()
        {
            var builderOrder = new Mock<IBuilderOrder>();

            builderOrder.Setup(m => m.GetOrder()).Returns(new List<Product>
                                                              {
                                                                  new Product(),
                                                                  new Product(),

                                                              });
            var payOrder = new Mock<IPayOrder>();
            var curOrder = new OrderPay(builderOrder.Object, payOrder.Object);
           
           
            payOrder.Verify(m=>m.Pay(It.IsAny<Product>()),Times.Exactly(2));
        }

    }
}
