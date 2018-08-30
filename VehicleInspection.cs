using System;
namespace SelfTrainingProject.TechCompanion
{
    public class VehicleInspection
    {
        public VehicleInspection()
        {
            CarProfile.GetVehicleDetails();
            Console.WriteLine("Please enter mileage                  : ");
            CarProfile.Mileage = Console.ReadLine().Trim();
            Console.WriteLine("Please enter exterior bodywork report : ");
            CarProfile.ExteriorBodyworkRpt = Console.ReadLine().Trim();
            Console.WriteLine("Please enter vehicle interior report  : ");
            CarProfile.VehicleInteriorRpt = Console.ReadLine().Trim();
            Console.WriteLine("Please enter engine bay report        : ");
            CarProfile.EngineBayRpt = Console.ReadLine().Trim();
            Console.WriteLine("Please enter front brake report       : ");
            CarProfile.FrontBrakesRpt = Console.ReadLine().Trim();
            Console.WriteLine("Please enter front suspension report  : ");
            CarProfile.FrontSuspensionRpt = Console.ReadLine().Trim();
            Console.WriteLine("Please enter steering system report   : ");
            CarProfile.SteeringRpt = Console.ReadLine().Trim();
            Console.WriteLine("Please enter rear brake report        : ");
            CarProfile.RearBrakesRpt = Console.ReadLine().Trim();
            Console.WriteLine("Please enter rear suspension report   : ");
            CarProfile.RearSuspensionRpt = Console.ReadLine().Trim();
            Console.WriteLine("Please enter under body report        : ");
            CarProfile.UnderBodyRpt = Console.ReadLine().Trim();
            Console.WriteLine("");
            Console.WriteLine("Enter report on \"work required\"         : ");
            CarProfile.WorkRequiredRpt = Console.ReadLine().Trim();
            Console.WriteLine("Please enter any additional notes     : ");
            CarProfile.AdditionalNotes = Console.ReadLine().Trim();
            Console.WriteLine("");
            Console.WriteLine("Press any key to continue : ");
            Console.ReadLine();
        }
    }
}
