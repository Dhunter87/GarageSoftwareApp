using System;
namespace SelfTrainingProject.TechCompanion
{
    public class ProgramLogin
    {
        public static int j = 0;

        public static void loginAttempt()
        {
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
                        (string.Equals(userNameAttempt, ExampleProfile.UserName) ||
                         (string.Equals(userNameAttempt, ExampleProfile2.UserName))))
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
                        j = 3;
                        break;
                    }
                    else if (string.Equals(passwordAttempt, ExampleProfile2.Password))
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
                            Console.WriteLine("");
                            Console.WriteLine("Please enter users first name: ");
                            string firstname = Console.ReadLine().Trim();
                            if (string.Equals(firstname, UserProfile.FirstName) ||
                               (string.Equals(firstname, ExampleProfile.FirstName)||
                                (string.Equals(firstname, ExampleProfile2.FirstName))))
                            {
                                Console.WriteLine("Please enter users last name: ");
                                string lastName = Console.ReadLine().Trim();
                                if (string.Equals(lastName, UserProfile.LastName) ||
                                   (string.Equals(lastName, ExampleProfile.LastName)||
                                    (string.Equals(lastName, ExampleProfile2.FirstName))))
                                {
                                    Console.WriteLine("Please enter date of birth: ");
                                    string dateOfBirth = Console.ReadLine().Trim();
                                    if (string.Equals(dateOfBirth, UserProfile.DateOfBirth) ||
                                       (string.Equals(dateOfBirth, ExampleProfile.DateOfBirth)||
                                        (string.Equals(dateOfBirth, ExampleProfile2.DateOfBirth))))
                                    {
                                        Console.WriteLine("Please enter address: ");
                                        string address = Console.ReadLine().Trim();
                                        if (string.Equals(address, UserProfile.Address) ||
                                           (string.Equals(address, ExampleProfile.Address)||
                                            (string.Equals(address, ExampleProfile2.Address))))
                                        {
                                            Console.WriteLine("Please enter phone number: ");
                                            string phoneNumber = Console.ReadLine().Trim();
                                            if (string.Equals(phoneNumber, UserProfile.PhoneNumber) ||
                                               (string.Equals(phoneNumber, ExampleProfile.PhoneNumber)||
                                                (string.Equals(phoneNumber, ExampleProfile2.PhoneNumber))))
                                            {
                                                Console.WriteLine("Please enter user name: ");
                                                string userName = Console.ReadLine().Trim();
                                                if (string.Equals(userName, UserProfile.UserName))
                                                {
                                                    Console.WriteLine("Your password is : " + UserProfile.Password);
                                                }
                                                else if (string.Equals(userName, ExampleProfile.UserName))
                                                {
                                                    Console.WriteLine("Your password is : " + ExampleProfile.Password);
                                                }
                                                else if (string.Equals(userName, ExampleProfile2.UserName))
                                                {
                                                    Console.WriteLine("Your password is : " + ExampleProfile2.Password);
                                                }
                                                else
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine(errorMessage);
                                                    Console.Beep();
                                                    Console.ResetColor();
                                                }
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine(errorMessage);
                                                Console.Beep();
                                                Console.ResetColor();
                                            }
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(errorMessage);
                                            Console.Beep();
                                            Console.ResetColor();
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(errorMessage);
                                        Console.Beep();
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(errorMessage);
                                    Console.Beep();
                                    Console.ResetColor();
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(errorMessage);
                                Console.Beep();
                                Console.ResetColor();
                            }
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
                            Console.ResetColor();
                        }
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
                        Console.WriteLine("");
                        Console.WriteLine("Please enter users first name: ");
                        string firstname = Console.ReadLine().Trim();
                        if (string.Equals(firstname, UserProfile.FirstName) ||
                           (string.Equals(firstname, ExampleProfile.FirstName)||
                            (string.Equals(firstname, ExampleProfile2.FirstName))))
                        {
                            Console.WriteLine("Please enter users last name: ");
                            string lastName = Console.ReadLine().Trim();
                            if (string.Equals(lastName, UserProfile.LastName) ||
                               (string.Equals(lastName, ExampleProfile.LastName)||
                                (string.Equals(lastName, ExampleProfile2.LastName))))
                            {
                                Console.WriteLine("Please enter date of birth: ");
                                string dateOfBirth = Console.ReadLine().Trim();
                                if (string.Equals(dateOfBirth, UserProfile.DateOfBirth) ||
                                   (string.Equals(dateOfBirth, ExampleProfile.DateOfBirth)||
                                    (string.Equals(dateOfBirth, ExampleProfile2.DateOfBirth))))
                                {
                                    Console.WriteLine("Please enter address: ");
                                    string address = Console.ReadLine().Trim();
                                    if (string.Equals(address, UserProfile.Address) ||
                                       (string.Equals(address, ExampleProfile.Address)||
                                        (string.Equals(address, ExampleProfile2.Address))))
                                    {
                                        Console.WriteLine("Please enter phone number: ");
                                        string phoneNumber = Console.ReadLine().Trim();
                                        if (string.Equals(phoneNumber, UserProfile.PhoneNumber))
                                        {
                                            Console.WriteLine("Your user name is : " + UserProfile.UserName);
                                        }
                                        else if (string.Equals(phoneNumber, ExampleProfile.PhoneNumber))
                                        {
                                            Console.WriteLine("Your user name is : " + ExampleProfile.UserName);
                                        }
                                        else if (string.Equals(phoneNumber, ExampleProfile2.PhoneNumber))
                                        {
                                            Console.WriteLine("Your user name is : " + ExampleProfile2.UserName);
                                        }
                                        else
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine(errorMessage);
                                            Console.Beep();
                                            Console.ResetColor();
                                        }
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine(errorMessage);
                                        Console.Beep();
                                        Console.ResetColor();
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(errorMessage);
                                    Console.Beep();
                                    Console.ResetColor();
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine(errorMessage);
                                Console.Beep();
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(errorMessage);
                            Console.Beep();
                            Console.ResetColor();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(errorMessage);
                        Console.Beep();
                        Console.ResetColor();
                    }

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
