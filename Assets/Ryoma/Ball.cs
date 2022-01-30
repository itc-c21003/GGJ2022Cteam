using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D Rig;
    bool Stop,Throw;
    Vector2 direction;
    public float ThrowX = 10f, ThrowY;
    public bool Vector
    {
        get { return Throw; }
        set
        {
            if (value)
            {
                direction.x = ThrowX;
                direction.y += ThrowY;
                Stop = false;
            }
            Throw = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if(!Stop) { direction.y -= 3 * Time.deltaTime; }
    }
    private void FixedUpdate()
    {
        Rig.velocity = direction;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "yuka")
        {
            direction.y = 0;           
            Stop = true;
        }
        if(collision.gameObject.tag == "kabe")
        {
            direction.x = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yuka")
        {
            direction.y = 0;
            Stop = true;
        }
        if (collision.gameObject.tag == "kabe")
        {
            direction.x = 0;
        }
    }
}
