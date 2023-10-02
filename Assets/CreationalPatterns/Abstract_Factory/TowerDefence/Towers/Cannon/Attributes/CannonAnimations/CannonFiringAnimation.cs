using UnityEngine;

namespace TowerDefenceExample
{
    public class CannonFiringAnimation : ITFiringAnimation
    {
        public void MakeAnimation()
        {
            Debug.Log("Cannon is bombarding");
        }
    }
}
