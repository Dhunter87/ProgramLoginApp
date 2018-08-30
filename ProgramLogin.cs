using System;
namespace SelfTrainingProject.SecureProgramLogin
{
    public class ProgramLogin
    {
        public static int j = 0;
        public bool FirstNameCheck { get; set; } = false;
        public bool LastNameCheck { get; set; } = false;
        public bool DOBCheck { get; set; } = false;
        public bool PhoneNumberCheck { get; set; } = false;
        public bool AddressCheck { get; set; } = false;
        public bool UserNameCheck { get; set; } = false;

        public bool Check1()
        {
            Console.WriteLine("");
            Console.WriteLine("Please enter users first name: ");
            string firstname = Console.ReadLine().Trim();
            if (string.Equals(firstname, UserProfile.FirstName) ||
               (string.Equals(firstname, ExampleProfile.FirstName)))
            {
                return FirstNameCheck = true;
            }
            return false;
        }
        public bool Check2()
        {
            Console.WriteLine("Please enter users last name: ");
            string lastName = Console.ReadLine().Trim();
            if (string.Equals(lastName, UserProfile.LastName) ||
               (string.Equals(lastName, ExampleProfile.LastName)))
            {
                return LastNameCheck = true;
            }
            return false;
        }
        public bool Check3()
        {
            Console.WriteLine("Please enter date of birth: ");
            string dateOfBirth = Console.ReadLine().Trim();
            if (string.Equals(dateOfBirth, UserProfile.DateOfBirth) ||
               (string.Equals(dateOfBirth, ExampleProfile.DateOfBirth)))
            {
                return DOBCheck = true;
            }
            return false;
        }
        public bool Check4()
        {
            Console.WriteLine("Please enter phone number: ");
            string phoneNumber = Console.ReadLine().Trim();
            if (string.Equals(phoneNumber, UserProfile.PhoneNumber) ||
               (string.Equals(phoneNumber, ExampleProfile.PhoneNumber)))
            {
                return PhoneNumberCheck = true;
            }
            return false;
        }
        public bool Check5()
        {
            Console.WriteLine("Please enter address: ");
            string address = Console.ReadLine().Trim();
            if (string.Equals(address, UserProfile.Address) ||
               (string.Equals(address, ExampleProfile.Address)))
            {
                return AddressCheck = true;
            }
            return false;
        }


        public string RetrievePassword()
        {
            string userName;
            Check1();
            if(FirstNameCheck == true)
            {
                Check2();                    
            }
            if (LastNameCheck == true)
            {
                Check3();
            }
            if(DOBCheck == true)
            {
                Check4();
            }
            if (PhoneNumberCheck == true)
            {
                Check5();
            }
            if(AddressCheck == true)
            {
                Console.WriteLine("Please enter user name: ");
                userName = Console.ReadLine().Trim();
                if (string.Equals(userName, UserProfile.UserName))
                {
                    Console.WriteLine("Your password is : " + UserProfile.Password);
                    return UserProfile.Password;
                }
                else if (string.Equals(userName, ExampleProfile.UserName))
                {
                    Console.WriteLine("Your password is : " + ExampleProfile.Password);
                    return ExampleProfile.Password;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Invalid Input!");
                Console.WriteLine("Password retrieval failed!");
                Console.ResetColor();
            }
            return null;
        }
        public string RetrieveUserName()
        {
            string address;
            Check1();
            if (FirstNameCheck == true)
            {
                Check2();
            }
            if (LastNameCheck == true)
            {
                Check3();
            }
            if (DOBCheck == true)
            {
                Check4();
            }
            if (PhoneNumberCheck == true)
            {
                Console.WriteLine("Please enter address: ");
                address = Console.ReadLine().Trim();
                if (string.Equals(address, UserProfile.Address))
                {
                    Console.WriteLine("Your user name is : " + UserProfile.UserName);
                    return UserProfile.Address;
                }
                else if (string.Equals(address, ExampleProfile.Address))
                {
                    Console.WriteLine("Your user name is : " + ExampleProfile.UserName);
                    return ExampleProfile.Address;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Invalid Input!");
                Console.WriteLine("User name retrieval failed!");
                Console.ResetColor();
            }
            return null;
        }

        public static void loginAttempt()
        {
            ProgramLogin login = new ProgramLogin();
            string errorMessage = "Ivalid input";

            for (int loginAttempts = 1; loginAttempts <= 3; loginAttempts++)
            {
                Console.WriteLine("");
                Console.WriteLine("login attempts : " + loginAttempts);
                Console.WriteLine("Please enter your username or type \"quit\" to exit: ");
                string userNameAttempt = Console.ReadLine();
                if (string.Equals(userNameAttempt.ToLower(), "quit"))
                {
                    break;
                }
                else if (string.Equals(userNameAttempt, UserProfile.UserName) ||
                        (string.Equals(userNameAttempt, ExampleProfile.UserName)))
                {
                    Console.WriteLine("Please enter your password or type \"quit\" to exit : ");
                    string passwordAttempt = Console.ReadLine();
                    if (string.Equals(userNameAttempt.ToLower(), "quit"))
                    {
                        break;
                    }
                    else if (string.Equals(passwordAttempt, UserProfile.Password))
                    {
						Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Access Granted!");
						Console.ResetColor();
                        Console.WriteLine("");
                        j = 3;
                        break;
                    }
                    else if (string.Equals(passwordAttempt, ExampleProfile.Password))
                    {
						Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Access Granted!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        j = 4;
                        break;
                    }
                    else
                    {
						Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Access Denied!");
						Console.Beep();
						Console.ResetColor();
                        Console.WriteLine("Press enter to continue or 1 to retrieve forgotten password!");
                        string entry = Console.ReadLine();
                        if (string.Equals(entry, "1"))
                        {
                            login.RetrievePassword();
                        }
                        else if (string.Equals(entry, ""))
                        {
                            continue;
                        }
                        else
                        {
							Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(errorMessage);
                            Console.Beep();
                            Console.ResetColor();                        }
                    }
                }
                else if (string.Equals(userNameAttempt, AdminProfile.adminUserName))
                {
                    Console.WriteLine("Please enter admin password or type \"quit\" to exit : ");
                    string adminPasswordAttempt = Console.ReadLine().Trim();
                    if (string.Equals(adminPasswordAttempt.ToLower(), "quit"))
                    {
                        break;
                    }
                    else if (string.Equals(adminPasswordAttempt, AdminProfile.adminPassword))
                    {
						Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Access Granted!");
                        Console.ResetColor();
                        Console.WriteLine("");
                        j = 2;
                        break;
                    }
                }
                else
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("User name not found!");
					Console.Beep();
					Console.ResetColor();
                    Console.WriteLine("Press enter to continue or 1 to retrieve forgotten user name!");
                    string entry = Console.ReadLine();
                    if (string.Equals(entry, ""))
					{
						continue;
					}
                    if (string.Equals(entry, "1"))
                    {
                        login.RetrieveUserName();
                    }
                    else
                    {
						Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errorMessage);
                        Console.Beep();
                        Console.ResetColor();                    }

                }
                if (loginAttempts == 3)
                {
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Login attempts limit reached!");
					Console.ResetColor(); 
                    Console.WriteLine("");
                }
            }
        }
    }
}

