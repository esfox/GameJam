using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomMove : MonoBehaviour {


    
    public Transform newPos;
    
    
    public string placeName;    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            collision.transform.position = newPos.position;
            
                //StartCoroutine(placeNameCo());
          
        }
    }
    /*
    private IEnumerator placeNameCo() {
        text.SetActive(true);
        placeText.text = placeName;
        yield return new WaitForSeconds(4f);
        text.SetActive(false);

    }*/
}
