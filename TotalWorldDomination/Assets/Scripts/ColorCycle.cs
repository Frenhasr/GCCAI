using UnityEngine;

public class ColorCycle : MonoBehaviour
{
	public float Speed = 1;
	private Light l;

	void Start()
	{
		l = GetComponent<Light>();
	}

	void Update()
	{
		l.color = HSBColor.ToColor(new HSBColor( Mathf.PingPong(Time.time * Speed, 1), 1, 1));
	}
}