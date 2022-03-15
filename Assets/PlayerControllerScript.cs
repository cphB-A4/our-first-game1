using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour
{
    public float Health = 100f;
    
    public GameObject Enemy;

    public static bool gameOver;

    public GameObject gameOverPanel;

    public void Update(){

    	float distance = Vector3.Distance(transform.position, Enemy.transform.position);

    	if(distance < 2.0f){
            Debug.Log("damage");
            //gives damage to player ... To do
            Health = Health-1;
        }

        if(Health==0){
            Debug.Log("game over");
            gameOver = true;
            gameOverPanel.SetActive(true);
        }

    }
}

