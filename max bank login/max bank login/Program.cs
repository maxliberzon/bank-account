using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max_bank_login
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username = "esketit";
            string typed;
            string Password = "silver85";
            string typed2;
            string securitycode = "666";
            string typed3;

            Console.WriteLine("Type in the Username.");
            typed = Console.ReadLine();
            if(typed == Username)
            {
                Console.WriteLine("You are correct");
            }
            if(typed != Username)
            {
                Console.WriteLine("You are wrong");
            }

            
        

            Console.WriteLine("Type in the Password");
            typed2 = Console.ReadLine();
            if (typed2 != Password)
            {
                Console.WriteLine("You are wrong");
            }

            Console.WriteLine("Type in the SecurityCode");
            typed3 = Console.ReadLine();
            if (typed3 != securitycode)
            {
                Console.WriteLine("You are wrong");
            }


            if (typed3 == securitycode)
            {
                Console.WriteLine("You are now logged in.");
            }


















            Console.ReadKey();
        }
    }
}
