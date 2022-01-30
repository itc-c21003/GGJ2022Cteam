using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabThrow : MonoBehaviour
{
    Ball Rig;
    Rigidbody2D Rigid;
    bool Grad,GR;   
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (Grad)
        {
            if (Input.GetKeyDown("x"))
            {
                GR = true;
            }
            if (Input.GetKeyUp("x"))
            {
                GR = false;
                Rig.Vector = true;
            }
        }
    }
    private void FixedUpdate()
    {
        if (GR)
        {
            Rigid.position = transform.position;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Throw")
        {
            Grad = true;
            Rig = collision.gameObject.GetComponent<Ball>();
            Rigid = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Throw")
        {
            Grad = false;
        }
    }
}
