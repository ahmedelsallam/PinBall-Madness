using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour {

	public int attackingPlayer;
	public GameManagerScript referee;
	public GameObject ceiling;



	void OnCollisionEnter (Collision other){
		if (other.transform.name == "Pinball") {

			referee.GoalScored (attackingPlayer);
			ceiling.SetActive (false);

		}

	}
	//	void OnCollisionExit (Collision col){
	//
	//		if (col.transform.tag != "Map") {
	//			ceiling.SetActive (false);
	//		}
	//	}



}
