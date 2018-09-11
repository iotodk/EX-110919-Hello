using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name: ");
            string usersName = Console.ReadLine();
            Console.WriteLine("Hello " + usersName);
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age < 50)
                Console.WriteLine(age + " is a nice age");
            else
                Console.WriteLine(age + " is a good age");

            Console.Read();
        }
    }
}
