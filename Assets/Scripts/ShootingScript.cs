using UnityEngine;
using UnityEngine.InputSystem;


public class ShootingScript : MonoBehaviour
{
    public GameObject bulletprefab;
    public InputAction shoot;
    public float cooldown = 0.5f;
    float cooldownleft;
    public float bulletspeed = 5f;
    public Animator animator;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shoot.Enable();
    }

    // Update is called once per frame
    void Update()
    {

        cooldownleft -= Time.deltaTime;

        if (shoot.WasPressedThisFrame() && cooldownleft <= 0)
        {
            GameObject bullet = Instantiate(bulletprefab, transform.position, Quaternion.identity);
            Rigidbody bulletRB = bullet.GetComponent<Rigidbody>();
            bulletRB.linearVelocity = transform.forward * bulletspeed;
            cooldownleft = cooldown;
            animator.SetTrigger("shoot");   
        }
        
    }
}