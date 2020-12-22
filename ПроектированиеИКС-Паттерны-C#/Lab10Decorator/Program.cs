using System;

namespace Lab10Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var reno = new Renault("Reno", "Renault LOGAN Active", 499.0);
            Print(reno);
            AutoBase myreno = new MediaNAV(reno, "Navigation");
            Print(myreno);
            AutoBase newmyReno = new SystemSecurity(new MediaNAV(reno, "Navigation"),
                "Security");
            Print(newmyReno);

            var audi = new Audi("Audi", "Audi 1", 3000);

            AutoBase myaudi = new TrackingSystem(
                new AutoPilotSystem(
                    new SystemSecurity(
                        new MediaNAV(audi, "Navigation"), "Security"), "Autopilot"), "Tracking");

            Print(myaudi);
        }

        private static void Print(AutoBase av)
        {
            Console.WriteLine(av.ToString());
        }
    }
}