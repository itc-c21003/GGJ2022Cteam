using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameUI : MonoBehaviour
{
    public Text m_spText;
    public Text m_deathCountText;
    public Text m_timerText;

    public GhostTime m_ghostTime;

    // Update is called once per frame
    void Update()
    {
        var spText = m_ghostTime.Ghosttime.ToString("F0");
        m_spText.text = $"SP: {spText}";
        m_deathCountText.text = $"Death: {StageStateRegistry.Instance.DeathCount}";
        var timeText = TimeSpan.FromSeconds(StageStateRegistry.Instance.ElapsedTime).ToString(@"mm\:ss");
        m_timerText.text = $"Time: {timeText}";
    }
}
