using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonDetectedState : ITDetectedState
    {
        public void GetState()
        {
            Debug.Log("Cannon DETECTED enemy vehicle !!!");
        }

    }
}
