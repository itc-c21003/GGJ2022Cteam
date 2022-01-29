using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabThrow : MonoBehaviour
{
    public Rigidbody2D Rig;
    public bool Grad;
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
            if (Input.GetKeyDown("x"))
            {
                Rig.gameObject.transform.parent = this.gameObject.transform;
            }
            if(Input.GetKey("x"))
            {
                Rig.position = transform.position;
            }
            else if (Input.GetKeyUp("x"))
            {
                Rig.gameObject.transform.parent = null;
                Grad = false;
                Rig.AddForce(force, ForceMode2D.Impulse);
            }
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
}
