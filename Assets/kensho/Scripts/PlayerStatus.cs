using System.Collections;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public GameObject m_PlayerRoot;

    private int DeathCount;

    // Use this for initialization
    void Start()
    {
        DeathCount = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void KillPhysical()
    {
        DeathCount++;
        m_PlayerRoot.transform.position = StageStateRegistry.Instance.PlayerSpawnPoint;
        Debug.Log($"プレイヤー（実体）が死亡！ 通算死亡回数:{DeathCount}");
    }
    public void KillSpiritual()
    {
        DeathCount++;
        m_PlayerRoot.transform.position = StageStateRegistry.Instance.PlayerSpawnPoint;
        Debug.Log($"プレイヤー（霊体）が死亡！ 通算死亡回数:{DeathCount}");
    }
}