using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.GurkansSandBox.StrategyPattern.Animals
{
	public class TestScene : MonoBehaviour
	{
		Animal comar = new Dog();
		Animal mavis = new Bird();

        private void Start()
        {
            Debug.Log(comar.TryToFly());
            Debug.Log(mavis.TryToFly());
        }
    }
}
