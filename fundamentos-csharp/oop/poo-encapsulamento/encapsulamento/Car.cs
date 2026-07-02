using System;

public class Car
{
	private int speed;
	public int Speed
	{ 
		get => speed;
		set => speed = value;
	}
	public void Accelerate() // public method
	{
		speed += 20;
	}
	
}
