using System;
namespace SelfTrainingProject.SecureProgramLogin
{
    public class ExampleProfile
    {
        public static string errorMessage = "Invalid input";

        public ExampleProfile()
        {

        }
        public static void RunExampleProfile()
        {
            ExampleProfile.GetAccountDetails();
        }

        public static readonly string FirstName = "John";
        public static readonly string LastName = "Doe";
        public static readonly string DateOfBirth = "10/11/1990";
        public static readonly string UserName = "JD1990";
        public static readonly string Password = "123";
        public static readonly string Address = "70 tharp road";
        public static readonly string PhoneNumber = "07713153222";
        public static readonly string EMailAddress = "jd@gmail.com";

        public static void GetAccountDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("First name     : " + FirstName);
            Console.WriteLine("Last name      : " + LastName);
            Console.WriteLine("DOB            : " + DateOfBirth);
            Console.WriteLine("User name      : " + UserName);
            Console.WriteLine("Address        : " + Address);
            Console.WriteLine("Phone number   : " + PhoneNumber);
            Console.WriteLine("E-Mail address : " + EMailAddress);
            Console.WriteLine("");

        }

    }
}
