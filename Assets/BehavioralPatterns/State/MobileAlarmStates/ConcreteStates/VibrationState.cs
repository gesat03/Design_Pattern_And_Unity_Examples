using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileAlarm
{
    public class VibrationState : IAlertState
    {
        public void Alert()
        {
            Debug.Log("Vibration alert active...");
        }
    }
}
