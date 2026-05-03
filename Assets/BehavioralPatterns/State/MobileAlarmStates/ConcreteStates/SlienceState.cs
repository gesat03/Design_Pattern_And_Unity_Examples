using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileAlarm
{
    public class SlienceState : IAlertState
    {
        public void Alert()
        {
            Debug.Log("No alert");
        }
    }
}
