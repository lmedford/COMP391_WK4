using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour {
    // Public fields 
    public float speed = 10;
    // Private fields
    private Rigidbody2
	// Use this for initialization
	void Start () 
    {
		rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right;
	}
	

}
