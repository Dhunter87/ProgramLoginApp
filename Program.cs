using System;

namespace SelfTrainingProject.SecureProgramLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMessage = "Invalid input";

            while (ProgramLogin.j < 2)
            {
                Console.WriteLine("Please enter 1 to login or type \"quit\" to exit : ");
                string entry = Console.ReadLine();
                if (string.Equals(entry.ToLower(), "quit"))
                {
                    System.Environment.Exit(1);
                }
                else if (string.Equals(entry, ""))
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.Beep();
                    Console.ResetColor();                }
                try
                {
                    int userEntry = int.Parse(entry);
                    if (userEntry == 1)
                    {
                        ProgramLogin.loginAttempt();
                    }
                    else
                    {
						Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errorMessage);
						Console.Beep();
                        Console.ResetColor();
                    }
                }
                catch (Exception)
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage + " Exception handled!");
					Console.Beep();
					Console.ResetColor();
                }
                if (ProgramLogin.j == 2)//admin user options
                {
                    AdminProfile.RunAdminProfile();
                }
                else if (ProgramLogin.j == 3)//general user options
                {
                    UserProfile.RunUserProfile();
                }
                else if (ProgramLogin.j == 4)//John Doe user options
                {
                    ExampleProfile.RunExampleProfile();
                }
                ProgramLogin.j = 0;
            }
        }
    }
}
