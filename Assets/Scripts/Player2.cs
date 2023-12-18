using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float movement;

    private void Start() {
        startPosition = transform.position;
    }

    private void Update() {
        movement = Input.GetAxisRaw("Vertical2");
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset() {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
