using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour {
    //https://github.com/Brackeys/2D-Movement/tree/master/2D%20Movement/Assets
    //add sprite renderer, charactercontroller script, rigidbody2d, box collider 2d, circle collider 2d, player movement script
    //create physics material, 0 friction, apply to player
    public CharacterController2D controller;
    public float runSpeed=40f;
    float horizontalMove=0f;
    bool jump=false;
    bool crouch=false;
    void Update() {
        horizontalMove=Input.GetAxisRaw("Horizontal")*runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump=true;
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch=true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch=false;
        }
    }

    void FixedUpdate(){
        controller.Move(horizontalMove*Time.fixedDeltaTime,crouch,jump); //references Move() in controller
        jump=false;
    }
}