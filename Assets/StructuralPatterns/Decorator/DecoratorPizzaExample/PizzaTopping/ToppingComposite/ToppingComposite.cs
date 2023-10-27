using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DecoratorPizzaExample
{
    public class ToppingComposite : IPizza
    {
        List<IPizza> toppingList;

        public ToppingComposite()
        {
            toppingList = new List<IPizza>();

            //toppingList.Add(new PlainPizza());
        }

        public void Add(IPizza topping)
        {
            if (toppingList.Contains(topping)) return;

            toppingList.Add(topping);
        }

        public void Remove(IPizza topping)
        {
            toppingList.Remove(topping);
        }
        
        public string GetDescription()
        {
            if (toppingList.Count < 1) return " ";

            string description = "";

            foreach (var topping in toppingList)
            {
                description += topping.GetDescription();
            }

            return description;
        }

        public float Cost()
        {
            if (toppingList.Count < 1) return 0;

            float cost = 0f;

            foreach (var topping in toppingList)
            {
                cost += topping.Cost();
            }

            return cost;
        }
    }
}
