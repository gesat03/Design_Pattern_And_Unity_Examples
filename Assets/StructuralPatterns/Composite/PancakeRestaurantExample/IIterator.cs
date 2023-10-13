using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PancakeRestaurantExample
{
    public interface IIterator<T>
    {
        public bool HasNext();
        public object Next();
    }
}
