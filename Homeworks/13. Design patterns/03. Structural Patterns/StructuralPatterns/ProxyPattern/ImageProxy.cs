namespace ProxyPattern
{
    using System;

    // Proxy
    public class ImageProxy : Image
    {
        // Private Proxy data 
        private string imageFilePath;

        // Reference to RealSubject
        private Image proxifiedImage;

        public ImageProxy(string imageFilePath)
        {
            this.imageFilePath = imageFilePath;
        }

        public void ShowImage()
        {
            // create the Image Object only when the image is required to be shown
            this.proxifiedImage = new HighResolutionImage(this.imageFilePath);

            // now call showImage on realSubject
            this.proxifiedImage.ShowImage();
        }
    }
}
