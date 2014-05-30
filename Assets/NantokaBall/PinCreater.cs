using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PinCreater : MonoBehaviour {
	public GameObject pin;
	public List<Vector3> list = new List<Vector3>();
	// Use this for initialization
	void Start () {
		foreach(Vector3 v in list)
		{
			Instantiate (pin,v,transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
