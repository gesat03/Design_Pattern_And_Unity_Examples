using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediaPlayerExample
{
    public interface IMediaPlayer
    {

        public void Play(EAudioType audioType, string fileName);

    }
}
