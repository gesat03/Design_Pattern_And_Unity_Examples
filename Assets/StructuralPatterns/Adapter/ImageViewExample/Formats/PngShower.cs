using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImageViewExample
{
    public class PngShower : IAdvancedImageViewer
    {
        public void ShowExtension(string fileName)
        {
            Debug.Log("Showing png file. Name: " + fileName);
        }
    }
}
