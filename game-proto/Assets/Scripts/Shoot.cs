using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public int multiplier = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	    transform.position = new Vector3(transform.position.x, transform.position.y, 0);
	
		if ( Input.GetMouseButtonDown(0)){
			
			RaycastHit hit = new RaycastHit();
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			
			if (Physics.Raycast (ray, out hit, 100.0f)){
				Debug.Log("yo!");
				hit.collider.transform.rigidbody.velocity = hit.collider.transform.rigidbody.velocity * multiplier;
			}
			
		}
		
	}
	
	void OnMouseDown () {
	    Debug.Log("yay");
	}
	
}
