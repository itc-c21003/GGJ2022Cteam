using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D Rig;
    public bool Stop;
    public Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!Stop) { direction.y -=  3*Time.deltaTime; }
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
}
