using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesProgam
{
    public delegate void DelOp(int x, int y);
    internal class MultiCastDelegates
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition of two numbers       : {0}", a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine("Substraction of two numbers   : {0}", a - b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication of two numbers : {0}", a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine("Division of two numbers       : {0}", a / b);
        }
    }
}
