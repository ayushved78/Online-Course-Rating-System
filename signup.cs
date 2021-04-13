using System;
using System.Collections.Generic;
using System.Security;

namespace rating
{
    class SignUp
    {
        public SignUp()
        {
            Console.WriteLine("SignUp Form: ");
            Console.WriteLine("\n");
            Console.WriteLine("Name:");
            string nama = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            string ph = Console.ReadLine();
            Console.WriteLine("Email:");
            string em = Console.ReadLine();
            Console.WriteLine("password:");
            SecureString pass = new SecureString();
            ConsoleKeyInfo nextKey= Console.ReadKey(true);
            while(nextKey.Key!=ConsoleKey.Enter)
            {
                if(nextKey.Key==ConsoleKey.Backspace)
                {
                    if(pass.Length>0)
                    {
                        pass.RemoveAt(pass.Length-1);
                        Console.Write(nextKey.KeyChar);
                        Console.Write(" ");
                        Console.Write(nextKey.KeyChar);
                    }
                }
                else
                {
                    pass.AppendChar(nextKey.KeyChar);
                    Console.Write("*");
                }
                nextKey=Console.ReadKey(true);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Re-emter password:");
            SecureString pass1 = new SecureString();
            ConsoleKeyInfo nextKey1= Console.ReadKey(true);
            // while(nextKey1.Key!=ConsoleKey.Enter)
            // {
            //     if(nextKey1.Key==ConsoleKey.Backspace)
            //     {
            //         if(pass1.Length>0)
            //         {
            //             pass.RemoveAt(pass1.Length-1);
            //             Console.Write(nextKey1.KeyChar);
            //             Console.Write(" ");
            //             Console.Write(nextKey1.KeyChar);
            //         }
            //     }
            //     else
            //     {
            //         pass.AppendChar(nextKey1.KeyChar);
            //         Console.Write("*");
            //     }
            //     nextKey=Console.ReadKey(true);
            // }
            if(pass==pass1)
            {
                Console.WriteLine("Welcome "+nama+"!");
                courses cs = new courses();
            }
            else
            {
                Console.WriteLine("password do not match");
            }
        }
    }

}