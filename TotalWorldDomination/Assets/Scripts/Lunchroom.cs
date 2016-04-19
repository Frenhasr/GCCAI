using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lunchroom : MonoBehaviour {

	public List<CharacterModel> characters = new List<CharacterModel>();
	public float foodRate;

	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
		foreach (CharacterModel c in characters) {

			c.hunger += foodRate;
		}



	}

	public void EnterLunchroom(CharacterModel c){

		characters.Add (c);

	}

	public void ExitLunchroom(CharacterModel c){

		characters.Remove (c);
	}
}
