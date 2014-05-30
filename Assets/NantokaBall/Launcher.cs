using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {
	public GameObject ball;
	public float power = 100f;
	private float p=0f;
	private Vector2 began_pos;
	private Vector2 prev_pos;
	private Vector3 default_pos;
	// Use this for initialization
	void Start () {
		Input.multiTouchEnabled=false;
		default_pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		MouseEvent();
	}
	void TouchEvent()
	{
		Touch[] touches = Input.touches;
		foreach(Touch t in touches)
		{
			if(t.phase == TouchPhase.Began)
			{
				began_pos = t.position;
				prev_pos = t.position;
			}
			else if(t.phase == TouchPhase.Moved)
			{
				Vector2 delta_v=t.position - prev_pos; 
				delta_v.x=0;
				this.gameObject.transform.Translate (delta_v);
				prev_pos = t.position;

			}
			else if(t.phase == TouchPhase.Ended)
			{
				

			}
		}
	}
	void MouseEvent()
	{
/*		if(Input.GetButtonDown("Jump"))
		{
			Instantiate(ball,default_pos,transform.rotation);
		}
		if(Input.GetButton("Jump"))
		{
			transform.Translate(transform.up);
		}
		if(Input.GetButtonUp ("Jump"))
		{
//			transform.Translate(default_pos - transform.position);
		}
*/		if(Input.GetButton("Jump"))
		{
			p+=Time.deltaTime*100;
			Debug.Log(p);
		}
		if(Input.GetButtonUp("Jump"))
		{
			GameObject obj = Instantiate(ball, transform.position + transform.forward, transform.rotation) as GameObject;
			obj.rigidbody.AddForce(transform.forward*(power+Random.value+p),ForceMode.Impulse);
			p=0f;
		}
	}
}
