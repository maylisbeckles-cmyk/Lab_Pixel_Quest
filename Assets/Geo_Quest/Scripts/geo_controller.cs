using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class geo_controller : MonoBehaviour


{
    public Color color1 = Color.magenta;
    public Color color2 = Color.blue;
    public Color color3 = Color.yellow;

    int hi = 3;
    private string Var2 = "Hello";
    private Rigidbody2D rb;
    public int variable1 = 2;
    public string nextLevel = "Lvl_2";
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
    {
        float xInput = Input.GetAxis("Horizontal");
        xInput *= variable1;
        rb.velocity = new Vector2(xInput, rb.velocity.y);
        //Debug.Log(xInput);

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
                


        }
    }
}
        

   
