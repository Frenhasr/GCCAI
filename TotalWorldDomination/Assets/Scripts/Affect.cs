using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Affect: IComparable<Affect>
{

	private string name;

	[HideInInspector]
	public float lowerBound, upperBound, neutral;

	[Range (-1.0f, 1.0f)]
	public float currentVal;

	public  Affect (string name, float currentVal)
	{

		this.name = name;
		this.lowerBound = 0;
		this.upperBound = 1;
		this.neutral = .5f;
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

	public string returnName ()
	{

		return name; 
	}


	#region IComparable implementation

	public int CompareTo (Affect other)
	{
		if (other == null) {
			return 1;
		} else if (this.currentVal > other.currentVal) {
			return 1;
		} else {
			return 0;
		}

			
	}

	#endregion
}
