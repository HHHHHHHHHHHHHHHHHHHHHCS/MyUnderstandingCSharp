using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._01_One
{
    #region C# .Net1
    /// <summary>
    /// C# .Net1存在强转比较耗性能 注意foreach 也有强转
    /// </summary>
    /*
    class ProductNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            _1_Product first = (_1_Product)x;
            _1_Product second = (_1_Product)y;
            return first.Name.CompareTo(second.Name);
        }
    }

    public class _02_SortArray
    {
        public static void Sort()
        {
            ArrayList productList = _1_Product.GetSampleProducts();
            productList.Sort(new ProductNameComparer());
            foreach (_1_Product product in productList)
            {
                Console.WriteLine(product);
            }
        }
    }
    */
    #endregion

    #region C# .Net2
    /// <summary>
    /// C# .Net2对比.Net1少了强转
    /// 但是 还是要创建一个比较类很不爽
    /// </summary>
    /*class ProductNameComparer : IComparer<_1_Product>
    {
        public int Compare(_1_Product x, _1_Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class _02_SortArray
    {
        public static void Sort()
        {
            List<_1_Product> productList = _1_Product.GetSampleProducts();
            productList.Sort(new ProductNameComparer());
            foreach (_1_Product product in productList)
            {
                Console.WriteLine(product);
            }
        }
    }*/
    #endregion

    #region C# .Net3-Delegate
    /// <summary>
    /// C# 使用委托减少了比较类的创建 但是可以更加简洁
    /// </summary>
    /*public class _02_SortArray
    {
        public static void Sort()
        {
            List<_1_Product> productList = _1_Product.GetSampleProducts();
            productList.Sort(delegate (_1_Product x, _1_Product y)
                {
                    return x.Name.CompareTo(y.Name);
                }
            );

            foreach (_1_Product product in productList)
            {
                Console.WriteLine(product);
            }
        }
    }*/
    #endregion

    #region C# .Net3-Lambda
    /// <summary>
    /// C# 使用了Lambda 更简洁
    /// </summary>
    /*public class _02_SortArray
    {
        public static void Sort()
        {
            List<_1_Product> productList = _1_Product.GetSampleProducts();
            productList.Sort((x,y)=>x.Name.CompareTo(y.Name));

            foreach (_1_Product product in productList)
            {
                Console.WriteLine(product);
            }
        }
    }*/
    #endregion

    #region C# .Net3-OrderBy
    /// <summary>
    /// C# 使用了OrderBy最简洁
    /// OrderBy 是扩展方法
    /// </summary>
    public class _02_SortArray
    {
        public static void Sort()
        {
            List<_01_Product> productList = _01_Product.GetSampleProducts();
            foreach (_01_Product product in productList.OrderBy(p=>p.Name))
            {
                Console.WriteLine(product);
            }
        }
    }
    #endregion
}
