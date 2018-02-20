using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestProject1
{
    public interface IBuilderOrder
    {
        IList<Product> GetOrder();
    }
    
}
