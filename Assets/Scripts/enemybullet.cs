using UnityEditor.UI;
using UnityEngine;

public class enemybullet : MonoBehaviour
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
        transform.Rotate(0f, 0f, 5f);
        Destroy(gameObject,timeleft);
        
    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            
        }
    }
}