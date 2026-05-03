using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoyDuck : DuckClass
{
    public DecoyDuck()
    {
        Flyable = new FlyNoWay();

        Quackable = new MuteQuack();
    }
    public override void Display()
    {
        Debug.Log("I'm not exist mann");
    }

}
