using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProgam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Cast Delegates");
            operation obj = SingleCastDelegates.Add;
            obj(5, 5);
            Console.ReadLine();
        }
    }
}
