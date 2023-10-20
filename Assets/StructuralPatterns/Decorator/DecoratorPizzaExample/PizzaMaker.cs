using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class PizzaMaker : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            IPizza simplePizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Debug.Log("Description of pizza: " + simplePizza.GetDescription() + "\t" + "Total cost: " + simplePizza.Cost() + " papel");
        }

    }
}
