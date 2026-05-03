using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileAlarm
{
    public class SoundState : IAlertState
    {
        public void Alert()
        {
            Debug.Log("Sound alert activated...");
        }
    }
}
