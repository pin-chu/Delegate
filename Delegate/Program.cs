using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int>{5,11, 4, 9, 66,48,35};
            Func<int, bool> isEven = n => n % 2 == 0;

            List<int> EvenItems = GetEvenItems(items,isEven);
           
        }
        static List<int> GetEvenItems(List<int> source,Func<int, bool> func){
            var result=new List<int>();

            foreach (int item in source)
            {
                if(func(item)==true)
                {
                    result.Add(item);
                }
            }

            return result;
        }

    }

}
