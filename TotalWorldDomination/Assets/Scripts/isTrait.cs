using UnityEngine;
using System.Collections;

public class isTrait : MonoBehaviour
{
	public Character c;
	public string traitString;
	private TRAIT t;

	// Use this for initialization
	void Start ()
	{
		if (traitString.Equals (TRAIT.isBoredBy.ToString ()))
			t = TRAIT.isBoredBy;
		if (traitString.Equals (TRAIT.isInterestedIn.ToString ()))
			t = TRAIT.isInterestedIn;
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void returnTrait ()
	{
		c.changeAffect (t);
	}
}
