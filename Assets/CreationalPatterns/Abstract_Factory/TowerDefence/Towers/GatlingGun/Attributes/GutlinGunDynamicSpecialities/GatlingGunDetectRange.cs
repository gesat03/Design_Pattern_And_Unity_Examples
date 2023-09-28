using UnityEngine;

namespace TowerDefenceExample
{
    public class GatlingGunDetectRange : ITDetectRange
    {
        public Vector2 DetectRange()
        {
            return new Vector2(1.0f, 1.0f);
        }
    }
}
