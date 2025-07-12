using System;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public int health = 10;
    public int Currenthealth;
    //public Transform player;
    public float Espeed = 5f;

    public NavMeshAgent agent;
    GameObject playerTarget;
    
    //private GameObject player11;

    //private Vector3 wayPointPos;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Currenthealth = health;
        //player11 = GameObject.Find("Player");
        playerTarget = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //wayPointPos = new Vector3(player11.transform.position.x, transform.position.y, player11.transform.position.z);
        //transform.position = Vector3.MoveTowards(transform.position, wayPointPos, Espeed * Time.deltaTime);

        agent.SetDestination(playerTarget.transform.position);
        
        
        if (Currenthealth <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Currenthealth -= 1;
            
        }
    }
    
    
}
