using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._03_Three
{
    public class _02_Type
    {
        public static void StaticTest()
        {
            _02_Type InstanceType = new _02_Type();
            Type type1 = InstanceType.GetType();
            Console.WriteLine(type1);
            MethodInfo method1 = type1.GetMethod("HelloWorld"
                , BindingFlags.Instance | BindingFlags.Public);
            method1.Invoke(InstanceType, new object[] { "oh yeah" });

            Type type2 = typeof(_02_Type);
            MethodInfo method_T1 = type1.GetMethod("HelloWorld_T"
               , BindingFlags.Instance | BindingFlags.Public);
            MethodInfo method_T2= method_T1.MakeGenericMethod(typeof(string));
            method_T2.Invoke(InstanceType, new object[] { "oh noooooo!" });

            Console.WriteLine("==================");
        }


        public void Test()
        {

            string listTypename = "System.Collections.Generic.List`1";
            Type defByName = Type.GetType(listTypename);

            Type closedByName = Type.GetType(listTypename + "[System.String]");
            Type closedByMethod = defByName.MakeGenericType(typeof(string));
            Type closedByTypeof = typeof(List<string>);

            Console.WriteLine(closedByName);
            Console.WriteLine(closedByMethod);
            Console.WriteLine(closedByTypeof);

            Type defByTypeof = typeof(List<>);
            Type defByMethod = closedByMethod.GetGenericTypeDefinition();

            Console.WriteLine(defByTypeof);
            Console.WriteLine(defByMethod);
            Console.WriteLine("==================");
        }

        public void HelloWorld(string arg)
        {
            Console.WriteLine("HelloWorld:"+ arg);
        }

        public void HelloWorld_T<T>(T arg)
        {
            Console.WriteLine("HelloWorld_T:" + arg);
        }
    }
}
