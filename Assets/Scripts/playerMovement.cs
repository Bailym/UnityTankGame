using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public CharacterController controller;  //controller
    public float speed = 0.5f;  //speed
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();    //assign
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //axis values
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        //create movement vector
        Vector3 movement = horizontalMovement * transform.right + verticalMovement * transform.forward;

        controller.Move(speed * movement);  //apply movement

    }

    private void OnCollisionEnter(Collision collision)
    {
        //ignore collisions with enemy
        if (collision.rigidbody.CompareTag("Enemy"))
        {
            Collider characterController = GetComponent<CharacterController>();
            Collider otherCollider = collision.collider;
            Physics.IgnoreCollision(characterController, otherCollider);
        }
    }
}
