using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public GameObject textBox;
    Text text;
    public bool isActive;
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag(Tags.Player) && 
            Input.GetKeyDown(KeyCode.E) && !isActive)
        {
            textBox.SetActive(true);
            isActive = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && !isActive)
        {
            textBox.SetActive(false);
            isActive = false;
        }
    }
}
