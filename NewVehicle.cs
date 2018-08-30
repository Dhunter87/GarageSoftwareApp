using System;
namespace SelfTrainingProject.TechCompanion
{
    public class NewVehicle
    {
        public static int CarCount = 0;
        public static int JobNumber = 0;
        public static void addNewVehicle()
        {
            Random random = new Random();
            JobNumber = random.Next(10000, 99999);
            Console.WriteLine("");
            Console.WriteLine("Please enter the customers first name    : ");
            CarProfile.CustomerName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the customers last name     : ");
            CarProfile.CustomerSirName = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the customers address       : ");
            CarProfile.CustomerAddress = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the customers phone number  : ");
            CarProfile.CustomerPhoneNumber = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the customers email address : ");
            CarProfile.CustomerEmail = Console.ReadLine().Trim();
            Console.WriteLine("");
            Console.WriteLine("Please enter the Regestration number     : ");
            CarProfile.RegNo = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the make                    : ");
            CarProfile.Make = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the model                   : ");
            CarProfile.Model = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the year                    : ");
            CarProfile.Year = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the colour                  : ");
            CarProfile.Colour = Console.ReadLine().Trim();
            Console.WriteLine("Please enter the engine size             : ");
            CarProfile.EngineSize = Console.ReadLine().Trim();

            Console.WriteLine("Please enter the Work required           : ");
            CarProfile.WorkRequired = Console.ReadLine().Trim();

            CarCount++;
            //Console.WriteLine("User count : " + CarCount);
            Console.WriteLine("");
            Console.WriteLine("Job number : " + JobNumber);
            Console.WriteLine("");
        }
    }
}
