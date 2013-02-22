using UnityEngine;
using System.Collections;

public class FixedRotation : MonoBehaviour {
	
	public bool xAxis = true;
	public bool yAxis = true;
	public bool zAxis = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rot = transform.eulerAngles;
		rot.x = 90;
		rot.y = 180;
		rot.z = 0;
		//transform.eulerAngles = rot;
	}
}
