using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImageViewExample
{
    public class ImageAdapter : IImageViewer
    {
        IAdvancedImageViewer advancedImageViewer;

        public ImageAdapter(EImageFormat imageformat)
        {
            switch (imageformat)
            {
                case EImageFormat.png:
                    advancedImageViewer = new PngShower();
                    break;
                case EImageFormat.jpg:
                    advancedImageViewer = new JpgShower();
                    break;
                default:
                    break;
            }
        }

        public void Show(EImageFormat imageFormat, string fileName)
        {
            advancedImageViewer.ShowExtension(fileName);
        }

    }
}
