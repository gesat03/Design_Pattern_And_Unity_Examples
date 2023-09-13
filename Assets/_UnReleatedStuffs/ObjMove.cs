using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GarbageCollector;

namespace VehicleExample
{
    public class ObjMove : MonoBehaviour
    {
        int cameraMaxWidthBorder;

        float mousePosX;
        float mouseFraction;
        float playerPositionX;

        public float swipeSpeed;
        public float CharacterMaxLimitX = 4.5f;
        public float CharacterMinLimitX = -4.5f;

        void Start()
        {
            cameraMaxWidthBorder = Camera.main.pixelWidth;

            GarbageCollection.GarbageCollectionTrack();
        }


        void Update()
        {
            mousePosX = Input.mousePosition.x;

            if (mousePosX > cameraMaxWidthBorder)
            {
                mousePosX = cameraMaxWidthBorder;
            }

            if (mousePosX < 0)
            {
                mousePosX = 0;
            }

            mouseFraction = Mathf.InverseLerp(0, cameraMaxWidthBorder, mousePosX);

            playerPositionX = Mathf.Lerp(CharacterMinLimitX, CharacterMaxLimitX, mouseFraction);

            transform.position = new Vector3(Mathf.Lerp(transform.position.x, playerPositionX, Time.deltaTime * swipeSpeed),
                transform.position.y, transform.position.z);
        }

    }
}
