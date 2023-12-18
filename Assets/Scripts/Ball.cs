using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool isStart;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public AudioSource audioSrc;
    public AudioClip scoreAudio;

    private void Start() {
        startPosition = transform.position;
        isStart = true;
        audioSrc.clip = scoreAudio;
    }

    private void Update() {
        if((Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Vertical2") != 0) && isStart == true)
        {
            Launch();
            isStart = false;
        }
    }

    private void Launch() {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset() {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        isStart = true;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        audioSrc.Play();
    }
}
