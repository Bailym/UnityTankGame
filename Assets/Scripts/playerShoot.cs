using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerShoot : MonoBehaviour
{
    public GameObject prefabShot;   //the shot prefab. sphere
    public Transform gunTransform;     //the gun to be shot from
    public float velocity = 1f; //velocity
 

    // Update is called once per frame
    void Update()
    {
        //left mouse press
        if (Input.GetMouseButtonDown(0))
        {
            //create a new shot object
            GameObject newShot = Instantiate(prefabShot, gunTransform.position, gunTransform.rotation);
            newShot.GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * velocity);  //apply a force
        }
        
    }
}
