using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlippersControls : MonoBehaviour {

	public float startPos;
	public float maxPos;
	public float strength;
	public float damper;

    AudioSource flipperSound;

    HingeJoint hinge;
	JointSpring spring = new JointSpring ();




	void Start () {


        flipperSound = GetComponent<AudioSource>();

        //gets the component and make sure that we are using the spring
        hinge = GetComponent<HingeJoint> ();
		hinge.useSpring = true;


		//we set the power and the damper for the spring hinges
		spring.spring = strength;
		spring.damper = damper;

		Reset ();

	}

	public void Bump () {

		//make the flipper does a kick when you click on the button
		spring.targetPosition = maxPos;

		hinge.spring = spring;
		hinge.useLimits = true;
        flipperSound.Play();

    }

	public void Reset (){

		//returns the flipper to its original position after you release your touch
		spring.targetPosition = startPos;


		hinge.spring = spring;
		hinge.useLimits = true;

	}
}
