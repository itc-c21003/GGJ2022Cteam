using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D Rig2D;
    Vector2 direction;
    public float JumpPower,Speed, Gravity;
    public bool Jump;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        Jump = true;
    }

    // Update is called once per frame
    void Update()
    {

        direction.x = Input.GetAxis("Horizontal")* Speed;
        
        if (!Jump)
        {
            if (Input.GetKeyDown("space"))
            {
                direction.y = JumpPower;
            }
        }
        if (Jump)
        {
            direction.y -= Gravity *Time.deltaTime;
        }
    }
    private void FixedUpdate()
    {
        Rig2D.velocity = direction;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yuka")
        {
            Jump = false;
            direction.y = 0;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "yuka")
        {
            Jump = true;
        }
    }
}
