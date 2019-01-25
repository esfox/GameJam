using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerStatus
{
    walk,    
    interact,    
    idle
}

public class Movement : MonoBehaviour {

    public PlayerStatus currentStatus;
    public float speed;
    //public FloatValue currentHealth;
    private Rigidbody2D rb;
    private Vector3 change;
    //Animator anim;
    //public Signal playerHealthSignal;
    //public AudioManager soundFX;

    // Use this for initialization
    void Start() {
        currentStatus = PlayerStatus.walk;
        
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        MoveCharacter();
    }
    
    
    
    
    
    void MoveCharacter()
    {            
        change.Normalize();
                rb.MovePosition(
            transform.position + change * speed * Time.deltaTime);        
    }

    
    
    

    

}

