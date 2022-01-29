using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D Rig2D;
    Vector2 direction;
    public float MaxSpeed, JumpPower,Speed, Gravity;
    public bool Jump;
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
        }
        Rig2D.velocity = direction;
        if (!Jump)
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log(Jump);
                direction.y = JumpPower;
                Jump = true;
            }
        }
        if (Jump)
        {
            direction.y -= Gravity;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yuka")
        {
            Jump = false;
        }
    }
}
