using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public GameObject textBox;
    public Text text;
    public string Dialogue;
    
    // Start is called before the first frame update
    void Start()
    {
        textBox.SetActive(false);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }    

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.CompareTag(Tags.Player) && Input.GetKeyDown(KeyCode.E) && !textBox.activeInHierarchy)
        {
            textBox.SetActive(true);
            text.text = Dialogue;            
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.Player) && textBox.activeInHierarchy)
        {
            textBox.SetActive(false);
        }


    }
}
