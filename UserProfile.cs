using System;
namespace SelfTrainingProject.TechCompanion
{
    public class UserProfile
    {
        public static string errorMessage = "Invalid input";

        private static string firstName;
        public static string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private static string lastName;
        public static string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private static string dateOfBirth;
        public static string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        private static string address;
        public static string Address
        {
            get { return address; }
            set { address = value; }
        }
        private static string phoneNumber;
        public static string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        private static string userName;
        public static string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private static string password;
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }
        private static string initialBalance;
        public static string InitialBalance
        {
            get { return initialBalance; }
            set { initialBalance = value; }
        }
        private static string eMailAddress;
        public static string EMailAddress
        {
            get { return eMailAddress; }
            set { eMailAddress = value; }
        }
        public static void RunUserProfile()
        {
            int l = 0;

            while (l < 1)
            {
                Console.Clear();
                TitleScreen titleScreen = new TitleScreen();
                Console.WriteLine("Enter 1 to carry out an inspection, 2 to login to a vehicle profile, 3 to logout or type \"quit\" to exit");
                string inProgramEntry = Console.ReadLine();
                if (string.Equals(inProgramEntry.ToLower(), "quit"))
                {
                    System.Environment.Exit(1);
                }
                else if (string.Equals(inProgramEntry, ""))
                {
                    Console.WriteLine(errorMessage);
                }
                try
                {
                    int InProgramEntry = int.Parse(inProgramEntry);
                    if (InProgramEntry == 1)
                    {
                        Console.WriteLine("Enter Job number : ");
                        string entry = Console.ReadLine();
                        try
                        {
                            int Entry = int.Parse(entry);
                            if(NewVehicle.JobNumber == Entry)
                            {
                                VehicleInspection vehicleInspection = new VehicleInspection();
                            }
                        }
                        catch(Exception)
                        {
                            Console.WriteLine(errorMessage + " Exception handled!");
                        }
                    }
                    else if (InProgramEntry == 2)
                    {
                        CarProfile.GetVehicleInspectionDetails();
                    }
                    else if (InProgramEntry == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine(errorMessage);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(errorMessage + " Exception handled!");
                }
            }
        }
    }
}
