using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PancakeRestaurantExample
{
    public class MenuItem : BaseMenuComponent
    {
        string _name;
        string _description;
        bool _isVegan;
        float _price;

        public MenuItem(string name, string description, bool isVegan, float price)
        {
            _name = name;
            _description = description;
            _isVegan = isVegan;
            _price = price;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override string GetName()
        {
            return _name;
        }

        public override float GetPrice()
        {
            return _price;
        }

        public override bool IsVegan()
        {
            return _isVegan;
        }

        public override void Print()
        {
            Debug.Log("Name of the dish is: " + GetName() +
                " this dish is: " + (IsVegan() ? "is vegan" : "is not vegan") +
                " price is: " + GetPrice() +
                " description is: " + GetDescription());
        }
    }
}
