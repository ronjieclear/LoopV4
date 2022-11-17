using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp67
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int ulit = 0;
            Console.WriteLine("== This is a Loop Program ==");
            Console.Write("Enter your name: ");
            name = Console.ReadLine();
            Console.Write("How many times do you want to display your name: ");
            ulit = int.Parse(Console.ReadLine());
            //Iteration = Ulit - Isang ikot

            //Do Loop
            int i = 0;
            do
            {
                Console.WriteLine(name);
                i++;
                if (i==3)//True   - //
                {
                    //break;  
                    goto jumpthispart;
                }                
            } while (i <ulit);

        part1:   //this is called label
            Console.WriteLine("This will print the Part 1");

        part2:
            Console.WriteLine("This will print the Part TWO");

        jumpthispart:
            Console.WriteLine("This will print the END PART");





            /*            //For Loop

                        for(int i =0; i < ulit; i++)
                        {
                            Console.WriteLine(name);
                            for (int y=0; y< i;y++)
                            {
                                Console.WriteLine(y);
                            }
                        }*/





            //While Loop
            /*           int i = 1;   //initialization
                       int k = 1;
                       while (i <= ulit) //Bryan    <- condition
                       {
                           Console.WriteLine(name);
                           i++; // i+=1; or i = i+1;   <- inc / dec
                           while(k <=i)
                           {
                               Console.WriteLine(k);
                               k++;
                           }                    
                       }*/





            Console.ReadLine();
        }
    }
}
