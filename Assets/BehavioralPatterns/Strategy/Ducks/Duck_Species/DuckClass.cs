using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DuckClass
{
	public IFlyable Flyable;

	public IQuackable Quackable;

	public void PerformFly()
    {
		Flyable.Fly();
	}
	public void PerformQuack()
	{
		Quackable.Quack();
	}
	public abstract void Display();

	public void Swim() 
	{
		Debug.Log("I can able to swim");
	}
}
