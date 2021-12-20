using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //destroy shot after 2 seconds to stop high memory usage
        Destroy(gameObject, 2);
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
