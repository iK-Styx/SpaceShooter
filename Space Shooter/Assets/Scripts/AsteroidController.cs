using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour {
	public GameObject explosion; 

	void OnTriggerEnter (Collider other){
		var myHealth = other.GetComponent<Health>(); 
		if (myHealth != null) {			
			myHealth.TakeDamage (10); 
		}	
		Instantiate (explosion, transform.position, transform.rotation); 
		Destroy (gameObject); 
	}
}
