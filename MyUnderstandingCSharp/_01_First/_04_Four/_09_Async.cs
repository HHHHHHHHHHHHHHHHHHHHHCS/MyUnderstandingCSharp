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
            using(HttpClient client = new HttpClient())
            {
                Task<string> stringTask = client.GetStringAsync(url);
                string str = await stringTask;
                return str;
            }
        }

        public static void PrintPage()
        {
            Task<string> stringTask = GetPageStringAsync("http://www.baidu.com/");
            Console.WriteLine(stringTask.Result);
        }
    }
}
