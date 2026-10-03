using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geo_controller : MonoBehaviour
{int hi = 3;
    private string Var2 = "Hello";
    private Rigidbody2D rb;
    // Start is called before the first frame update
   
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>();
        Debug.Log(Var2 + "World");
        Debug.Log(transform.position);
        Var2 = "Goodbye";
        Debug.Log(Var2 + "World");
    }

    // Update is called once per frame
    void Update()

    {   if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector2(-1, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity = new Vector2(1, rb.velocity.x);
        }
        
        /*
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);

        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);

        }

        Debug.Log(hi);
        (hi)++;
        */
    }
} 
