using System;
using System.Collections.Generic;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonData person = new PersonData();
            Console.WriteLine("Welcome to Person Data Management!!!");
            List<Person> list = new List<Person>();
            Console.WriteLine("Enter 1. Adding to person details to list");
            Console.WriteLine("Enter 2. Retrieve top two records which age is less tahn 60");
            Console.WriteLine("Enter the option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    PersonData.AddPerson(list);
                    break;
                case 2:
                    PersonData.AddPerson(list);
                    PersonData.RetrieveTopTwoLessThan60(list);
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }


        }
        
    }
}
