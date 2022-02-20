using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EmemyScript : MonoBehaviour
{
    private NavMeshAgent Mob;

    public GameObject Player;

    public static bool gameOver;

    public GameObject gameOverPanel;

    public float MobDistanceRun = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        Mob = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        //run towards player

        if(distance < MobDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;

            Vector3 newPos = transform.position - dirToPlayer;

            Mob.SetDestination(newPos);
        }

        if(distance < 2.0f){
            Debug.Log("game over");
            //gives damage to player ... To do
            gameOver = true;
            gameOverPanel.SetActive(true);
        }
    }
}
