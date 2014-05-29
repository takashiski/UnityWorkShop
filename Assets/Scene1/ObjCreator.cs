using UnityEngine;
using System.Collections;

public class ObjCreator : MonoBehaviour {
	public GameObject obj;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			Vector3 v = Input.mousePosition;
			v.z=10f;
			//v.y+=3f;
//			Debug.Log (v);
//			Debug.Log (camera.ScreenToWorldPoint(v));
			GameObject o = Instantiate(obj,camera.ScreenToWorldPoint(v),transform.rotation) as GameObject;
			o.rigidbody.AddForce(transform.forward*10f,ForceMode.Impulse);
			Destroy (o.gameObject,3f);
		}
	}
}
