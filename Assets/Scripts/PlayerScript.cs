using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody rb;
    public int health = 10;
    public int currentHealth;
    public int dih = 14;
    string navn = "Wilson";
    bool has_erection = true;
    public float speed = 20f;
    public float dihCooldown = 1;
    public int CoinsCollected;
    public InputAction moveAction;
    public Animator animator;
    public GameObject gameOverScreen;
    public InputAction restartAction;

    public GameObject Health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverScreen.SetActive(false);
        rb.GetComponent<Rigidbody>();
        moveAction.Enable();
        currentHealth = health;

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 moveInput = moveAction.ReadValue<Vector2>();

        Vector3 newVelocity = rb.linearVelocity;

        newVelocity.x = moveInput.x * speed;
        newVelocity.z = moveInput.y * speed;

        rb.linearVelocity = newVelocity;
        // Animation kode går under her (efter movement kode)
        animator.SetFloat("Speed", rb.linearVelocity.magnitude);

        
        
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            currentHealth -= 1;
            if (currentHealth <= 0)
            {
                Health.SetActive(false);
                gameOverScreen.SetActive(true);
            }
        }
    }
}
 