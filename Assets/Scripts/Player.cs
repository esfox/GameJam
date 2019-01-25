using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Player : MonoBehaviour
{
    private int objectIndex;
    public int ObjectIndex
    {
        get { return objectIndex; }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag(Tags.Object))
        {
            objectIndex = other.GetComponent<Interactable>().Index;
            Destroy(other.gameObject);
        }
    }
}
