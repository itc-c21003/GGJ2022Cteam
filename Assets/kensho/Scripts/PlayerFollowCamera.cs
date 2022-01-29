using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    public Transform m_PhysicalBodyTransform;
    public Transform m_SpiritualBodyTransform;
    public GhostChenger m_ghostChanger;
    public float m_speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void LateUpdate()
    {
        Vector3 targetPos = m_ghostChanger.IsSpiritBody ? m_SpiritualBodyTransform.position : m_PhysicalBodyTransform.position;
        targetPos.z = transform.position.z;
        transform.position = Vector3.Lerp(transform.position, targetPos, m_speed * Time.deltaTime);
    }
}
