using System;
using System.Collections.Generic;
using System.Security;

namespace rating
{
    class login
    {
        public login()
        {
            Console.WriteLine("email:");
            string e = Console.ReadLine();
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
            new courses();

        }
    }
}