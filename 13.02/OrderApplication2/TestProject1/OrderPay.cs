using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject1
{
    public class OrderPay
    {
        private IBuilderOrder builderOder;
        private IPayOrder payOrder;

        public OrderPay(IBuilderOrder builderOder, IPayOrder payOrder)
        {
            // TODO: Complete member initialization
            this.builderOder = builderOder;
            this.payOrder = payOrder;
            IList<Product> b = builderOder.GetOrder();
            foreach(Product p in b)
                payOrder.Pay(p);
        }
        public int GetOrder()
        {
             
            return builderOder.GetOrder().Count;
        }
        void Pay(Product product)
        {
        }
    }
}
