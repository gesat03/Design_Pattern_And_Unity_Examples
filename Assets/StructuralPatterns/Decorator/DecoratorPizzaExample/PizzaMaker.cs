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
        //ToppingComposite _toppingComposite;

        void Start()
        {
            //_simplePizza = new TomatoSauce(new Mozzarella(new Salami(new PlainPizza())));
            //Debug.Log("Description of pizza: " + _simplePizza.GetDescription() + "\t" + "Total cost: " + _simplePizza.Cost() + " papel");
            
            //_toppingComposite = new ToppingComposite();
            
            _simplePizza = new PlainPizza();
        }

        private void Update()
        {
            DescriptionText.text = _simplePizza.GetDescription();
            TotalCostText.text = "Total cost: " + _simplePizza.Cost().ToString();

            //DescriptionText.text = _toppingComposite.GetDescription();
            //TotalCostText.text = "Total cost: " + _toppingComposite.Cost().ToString();
        }

        public void SelectSalami()
        {
            _simplePizza = new Salami(_simplePizza);
            //_toppingComposite.Add(new Salami(new PlainPizza()));
        }
        public void SelectCheese()
        {
            _simplePizza = new Cheese(_simplePizza);
            //_toppingComposite.Add(new Cheese(new PlainPizza()));
        }
        public void SelectTomatoSauce()
        {
            _simplePizza = new TomatoSauce(_simplePizza);
            //_toppingComposite.Add(new TomatoSauce(new PlainPizza()));
        }
        public void SelectMozzarella()
        {
            _simplePizza = new Mozzarella(_simplePizza);
            //_toppingComposite.Add(new Mozzarella(new PlainPizza()));
        }
        public void SelectSausage()
        {
            _simplePizza = new Sausage(_simplePizza);
            //_toppingComposite.Add(new Sausage(new PlainPizza()));
        }
        public void SelectOlive()
        {
            _simplePizza = new Olive(_simplePizza);
            //_toppingComposite.Add(new Olive(new PlainPizza()));
        }
        public void SelectPepperony()
        {
            _simplePizza = new Pepperony(_simplePizza);
            //_toppingComposite.Add(new Pepperony(new PlainPizza()));
        }
    }
}
