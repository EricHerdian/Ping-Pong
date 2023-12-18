using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Ball"))
        {
            GameObject.Find("GameManager").GetComponent<Gameplay>().Player2Scored();
        }
    }
}
