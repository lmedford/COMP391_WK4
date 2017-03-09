using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    // Public Fields
    public float speed;

    // Private fields
    private Rigidbody2D rb;

    // Initialize our variables
    void start()
    {
        rb = GetComponent < Rigidbody2D>();
    }
	// when using physics
	// Update is called once per frame
	void FixedUpdate () 
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        GetComponent<Rigidbody2D>().velocity = movement * speed;

        rb.position = Vector2(Math.Clamp(rb.position.x, -8.0f, 4.0f,)
            Mathf.Clamp(rb.position.y,-4.25f, 4.25f));

        //Move (movement);

        
	}
    /*
    void Move (Vector2 movement)
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        max.x = max.x - 0.225f;
        max.x = max.x + 0.225f;

        min.y = min.y - 0.285f;
        min.y = min.y + 0.285f;

        Vector2 pos = transform.position;

        pos += movement * speed * Time.deltaTime;

        pos.x = Mathf.Clamp(pos.x, min.x, max.x);
        pos.y = Mathf.Clamp(pos.y, min.y, max.y);

        transform.position = pos;   
    } */
    
}
