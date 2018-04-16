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
    /// .Net1 使用ArrayList是十分不安全的
    /// Get和Set 封装的不是很完善
    /// 构造函数不是很简洁
    /// </summary>
    /*public class _1_Product
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
        }
        
        public _1_Product(string name,decimal  price)
        {
            this.name = name;
            this.price = price;
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new _1_Product("West Side Story", 9.99m));
            list.Add(new _1_Product("Assassins", 14.99m));
            list.Add(new _1_Product("Froga", 13.99m));
            list.Add(new _1_Product("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", name, price);
        }
    }*/
    #endregion

    #region C# .Net2
    /// <summary>
    /// List<_1_Product> 完善了之前对列表的不安全限制
    /// Get Set 有一定的保护和完善，但是还能更加简洁
    /// 构造函数对比.Net1 简洁
    /// GetSampleProducts 还不够简洁
    /// </summary>
    /*public class _1_Product
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }

            private set
            {
                name = value;
            }
        }

        decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }

            private set
            {
                Price = value;
            }
        }
        
        public _1_Product(string name,decimal  price)
        {
            Name = name;
            Price = price;
        }

        public static List<_1_Product> GetSampleProducts()
        {
            List<_1_Product> list = new List<_1_Product>();
            list.Add(new _1_Product("West Side Story", 9.99m));
            list.Add(new _1_Product("Assassins", 14.99m));
            list.Add(new _1_Product("Froga", 13.99m));
            list.Add(new _1_Product("Sweeney Todd", 10.99m));
            return list;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", name, price);
        }
    }*/
    #endregion

    #region C# .Net3
    /// <summary>
    /// 没有可见的变量与属性关联，对name和price做了访问保护  
    /// 而且都使用Get Set保证了一致性
    /// 同时提供内部构造函数 方便内部创造使用
    /// 列表比之前更简洁了
    /// </summary>
    public class _1_Product
    {
        public string Name
        {
            get;
            private set;
        }

        public decimal Price
        {
            get;
            private set;
        }

        public _1_Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        protected _1_Product()
        {

        }

        public static List<_1_Product> GetSampleProducts()
        {
            return new List<_1_Product>()
            {
                new _1_Product("West Side Story", 9.99m)
                ,new _1_Product("Assassins", 14.99m)
                ,new _1_Product("Froga", 13.99m)
                ,new _1_Product("Sweeney Todd", 10.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", Name, Price);
        }
    }
    #endregion
}
