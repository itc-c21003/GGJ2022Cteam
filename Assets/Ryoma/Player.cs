using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D Rig2D;
    Vector2 direction;
    public float MaxSpeed, JumpPower,Speed;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
    }

    // Update is called once per frame
    void Update()
    {
        if(Rig2D.velocity.magnitude < MaxSpeed)
        {
            direction.x = Input.GetAxis("Horizontal")* Speed;
            Rig2D.AddForce(direction);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yuka")
        {
            if (Input.GetKeyDown("space"))
            {
                Rig2D.AddForce(transform.up * JumpPower, ForceMode2D.Impulse);
            }
        }
    }
}
