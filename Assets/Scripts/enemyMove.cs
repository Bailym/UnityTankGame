using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMove : MonoBehaviour
{
    GameObject manager; //need reference to game manager to deduct health.
    private NavMeshAgent meshAgent; //The mesh agent for the enemy
    Transform exit; //the exit/ end of the map

    // Start is called before the first frame update
    void Start()
    {
        //assign components
        meshAgent = GetComponent<NavMeshAgent>();
        exit = GameObject.FindGameObjectWithTag("Exit").transform;
        manager = GameObject.FindGameObjectWithTag("Manager");

    }

    // Update is called once per frame
    void Update()
    {
        meshAgent.SetDestination(exit.position);    //enemy will move towards the exit
    }

    private void OnTriggerEnter(Collider other)
    {
        //if enemy collies with the exit
        if (other.CompareTag("Exit"))
        {
            Destroy(gameObject);
            manager.GetComponent<manager>().loseHealth(1);  //deduct health by calling the game manager function
         
        }

        //if the enemy has been shot, destroy.
        if (other.CompareTag("Shot"))
        {
            Destroy(gameObject);
        }
    }
}
