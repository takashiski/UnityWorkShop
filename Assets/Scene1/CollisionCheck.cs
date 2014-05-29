using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

	void OnCollisionEnter(Collision c)
	{
		c.gameObject.renderer.material.color = new Color(Random.value,Random.value,Random.value,1f);

	}

}
