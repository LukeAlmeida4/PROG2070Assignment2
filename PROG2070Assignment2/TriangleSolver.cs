using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    public class TriangleSolver
    {

        public static string Analyze(int x, int y, int z)
        {
            //Declaring our variables
            string analyzedOutput = null;
            string triangleString = null;
            bool triangleCheck = false;

            //checking to see if the passed values form a triangle
            if (x + y > z && x + z > y && y + z > x)
            {
                //if they do returh a string confirming this and change the boolean variable to true
                triangleString = "This correctly forms a triangle, thanks! ";
                triangleCheck = true;
            }
            else
            {
                //if not change the boolean variable to false
                triangleCheck = false;
            }

            //excude the code if the boolean is true
            if (triangleCheck == true)
            {
                //checking for an equilateral triangle with the values
                if (x == y && y == z && z == x)
                {
                    analyzedOutput = triangleString + "After checking the numbers I have determined this is an Equilateral Triangle ";
                }
                //checking for a scalene triangle with the values
                else if (x != y && y != z && z != x)
                {
                    analyzedOutput = triangleString + "After checking the numbers I have determined this is a Scalene Triangle ";
                }
                //checking for a isosceles triangle with the values
                else if (x == y || x == z || y == z)
                {
                    analyzedOutput = triangleString + "After checking the numbers I have determined this is an Isosceles Triangle ";
                }
            }
            //execute this code if the bool is false
            else 
            {
                analyzedOutput = "Sorry this is not a proper triangle - returning to main menu";
            }
            //checking if the passed value is null
            if (x == 0)
            {
                throw new ArgumentNullException("x");
            }
            //checking if the passed value is negative
            if (x < -1)
            {
                throw new ArgumentException("x");
            }

            return analyzedOutput;

        }
    }
}
