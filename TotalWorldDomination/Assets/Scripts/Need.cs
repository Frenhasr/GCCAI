using UnityEngine;
using System.Collections;


[System.Serializable]
public class Need
{

	private string name;

	[HideInInspector]
	public float lowerBound, upperBound, neutral;

	[Range (0.0f, 1.0f)]
	public float currentVal;


	public float changeRate;

	void Start ()
	{

		//currentVal = Mathf.Abs (currentVal);
	}

	public Need (string name, float currentVal, float changeRate)
	{

		this.name = name;
		this.lowerBound = 0;
		this.upperBound = 1;
		this.neutral = .5f;
		this.currentVal = currentVal;
		this.changeRate = Mathf.Abs (changeRate / 1000);

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



	public string returnName ()
	{

		return name;
	}



		
}
