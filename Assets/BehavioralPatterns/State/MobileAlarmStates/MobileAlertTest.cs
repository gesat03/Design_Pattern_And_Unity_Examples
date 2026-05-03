using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace MobileAlarm
{
    public class MobileAlertTest : MonoBehaviour
    {

        AlertStateContext _alertContext;

        private void Start()
        {
            _alertContext = new AlertStateContext();
            _alertContext.Alert();

            _alertContext.SetState(new SoundState());
            _alertContext.Alert();

            _alertContext.SetState(new SlienceState());
            _alertContext.Alert();
        }

    }
}
