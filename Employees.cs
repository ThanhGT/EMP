using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMP
{
    // base class for employees
    public class Employees
    {
        public int emp_num;
        public string emp_lname;
        public string emp_fname;
        public string emp_type;

        // method to print contact info
        public void PrintContactInfo()
        {
            Console.WriteLine("");
            Console.WriteLine($"Employee Number: {emp_num}");
            Console.WriteLine($"Last Name: {emp_lname}");
            Console.WriteLine($"First Name: {emp_fname}");
            Console.WriteLine($"Type: {emp_type}");
        }
    }
}
