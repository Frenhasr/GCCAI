using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

	public Transform rightDoor;
	public Transform leftDoor;
	public float openAmt;
	public float seconds;

	bool hasOpened = false; 
	bool opendoors = false;
	float startTime;
	Vector3 rightStartPos;
	Vector3 leftStartPos;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (opendoors == true) {
			rightDoor.position = Vector3.Lerp(rightStartPos, rightStartPos + new Vector3 (0, 0, openAmt), (Time.time - startTime)/seconds);
			leftDoor.position = Vector3.Lerp(leftStartPos, leftStartPos - new Vector3 (0, 0, openAmt), (Time.time - startTime)/seconds);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (hasOpened == false) {
			opendoors = true;
			startTime = Time.time;
			rightStartPos = rightDoor.position;
			leftStartPos = leftDoor.position;
			hasOpened = true;
		}
	}

}
