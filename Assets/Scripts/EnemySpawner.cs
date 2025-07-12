using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject spawnObject;
    public float spawnCooldown = 2f;
    float currentSpawnTimer;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentSpawnTimer -= Time.deltaTime;

        if (currentSpawnTimer <= 0)
        {
            Vector3 spawnPosition = transform.position;
            spawnPosition.x = spawnPosition.x + Random.Range(-5, 5);
            spawnPosition.z = spawnPosition.z + Random.Range(-5, 5);
            
            Instantiate(spawnObject, spawnPosition, Quaternion.identity);
            currentSpawnTimer = spawnCooldown;
        }


    }
}
