using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2900484#content
namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 10; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //same code written with while loop
            //var i = 0;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            //while (true)
            //{
            //    Console.Write("Type your name: \n");
            //    var input = Console.ReadLine();

            //    if (String.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }
            //    Console.WriteLine("@Echo: "+ input);
            //}
            while (true)
            {
                Console.Write("Type your name: \n");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }
                break;
            }
        }
    }
}