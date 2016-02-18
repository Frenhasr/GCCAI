using UnityEngine;
using System.Collections;

public class CharacterModel : MonoBehaviour {


	[Range(-1.0f, 1.0f)]
	public float hunger, social, sleep;

	public float hungerRate;

	[Range (0.0f, 1.0f)]
	public float deltaAffectOne, deltaAffectTwo, deltaAffectThree;
	

	[Range(-1.0f, 1.0f)]
	public float affectOne, affectTwo, affectThree;

	private int signA1, signA2, signA3;

	public Lunchroom lunchroom;
	public GameObject danceClub;
	 
	

	// Use this for initialization
	void Start () {
		
		signA1 = 1;
		signA2 = -1;
		signA3 = 1;
	}
	
	// Update is called once per frame
	void Update () {


		hunger = Mathf.Clamp (hunger - hungerRate * Time.deltaTime, -1, 1);
		if (hunger < -.5) {
			this.transform.position = lunchroom.transform.position;
			lunchroom.EnterLunchroom (this);

		} else {
			this.transform.position = danceClub.transform.position;
			lunchroom.ExitLunchroom (this);
		}



		affectOne = Mathf.Clamp (affectOne + signA1 * deltaAffectOne * Time.deltaTime, -1, 1);
		affectTwo = Mathf.Clamp (affectTwo + signA2 * deltaAffectTwo * Time.deltaTime, -1, 1);
		affectThree = Mathf.Clamp (affectThree + signA3 * deltaAffectThree * Time.deltaTime, -1, 1);
	}
}
