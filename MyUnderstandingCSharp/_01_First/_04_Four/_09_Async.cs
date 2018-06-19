using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyUnderstandingCSharp._01_First._04_Four
{
    public static class _09_Async
    {
        private static async Task<string> GetPageStringAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                Task<string> stringTask = client.GetStringAsync(url);
                string str = await stringTask;
                return str;
            }
        }

        public static async void AsyncLambda()
        {
            Func<Task> lambda = async () => await Task.Delay(1000);
            Func<Task<int>> anonMethod = async delegate ()
            {
                Console.WriteLine("Started");
                await Task.Delay(1000);
                Console.WriteLine("Finished");
                return 10;
            };

            Console.WriteLine(await anonMethod());
        }

        public static void AsyncResult()
        {
            Task<int> first = AsyncResult(1);
            Task<int> second = AsyncResult(2);

            Console.WriteLine(first.Result);
            Console.WriteLine(second.Result);
        }

        private static async Task<int> AsyncResult(int _x)
        {
            Func<int, Task<int>> function = async x =>
            {
                Console.WriteLine("{0}:is Start", x);
                await Task.Delay(x * 1000);
                Console.WriteLine("{0}:is End", x);
                return x * x;
            };
            return await function(_x);
        }

        public static void PrintPage()
        {
            Task<string> stringTask = GetPageStringAsync("http://www.baidu.com/");
            Console.WriteLine(stringTask.Result);
        }
    }
}
