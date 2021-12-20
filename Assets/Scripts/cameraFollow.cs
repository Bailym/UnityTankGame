using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //camera transfrom postion above the player slighly in front
        gameObject.GetComponent<Transform>().position = new Vector3(playerTransform.position.x, playerTransform.position.y + 5, playerTransform.position.z + 0.5f);
        
    }
}
