using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ASS_2
{
    /*public delegate void Deligate_fun(Employee employee, int itr);
    class Empty_Exceptions : Exception
    {
        public Empty_Exceptions(string message) : base(message)
        {

        }
    }*/
    class Employee
    {
        Dictionary<int, String> d_name = new Dictionary<int, string>();
        Dictionary<int, String> d_education = new Dictionary<int, string>();
        public static string path = @"C:\Users\swinal\T1.txt";

        //Deligate_fun del1 = new Deligate_fun(AddDetails);
        public Employee()
        {
            Console.WriteLine("ENTER NUMBER OF EMPLOYEES TO BE ADDED");
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                Console.Write("NAME :");
                String name = Console.ReadLine();
                d_name.Add(i, name);
                Console.WriteLine();

                Console.WriteLine("QUALIFICATION : { BCA , BE , BSC , CA , M-COM , B-COM }");
                
                try
                {
                    String qualification = Console.ReadLine();
                    if (string.IsNullOrEmpty(qualification))
                    {
                        throw new Exception("ENTER VALID QUALIFICATION");

                    }
                    else
                    {
                        d_education.Add(i, qualification);
                        Console.WriteLine("QUALIFICATION :{0}", qualification);
                        if(qualification=="BCA" || qualification == "BE" || qualification == "BSC")
                        {
                            Console.WriteLine("DEPARTMENT IS IT");

                        }
                        else
                        {
                            Console.WriteLine("DEPARTMENT IS ACCOUNTING");
                        }
                    }
                }
                catch (Exception empty)
                {
                    Console.WriteLine(empty.Message);

                    if (File.Exists(path))
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine(empty.Message);
                        }
                    }

                }
            }
        }
    }
}
