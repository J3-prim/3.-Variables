using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize at same time 
            int age = 5;
            string name = "James";

            Console.WriteLine("Hi "+name);
            Console.WriteLine("You are " +age+" years of age");
            Console.WriteLine("Next year you will be " + (age+1));

            age = age + 10;
            Console.WriteLine("In 10 years you will be " + age );

            string lastName = "Jones";
            Console.WriteLine("Your last name is  " + lastName);

            //freeze console
            Console.ReadLine();

        }
    }
}
