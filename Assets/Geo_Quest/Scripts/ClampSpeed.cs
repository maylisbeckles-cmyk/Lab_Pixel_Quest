using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampSpeed : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(
            Mathf.Clamp(rb.velocity.x, 0f, 30f),
            Mathf.Clamp(rb.velocity.y, 0f, 3f)
        );
    }
}
