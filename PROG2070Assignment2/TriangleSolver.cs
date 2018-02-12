using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070Assignment2
{
    class TriangleSolver
    {
        public static string Analyze(int x, int y, int z)
        {
            string analyzedOutput = "test";
            int outcome = x + y + z;
            
            if (outcome == 3)
            {
                analyzedOutput = "this worked!";
            }
            else
            {
                analyzedOutput = "it still worked!";
            }
            return analyzedOutput;
        }
    }
}
