using System;

namespace Lab7Facade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var drive = new Drive();
            var power = new Power();
            var notification = new Notification();
            var microwave = new Microwave(drive, power, notification);

            power.PowerEvent += PowerPowerEvent;
            drive.DriveEvent += DriveDriveEvent;
            notification.notificationEvent += NotificationNotificationEvent;

            Console.WriteLine("Defrost");
            microwave.Defrost();
            //вызов нового фасада
            Console.WriteLine("Cooking:");
            microwave.Cook();
        }

        private static void NotificationNotificationEvent(object sender, EventArgs e)
        {
            var n = (Notification) sender;
            Console.WriteLine(n.ToString());
        }

        private static void DriveDriveEvent(object sender, EventArgs e)
        {
            var d = (Drive) sender;
            Console.WriteLine(d.ToString());
        }

        private static void PowerPowerEvent(object sender, EventArgs e)
        {
            var p = (Power) sender;
            Console.WriteLine(p.ToString());
        }
    }
}