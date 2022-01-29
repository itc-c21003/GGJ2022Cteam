using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathArea : MonoBehaviour
{
    public bool m_forPhysical = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && m_forPhysical)
        {
            collision.GetComponent<PlayerStatus>()?.KillPhysical();
        }else if (collision.tag == "Ghost" && !m_forPhysical)
        {
            collision.gameObject.GetComponentInParent<PlayerStatus>()?.KillSpiritual();
        }
    }
}
