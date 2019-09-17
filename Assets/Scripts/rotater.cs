using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotater : MonoBehaviour
{
    //spins the collectable item

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(45,0,0)*Time.deltaTime);
    }
}
