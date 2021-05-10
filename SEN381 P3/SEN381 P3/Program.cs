using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEN381_P3
{
    enum Choice{
        EXIT=0 ,
        INSERT
    }
    class Program
    {
        static void Main(string[] args)
        {
            Boolean St = false;
            while (St != true)
            {
                Console.WriteLine("======================Welcome=======================");
                Console.WriteLine("Enter \"Exit\" to terminate application.");
                Console.WriteLine("Enter \"Insert\" to insert content of database.");
                Console.WriteLine("====================================================");
                //string Option = Console.ReadLine();

                //Choice ch = (Choice)Convert.ToInt32(Option);


                if (Enum.TryParse<Choice>(Console.ReadLine().ToUpper(), ignoreCase: true, out var Option))
                {
                    switch (Option)
                    {
                        case Choice.EXIT:
                            Console.WriteLine("======================EXIT==========================");
                            Console.WriteLine("Application is being terminated!");
                            Console.WriteLine("====================================================");
                            St = true;
                            Environment.Exit(100);
                            break;
                        case Choice.INSERT:


                            Console.WriteLine("======================INSERT========================");
                            Console.WriteLine("Please enter which item you would like to insert.");
                            Console.WriteLine("Please enter \"Client\", \"Employee\" or \"Job\".");
                            Console.WriteLine("====================================================");
                            string c = Console.ReadLine().ToUpper();
                            if (c == "CLIENT")
                            {
                                string[] Client = new string[4];
                                Console.WriteLine("======================Client========================");
                                Console.WriteLine("Enter clients first name.");
                                Client[0] = Console.ReadLine();
                                Console.WriteLine("Enter clients last name.");
                                Client[1] = Console.ReadLine();
                                Console.WriteLine("Enter clients Phone number.");
                                Client[2] = Console.ReadLine();
                                Console.WriteLine("Enter clients address.");
                                Client[3] = Console.ReadLine();
                                Console.WriteLine("====================================================");
                            }
                            else if (c == "EMPLOYEE")
                            {
                                string[] Employee = new string[3];
                                Console.WriteLine("======================Employees========================");
                                Console.WriteLine("Enter employee first name.");
                                Employee[0] = Console.ReadLine();
                                Console.WriteLine("Enter employee last name.");
                                Employee[1] = Console.ReadLine();
                                Console.WriteLine("Enter employee Phone number.");
                                Employee[2] = Console.ReadLine();
                                Console.WriteLine("=======================================================");

                            }
                            else if (c == "JOB")
                            {
                                string[] Job = new string[3];
                                Console.WriteLine("======================Jobs=========================");
                                Console.WriteLine("Enter jobs start date.");
                                Job[0] = Console.ReadLine();
                                Console.WriteLine("Enter jobs expiration date");
                                Job[1] = Console.ReadLine();
                                Console.WriteLine("Enter jobs details.");
                                Job[2] = Console.ReadLine();
                                Console.WriteLine("====================================================");
                            }
                            else
                            {
                                Console.WriteLine("======================ERROR=========================");
                                Console.WriteLine("Enter a valid option!");
                                Console.WriteLine("====================================================");
                            }

                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Unknown request.");
                }
            }

           
        }
    }
}
