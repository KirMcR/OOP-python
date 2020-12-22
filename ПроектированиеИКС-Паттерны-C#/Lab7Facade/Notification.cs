using System;

namespace Lab7Facade
{
    internal class Notification
    {
        private string message;

        public string MessageFin
        {
            get => message;
            set
            {
                message = value;
                notificationEvent?.Invoke(this, new EventArgs());
            }
        }

        public event EventHandler notificationEvent;

        public void StartNotification()
        {
            MessageFin = "Operation has started";
        }

        public void StopNotification()
        {
            MessageFin = "Operation has finished";
        }

        public override string ToString()
        {
            var s = string.Format("Info: {0}", MessageFin);
            return s;
        }
    }
}