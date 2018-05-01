using System;
using System.Collections.Generic;
using System.Linq;

namespace MyUnderstandingCSharp._01_First._01_One
{
    class _06_Product
    {
        public int SupplierID { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        private _06_Product(int id, string name, decimal price)
        {
            SupplierID = id;
            Name = name;
            Price = price;
        }

        public static List<_06_Product> GetSampleSuppliers()
        {
            return new List<_06_Product>()
            {
                new _06_Product(1,"Be a Dog",10.1m),
                new _06_Product(1,"Cool Book",9.99m),
                new _06_Product(3,"Learn C#",20m),
                new _06_Product(4,"How to Fly",10m),
                new _06_Product(5,"Be fat",1m),
            };
        }
    }

    class _06_Supplier
    {
        public int SupplierID { get; private set; }
        public string Name { get; private set; }

        private _06_Supplier(int id, string name)
        {
            SupplierID = id;
            Name = name;
        }

        public static List<_06_Supplier> GetSampleSuppliers()
        {
            return new List<_06_Supplier>()
            {
                new _06_Supplier(1,"Apple Company"),
                new _06_Supplier(2,"Inter Company"),
                new _06_Supplier(3,"Nvdia Company"),
                new _06_Supplier(4,"BIM Company"),
                new _06_Supplier(5,"AMD Company")
            };
        }
    }


    /// <summary>
    /// Linq 在C# .net3 被引入
    /// </summary>
    public class _6_LinqProduct
    {
        public void FilterByPrice()
        {
            List<_01_Product> products = _01_Product.GetSampleProducts();
            var filtered = from _01_Product p in products
                           where p.Price > 10m
                           select p;
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }
        }

        public void FilterBySupplierAndPrice()
        {
            var products = _06_Product.GetSampleSuppliers();
            var suppliers = _06_Supplier.GetSampleSuppliers();
            var filtered = from p in products
                           join s in suppliers
                            on p.SupplierID equals s.SupplierID
                           where p.Price > 10m
                           orderby s.Name, p.Name
                           select new { SuppliderName = s.Name, ProductName = p.Name };

            foreach(var v in filtered)
            {
                Console.WriteLine(string.Format("SuppliderName:{0},ProductName:{1}"
                    , v.SuppliderName, v.ProductName));
            }

        }
    }
}
