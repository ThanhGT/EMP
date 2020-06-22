using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP
{
    // derived class for pilot
    public class Pilot : Employees
    {
        public string pil_license;
        public string pil_ratings;

        // prints pilot info
        public void PrintInfo()
        {
            Console.WriteLine($"Pilot License: {pil_license}");
            Console.WriteLine($"Pilot Rating: {pil_ratings}");
            Console.WriteLine("");
        }
    }
}
