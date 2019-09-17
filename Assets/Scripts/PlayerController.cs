﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //check every frame for player input and apply that input to the player game object
    //every frame as movement

   public float speed;
    private Rigidbody rb; //create a variable of type Rigidbody

    void Start(){
        rb= GetComponent<Rigidbody>(); //finds and returns a reference to the rigidbody
        //object in the game, if there is one. in our case, the player (ball)
    }
    void FixedUpdate(){ //called before performing physics calculations, physics code
    //because our ball moves with physics, this code will use fixedupdate() instead of
    //update()
        float moveHorizontal= Input.GetAxis("Horizontal");
        float moveVertical= Input.GetAxis("Vertical");

        Vector3 movement= new Vector3(moveHorizontal,0.0f,moveVertical);
        rb.AddForce(movement*speed);
        
    }
}