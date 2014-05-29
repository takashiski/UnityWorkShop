using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {
	public GameObject ball;
	public float power = 100f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Jump"))
		{
			GameObject obj = Instantiate(ball, transform.position + transform.forward, transform.rotation) as GameObject;
			obj.rigidbody.AddForce(transform.forward*(power+Random.value),ForceMode.Impulse);
		}
	}
}
