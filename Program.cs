using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********************************
            //******* Task3 Test Code *********
            //*********************************
            //Employee hrRep = new HR();

            //hrRep.ClockIn();
            //hrRep.Work();
            //hrRep.SubmitDailyReport();
            //Console.WriteLine(); //Line break
            //*********************************
            //******* Task3 Test Code *********
            //*********************************
                                 

            
            Employee employee1 = new Engineer();
            employee1.SubmitDailyReport();
            Console.WriteLine(); // line break
                                 //manager
            //Employee manager = new Manager();
            //manager.ClockIn();
            //manager.Work();
            //manager.SubmitDailyReport();
            //Console.WriteLine(); //line break
            //                     //intern
            //Employee intern = new Intern();
            //intern.ClockIn();
            //intern.Work();
            //intern.SubmitDailyReport();
            //Console.WriteLine();//another line break

            //downcasting engineer
            Engineer engineer1 = (Engineer)employee1;
            if (engineer1 != null)
            {
                engineer1.SubmitDailyReport();
            }
            else
            {
                Console.WriteLine("Downcast failed!");
            }

            //lists
            List<Employee> employees = new List<Employee>();

            Employee employee2 = new Manager();
            Employee employee3 = new Intern();
            Employee employee4 = new HR();

            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);

            // loop through each one
            foreach (Employee employee in employees)
            {
                if (employee is Engineer)
                {
                    Console.WriteLine("This is an Engineer.");
                }
                else if (employee is Manager)
                {
                    Console.WriteLine("This is a Manager.");
                }
                else if (employee is Intern)
                {
                    Console.WriteLine("This is an Intern.");
                }
                else if (employee is HR)
                {
                    Console.WriteLine("This is HR.");
                }
                Console.WriteLine();//line break
                employee.ClockIn();
                employee.Work();
                employee.SubmitDailyReport();
                Console.WriteLine();

            }
        }
    }
}
