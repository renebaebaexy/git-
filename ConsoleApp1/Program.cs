using System;
using System.Threading;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static async Task DoSomeWorkAsync()
        {
            Console.WriteLine("Inside DoSomeWorkAsync");
            await Task.Delay(2000);
            Console.WriteLine("End of DoSomeWorkAsync");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Inside Main Program");
            Task task = DoSomeWorkAsync();
            Console.WriteLine("End Main Program");
            //await task;
        }
    }

}
