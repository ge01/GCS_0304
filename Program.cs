using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_0304_081816
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a Test Average program with Exception Handling
            try
            {
                //Get the three test scores.
                Console.Write("Test 1:");
                var test1 = double.Parse(Console.ReadLine());

                Console.Write("Test 2:");
                var test2 = double.Parse(Console.ReadLine());

                Console.Write("Test 3:");
                var test3 = double.Parse(Console.ReadLine());

                //Calculate the average test score
                var average = (test1 + test2 + test3) / 3.0;

                //Display the average test score, with
                //the output rounded to 1 decimal point.
                Console.WriteLine("Average Test Score: " + average.ToString("n1"));
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                //Display the defalut error message.
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
