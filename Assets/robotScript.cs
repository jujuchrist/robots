using UnityEngine;
using System.Collections;

public class robotScript : MonoBehaviour {

    private float vitesse = 1f; // unite/sec

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        foreach(Transform child in transform)
        {
            if (child.gameObject.tag == "corps")
            {
                Rigidbody2D rb = child.GetComponent<Rigidbody2D>();
                rb.velocity = Vector2.right;
            }
        }
        
	}   
}
