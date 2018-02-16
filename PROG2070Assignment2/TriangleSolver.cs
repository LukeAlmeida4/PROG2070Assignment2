using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
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
                triangleCheck = true;
            }
            else
            {
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
        }
    }
}
