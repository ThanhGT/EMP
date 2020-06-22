using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 * GROUP 9
 * Thanh Tran
 * Gaurav Tyade
 * Robin Lansiquot
 * Bilaal Rashid
 * 
 * program that prints a specific employee type based on user's selection
 */

namespace EMP
{
    class EMP
    {
        static void Main(string[] args)
        {
            // create object instances of each employee type
            Employees emp = new Employees();
            Pilot pilot = new Pilot();
            Mechanic mechanic = new Mechanic();
            Accountant accountant = new Accountant();

            //declare and initalize boolean type isRunning
            bool isRunning = true;

            // keep running until user enters QUIT
            while (isRunning)
            {
                Console.Write("Type in an employee type (PILOT | MECHANIC | ACCOUNTANT): ");
                string empType = Console.ReadLine().ToUpper();

                pilot.emp_type = "PILOT";
                mechanic.emp_type = "MECHANIC";
                accountant.emp_type = "ACCOUNTANT";

                if (empType.Equals(pilot.emp_type))
                {
                    // pilot info
                    pilot.emp_num = 001;
                    pilot.emp_lname = "Lansiquot";
                    pilot.emp_fname = "Robin";
                    pilot.emp_type = "Pilot";
                    pilot.pil_license = "A2PO3N23Z";
                    pilot.pil_ratings = "5";

                    pilot.PrintContactInfo();
                    pilot.PrintInfo();
                }
                else if (empType.Equals(mechanic.emp_type))
                {

                    // mechanic info
                    mechanic.emp_num = 100;
                    mechanic.emp_lname = "Rashid";
                    mechanic.emp_fname = "Bilaal";
                    mechanic.emp_type = "Mechanic";
                    mechanic.mec_title = "Auto Mechanic";
                    mechanic.mec_cert = "CN23214902";

                    mechanic.PrintContactInfo();
                    mechanic.PrintInfo();

                }
                else if (empType.Equals(accountant.emp_type))
                {
                    // accountant info
                    accountant.emp_num = 103;
                    accountant.emp_lname = "Tayade";
                    accountant.emp_fname = "Gaurav";
                    accountant.emp_type = "Accountant";
                    accountant.acc_title = "Tax accountant";
                    accountant.acc_license_type = "CA/CPA";

                    accountant.PrintContactInfo();
                    accountant.PrintInfo();
                }
                else if (empType.Equals("QUIT"))
                {
                    System.Environment.Exit(0);
                } else
                {
                    Console.WriteLine("Incorrect employee type. Try again!");
                }
            }

            Thread.Sleep(90000);

        }
    }
}
