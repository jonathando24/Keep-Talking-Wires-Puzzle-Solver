using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTalkingWires
{
    class Program
    {
        static void Main(string[] args)
        {
            //blue = 1
            //black = 2
            //white = 3
            //yellow = 4
            //red = 5 
            Console.WriteLine("Color of wires (in order, in one line, no spaces)");
            Console.WriteLine("1. blue\n2. black\n3. white\n4. yellow\n5. red");
            String input = Console.ReadLine();
            int wireNum = input.Length;
            //3 wires
            if (wireNum == 3)
            {
                if(input.IndexOf("5") == -1)
                {
                    Console.WriteLine("Cut the Second Wire");
                }
                else if (input.Substring(2).Equals("3"))
                {
                    Console.WriteLine("Cut the Last Wire");
                }
                else if(input.IndexOf("1") != -1 && input.IndexOf("1") != 2 && input.Substring(input.IndexOf("1")+1).IndexOf("1") != -1)
                {
                    Console.WriteLine("Cut the Last Blue Wire");
                }
                else
                {
                    Console.WriteLine("Cut the Last Wire");
                }

            }
            //4 wires
            else if (wireNum == 4)
            {
                bool done = false;
                if(input.IndexOf("5") != -1 && input.IndexOf("5") != 3 && input.Substring(input.IndexOf("5") + 1).IndexOf("5") != -1)
                {
                    Console.WriteLine("Is the last digit of the serial number odd? y/n");
                    String odd = Console.ReadLine();
                    if (odd.Equals("y"))
                    {
                        Console.WriteLine("Cut the Last Red Wire");
                        done = true;
                    }
                }
                if (done == false)
                {
                    if (input.IndexOf("5") == -1 && input.Substring(3).Equals("4"))
                    {
                        Console.WriteLine("Cut the First Wire");
                    }
                    else if (input.IndexOf("1") != -1 && input.IndexOf("1") != 3 && input.Substring(input.IndexOf("1") + 1).IndexOf("1") == -1)
                    {
                        Console.WriteLine("Cut the First Wire");
                    }
                    else if (input.IndexOf("4") != -1 && input.IndexOf("4") != 3 && input.Substring(input.IndexOf("4") + 1).IndexOf("4") != -1)
                    {
                        Console.WriteLine("Cut the Last Wire");
                    }
                    else
                    {
                        Console.WriteLine("Cut the Second Wire");
                    }
                }

            }
            //5 wires
            else if (wireNum == 5)
            {
                bool done = false;
                if (input.Substring(4).Equals("2"))
                {
                    Console.WriteLine("Is the last digit of the serial number odd? y/n");
                    String odd = Console.ReadLine();
                    if (odd.Equals("y"))
                    {
                        Console.WriteLine("Cut the Fourth Wire");
                        done = true;
                    }
                }
                if (done == false)
                {
                    if ((input.IndexOf("5") != -1 && input.IndexOf("5") != 4 && input.Substring(input.IndexOf("5") + 1).IndexOf("5") == -1)
                        && (input.IndexOf("4") != -1 && input.IndexOf("4") != 4 && input.Substring(input.IndexOf("4") + 1).IndexOf("4") != -1))
                    {
                        Console.WriteLine("Cut the First Wire");
                    }
                    else if(input.IndexOf("2") == -1)
                    {
                        Console.WriteLine("Cut the Second Wire");
                    }
                    else
                    {
                        Console.WriteLine("Cut the First Wire");
                    }
                }
            }
            //6 wires
            else if (wireNum == 6)
            {
                bool done = false;
                if (input.IndexOf("4") == -1)
                {
                    Console.WriteLine("Is the last digit of the serial number odd? y/n");
                    String odd = Console.ReadLine();
                    if (odd.Equals("y"))
                    {
                        Console.WriteLine("Cut the Third Wire");
                        done = true;
                    }
                }
                if (done == false)
                {
                    if ((input.IndexOf("4") != -1 && input.IndexOf("4") != 5 && input.Substring(input.IndexOf("4") + 1).IndexOf("4") == -1)
                        && (input.IndexOf("3") != -1 && input.IndexOf("3") != 5 && input.Substring(input.IndexOf("3") + 1).IndexOf("3") != -1))
                    {
                        Console.WriteLine("Cut the Fourth Wire");
                    }
                    else if (input.IndexOf("5") == -1)
                    {
                        Console.WriteLine("Cut the Last Wire");
                    }
                    else
                    {
                        Console.WriteLine("Cut the Fourth Wire");
                    }
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
