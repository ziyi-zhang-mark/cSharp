using System;
using System.Threading;

namespace EventsAndDelegatesC
{

    public class FileEventArgs : EventArgs
    {
        public File File { get; set; }
    }

    public class DownloadHelper
    {
        // step 1: create a delegate
        public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);

        // step 2: create an event based on the delegate
        // not intialized, event can be subscribed and then be non null
        public event FileDownloadedEventHandler Filedownloaded;

        // step 3: raise the event
        protected virtual void OnFileDownloaded(File file)
        {
            if (Filedownloaded != null)
            {
                Filedownloaded(this, new FileEventArgs(){ File = file});
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);

            // step 3.1
            OnFileDownloaded(file);
        }
    }
}
