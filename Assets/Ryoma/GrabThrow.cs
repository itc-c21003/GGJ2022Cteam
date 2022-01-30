using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabThrow : MonoBehaviour
{
    public Ball Rig;
    public Rigidbody2D Rigid;
    public bool Grad,GR;
    public float Throw = 10f, ThrowUP;
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
                Rig.direction.x = Throw;
                Rig.direction.y += ThrowUP; 
                Rig.Stop = false;
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
