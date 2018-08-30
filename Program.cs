using System;

namespace SelfTrainingProject.TechCompanion
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMessage = "Invalid input";

            int i = 0;

            while (i < 1)
            {
                ProgramLogin.j = 0;
                while (ProgramLogin.j < 2)
                {
                    Console.Clear();
                    TitleScreen titleScreen = new TitleScreen();
                    Console.WriteLine("Please enter 1 to login or type \"quit\" to exit : ");
                    string entry = Console.ReadLine();
                    if (string.Equals(entry.ToLower(), "quit"))
                    {
                        System.Environment.Exit(1);
                    }
                    else if (string.Equals(entry, ""))
                    {
                        Console.WriteLine(errorMessage);
                    }
                    try
                    {
                        int userEntry = int.Parse(entry);
                        if (userEntry == 1)
                        {
                            ProgramLogin.loginAttempt();
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
                    if (ProgramLogin.j == 2)//admin user options
                    {
                        AdminProfile.RunAdminProfile();
                    }
                    else if (ProgramLogin.j == 3)//general user options
                    {
                        UserProfile.RunUserProfile();
                    }
                    else if (ProgramLogin.j == 4)//general user options
                    {
                        ReceptionUser.RunReceptionUser();
                    }

                }
            }

        }
    }
}
