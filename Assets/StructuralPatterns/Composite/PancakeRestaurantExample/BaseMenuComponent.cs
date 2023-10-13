using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PancakeRestaurantExample
{
    public abstract class BaseMenuComponent
    {
        public virtual BaseMenuComponent GetChild(int i) 
        {
            throw new System.NotSupportedException();
        }
        public virtual void Add(BaseMenuComponent menuComponent)
        {
            throw new System.NotSupportedException();
        }
        public virtual void Remove(BaseMenuComponent menuComponent)
        {
            throw new System.NotSupportedException();
        }
        public virtual string GetName()
        {
            throw new System.NotSupportedException();
        }
        public virtual string GetDescription()
        {
            throw new System.NotSupportedException();
        }
        public virtual float GetPrice()
        {
            throw new System.NotSupportedException();
        }
        public virtual bool IsVegan()
        {
            throw new System.NotSupportedException();
        }
        public virtual void Print()
        {
            throw new System.NotSupportedException();
        }
    }
}
