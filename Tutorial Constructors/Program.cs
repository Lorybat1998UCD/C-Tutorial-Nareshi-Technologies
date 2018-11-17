using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Constructors
{
    class Program
    {
        int i;
        bool b;
        static void Main(string[] args)
        {


            Program p = new Program();
            Console.WriteLine("Integer i is : " + p.i);
            Console.WriteLine("Boolean b is : " +p.b);

            ExplicitConDemo obj = new ExplicitConDemo();

            ExplicitConDemo obj2 = new ExplicitConDemo();

            ExplicitConDemo obj3 = new ExplicitConDemo();

            Console.ReadKey();

        }
    }
}
