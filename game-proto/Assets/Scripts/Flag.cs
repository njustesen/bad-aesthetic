using UnityEngine;
using System.Collections;

public class Flag : MonoBehaviour {
	
	private GameObject holder;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (holder != null){
		
			gameObject.transform.position = holder.transform.position;
			
		}
		
	}
	
	void OnTriggerEnter (Collider other) {
		
		if (other.gameObject.tag == "Unit"){
			/*
			Shoot shoot = (Shoot) other.gameObject.GetComponent("Shoot");
			
			shoot.hasFlag = true;
			*/
			holder = other.gameObject;
			
		}
		
		Debug.Log(other.gameObject.tag);
		
		if (other.gameObject.tag == "Castle"){
			
			Debug.Log("Wraaa");
			
			Destroy(other.gameObject);
			
			Destroy(gameObject);
			
			holder = null;
			
		}
		
		
	}
		
}
