using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MediaPlayerExample
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer advancedMediaPlayer;

        public MediaAdapter(EAudioType audioType)
        {
            switch (audioType)
            {
                case EAudioType.mp3:
                    break;
                case EAudioType.mp4:
                    advancedMediaPlayer = new MP4Player();
                    break;
                case EAudioType.vlc:
                    advancedMediaPlayer = new VLCPlayer();
                    break;
                default:
                    break;
            }
        }

        public void Play(EAudioType audioType, string fileName)
        {
            advancedMediaPlayer.Play(fileName);

            //switch (audioType)
            //{
            //    case EAudioType.mp3:
            //        break;
            //    case EAudioType.mp4:
            //        advancedMediaPlayer.PlayMP4(fileName);
            //        break;
            //    case EAudioType.vlc:
            //        advancedMediaPlayer.PlayVLC(fileName);
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
