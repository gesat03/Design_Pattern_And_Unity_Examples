using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediaPlayerExample
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;

        public void Play(EAudioType audioType, string fileName)
        {
            if(audioType == EAudioType.mp3)
            {
                Debug.Log("Playing Mp3 file. Name: " + fileName);
            }
            else if (audioType == EAudioType.mp4 || audioType == EAudioType.vlc)
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Debug.Log("Invalid media. " + audioType + " format not supported");
            }
        }
    }
}
