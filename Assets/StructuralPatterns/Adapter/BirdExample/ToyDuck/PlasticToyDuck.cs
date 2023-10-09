using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirdExample
{
    public class PlasticToyDuck : IToyDuck
    {
        public string MakeSound()
        {
            return "Squeak!";
        }
    }
}
