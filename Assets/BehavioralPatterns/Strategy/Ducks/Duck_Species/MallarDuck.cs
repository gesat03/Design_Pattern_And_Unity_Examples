using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MallarDuck : DuckClass
{
    public MallarDuck()
    {
        Flyable = new FlyLikeAnEagle();

        Quackable = new JustQuack();
    }

    public override void Display()
    {
        Debug.Log("I have a green head x)");
    }

}
