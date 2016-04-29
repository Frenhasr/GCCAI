using UnityEngine;
using System.Collections;
using System.Collections.Generic;



//Return the highest affect as a public function
//

public enum GENDER
{
	Female = 0,
	Genderqueer = 1,
	Intersex = 2,
	Male = 3,
	Transgender = 4,
	Transsexual = 5,
	CrossDresser = 6,
	FTM = 7,
	MTF = 8,
	Other = 9}

;

//public enum TRAIT
//{
//	isBoredBy,
//	isInterestedIn,
//	isSaddenedBy,
//	enjoys,
//	isSurprisedBy,
//	isCalmedBy,
//	isDistressedBy,
//	isAmusedBy,
//	isAngeredBy,
//	isCheeredBy,
//	isDisgustedBy,
//	loves,
//	isAshamedBy,
//	isProudOf,
//	isAfraidOf,
//	hopesFor}
//;




public class AffectManager : MonoBehaviour
{



	#region Character Identity

	public string characterName;
	public int characterAge;

	#endregion





	#region Needs

	[Range (0.0f, 1.0f)]
	public float friendship;

	[Range (0.0f, 1.0f)]
	public float enmity;

	[Range (0.0f, 1.0f)]
	public float competition;

	[Range (0.0f, 1.0f)]
	public float lust;

	[Range (0.0f, 1.0f)]
	public float greed;

	[Range (0.0f, 1.0f)]
	public float mentorship;

	#endregion





	#region Affect

	[Range (-1.0f, 1.0f)]
	public float boredomToInterest;

	[Range (-1.0f, 1.0f)]
	public float sadToJoy;

	[Range (-1.0f, 1.0f)]
	public float supriseToCalm;

	[Range (-1.0f, 1.0f)]
	public float distressToAmused;

	[Range (-1.0f, 1.0f)]
	public float angerToCheers;

	[Range (-1.0f, 1.0f)]
	public float disgustToLove;

	[Range (-1.0f, 1.0f)]
	public float shameToPride;

	[Range (-1.0f, 1.0f)]
	public float fearToHope;

	#endregion

	//-----------Affect Multipliers----------------------------



	#region Affect Multipliers

	public float boredom;
	public float interest;
	public float sadness;
	public float enjoyment;
	public float surprise;
	public float calm;
	public float distress;
	public float amusement;
	public float anger;
	public float cheer;
	public float disgust;
	public float love;
	public float shame;
	public float pride;
	public float fear;
	public float hope;

	#endregion


	public int deltaAffect;


	public List<string> characterTraits;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public string dominantAffect ()
	{

		return friendship.ToString ();
	}
}
