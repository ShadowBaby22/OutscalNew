using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rigidbody2d;
    public float speed;
    private float time = 0.0f;
   
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxis("Horizontal") > 0) //checks for input and accesses the Horizontal Axis that in the project settings for unity
        {
            rigidbody2d.velocity = new Vector2(speed, 0f); 
           
           if (speed>=5){
               speed=speed+(1.2f*Time.deltaTime); 
               //rigidbody2d.velocity = new Vector2(speed, 0f); 
            Debug.Log(speed); 
           }
           
        //speed=5f; 
            
            //time = time + Time.fixedDeltaTime;
            //if (time > 0.9f ){
            //rigidbody2d.velocity = new Vector2(speed*2f, 0f);
            //var dir = Input.GetAxis("Horizontal");
            //Debug.Log(dir); 
            //rigidbody2d.velocity = new Vector2(speed * dir * 1.5f,0f);
            //rigidbody2d.AddForce(force); 
        }
            
        else if(Input.GetAxis("Horizontal") < 0) //Negative input (pressed a or left arrow key)
        {
            rigidbody2d.velocity = new Vector2(-speed, 0f);
        }

        else if(Input.GetAxis("Vertical") > 0) 
        {
            rigidbody2d.velocity = new Vector2(0f, speed);
        }

        else if(Input.GetAxis("Vertical") < 0) 
        {
            rigidbody2d.velocity = new Vector2(0f, -speed);
        }

        else if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0)
        {
            //stop
            rigidbody2d.velocity = new Vector2(0f, 0f);
        }


    }

   

 private void OnTriggerEnter2D(Collider2D other) {

     if(other.tag == "Door")
       Debug.Log("Level Complete"); 
 }

}
 
  
