using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;
    public int lives;

    public float runSpeed = 20.0f;

    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}