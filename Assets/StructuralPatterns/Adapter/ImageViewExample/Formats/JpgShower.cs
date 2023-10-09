using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImageViewExample
{
    public class JpgShower : IAdvancedImageViewer
    {
        public void ShowExtension(string fileName)
        {
            Debug.Log("Showing jpg file. Name: " + fileName);
        }
    }
}
