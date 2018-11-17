using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Constructors
{
    class ParametrizedConDemo
    {
        int x;

        public ParametrizedConDemo(int i)
        {
            x = i;
            Console.WriteLine("Parametrized Constructor Called: " + i);
        }
        public void Display()
        {
            Console.WriteLine("Value of x is :" + x);
        
        }

        static void Main()
        {
            ParametrizedConDemo cd1 = new ParametrizedConDemo(10);
            cd1.Display();

            ParametrizedConDemo cd2 = new ParametrizedConDemo(20);
              
            cd2.Display();
            Console.ReadLine();
        }
    }
}
