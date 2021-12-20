using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aimMovement : MonoBehaviour
{
    float xRotation = 0f;
    public Transform pivotTransform;
    public float sensitivity = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {
        //rotation of tank cyclinder follows mouse.
        var pos = Camera.main.WorldToScreenPoint(pivotTransform.position);  
        var dir = Input.mousePosition - pos;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        pivotTransform.rotation = Quaternion.AngleAxis(-angle, Vector3.up);
    }
}
