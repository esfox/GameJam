using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomMove : MonoBehaviour {
        
    public Transform newPos;
    public Text place;
    public GameObject textHolder;
    public string placeName;
    CameraMovement cam;
    public Vector2 minPos;
    public Vector2 maxPos;
	// Use this for initialization
	void Start () {
        cam = FindObjectOfType<CameraMovement>();
        textHolder.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(Tags.Player))
        {
            
            collision.transform.position = newPos.position;
            StartCoroutine(placeNameCo());
            cam.maxPos = this.maxPos;
            cam.minPos = this.minPos;
        }
    }
    
    //play automated animation on area change
    private IEnumerator placeNameCo() {
        textHolder.SetActive(true);
        place.text = placeName;
        yield return new WaitForSeconds(4f);
        textHolder.SetActive(false);
    }
}
