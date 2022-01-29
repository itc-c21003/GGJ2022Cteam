using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public string m_requiredKeyName = "DefaultKey";
    public GameObject m_doorSprite;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && StageStateRegistry.Instance.IsKeyCollected(m_requiredKeyName))
        {
            m_doorSprite?.SetActive(false);
        }
        else
        {
            // TODO: ƒƒbƒN‚³‚ê‚Ä‚é‚Ì‰¹‚ğÄ¶
        }
    }
}
