using System;

namespace ASS_2
{
    
    class Program
    {
       
        static void Main(string[] args)
        {
            int flag = 0;
            do
            {
                Console.WriteLine("1. ADD EMPLOYEES");
                Console.WriteLine("2. EXIT");
                int option = int.Parse(Console.ReadLine());
                if(option==1)
                {
                    Employee employee_object = new Employee();
                    
                }
                else if(option==2)
                {
                    flag++;
                }
            } while (flag == 0);
            

            


        }
    }
}
