using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool puedoSaltar = false;
    private Rigidbody2D rb2d;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            rb2d.velocity = new Vector2(10, rb2d.velocity.y);
        }
        else
        {
            rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;
            rb2d.velocity = new Vector2(-10, rb2d.velocity.y);
        }
         if(Input.GetKeyDown(KeyCode.UpArrow) && puedoSaltar)
        {
            var jump = 30f;
            rb2d.velocity = Vector2.up * jump;
        }
        
    }
     void OnCollisionEnter2D(Collision2D other)
    {
        puedoSaltar = true;
    }
}
