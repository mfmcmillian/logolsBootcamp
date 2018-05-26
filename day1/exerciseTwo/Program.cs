using System;

namespace exerciseTwo
{
    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine(GetStatus(2));
        }
    public static string GetStatus(int status)
        {
            if(status == 1)
            {
                return "Alive";
            }
            else if(status == 2)
            {
                return "Zombie";
            }
            else if(status == 3)
            {
                return "Dead";
            }
            else if(status == 4)
            {
                return "Unknown";
            } 

            return "unknown";
        }
    }
}
            // while (whileCount < statusCodes.Length)
            // {
            //    if(statusCodes[whileCount] == 1)
            //     {
            //         Console.WriteLine("1=You are alive");
            //         whileCount ++;
            //     }
            //     else if(statusCodes[whileCount] == 2)
            //     {
            //         Console.WriteLine("2=You are a zombie");
            //         whileCount ++;
            //     }
            //     else if(statusCodes[whileCount] == 3)
            //     {
            //         Console.WriteLine("3=You are dead");
            //         whileCount ++;
            //     }
            //     else if(statusCodes[whileCount] == 4)
            //     {
            //         Console.WriteLine("4=You are unknown");
            //         whileCount ++;
            //     } 
            // }      
        
    

