using System;

namespace exerciseOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int statusCode = 2;
            if(statusCode == 1)
            {
                Console.WriteLine("You are alive");
            }
            
            else if(statusCode == 2)
            {
                Console.WriteLine("You are a zombie");
            }
            
            else if(statusCode == 3)
            {
                Console.WriteLine("You are dead");
            }
            
            else(statusCode == 4)
            {
                Console.WriteLine("You are unknown");
            }
            
        }
    }
}
