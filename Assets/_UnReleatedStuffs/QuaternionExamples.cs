using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleExample
{
    public class QuaternionExamples : MonoBehaviour
    {
        public Transform TargetObj;

        [Range(0, 100)]
        public float Speed;

        public float EulerY;


        // Update is called once per frame
        void Update()
        {
            RotateTowards();

            //LookRotation();
        }

        void RotateTowards()
        {
            float step = Speed * Time.deltaTime;

            Quaternion rotateAngle = Quaternion.Euler(0, EulerY, 0);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotateAngle/*TargetObj.rotation*/, step);
        }

        void LookRotation()
        {
            Vector3 relativePos = TargetObj.position - transform.position;

            // the second argument, upwards, defaults to Vector3.up
            Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
            transform.rotation = rotation;
        }
    }
}
