using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DuckType
{
    Rubber,
    Mallar,
    RedHead,
    Decoy
}

public class DuckTest : MonoBehaviour
{
    public DuckType NewDuckType;

    private DuckClass _newDuck;

    private void Start()
    {
        _newDuck = new MallarDuck();
    }

    private void DecideDuck(DuckType duckType)
    {
        switch (duckType)
        {
            case DuckType.Rubber:
                _newDuck = new RubberDuck();
                break;
            case DuckType.Mallar:
                _newDuck = new MallarDuck();
                break;
            case DuckType.RedHead:
                _newDuck = new RedHeadDuck();
                break;
            case DuckType.Decoy:
                _newDuck = new DecoyDuck();
                break;
            default:
                break;
        }
    }

    [ContextMenu("ActionDuck")]
    public void DuckAction()
    {
        DecideDuck(NewDuckType);

        _newDuck.PerformFly();
        _newDuck.PerformQuack();
        _newDuck.Swim();
        _newDuck.Display();
    }
}
