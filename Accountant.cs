using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP
{
    // derived class for accountants
    class Accountant : Employees
    {
        public string acc_title;
        public string acc_license_type;

        // method to print accountant information
        public void PrintInfo()
        {
            Console.WriteLine($"Accountant Title: {acc_title}");
            Console.WriteLine($"Accountant License Type: {acc_license_type}");
            Console.WriteLine("");
        }
    }
}
