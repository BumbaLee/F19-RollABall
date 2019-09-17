using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //check every frame for player input and apply that input to the player game object
    //every frame as movement

    public float speed;
    public Text countText; //holds reference to UI text component 
    public Text winText;
    private Rigidbody rb; //create a variable of type Rigidbody
    private int count; //variable to hold the number of pickups weve collected

    void Start(){
        rb= GetComponent<Rigidbody>(); //finds and returns a reference to the rigidbody
        //object in the game, if there is one. in our case, the player (ball)
        count=0;
        SetCountText(); //initializes countText
        winText.text=""; //initializes win text to nothing
    }
    void FixedUpdate(){ //called before performing physics calculations, physics code
    //because our ball moves with physics, this code will use fixedupdate() instead of
    //update()
        float moveHorizontal= Input.GetAxis("Horizontal");
        float moveVertical= Input.GetAxis("Vertical");

        Vector3 movement= new Vector3(moveHorizontal,0.0f,moveVertical);
        rb.AddForce(movement*speed);
        
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Pick Up")){//checks to see if collider is a "pickup"
            other. gameObject.SetActive(false); // deactivates "pickup" collider, 
            //eliminates its presence in the game scene
            count= count + 1; 
            SetCountText();
        }
        else if(other.gameObject.CompareTag("Five Pointer")){
            other.gameObject.SetActive(false);
            count=count+5; 
            SetCountText();
        }
    
    }
    void SetCountText (){
         countText.text= "Count: "+count.ToString();
         if (count>=12){
             winText.text="You Win!";

         }
    }
}
