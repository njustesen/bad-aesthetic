using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	
	public int multiplier = 10;
	public int team = 1;
	//public bool hasFlag = false;
	private bool active = false;
	private Vector3 mousePos;

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
				
				if (hit.collider.transform == transform){
					
					active = true;
				
					mousePos = Input.mousePosition;
					
				}
				
			}
			
		}
		
		if(Input.GetMouseButtonUp(0)){
		
			if (active){
			
				active = false;
				
				// Calc distance
				//float dis = Vector3.Distance(Input.mousePosition, transform.position);
				Vector3 v = mousePos - Input.mousePosition;
				
				transform.rigidbody.AddForce(v * multiplier);
				
				
			}
		}
		
	}
	
	void OnCollisionEnter(Collision collision) {
		/*
	    if (collision.gameObject.tag == "Flag"){
			
			hasFlag = true;
			
		}
		
		if (collision.gameObject.tag == "Castle"){
			
			Debug.Log("Wiii1111");
			
			Castle castle = (Castle) collision.gameObject.GetComponent("Castle");
			
			if (castle.team == team && hasFlag){
				
				Debug.Log("Wiii2222");
				
				Destroy(collision.gameObject);
				
			}
			
		}
		*/
		
	}
	
	void OnMouseDown () {
	    Debug.Log("yay");
	}
	
	void OnMouseRelease () {
	    Debug.Log("release");
	}
	
	
}
