using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearPingPongMove : MonoBehaviour, IHasActive
{
    public bool m_isActive = true;
    public Transform m_point1;
    public Transform m_point2;
    public float m_moveSpeed = 1.0f;

    public bool IsActive
    {
        get
        {
            return m_isActive;
        }
        set
        {
            m_isActive = value;
        }
    }

    private Vector2 moveVec;
    private int direction = 1;
    private Rigidbody2D rig2d;

    void Start()
    {
        rig2d = GetComponent<Rigidbody2D>();
        var diff = m_point2.position - m_point1.position;
        var vec3 = diff / Mathf.Max(diff.x, diff.y);
        moveVec = new Vector2(vec3.x, vec3.y);
        transform.position = m_point1.position;
    }

    void Update()
    {
        if (IsActive)
        {
            rig2d.velocity = moveVec * m_moveSpeed * direction;
            var goalPoint = direction == 1 ? m_point2 : m_point1;
            if (Vector3.Distance(transform.position, goalPoint.position) <= 0.3)
            {
                direction *= -1;
            }
        }
        else
        {
            rig2d.velocity = Vector2.zero;
        }
    }
}
