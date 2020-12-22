using System;

namespace Lab7Facade
{
    internal class Power
    {
        private int _power;

        public int MicrowavePower
        {
            get => _power;
            set
            {
                _power = value;
                PowerEvent?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler PowerEvent;

        public override string ToString()
        {
            var s = string.Format("Power was set {0}w ", MicrowavePower);
            return s;
        }
    }
}