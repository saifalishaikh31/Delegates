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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n 1.Single Cast Delegates."
                                + "\n 2.Multi Cast Delegates."
                                + "\n 3.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Single Cast Delegates");
                        operation obj = SingleCastDelegates.Add;
                        obj(5, 5);
                        break;
                    case 2:
                        Console.WriteLine("Multi Cast Delegates");
                        DelOp delOp = MultiCastDelegates.Add;
                        delOp += MultiCastDelegates.Sub;
                        delOp += MultiCastDelegates.Mul;
                        delOp += MultiCastDelegates.Div;
                        delOp(5, 5);
                        delOp(8, 3);
                        break;
                    case 3:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter correct option!!!");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
