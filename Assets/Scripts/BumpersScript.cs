using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpersScript : MonoBehaviour {


	public float force;

	public BallScript pinBall;


	void OnCollisionEnter (Collision other){
		if (other.transform.name == "Pinball") {
			pinBall.myRb.velocity = Vector3.forward * force;
		}
	}



}
