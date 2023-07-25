using Pets.Domain.Notifications.Interfaces;

namespace Pets.Domain.Notifications
{
    public class Notification : INotification
    {
        public Notification(string message, string propertyName)
        {
            Message = message;
            PropertyName = propertyName;            
        }

        public string Message {get; private set; }
        public string PropertyName {get; private set; }
    }
}