using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediaPlayerExample
{
    public class VLCPlayer : IAdvancedMediaPlayer
    {
        //public void PlayMP4(string fileName)
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void PlayVLC(string fileName)
        //{
        //    Debug.Log("Playing VLC file. Name: " + fileName);
        //}
        public void Play(string fileName)
        {
            Debug.Log("Playing VLC file. Name: " + fileName);
        }

    }
}
