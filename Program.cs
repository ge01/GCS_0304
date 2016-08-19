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
                // Create named constants to hold minimum
                // scores required for each letter grade.
                var MIN_A_SCORE = 90;
                var MIN_B_SCORE = 80;
                var MIN_C_SCORE = 70;
                var MIN_D_SCORE = 60;

                char grade = 'Z';             //Holds the letter grade

                //Get the three test scores.
                Console.Write("Test 1:");
                var test1 = double.Parse(Console.ReadLine());

                Console.Write("Test 2:");
                var test2 = double.Parse(Console.ReadLine());

                Console.Write("Test 3:");
                var test3 = double.Parse(Console.ReadLine());

                //Calculate the average test score
                var average = (test1 + test2 + test3) / 3.0;

                // Determin the letter grade
                if (average >= MIN_A_SCORE)
                    grade = 'A';
                else if (average >= MIN_B_SCORE)
                    grade = 'B';
                else if (average >= MIN_C_SCORE)
                    grade = 'C';
                else if (average >= MIN_D_SCORE)
                    grade = 'D';
                else if (average >= 0)
                    grade = 'F';

                //Display the average test score, with
                //the output rounded to 1 decimal point.
                Console.WriteLine("Average Test Score: " + average.ToString("n1"));

                //Display the letter grade
                Console.WriteLine("Your letter grade is: " + grade);
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

//The compiler isn't smart enough to know that at least one of your 
//if blocks will be executed. Therefore, it doesn't see that variables 
//like grade will be assigned no matter what.
//The compiler knows that with an if/else block, one of the blocks is 
//guaranteed to be executed, and therefore if you're assigning the variable 
//in all of the blocks, it won't give the compiler error.
//You can also instantiate grade with a default value, 
//if it makes sense to do so.
//http://stackoverflow.com/questions/5710485/what-does-use-of-unassigned-local-variable-mean