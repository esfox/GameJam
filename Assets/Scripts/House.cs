using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class House : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.ObjectRetrieved();
    }
}
