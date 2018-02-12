using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    class Program
    {
        public static void Main()
        {
            int userChoice = 0;
            int firstDimension = 0;
            int secondDimension = 0;
            int thirdDimension = 0;
            string triangleOutcome;



            while (userChoice != 2)
            {

                userChoice = Menu();

                if (userChoice == 1)
                {
                    
                    Console.WriteLine("Enter a positive value for the first side of the triangle");
                    firstDimension = GetInput();
                    if (firstDimension == 0)
                    {
                        userChoice = 0;
                    }
                    else
                    {
                        Console.WriteLine("Enter a positive value for the second side of the triangle");
                        secondDimension = GetInput();
                        if (secondDimension == 0)
                        {
                            userChoice = 0;
                        }
                        else
                        {
                            Console.WriteLine("Enter a positive value for the third side of the triangle");
                            thirdDimension = GetInput();
                            if (thirdDimension == 0)
                            {
                                userChoice = 0;
                            }
                            else
                            {
                                triangleOutcome = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);
                                Console.WriteLine("Do these numbers form a triangle?" + triangleOutcome.ToString());
                            }
                        }
                    }
                }

                else if (userChoice == 2)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Please enter 1 to form a triangle, or 2 to exit the program");
                }
            }
        }

        //Method for getting our user input and returning this value
        //Using try catch to ensure it is a valid entry
        private static int GetInput()
        {
            int input;

            try
            {
                input = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.WriteLine("Please enter on positive numbers. Sending back to the main menu");
                input = 0;
            }

            return input;
        }

        private static int Menu()
        {
            int optionChoice;

            Console.WriteLine("Triangle Solver");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Enter Triangle Dimensions");
            Console.WriteLine("2. Exit");

            //Using a try catch to ensure the input is a number
            try
            {
                optionChoice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter on positive numbers. Sending back to the main menu");
                optionChoice = 0;
            }

            return optionChoice;
        }

    }
}