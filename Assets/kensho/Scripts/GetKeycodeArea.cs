using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeycodeArea : MonoBehaviour
{
    public string m_keyName = "DefaultKey";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StageStateRegistry.Instance.AddCollectedKey(m_keyName);
        }
    }
}
