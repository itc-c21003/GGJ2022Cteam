using System.Collections;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public GameObject m_PlayerRoot;

    private GhostChenger ghostChenger;

    // Use this for initialization
    void Start()
    {
        ghostChenger = GetComponent<GhostChenger>();
        StageStateRegistry.Instance.DeathCount = 0;
        StageStateRegistry.Instance.ElapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        StageStateRegistry.Instance.ElapsedTime += Time.deltaTime;
    }

    public void KillPhysical()
    {
        if (ghostChenger.IsSpiritBody) return;
        StageStateRegistry.Instance.DeathCount++;
        m_PlayerRoot.transform.position = StageStateRegistry.Instance.PlayerSpawnPoint;
        Debug.Log($"プレイヤー（実体）が死亡！ 通算死亡回数:{StageStateRegistry.Instance.DeathCount}");
    }
    public void KillSpiritual()
    {
        if (!ghostChenger.IsSpiritBody) return;
        ghostChenger.IsSpiritBody = false;
        StageStateRegistry.Instance.DeathCount++;
        m_PlayerRoot.transform.position = StageStateRegistry.Instance.PlayerSpawnPoint;
        Debug.Log($"プレイヤー（霊体）が死亡！ 通算死亡回数:{StageStateRegistry.Instance.DeathCount}");
    }
}