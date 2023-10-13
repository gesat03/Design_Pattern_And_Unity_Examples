using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PancakeRestaurantExample
{
    public class Menu : BaseMenuComponent
    {

        List<BaseMenuComponent> _menuComponent = new List<BaseMenuComponent>();

        string _name;
        string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(BaseMenuComponent menuComponent)
        {
            _menuComponent.Add(menuComponent);
        }

        public override void Remove(BaseMenuComponent menuComponent)
        {
            _menuComponent.Remove(menuComponent);
        }

        public override string GetName()
        {
            return _name;
        }

        public override string GetDescription()
        {
            return _description;
        }

        public override void Print()
        {
            //IIterator<BaseMenuComponent> iterator = _menuComponent.

            base.Print();
        }
    }
}
