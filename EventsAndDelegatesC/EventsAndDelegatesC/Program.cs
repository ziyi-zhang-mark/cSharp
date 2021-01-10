namespace EventsAndDelegatesC
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new File() { Title = "File 1" };
            var downloadHelper = new DownloadHelper(); // publisher

            var unpackService = new UnpackService(); // receiver
            downloadHelper.Filedownloaded += unpackService.OnFileDownloaded;

            var notificationService = new NotificationService(); // receiver
            downloadHelper.Filedownloaded += notificationService.OnFileDownloaded;

            downloadHelper.Download(file);
        }
    }
}
