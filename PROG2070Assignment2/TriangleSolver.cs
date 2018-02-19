using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
<<<<<<< HEAD
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
=======
<<<<<<< HEAD
    public class TriangleSolver
=======
    class TriangleSolver
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
    {
        public static string Analyze(int x, int y, int z)
        {
            string analyzedOutput = "test";
<<<<<<< HEAD
            string triangleString = "not a triangle";
            bool triangleCheck = false;

            if (x + y > z && x + z > y  && y + z > x)
            {
                triangleString = "This correctly forms a triangle, thanks!" + System.Environment.NewLine;
>>>>>>> 21cac3701b1c68bb616a5b16c0b9dd8d7d87b2bd
                triangleCheck = true;
            }
            else
            {
<<<<<<< HEAD
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

=======
                triangleCheck = false;
            }

            if (triangleCheck == true)
            {
                if (x == y && y == z && z == x)
                {
                    analyzedOutput = triangleString + "After checking the numbers I have determined this is an Equilateral Triangle" + System.Environment.NewLine;
                }
                else if (x != y && y != z && z != x)
                {
                    analyzedOutput = triangleString + "After checking the numbers I have determined this is a Scalene Triangle" + System.Environment.NewLine;
                }
                else if (x == y || x == z || y == z)
                {
                    analyzedOutput = triangleString + "After checking the numbers I have determined this is an Isosceles Triangle" + System.Environment.NewLine;
                }
            }
            else if (triangleCheck == false)
            {
                analyzedOutput = "Sorry this is not a proper triangle - returning to main menu";
            }

=======
            int outcome = x + y + z;
            
            if (outcome == 3)
            {
                analyzedOutput = "this worked!";
            }
            else
            {
                analyzedOutput = "it still worked!";
            }
>>>>>>> d8e43394ece147afe5c336fcb3832d1ccd8e2251
            return analyzedOutput;
>>>>>>> 21cac3701b1c68bb616a5b16c0b9dd8d7d87b2bd
        }
    }
}
