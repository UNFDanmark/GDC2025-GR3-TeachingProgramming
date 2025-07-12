using System;
using UnityEngine;

public class AIEyes : MonoBehaviour
{
    RaycastHit hit;
    bool hitSomething;
    public float sightDistance = 8f;
    public Transform eyes;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hitSomething = Physics.Raycast(eyes.position, eyes.forward, out hit, sightDistance);




        if (hitSomething)
        {
            if (hit.transform.CompareTag("Player"))
            {
                print("hey buddy");
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
