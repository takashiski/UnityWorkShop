using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter(Collider c)
	{
		Destroy (c.gameObject);
	}
}
