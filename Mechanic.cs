using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP
{
    // derived class for mechanics
    public class Mechanic : Employees
    {
        public string mec_title;
        public string mec_cert;

        // method to print mechanic info
        public void PrintInfo()
        {
            Console.WriteLine($"Mechanic Title: {mec_title}");
            Console.WriteLine($"Mechanic Certificate: {mec_cert}");
            Console.WriteLine("");
        }
    }
}
