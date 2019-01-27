using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Player : MonoBehaviour
{
    private int objectIndex = -1;
    public int ObjectIndex
    {
        get { return objectIndex; }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(Tags.Object))
            GetObject(other.gameObject);
    }

    private void GetObject(GameObject other)
    {
        Part part = other.GetComponent<Part>();
        if(!part) return;

        objectIndex = other.GetComponent<Part>().Number;
        Destroy(other);
    }
}
