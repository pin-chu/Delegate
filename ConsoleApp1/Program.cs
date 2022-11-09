using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int> { 5, 11, 4, 9, 66, 48, 35 };
            Func<int, bool> isEven = n => n % 2 == 0;

            List<int> EvenItems = GetEvenitems(items, isEven);

        }
        static List<int> GetEvenitems(List<int> source, Func<int, bool> func)
        {
            var result = new List<int>();

            foreach (int item in source)
            {
                if (func(item) == true)
                {
                    result.Add(item);
                }
                return result;
            }

        }
    }
}
