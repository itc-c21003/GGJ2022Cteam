using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpPower, Speed;
    public float m_sprintSpeed;
    public float m_gravityScale = 1.0f;
    public float m_groundCheckDistance = 0.2f;
    public Transform m_groundCheckStartPos;
    public Animator anim;
    private Vector2 direction;
    private Rigidbody2D rig2d;
    Vector2 Rot;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        rig2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var speed = Input.GetKey(KeyCode.LeftShift) ? m_sprintSpeed : Speed;
        direction.x = Input.GetAxis("Horizontal") * speed;
        direction.y = rig2d.velocity.y;
        if(direction.x != 0)
        {
            anim.SetTrigger("run");
        }        
        if(direction.x == 0)
        {
            anim.SetTrigger("idol");
        }
        if (IsGrounded())
        {
            if (Input.GetKeyDown("space"))
            {
                direction.y = JumpPower;
            }
        }
        rig2d.velocity = direction;
    }

    public bool IsGrounded()
    {
        var hits = Physics2D.RaycastAll(m_groundCheckStartPos.position, Vector2.down, m_groundCheckDistance);
        foreach (var hit in hits)
        {
            if (!hit.collider.isTrigger)
            {
                return true;
            }
        }
        return false;
    }
}
