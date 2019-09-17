using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //at start of game, establish distance between camera and player and apply
        //to a variable
        offset= transform.position - player.transform.position;
    }

    // use LateUpdate() instead of Update() because it requires player to move before
    //making changes. Otherwise, camera position will keep changing, even if player 
    //stands still
    void LateUpdate()
    {
        //for every frame, add the offset to the player position to maintain 
        //steady camera position
        transform.position=player.transform.position+offset;
    }
}
