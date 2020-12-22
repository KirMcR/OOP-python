using System;

namespace Lab7Facade
{
    internal class Drive
    {
        private string _twist;

        public Drive() => Twist = "Initial position";

        public string Twist
        {
            get => _twist;
            set
            {
                _twist = value;
                DriveEvent?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler DriveEvent;

        public void TurnRight() => Twist = "Turn right";

        public void TurnLeft() => Twist = "Turn left";

        public void Stop() => Twist = "Stop";

        public override string ToString() => $"Drive unit: {Twist}";
    }
}