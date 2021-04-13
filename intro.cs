using System;
using System.Collections.Generic;

namespace rating

{
    class intro
    {
public void start()
        {
            Console.WriteLine("******* Welcome to Online Course Rating System *********\n\n");
            Console.WriteLine("Enter Service you wanna use:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("3. View Courses");
            int n = int.Parse(Console.ReadLine());
            if(n==1)
            {
                login Login = new login();
            }
            else if(n==2)
            {
                //Console.WriteLine("SignUp Hommie");
                SignUp signup = new SignUp();
            }
            else if(n==3)
            {
                new courses();
            }
            else
            {
                Console.WriteLine("Invalid Service");
            }
        }        
    }
}