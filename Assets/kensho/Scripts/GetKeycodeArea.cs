using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKeycodeArea : MonoBehaviour
{
    public string m_keyName = "DefaultKey";
    public GameObject m_keyVisual;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Ghost")
        {
            StageStateRegistry.Instance.AddCollectedKey(m_keyName);
            m_keyVisual.SetActive(false);
            Debug.Log($"Collected Key:{m_keyName}!!");
        }
    }
}
