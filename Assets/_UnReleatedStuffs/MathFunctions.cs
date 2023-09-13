using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class MathFunctions : MonoBehaviour
    {
        [Range(-100, 200)]
        public float Range;

        private void Update()
        {
            MoveTowards();
        }

        [ContextMenu("ClampSmt")]
        void ClampSmt()
        {
            float number = Mathf.Clamp(Range, 0, 100);
            Debug.Log("The range is: " + Range + "\n" + "Clamped number is: " + number);
            Debug.Log("\n" + Mathf.Clamp01(Range));
        }

        [ContextMenu("justTest")]
        void DeltaAngle()
        {
            Debug.Log(Mathf.DeltaAngle(30, 45));
        }

        void LerpAngle()
        {
            float angle = Mathf.LerpAngle(-10, 180, (Time.deltaTime * 100));
            Debug.Log(angle);
        }

        void MoveTowards()
        {
            float currStrength = 0;
            float maxStrength = 90;
            float recoveryRate = 2;

            currStrength = Mathf.MoveTowards(currStrength, maxStrength, recoveryRate * Time.deltaTime);
            Debug.Log(currStrength);
        }
    }
}
