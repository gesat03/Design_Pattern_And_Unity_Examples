using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHeadDuck : DuckClass
{
    public RedHeadDuck()
    {
        Flyable = new FlyWithWings();

        Quackable = new JustQuack();
    }
    public override void Display()
    {
        Debug.Log("My head is Red B;)");
    }

}
