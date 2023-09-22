namespace TowerDefenceExample
{
    public class TowerFireRate : ITSpecialities<float>
    {
        float _fireRate;

        public TowerFireRate(float fireRate)
        {
            _fireRate = fireRate;
        }

        public float GetValue()
        {
            return _fireRate;
        }
    }
}
