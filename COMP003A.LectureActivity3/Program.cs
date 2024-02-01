/*
 * Author: Anthony Alvarez
 * Cours: COMP-003A
 * Purpose: lecture Activity 3 Code
 */

namespace COMP003A.LectureActivity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Conditional (Selection) Statements");
            Console.WriteLine("***************************************");

            Console.WriteLine("1. single if statement");
            Console.Write("\tEnter a whole positive number: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine()); // store user input as an integer

            // single if statement
            if (inputNumber % 2 == 0)
            {
                // this code block executes if the condition about is true
                Console.WriteLine("\tinputNumber is even.");
            }
            Console.WriteLine("2. if-else staement");
            // if-else statement
            if (inputNumber % 2 == 0)
            {
                // this code block executes if the conditon about is true
                Console.WriteLine("\tinputNumber is even.");
            }
            else
            {
                // this code block executes if the above condition is false
                Console.WriteLine("\tinputNumber is odd.");
            }
        }
    }
}