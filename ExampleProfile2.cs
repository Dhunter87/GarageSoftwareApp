using System;
namespace SelfTrainingProject.TechCompanion
{
    public class ExampleProfile2 // purely for demonstration purposes, so user doesn't have to go into admin profile, store new user then open program.
    {
        public static string errorMessage = "Invalid input";

        public ExampleProfile2()
        {

        }
        public static void RunExampleProfile2()
        {
            ExampleProfile.GetAccountDetails();
        }

        public static readonly string FirstName = "Jane";
        public static readonly string LastName = "Doe";
        public static readonly string DateOfBirth = "11/11/1991";
        public static readonly string UserName = "JD1991";
        public static readonly string Password = "321";
        public static readonly string Address = "71 tharp road";
        public static readonly string PhoneNumber = "07702213153";
        public static readonly string EMailAddress = "jd2@gmail.com";

        public static void GetAccountDetails2()
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
