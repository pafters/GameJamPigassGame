using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    [SerializeField] GameObject DeadZone;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity; 
        }
        
        if(gameObject.transform.position.x < DeadZone.transform.position.x)
        {
            gameManager.GameOver();
            Debug.Log("DEAD IS WORK");
        }
                
    }

   
    private void OnTriggerEnter2D (Collider2D collision)
    {
        
        if(collision.gameObject.name == "Salo")
        {
            Debug.Log("SALO IS GET");
            Destroy(collision.gameObject);
        }
        
    }
}
