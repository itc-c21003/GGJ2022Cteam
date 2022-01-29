using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMoveFloor : MonoBehaviour
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

    private Vector3 moveVec;
    private int direction = 1;

    void Start()
    {
        var diff = m_point2.position - m_point1.position;
        moveVec = diff / Mathf.Max(diff.x, diff.y);
        transform.position = m_point1.position;
    }

    void Update()
    {
        if (IsActive)
        {
            transform.position += moveVec * m_moveSpeed * direction * Time.deltaTime;
            var goalPoint = direction == 1 ? m_point2 : m_point1;
            if (Vector3.Distance(transform.position, goalPoint.position) <= 0.2)
            {
                direction *= -1;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.SetParent(transform);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.transform.SetParent(null);
        }
    }
}
