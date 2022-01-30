using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recover : MonoBehaviour
{
    public GhostTime ghostTime;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player"|| collision.gameObject.tag == "Ghost")
        {
            ghostTime.Recovery();
        }
    }
}
