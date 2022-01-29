using System.Collections;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public GameObject m_PlayerRoot;

    private int deathCount;
    private GhostChenger ghostChenger;

    // Use this for initialization
    void Start()
    {
        deathCount = 0;
        ghostChenger = GetComponent<GhostChenger>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void KillPhysical()
    {
        if (ghostChenger.IsSpiritBody) return;
        deathCount++;
        m_PlayerRoot.transform.position = StageStateRegistry.Instance.PlayerSpawnPoint;
        Debug.Log($"プレイヤー（実体）が死亡！ 通算死亡回数:{deathCount}");
    }
    public void KillSpiritual()
    {
        if (!ghostChenger.IsSpiritBody) return;
        ghostChenger.IsSpiritBody = false;
        deathCount++;
        m_PlayerRoot.transform.position = StageStateRegistry.Instance.PlayerSpawnPoint;
        Debug.Log($"プレイヤー（霊体）が死亡！ 通算死亡回数:{deathCount}");
    }
}