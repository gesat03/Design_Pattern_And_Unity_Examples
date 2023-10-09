using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImageViewExample
{
    public class ImageViewerTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GalleryApp gallery = new GalleryApp();

            gallery.Show(EImageFormat.jpeg, "resim1.jpeg");
            gallery.Show(EImageFormat.png, "resim2.jpeg");
            gallery.Show(EImageFormat.jpg, "resim3.jpeg");
        }

    }
}
