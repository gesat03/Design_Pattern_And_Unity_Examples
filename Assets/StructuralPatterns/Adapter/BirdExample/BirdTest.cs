using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BirdExample
{
    public class BirdTest : MonoBehaviour
    {

        private void Start()
        {
            IBird sparrow = new Sparrow();

            IToyDuck plasticToyDuck = new PlasticToyDuck();

            IToyDuck birdAdapter = new BirdAdapter(sparrow);

            Debug.Log("Sparrow make a sound like: " + sparrow.MakeSound() + " and able to " + sparrow.Fly());

            Debug.Log("Plastic Duck make a sound like: " + plasticToyDuck.MakeSound());

            Debug.Log("Sparrow which instatiate as a ToyDuck make a sound like: " + birdAdapter.MakeSound());
        }

    }
}
