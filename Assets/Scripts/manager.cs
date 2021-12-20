using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public GameObject spawner;  //the gameobject where the enemy spawns
    public int roundNumber = 1; //current round
    public int maxHealth = 100; //max health
    public int remainingHealth = 100;   //remaining health
    public List<GameObject> enemies = new List<GameObject>();   //a list of avaiable enemies
    public Text UIText; //the UI Text component
    // Start is called before the first frame update
    void Start()
    {
        //defauklt UI text
        UIText.text = "Round: " + roundNumber + "\nHealth: " + remainingHealth + "/" + maxHealth;
        StartCoroutine(Wave(5));    //start the first wave

    }

    //wave with n amount of enemies
    IEnumerator Wave(int n)
    {
        //spawn n enemies
        for (int i = 0; i < n; i++)
        {
            Instantiate(enemies[0], spawner.transform.position, spawner.transform.rotation);
        }

        //Wait for n seconds (cap this at a sensible value)
        yield return new WaitForSeconds(n);
        //increment UI counter
        UIText.text = "Round: " + roundNumber++ + "\nHealth: " + remainingHealth + "/" + maxHealth;
        //increase n by 20%
        float next = Mathf.RoundToInt((float)n *1.2f);
        StartCoroutine(Wave((int)next));    //recursive call next wave

    }

    public void loseHealth(int damage)
    {
        remainingHealth -= damage;  //remove damage from health

        //if health is 0 or less
        if (remainingHealth <= 0)
        {
            //reload the game (end screen here at some point)
            SceneManager.LoadScene("Level 1");
        }
        //update the UI label
        UIText.text = "Round: " + roundNumber + "\nHealth: " + remainingHealth + "/" + maxHealth;
    }


}
