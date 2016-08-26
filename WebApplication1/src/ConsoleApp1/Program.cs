using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Console app started");
            Task.Delay(100000).Wait();
            Console.WriteLine("Wait time over, exiting");
        }
    }
}
