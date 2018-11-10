using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

	public AudioSource BumperBell;

	void Start () {

		BumperBell = GetComponent<AudioSource> ();
		
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.gameObject.tag == "Slippery slope") {

			BumperBell.Play ();


		}
	}
	}
