using UnityEngine;

namespace TowerDefenceExample
{
    public class TowerDetectRange : ITSpecialities<Vector2>
    {
        Vector2 _range;

        public TowerDetectRange(Vector2 range)
        {
            _range = range;
        }

        public Vector2 GetValue()
        {
            return _range;
        }
    }
}
