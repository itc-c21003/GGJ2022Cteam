using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabThrow : MonoBehaviour
{
    public Rigidbody2D Rig;
    public bool Grad,GR;
    public float Throw = 10f;
    Vector3 force;
    // Start is called before the first frame update
    void Start()
    {
        force = new Vector3(Throw, 0.0f, 0.0f);
    }
    // Update is called once per frame
    void Update()
    {
        if (Grad)
        {
            if (Input.GetKeyDown("a"))
            {
                GR = true;
            }
            if (Input.GetKeyUp("a"))
            {
                GR = false;
                Rig.velocity = force;
            }
        }
    }
    private void FixedUpdate()
    {
        if (GR)
        {
            Rig.position = transform.position;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Throw")
        {
            Grad = true;
            Rig = collision.gameObject.GetComponent<Rigidbody2D>();
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
