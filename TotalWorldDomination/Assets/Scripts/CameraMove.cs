using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour 
{
	public float speed = 5.0f;
	public float rotspeed = 10.0f;
	public float jumpheight = 100.0f;

	public Rigidbody rb;
	public Light light;
	float initialHeight;

	float h;
	float s;
	float v;

	void Start()
	{
		initialHeight = transform.position.y;
	}

	void Update()
	{
		Vector3 pos = transform.position;

		Vector3 right = transform.right;
		Vector3 left = -transform.right;
		Vector3 forward = new Vector3 (transform.forward.x, 0, transform.forward.z);
		Vector3 back = -forward;

		if(Input.GetKey(KeyCode.D))
		{
			transform.position += right * speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.A))
		{
			transform.position += left * speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.W))
		{
			transform.position += forward * speed * Time.deltaTime;
		}
		if(Input.GetKey(KeyCode.S))
		{
			transform.position += back * speed * Time.deltaTime;
		}


		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.RotateAround(pos, Vector3.up, rotspeed);
		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.RotateAround(pos, Vector3.up, -rotspeed);
		}
		/*
		if(Input.GetKey(KeyCode.UpArrow))
		{
			transform.RotateAround(pos, right, -rotspeed);
		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			transform.RotateAround(pos, right, rotspeed);
		}
		*/

		if((Input.GetKeyDown(KeyCode.Space)) && (transform.position.y <= initialHeight + 0.01))
		{
			Color.RGBToHSV(light.color, out h, out s, out v);
			h = h + 20;
			light.color = Color.HSVToRGB(h, s, v);
			print(h);
		}

	}

	void FixedUpdate()
	{
		if((Input.GetKeyDown(KeyCode.Space)) && (transform.position.y <= initialHeight + 0.01))
		{
			rb.AddForce(Vector3.up * jumpheight);
		}
	}
}