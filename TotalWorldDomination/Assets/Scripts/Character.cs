using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;

public class Character : MonoBehaviour
{
	[Header ("Identity")]

	#region Character Identitty

	public string characterName;
	public int characterAge;

	#endregion



	[Header ("Needs")]
	#region Needs

	public Need friendship;
	public Need enmity;
	public Need competition;
	public Need lust;
	public Need greed;
	public Need mentorship;


	private Dictionary<string, Need> needs = new Dictionary<string, Need> ();

	#endregion

	[Header ("Affects")]

	#region Affects

	public Affect boredomToInterest;
	public Affect sadToJoy;
	public Affect supriseToCalm;
	public Affect distressToAmused;
	public Affect angerToCheers;
	public Affect disgustToLove;
	public Affect shameToPride;
	public Affect fearToHope;

	private Affect highestAffect = null;

	public string currentAffect;
	private Dictionary<string, Affect> affects = new Dictionary<string, Affect> ();

	[Header ("Affect Multipliers")]
	[Range (0.0f, 1.0f)]
	public float boredom;
	[Range (0.0f, 1.0f)]
	public float sadness;
	[Range (0.0f, 1.0f)]
	public float enjoyment;
	[Range (0.0f, 1.0f)]
	public float surprise;
	[Range (0.0f, 1.0f)]
	public float calm;
	[Range (0.0f, 1.0f)]
	public float distress;
	[Range (0.0f, 1.0f)]
	public float amusement;
	[Range (0.0f, 1.0f)]
	public float anger;
	[Range (0.0f, 1.0f)]
	public float cheer;
	[Range (0.0f, 1.0f)]
	public float disgust;
	[Range (0.0f, 1.0f)]
	public float love;
	[Range (0.0f, 1.0f)]
	public float shame;
	[Range (0.0f, 1.0f)]
	public float pride;
	[Range (0.0f, 1.0f)]
	public float fear;
	[Range (0.0f, 1.0f)]
	public float hope;
	[Range (0.0f, 1.0f)]
	public float interest;


	#endregion



	// Use this for initialization
	void Start ()
	{
		friendship = new Need ("friendship", friendship.currentVal, friendship.changeRate);
		enmity = new Need ("enmity", enmity.currentVal, enmity.changeRate);
		competition = new Need ("competition", competition.currentVal, competition.changeRate);
		lust = new Need ("lust", lust.currentVal, lust.changeRate);
		greed = new Need ("greed", greed.currentVal, greed.changeRate);
		mentorship = new Need ("mentorship", mentorship.currentVal, mentorship.changeRate);


		#region Initializing Needs Dicitonary

		needs.Add ("friendship", friendship);
		needs.Add ("enmity", enmity);
		needs.Add ("competition", competition);
		needs.Add ("lust", lust);
		needs.Add ("greed", greed);
		needs.Add ("mentorship", mentorship);

		#endregion



		boredomToInterest = new Affect ("boredomToInterest", boredomToInterest.currentVal);
		sadToJoy = new Affect ("sadToJoy", sadToJoy.currentVal);
		supriseToCalm = new Affect ("supriseToCalm", supriseToCalm.currentVal);
		distressToAmused = new Affect ("distressToAmused", distressToAmused.currentVal);
		angerToCheers = new Affect ("angerToCheers", angerToCheers.currentVal);
		disgustToLove = new Affect ("disgustToLove", disgustToLove.currentVal);
		shameToPride = new Affect ("shameToPride", shameToPride.currentVal);
		fearToHope = new Affect ("fearToHope", fearToHope.currentVal);

		#region Initializing Affects Dictionary

		affects.Add ("boredomToInterest", boredomToInterest);
		affects.Add ("sadToJoy", sadToJoy);
		affects.Add ("supriseToCalm", supriseToCalm);
		affects.Add ("distressToAmused", distressToAmused);
		affects.Add ("angerToCheers", angerToCheers);
		affects.Add ("disgustToLove", disgustToLove);
		affects.Add ("shameToPride", shameToPride);
		affects.Add ("fearToHope", fearToHope);

		#endregion;

	}
	
	// Updat	e is called once per frame
	void Update ()
	{
	
		foreach (KeyValuePair<string,Need> entry in needs) {


			entry.Value.currentVal = Mathf.Clamp (entry.Value.currentVal - (entry.Value.changeRate * Time.deltaTime), 0, 1);
		}

		returnHighestAffect ();



	}


	public void returnHighestAffect ()
	{
		

		foreach (KeyValuePair<string, Affect> a in affects) {
			if (a.Value.CompareTo (highestAffect) == 1) {
				
				highestAffect = a.Value;
			}
		}

		currentAffect = highestAffect.returnName ();
		
	}

	public void changeAffect (TRAIT a)
	{
		switch (a) {

		case TRAIT.isBoredBy:
			affects ["boredomToInterest"].ValueChange (-boredom);
			break;
		case TRAIT.isInterestedIn:
			affects ["boredomToInterest"].ValueChange (interest);
			break;
		case TRAIT.isSaddenedBy:
			affects ["sadToJoy"].ValueChange (-sadness);
			break;
		case TRAIT.enjoys:
			affects ["sadToJoy"].ValueChange (enjoyment);
			break;
		case TRAIT.isDistressedBy:
			affects ["distressToAmused"].ValueChange (-distress);
			break;
		case TRAIT.isAmusedBy:
			affects ["distressToAmused"].ValueChange (amusement);
			break;
		case TRAIT.isAngeredBy:
			affects ["angerToCheers"].ValueChange (-anger);
			break;
		case TRAIT.isCheeredBy:
			affects ["angerToCheers"].ValueChange (amusement);
			break;
		case TRAIT.isDisgustedBy:
			affects ["disgustToLove"].ValueChange (-disgust);
			break;
		case TRAIT.loves:
			affects ["disgustToLove"].ValueChange (love);
			break;
		case TRAIT.isAshamedBy:
			affects ["shameToPride"].ValueChange (-shame);
			break;
		case TRAIT.isProudOf:
			affects ["shameToPride"].ValueChange (pride);
			break;
		case TRAIT.isAfraidOf:
			affects ["fearToHope"].ValueChange (-fear);
			break;
		case TRAIT.hopesFor:
			affects ["fearToHope"].ValueChange (hope);
			break;




		}
	

	}



}
