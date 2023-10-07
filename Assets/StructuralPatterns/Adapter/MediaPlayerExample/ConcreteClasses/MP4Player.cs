using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediaPlayerExample
{
    public class MP4Player : IAdvancedMediaPlayer
    {
        //public void PlayMP4(string fileName)
        //{
        //    Debug.Log("Playing Mp4 file. Name: " + fileName);
        //}

        //public void PlayVLC(string fileName)
        //{
        //    throw new System.NotImplementedException();
        //}
        public void Play(string fileName)
        {
            Debug.Log("Playing Mp4 file. Name: " + fileName);
        }
    }
}
