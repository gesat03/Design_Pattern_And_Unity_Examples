using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImageViewExample
{
    public class GalleryApp : IImageViewer
    {
        ImageAdapter imageAdapter;

        public void Show(EImageFormat imageFormat, string fileName)
        {
            switch (imageFormat)
            {
                case EImageFormat.jpeg:
                    Debug.Log("Showing jpeg file. Name: " + fileName);
                    break;
                default:
                    imageAdapter = new ImageAdapter(imageFormat);
                    imageAdapter.Show(imageFormat, fileName);
                    break;
            }
        }
    }
}
