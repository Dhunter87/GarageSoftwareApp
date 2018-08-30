using System;
namespace SelfTrainingProject.TechCompanion
{
    public class CarProfile
    {
        private static string customerName;
        public static string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        private static string customerSirName;
        public static string CustomerSirName
        {
            get { return customerSirName; }
            set { customerSirName = value; }
        }
        private static string customerAddress;
        public static string CustomerAddress
        {
            get { return customerAddress; }
            set { customerAddress = value; }
        }
        private static string customerPhoneNumber;
        public static string CustomerPhoneNumber
        {
            get { return customerPhoneNumber; }
            set { customerPhoneNumber = value; }
        }
        private static string customerEmail;
        public static string CustomerEmail
        {
            get { return customerEmail; }
            set { customerEmail = value; }
        }
        private static string regNo;
        public static string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }
        private static string make;
        public static string Make
        {
            get { return make; }
            set { make = value; }
        }
        private static string model;
        public static string Model
        {
            get { return model; }
            set { model = value; }
        }
        private static string year;
        public static string Year
        {
            get { return year; }
            set { year = value; }
        }
        private static string engineSize;
        public static string EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }
        private static string numberOfOwners;
        public static string NumberOfOwners
        {
            get { return numberOfOwners; }
            set { numberOfOwners = value; }
        }
        private static string colour;
        public static string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        private static string workRequired;
        public static string WorkRequired
        {
            get { return workRequired; }
            set { workRequired = value; }
        }
        private static string additionalNotes;
        public static string AdditionalNotes
        {
            get { return additionalNotes; }
            set { additionalNotes = value; }
        }

        public CarProfile()
        {
        }
        public static void GetVehicleDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("Customer name       : " + CustomerName + " " + CustomerSirName);
            Console.WriteLine("Customer address    : " + CustomerAddress);
            Console.WriteLine("Customer number     : " + CustomerPhoneNumber);
            Console.WriteLine("Customer E-mail     : " + CustomerEmail);
            Console.WriteLine("");
            Console.WriteLine("Job Number          : " + NewVehicle.JobNumber);
            Console.WriteLine("Regestration number : " + RegNo);
            Console.WriteLine("Make                : " + make);
            Console.WriteLine("Model               : " + model);
            Console.WriteLine("Year                : " + year);
            Console.WriteLine("Engine size         : " + engineSize);
            Console.WriteLine("Colour              : " + colour);
            Console.WriteLine("");
            Console.WriteLine("Work Required       : " + WorkRequired);
            Console.WriteLine("");
        }
        private static string mileage;
        public static string Mileage
        {
            get { return mileage; }
            set { mileage = value; }
        }
        private static string frontBrakesRpt;
        public static string FrontBrakesRpt
        {
            get { return frontBrakesRpt; }
            set { frontBrakesRpt = value; }
        }
        private static string rearBrakesRpt;
        public static string RearBrakesRpt
        {
            get { return rearBrakesRpt; }
            set { rearBrakesRpt = value; }
        }
        private static string exteriorBodyworkRpt;
        public static string ExteriorBodyworkRpt
        {
            get { return exteriorBodyworkRpt; }
            set { exteriorBodyworkRpt = value; }
        }
        private static string vehicleInteriorRpt;
        public static string VehicleInteriorRpt
        {
            get { return vehicleInteriorRpt; }
            set { vehicleInteriorRpt = value; }
        }
        private static string frontSuspensionRpt;
        public static string FrontSuspensionRpt
        {
            get { return frontSuspensionRpt; }
            set { frontSuspensionRpt = value; }
        }
        private static string steeringRpt;
        public static string SteeringRpt
        {
            get { return steeringRpt; }
            set { steeringRpt = value; }
        }
        private static string rearSuspensionRpt;
        public static string RearSuspensionRpt
        {
            get { return rearSuspensionRpt; }
            set { rearSuspensionRpt = value; }
        }
        private static string engineBayRpt;
        public static string EngineBayRpt
        {
            get { return engineBayRpt; }
            set { engineBayRpt = value; }
        }
        private static string underBodyRpt;
        public static string UnderBodyRpt
        {
            get { return underBodyRpt; }
            set { underBodyRpt = value; }
        }
        private static string workRequiredRpt;
        public static string WorkRequiredRpt
        {
            get { return workRequiredRpt; }
            set { workRequiredRpt = value; }
        }
        public static void GetVehicleInspectionDetails()
        {
            Console.WriteLine("");
            GetVehicleDetails();
            Console.WriteLine("");
            Console.WriteLine("Mileage                   : " + Mileage);
            Console.WriteLine("Exterior Bodywork Report  : " + ExteriorBodyworkRpt);
            Console.WriteLine("Vehicle Interior Report   : " + VehicleInteriorRpt);
            Console.WriteLine("Engine Bay Report         : " + EngineBayRpt);
            Console.WriteLine("Front Brake Report        : " + FrontBrakesRpt);
            Console.WriteLine("Front Suspension Report   : " + FrontSuspensionRpt);
            Console.WriteLine("Steering Report           : " + SteeringRpt);
            Console.WriteLine("Rear Brake Report         : " + RearBrakesRpt);
            Console.WriteLine("Rear Suspension Report    : " + RearSuspensionRpt);
            Console.WriteLine("Under Body Report         : " + UnderBodyRpt);
            Console.WriteLine("");
            Console.WriteLine("Work required report      : " + WorkRequiredRpt);
            Console.WriteLine("Additional notes          : " + AdditionalNotes);
            Console.WriteLine("");
            if(!(string.Equals(UserProfile.FirstName, null))) // this "if/else" block of code would not be needed if I didnt have to have an example profile for demo purposes
            {
                Console.WriteLine("Your technician was       : " + UserProfile.FirstName + " " + UserProfile.LastName); 
            }
            else
            {
                Console.WriteLine("Your technician was       : " + ExampleProfile.FirstName + " " + ExampleProfile.LastName);
            }
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue : ");
            Console.ReadLine();
        }
    }
}
