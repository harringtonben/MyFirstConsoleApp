using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
               Not only do you have to say what type the variable is, you also
               have to instantiate that exact same type of object on assignment.
               This may seem redundant, but it's part of the C# language compiler's
               type checking constraints.
           */
            string[] products = new string[] {
                "Motorcycle",
                "Sofa",
                "Sandals",
                "Omega Watch",
                "iPhone"
            };

            /*
                This syntax should look very similar to what you did in an Angular
                partial's ng-repeat directive. However, once again you have to
                explicitly say what type of variable product is. Since the products
                array holds strings, then its type must be string.
            */
            foreach (string product in products)
            {
                if (product.Length > 5)
                {
                    Console.WriteLine(product);
                }
            }
            Console.ReadKey();
        }
    }
}
