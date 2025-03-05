using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapGExam
{
    interface INotificationObserver
    {
        void Update(string message);
    }

    class progm_19_EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }

    class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    class NotificationService
    {
        private List<INotificationObserver> observers = new List<INotificationObserver>();

        public void Subscribe(INotificationObserver observer)
        {
            observers.Add(observer);
        }

        public void NotifyAll(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
