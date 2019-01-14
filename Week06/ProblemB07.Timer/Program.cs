using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemB07._Timer
{
    // Declaration of a delegate
    public delegate void SimpleDelegate(string param);

    class Program
    {
        static void Main(string[] args)
        {
            SimpleDelegate sd = new SimpleDelegate(MyTimer.TestMethod);

            int counter = 1;
            while (counter <= 5)
            {
                sd("This is called via delegate every 1 second... ");
                System.Threading.Thread.Sleep(1000);
                counter++;
            }
            Console.WriteLine("Done.");

            SimpleDelegate sd2 = new SimpleDelegate(MyTimer.SecondMethod);
            sd2("Here's the delegate over the second method");
            Console.ReadKey();
        }
    }

    public class MyTimer
    {
        public static void TestMethod(string message)
        {
            Console.WriteLine(System.DateTime.Now + ": " + message);
        }

        public static void SecondMethod(string var)
        {
            Console.WriteLine(var + "/" + var);
        }
    }
}
