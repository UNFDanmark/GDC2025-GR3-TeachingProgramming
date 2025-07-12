using System;
using UnityEngine;

public class AIEyes : MonoBehaviour
{
    RaycastHit hit;
    bool hitSomething;
    public float sightDistance = 8f;
    public Transform eyes;
    public float cooldown = 0.5f;
    float cooldownleft;
    //bullet
    public GameObject bulletprefab;
    public float bulletspeed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hitSomething = Physics.Raycast(eyes.position, eyes.forward, out hit, sightDistance);

        cooldownleft -= Time.deltaTime;


        if (hitSomething)
        {
            if (hit.transform.CompareTag("Player") && cooldownleft <= 0)
            {
                
                    GameObject bullet = Instantiate(bulletprefab, transform.position, Quaternion.identity);
                    Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
                    bulletRB.linearVelocity = transform.forward * bulletspeed;
                    bulletRB.rotation = Quaternion.LookRotation(eyes.forward)*Quaternion.AngleAxis(90,new Vector3(0,1,0));
                    cooldownleft = cooldown;
                
            }
        }
    }

    void OnDrawGizmos()
    {
        if (hitSomething && hit.transform.CompareTag("Player"))
        {
            Gizmos.color=Color.chartreuse;
        }
        else
        {
            Gizmos.color = Color.red;
        }
        
        Gizmos.DrawRay(eyes.position,eyes.forward*sightDistance);
    }
}
