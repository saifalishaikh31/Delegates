using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProgam
{
    public delegate void operation(int x, int y);
    public class SingleCastDelegates
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition of two numbers : {0}", a+b);
        }
    }
}
