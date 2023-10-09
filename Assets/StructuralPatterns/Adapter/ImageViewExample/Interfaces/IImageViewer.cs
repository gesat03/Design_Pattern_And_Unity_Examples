using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImageViewExample
{
    public interface IImageViewer
    {

        public void Show(EImageFormat imageFormat, string fileName);

    }
}
