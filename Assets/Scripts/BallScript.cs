using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    public float force;

    public Rigidbody myRb;

    AudioSource ResetBell;

    void Start()
    {

        //randomize which player will get the ball at the start of the game

        ResetBell = GetComponent<AudioSource>();

        myRb = GetComponent<Rigidbody>();
        myRb.AddForce(new Vector3(Random.Range(-20f, 20f), 0, Random.Range(-20f, 20f)));
        myRb.AddTorque(new Vector3(Random.Range(-20f, 20f), Random.Range(-20f, 20f), Random.Range(-20f, 20f)));


    }



    public void Reset()
    {

        //resets the ball position and movement
        myRb.velocity = Vector3.zero;
        transform.position = new Vector3(0, 4f, 0);
        ResetBell.Play();

        //restart the ball
        myRb.AddForce(new Vector3(Random.Range(-20f, 20f), 0, Random.Range(-20f, 20f)));
        myRb.AddTorque(new Vector3(Random.Range(-20f, 20f), Random.Range(-20f, 20f), Random.Range(-20f, 20f)));

    }
}