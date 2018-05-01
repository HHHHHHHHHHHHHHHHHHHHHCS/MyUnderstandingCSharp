using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._01_One
{
    /// <summary>
    /// C# .net4 可选参数
    /// </summary>
    public class _05_OptionalParameterProduct
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

        public _05_OptionalParameterProduct(string bookName, decimal? price = null)
        {
            this.bookName = bookName;
            Price = price;
        }


        public void FindNull()
        {
            List<_05_OptionalParameterProduct> nullableProducts = new List<_05_OptionalParameterProduct>();
            nullableProducts.Add(new _05_OptionalParameterProduct("AAA", 1));
            nullableProducts.Add(new _05_OptionalParameterProduct("BBB", 2));
            nullableProducts.Add(new _05_OptionalParameterProduct("CCC"));
            nullableProducts.Add(new _05_OptionalParameterProduct("DDD"));
            nullableProducts.Add(new _05_OptionalParameterProduct("EEE", 3));
            nullableProducts.FindAll(p => p.Price == null).ForEach(Console.WriteLine);
        }

    }
}
