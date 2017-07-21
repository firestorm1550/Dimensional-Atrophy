﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Use this for initialization
    
    public Rigidbody playerRB;
    public int speed;
	void Start ()
    {
        playerRB.AddForce(new Vector3(1,1,1));
        ReturnHome();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
            playerRB.velocity = new Vector3(-speed, playerRB.velocity.y, playerRB.velocity.z);
        if (Input.GetKeyUp(KeyCode.W))
            playerRB.velocity = new Vector3(0, playerRB.velocity.y, playerRB.velocity.z);
        if (Input.GetKeyDown(KeyCode.S))
            playerRB.velocity = new Vector3(speed, playerRB.velocity.y, playerRB.velocity.z);
        if (Input.GetKeyUp(KeyCode.S))
            playerRB.velocity = new Vector3(0, playerRB.velocity.y, playerRB.velocity.z);

        if (Input.GetKeyDown(KeyCode.A))
            playerRB.velocity = new Vector3(playerRB.velocity.x, playerRB.velocity.y, -speed);
        if (Input.GetKeyUp(KeyCode.A))
            playerRB.velocity = new Vector3(playerRB.velocity.x, playerRB.velocity.y, 0);
        if (Input.GetKeyDown(KeyCode.D))
            playerRB.velocity = new Vector3(playerRB.velocity.x, playerRB.velocity.y, speed);
        if (Input.GetKeyUp(KeyCode.D))
            playerRB.velocity = new Vector3(playerRB.velocity.x, playerRB.velocity.y, 0);

        if (Input.GetKeyDown(KeyCode.R))
            playerRB.velocity = new Vector3(playerRB.velocity.x, speed, playerRB.velocity.z);
        if (Input.GetKeyUp(KeyCode.R))
            playerRB.velocity = new Vector3(playerRB.velocity.x, 0, playerRB.velocity.z);
        if (Input.GetKeyDown(KeyCode.F))
            playerRB.velocity = new Vector3(playerRB.velocity.x, -speed, playerRB.velocity.z);
        if (Input.GetKeyUp(KeyCode.F))
            playerRB.velocity = new Vector3(playerRB.velocity.x, 0, playerRB.velocity.z);

    }
    private void ReturnHome()
    {
        playerRB.MovePosition(new Vector3(0,25,0));
    }
}
