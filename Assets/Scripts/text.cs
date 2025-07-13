using System.Net.Mime;
using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{

    

    public TextMeshProUGUI current_health;
    PlayerScript PsS;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PsS = GameObject.FindWithTag("Player").GetComponent<PlayerScript>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        current_health.text = "Health:" + PsS.currentHealth+"/"+PsS.health;
    }
}
