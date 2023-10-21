using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace DecoratorPizzaExample
{
    public class PizzaMaker : MonoBehaviour
    {
        public TextMeshProUGUI DescriptionText;
        public TextMeshProUGUI TotalCostText;

        IPizza _simplePizza;

        void Start()
        {
            //_simplePizza = new TomatoSauce(new Mozzarella(new Salami(new PlainPizza())));
            //Debug.Log("Description of pizza: " + _simplePizza.GetDescription() + "\t" + "Total cost: " + _simplePizza.Cost() + " papel");
            
            _simplePizza = new PlainPizza();

        }

        private void Update()
        {
            DescriptionText.text = _simplePizza.GetDescription();
            TotalCostText.text =  "Total cost: " + _simplePizza.Cost().ToString();
        }

        public void SelectSalami()
        {
            _simplePizza = new Salami(_simplePizza);
        }
        public void SelectCheese()
        {
            _simplePizza = new Cheese(_simplePizza);
        }
        public void SelectTomatoSauce()
        {
            _simplePizza = new TomatoSauce(_simplePizza);
        }
        public void SelectMozzarella()
        {
            _simplePizza = new Mozzarella(_simplePizza);
        }
        public void SelectSausage()
        {
            _simplePizza = new Sausage(_simplePizza);
        }
        public void SelectOlive()
        {
            _simplePizza = new Olive(_simplePizza);
        }
        public void SelectPepperony()
        {
            _simplePizza = new Pepperony(_simplePizza);
        }
    }
}
