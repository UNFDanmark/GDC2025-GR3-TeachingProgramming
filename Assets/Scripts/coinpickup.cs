using UnityEngine;

public class coinpickup : MonoBehaviour
{
    private GameObject player22;
    private PlayerScript PS;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PS = GameObject.Find("Player").GetComponent<PlayerScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        PS.CoinsCollected += 1;
        
        Destroy(gameObject);
    }
}
