using System.Collections;
using UnityEngine;

public class StageLoader : MonoBehaviour
{
    public Transform m_playerSpawnPoint;

    // Use this for initialization
    void Start()
    {
        StageStateRegistry.Instance.PlayerSpawnPoint = m_playerSpawnPoint.position;
        Debug.Log("ステージの初期化を完了");
    }

    // Update is called once per frame
    void Update()
    {

    }
}