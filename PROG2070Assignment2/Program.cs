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
<<<<<<< HEAD
            //declaring our variables
=======
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
            int userChoice = 0;
            int firstDimension = 0;
            int secondDimension = 0;
            int thirdDimension = 0;
            string triangleOutcome;

<<<<<<< HEAD
            //using a while loop to to initiate the menu
            //user choice initaited to 0 to ensure the menu appears. If 2 is selected the program exits
            while (userChoice != 2)
            {
                //storing the menu method return varaible in the user choice variable
                userChoice = Menu();

                //when the 1 menu item is selected 
                if (userChoice == 1)
                {
                    
                    //asks the users to enter the first dimension.
                    Console.WriteLine(System.Environment.NewLine + "Enter a positive value for the first side of the triangle" + System.Environment.NewLine);

                    //using the GetInput method to store the first dimension of the triangle
                    firstDimension = GetInput();

                    //GetInput returns 0 if the dimension is not a proper value, if the case we change userchoice to 0 to return to the main menu
=======


            while (userChoice != 2)
            {

                userChoice = Menu();

                if (userChoice == 1)
                {
                    
                    Console.WriteLine("Enter a positive value for the first side of the triangle");
                    firstDimension = GetInput();
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
                    if (firstDimension == 0)
                    {
                        userChoice = 0;
                    }
<<<<<<< HEAD

                    //rather the value is proper input, continue 
                    else
                    {
                        //ask the user for the second dimension of the triangle
                        Console.WriteLine(System.Environment.NewLine + "Enter a positive value for the second side of the triangle" + System.Environment.NewLine);

                        //using the GetInput method to store the first dimension of the triangle
                        secondDimension = GetInput();

                        //GetInput returns 0 if the dimension is not a proper value, if the case we change userchoice to 0 to return to the main menu and prompt the user
=======
                    else
                    {
                        Console.WriteLine("Enter a positive value for the second side of the triangle");
                        secondDimension = GetInput();
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
                        if (secondDimension == 0)
                        {
                            userChoice = 0;
                        }
<<<<<<< HEAD

                        //rather the second value is proper input, continue
                        else
                        {
                            //finally ask the user for the third dimension of the triangle
                            Console.WriteLine(System.Environment.NewLine + "Enter a positive value for the third side of the triangle" + System.Environment.NewLine);

                            //using the GetInput method to store the first dimension of the triangle
                            thirdDimension = GetInput();

                            //GetInput returns 0 if the dimension is not a proper value, if the case we change userchoice to 0 to return to the main menu and prompt the user
=======
                        else
                        {
                            Console.WriteLine("Enter a positive value for the third side of the triangle");
                            thirdDimension = GetInput();
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
                            if (thirdDimension == 0)
                            {
                                userChoice = 0;
                            }
<<<<<<< HEAD
                            //if the third value is proper, call the Analyze method and pass the three dimensions the user has given
                            else
                            {
                                //storing the string returned from the analyze method in variable
                                triangleOutcome = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);
                                Console.WriteLine(System.Environment.NewLine + triangleOutcome.ToString() + System.Environment.NewLine); //outputting the outcome to the console
=======
                            else
                            {
                                triangleOutcome = TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension);
                                Console.WriteLine("Do these numbers form a triangle?" + triangleOutcome.ToString());
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
                            }
                        }
                    }
                }

<<<<<<< HEAD
                //exits the program on 2 input
=======
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
                else if (userChoice == 2)
                {
                    return;
                }
                else
                {
<<<<<<< HEAD
                    Console.WriteLine("Please enter 1 to form a triangle, or 2 to exit the program" + System.Environment.NewLine);
=======
                    Console.WriteLine("Please enter 1 to form a triangle, or 2 to exit the program");
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
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
<<<<<<< HEAD
                Console.WriteLine("Please enter on positive numbers. Sending back to the main menu" + System.Environment.NewLine);
=======
                Console.WriteLine("Please enter on positive numbers. Sending back to the main menu");
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
                input = 0;
            }

            return input;
        }

<<<<<<< HEAD
        //generating our menu to display to the user with two options
=======
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
        private static int Menu()
        {
            int optionChoice;

            Console.WriteLine("Triangle Solver");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Enter Triangle Dimensions");
            Console.WriteLine("2. Exit");
<<<<<<< HEAD
            Console.WriteLine(System.Environment.NewLine);
=======
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251

            //Using a try catch to ensure the input is a number
            try
            {
                optionChoice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
<<<<<<< HEAD
                Console.WriteLine("Please enter positive numbers only. Sending back to the main menu" + System.Environment.NewLine);
=======
                Console.WriteLine("Please enter on positive numbers. Sending back to the main menu");
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
                optionChoice = 0;
            }

            return optionChoice;
        }

    }
}