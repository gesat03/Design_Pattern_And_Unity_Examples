using UnityEngine;

namespace Assets.GurkansSandBox.CommandPattern.RemoteControl
{
    public class Television : IElectronicDevice
    {
        private int _volume;
        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if(_volume + value < 0)
                {
                    _volume = 0;
                }
                else
                {
                    _volume = value;
                }
                
            }
        }

        public void Off()
        {
            Debug.Log("Tv is off");
        }

        public void On()
        {
            Debug.Log("Tv is on");
        }

        public void VolumeDown()
        {
            Volume--;
            Debug.Log(_volume);
        }

        public void VolumeUp()
        {
            Volume++;
            Debug.Log(_volume);
        }
    }
}
