using System;

namespace EventsAndDelegatesC
{
    public class NotificationService
    {
        public void OnFileDownloaded(object source, EventArgs e)
        {
            Console.WriteLine("NotificationService: Notifying user that download is done...");
        }
    }
}
