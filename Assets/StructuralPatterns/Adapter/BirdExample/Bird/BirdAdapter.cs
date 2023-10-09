using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirdExample
{
    // This adapter type is called Object Adapter
    // The purpose here is we are imitating bird as a toy duck
    // Converting IBird interface to IToyDuck interface
    public class BirdAdapter : IToyDuck
    {
        IBird _bird;

        public BirdAdapter(IBird bird)
        {
            _bird = bird;
        }

        public string MakeSound()
        {
            return _bird.MakeSound();
        }
    }
}
