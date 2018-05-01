using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._01_One
{
    /// <summary>
    /// C# .net2 引入了?强制为null
    /// 下面的查询用了C# .net3
    /// </summary>
    public class _04_NullableProduct
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

        public _04_NullableProduct(string bookName,decimal? price)
        {
            this.bookName = bookName;
            Price = price;
        }


        public void FindNull()
        {
            List<_04_NullableProduct> nullableProducts = new List<_04_NullableProduct>();
            nullableProducts.Add(new _04_NullableProduct("AAA",1));
            nullableProducts.Add(new _04_NullableProduct("BBB", 2));
            nullableProducts.Add(new _04_NullableProduct("CCC", null));
            nullableProducts.Add(new _04_NullableProduct("DDD", null));
            nullableProducts.Add(new _04_NullableProduct("EEE", 3));
            nullableProducts.FindAll(p => p.Price == null).ForEach(Console.WriteLine);
        }
    }
}
