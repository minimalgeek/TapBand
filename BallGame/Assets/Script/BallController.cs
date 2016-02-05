﻿using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

    private BallState state;

    private float countDown;
    private int previousSecond;

    private Rigidbody2D myRigidBody;

    public BallState State
    {
        set
        {
            state = value;
        }
    }

    void Start () {
        countDown = state.ballAliveTime;
        previousSecond = state.ballAliveTime;

        myRigidBody = GetComponent<Rigidbody2D>();
    }
	
	
	void Update () {
        float deltaTime = Time.deltaTime;

        countDown -= deltaTime;
        if (countDown <= 0)
        {
            // TODO : pass BallState
            Debug.Log(state.numberOfSuccessfulTaps);
            Destroy(gameObject);
        }

        if (Input.GetMouseButtonDown(0))
        {
            state.numberOfSuccessfulTaps++;
        }
    }

    void FixedUpdate()
    {
        if ((int)countDown < previousSecond)
        {
            myRigidBody.AddForce(new Vector2(Random.Range(-200, 200), 0));
            previousSecond = (int)countDown;
        }
    }


}
