using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MobileAlarm
{
    public class AlertStateContext 
    {
        IAlertState _currentState;

        public AlertStateContext()
        {
            _currentState = new VibrationState();
        }

        public void SetState(IAlertState state)
        {
            _currentState = state;
        }

        public void Alert()
        {
            _currentState.Alert();
        }
    }
}
