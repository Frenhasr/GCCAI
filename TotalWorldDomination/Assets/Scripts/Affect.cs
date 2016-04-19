using UnityEngine;
using System.Collections;

public class Affect
{

	private string name;
	private float lowerBound, upperBound, neutral, currentVal;

	public  Affect (string name, float lowerBound, float upperBound, float neutral, float currentVal)
	{

		this.name = name;
		this.lowerBound = lowerBound;
		this.upperBound = upperBound;
		this.neutral = neutral;
		this.currentVal = currentVal;

	}

	public float LowerBound ()
	{

		return lowerBound;

	}

	public float UpperBound ()
	{
		return upperBound;

	}

	public float NeutralBound ()
	{

		return neutral;
	}


	public float CurrentVal ()
	{

		return currentVal;
	}


	public void ValueChange (float v)
	{

		currentVal += v;


	}


}
