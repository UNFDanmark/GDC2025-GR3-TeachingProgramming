using UnityEngine;

public class coinpickup : MonoBehaviour
{
    private GameObject player22;
    private PlayerScript PS;
    float EEE;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PS = GameObject.Find("Player").GetComponent<PlayerScript>();
        EEE = Random.Range(0.9f,1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, -0.6f);
        transform.position = new Vector3(transform.position.x,((Mathf.Sin(Time.time*EEE*3)+1)/7),transform.position.z);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        PS.CoinsCollected += 1;
        
        Destroy(gameObject);
    }
}
