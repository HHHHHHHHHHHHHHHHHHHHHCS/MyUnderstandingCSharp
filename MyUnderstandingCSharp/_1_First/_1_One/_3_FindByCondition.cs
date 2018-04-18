using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._1_First._1_One
{
    #region C# .Net1
    /// <summary>
    /// C# .Net1 简单明了，但是嵌套过多，可以换种方法
    /// </summary>
    /*public class _3_FindByCondition
    {
        public static void FindByCondition()
        {
            ArrayList products = _1_Product.GetSampleProducts();
            foreach(_1_Product product in products)
            {
                if(product.Price>10m)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }*/
    #endregion

    #region C# .Net2-1
    /// <summary>
    /// C# .Net2 使用了方法组转换，语句减少了嵌套
    /// </summary>
    /*public class _3_FindByCondition
    {
        public static void FindByCondition()
        {
            List<_1_Product> products = _1_Product.GetSampleProducts();
            Predicate<_1_Product> test = delegate (_1_Product p) { return p.Price > 10m; };
            List<_1_Product> matches = products.FindAll(test);

            Action<_1_Product> print = Console.WriteLine;
            matches.ForEach(print);
        }
    }*/
    #endregion

    #region C# .Net2-2
    /// <summary>
    /// C# .Net2 这样子写语句更便读
    /// </summary>
    /*public class _3_FindByCondition
    {
        public static void FindByCondition()
        {
            List<_1_Product> products = _1_Product.GetSampleProducts();
            //Predicate<_1_Product> test = delegate (_1_Product p) { return p.Price > 10m; };
            //Action<_1_Product> print = Console.WriteLine;
            //products.FindAll(test).ForEach(print);
            //上面三句话可以合成一句
            products.FindAll(delegate (_1_Product p) { return p.Price > 10m; })
                .ForEach(Console.WriteLine);
        }
    }*/
    #endregion

    #region C# .Net3
    /// <summary>
    /// C# .Net3 使用Lambda 更容易阅读
    /// </summary>
    public class _3_FindByCondition
    {
        public static void FindByCondition()
        {
            List<_1_Product> products = _1_Product.GetSampleProducts();

            //foreach(var product in products.FindAll(p => { return p.Price > 10m; }))
            //{
            //    Console.WriteLine(product);
            //}
            //上面的话最后可以简化成这样
            products.FindAll(p => { return p.Price > 10m; })
                .ForEach(Console.WriteLine);
        }
    }
    #endregion
}
