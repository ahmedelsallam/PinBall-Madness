using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellingScript : MonoBehaviour {



	public GameObject ceiling;

//	public bool boxCollider;



	void Start (){


		ceiling.SetActive (false);

		
	}

	void OnCollisionEnter (Collision other){

		if (other.transform.tag == "Map") {

			ceiling.SetActive (true);

//			Debug.Log ("am on the ground");
		}

	}

	void OnCollisionExit (Collision col){

		if (col.transform.tag != "Map") {
			ceiling.SetActive (false);
		}
	}


}
