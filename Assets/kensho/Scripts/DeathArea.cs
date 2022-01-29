using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathArea : MonoBehaviour
{
    public bool m_forPhysical = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            var status = collision.GetComponent<PlayerStatus>();
            if (m_forPhysical)
            {
                status?.KillPhysical();
            }
            else
            {
                status?.KillSpiritual();
            }
        }
    }
}
