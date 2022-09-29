using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            string s = Console.ReadLine();
            try
            {
                int x = Convert.ToInt32(s);
                Console.WriteLine($"Ви ввели число {x}");
            }
            catch
            {
                Console.WriteLine("N не є цілим числом");
            }
            
        }
    }
}
