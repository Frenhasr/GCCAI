using UnityEngine;
using System.Collections;

public class Need
{

	private string name;
	private float lowerBound, upperBound, neutral, currentVal, changeRate;


	public Need (string name, float lowerBound, float upperBound, float neutral, float currentVal, float changeRate)
	{

		this.name = name;
		this.lowerBound = lowerBound;
		this.upperBound = upperBound;
		this.neutral = neutral;
		this.currentVal = currentVal;
		this.changeRate = changeRate;

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

	public void PositiveChange (float v)
	{

		currentVal += v;
	}

	private float ChangeOvertime ()
	{

		return Mathf.Lerp (upperBound, lowerBound, Time.time * changeRate);
	}

	public string returnName ()
	{

		return name;
	}


	void Update ()
	{
		currentVal = ChangeOvertime ();

	}
		
}
