using UnityEditor.UI;
using UnityEngine;

public class bulletbehavior : MonoBehaviour
{
    float despawntime = 5f;
    float timeleft;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timeleft = despawntime;
    }

    // Update is called once per frame
    void Update()
    {
        
        Destroy(gameObject,timeleft);
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            
        }
    }
}
