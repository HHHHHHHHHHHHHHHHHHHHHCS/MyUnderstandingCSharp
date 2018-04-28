using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._1_First._2_Two
{
    public class _8_PairOfT<T1, T2> : IEquatable<_8_PairOfT<T1, T2>>
    {
        private static readonly IEqualityComparer<T1> firstComparer
            = EqualityComparer<T1>.Default;
        private static readonly IEqualityComparer<T2> secondComparer
            = EqualityComparer<T2>.Default;

        private readonly T1 first;
        private readonly T2 second;


        /// <summary>
        /// 这个的实例化方法，但是并不是很好用
        /// _8_PairOfT<int, string> pair = new _8_PairOfT<int, string>(10, "value");
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        public _8_PairOfT(T1 first, T2 second)
        {

            this.first = first;
            this.second = second;
        }

        public bool Equals(_8_PairOfT<T1, T2> other)
        {
            return other != null
                && firstComparer.Equals(this.first, other.first)
                && secondComparer.Equals(this.second, other.second);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as _8_PairOfT<T1, T2>);
        }

        public override int GetHashCode()
        {
            return firstComparer.GetHashCode(first) * 37
                + secondComparer.GetHashCode(second);
        }
    }

    public static class _8_PairOfT
    {

        /// <summary>
        /// 另外一种初始方法,比较简洁
        /// _8_PairOfT1<int,string> p = _8_PairOfT1.Of(10, "Value");
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static _8_PairOfT<T1, T2> Of<T1, T2>(T1 first, T2 second)
        {
            
            return new _8_PairOfT<T1,T2>(first, second); ;
        }

    }
}
