using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberDuck : DuckClass
{
    public RubberDuck()
    {
        Flyable = new FlyNoWay();

        Quackable = new Squeak();
    }

    public override void Display()
    {
        Debug.Log("I'm just a rubber duck");
    }

}
