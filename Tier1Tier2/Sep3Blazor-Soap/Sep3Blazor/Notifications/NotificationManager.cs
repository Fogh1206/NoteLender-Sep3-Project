using System;
using System.Threading.Tasks;
using Assignment1.Data.Notifications.NotificationModel;

namespace Assignment1.Data.Notifications
{
    public class NotificationManager
    {
        public event Action<Notification> OnShow;
        public event Action OnHide;

        public async Task Show(string title, string content, NotificationType type)
        {
            
            Console.WriteLine("show");
            Notification notification = new Notification()
            {
                Title = title,
                Content = content,
                Type = type
            };
            OnShow?.Invoke(notification);
            await Task.Delay(1000);
            try
            {
                OnHide?.Invoke();
                Console.WriteLine("Hide");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
        
        

    }
}