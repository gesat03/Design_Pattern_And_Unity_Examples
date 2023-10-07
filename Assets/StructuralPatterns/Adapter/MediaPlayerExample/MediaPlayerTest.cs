using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediaPlayerExample
{
    public class MediaPlayerTest : MonoBehaviour
    {
        AudioPlayer audioPlayer;

        private void Start()
        {
            audioPlayer = new AudioPlayer();

            audioPlayer.Play(EAudioType.mp3, "yallah şöför yallah.mp3");
            audioPlayer.Play(EAudioType.mp4, "bir tek dileğim var komik.mp4");
            audioPlayer.Play(EAudioType.vlc, "dünyayı kurtaran adamın oğlu.vlc");
            audioPlayer.Play(EAudioType.avi, "hababam sınıfı.avi");
        }
    }
}
