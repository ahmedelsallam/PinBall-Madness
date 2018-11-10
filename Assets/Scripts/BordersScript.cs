using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BordersScript : MonoBehaviour {


	public BallScript pinball;


	void OnCollisionEnter (Collision other){

		if (other.transform.name == "Pinball") {
			pinball.Reset ();
//			Debug.Log ("resetting lets go again");
		}

	}


}
