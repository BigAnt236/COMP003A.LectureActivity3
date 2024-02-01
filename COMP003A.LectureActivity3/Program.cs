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

            Console.WriteLine("3. nested if statement");
            // nested if statements
            if (inputNumber % 2 == 0)
            {
                // this code block executes if inpuNumber is divisible by 2
                Console.WriteLine("\tinputNumber is even");

                if (inputNumber % 5 == 0)
                {
                    //this code block executes if inputNumber is divisible by 2 first, and divisivle by 5 after
                    Console.WriteLine("\t\tinputNumber is also divisible by 5.");
                }
                else
                {
                    //this code block executes if inputNumber is divisible by 2 first, and NOT divisible by 5 after
                    Console.WriteLine("\t\tinputNumber is NOT divisible by 5.");
                }
            }
            else
            {
                //this code block executes if inputNumber is NOT divisible by 2
                Console.WriteLine("\t\tinputNumber is odd.");
            }

            Console.WriteLine("4. multiple if-else statements");
            // multiple if-else statements
            if (inputNumber % 2 == 0) 
            { 
                //this code block executes if the above condition is true
                //the rest if the condtions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 2");
            }
            else if (inputNumber % 3 == 0)
            {
                //this code block executes if the above condition is true
                //the rest of the conditions will no loner execute
                Console.WriteLine("\tinputNumber is divisible by 3.");
            }
            else if (inputNumber % 5 == 0)
            {
                //this code block executes if the above condtion is true
                //the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 5.");
            }
            else if (inputNumber % 7 == 0)
            {
                //this code block executes if the above condtion is true
                //the rest of the conditions will no longer execute
                Console.WriteLine("\tinputNumber is divisible by 7.");
            }
            else 
            {
                //this code block executes if the above conditions are NOT true
                Console.WriteLine("\tinputNumber is NOT divisible by 2/3/5/7.");
            }

            Console.WriteLine("5. ternary operator");
            string outputMessage = inputNumber % 2 == 0
                ? "\tinputNumber is even."
                : "\tinputNumber is odd.";
            Console.WriteLine(outputMessage);

            int randomNumber = new Random().Next(10); //generates a random number 10 or below
            Console.WriteLine("6. comparison operators");
            Console.WriteLine($"\t{inputNumber} == {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} != {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} > {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} >= {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} < {randomNumber}: {inputNumber == randomNumber}");
            Console.WriteLine($"\t{inputNumber} <= {randomNumber}: {inputNumber == randomNumber}");


        }
        }
    }