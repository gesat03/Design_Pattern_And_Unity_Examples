using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyNoWay : IFlyable
{
    public void Fly()
    {
        Debug.Log("I can't fly :(((");
    }
}
