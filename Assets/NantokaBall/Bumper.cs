using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {
	public float power = 2000;
	void OnCollisionEnter(Collision c)
	{
		ContactPoint[] cp = c.contacts;
		Vector3 dir = cp[0].point-transform.position;
		c.rigidbody.AddForceAtPosition(dir.normalized*power,c.gameObject.transform.position);

	}
}
