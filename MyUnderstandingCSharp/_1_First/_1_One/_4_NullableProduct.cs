using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._1_First._1_One
{
    /// <summary>
    /// C# .net2 引入了?强制为null
    /// 下面的查询用了C# .net3
    /// </summary>
    public class _4_NullableProduct
    {
        private readonly string bookName;
        public string BookName
        {
            get { return bookName; }
        }

        decimal? price;
        public decimal? Price
        {
            get { return price; }
            private set { price = value; }
        }

        public _4_NullableProduct(string bookName,decimal? price)
        {
            this.bookName = bookName;
            Price = price;
        }


        public void FindNull()
        {
            List<_4_NullableProduct> nullableProducts = new List<_4_NullableProduct>();
            nullableProducts.Add(new _4_NullableProduct("AAA",1));
            nullableProducts.Add(new _4_NullableProduct("BBB", 2));
            nullableProducts.Add(new _4_NullableProduct("CCC", null));
            nullableProducts.Add(new _4_NullableProduct("DDD", null));
            nullableProducts.Add(new _4_NullableProduct("EEE", 3));
            nullableProducts.FindAll(p => p.Price == null).ForEach(Console.WriteLine);
        }
    }
}
