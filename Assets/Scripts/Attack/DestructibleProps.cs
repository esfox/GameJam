using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleProps : MonoBehaviour
{
    public int health;
    private Canvas HealthCanvas;
    private void Start()
    {
        
    }

    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void TakeDamage (int damage){

        health -= damage;
        Debug.Log("Hit");
    }
}
