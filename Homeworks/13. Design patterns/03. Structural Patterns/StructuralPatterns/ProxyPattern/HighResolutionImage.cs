namespace ProxyPattern
{
    using System;

    // Image Viewer program
    // RealSubject
    public class HighResolutionImage : Image
    {
        public HighResolutionImage(string imageFilePath)
        {
            this.LoadImage(imageFilePath);
        }

        public void ShowImage()
        {
            // Actual Image rendering logic
        }

        private void LoadImage(string imageFilePath)
        {
            // load Image from disk into memory
            // this is heavy and costly operation
        }
    }
}