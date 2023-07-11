using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gotoconcept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Again:
            Console.WriteLine("Entere user name");
            userName = Console.ReadLine();
            if(userName.Length>=6)
            {
                Console.WriteLine("Welcome : \t " + userName);
            }
            else
            {
                Console.WriteLine("Inavalid User Name");
                goto Again;
            }
            Console.ReadKey();
        }
    }
}
