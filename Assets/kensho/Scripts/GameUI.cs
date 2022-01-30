using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public Text m_spText;
    public Text m_deathCountText;
    public Text m_timerText;

    public GameObject m_resultPanel;
    public Text m_resultDeathCountText;
    public Text m_resultTimerText;
    public Text m_resultTotalSpiritTimeText;
    public Button m_resultRestartButton;

    public GhostTime m_ghostTime;

    private bool showResults = false;
    public bool ShowResults
    {
        get
        {
            return showResults;
        }
        set
        {
            showResults = value;
            Time.timeScale = value ? 0f : 1f;
            m_resultPanel.SetActive(value);
            if (value) ApplyResults();
        }
    }

    private void Start()
    {
        m_resultRestartButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        });
        ShowResults = false;
    }

    // Update is called once per frame
    void Update()
    {
        var spText = m_ghostTime.Ghosttime.ToString("F0");
        m_spText.text = $"SP: {spText}";
        m_deathCountText.text = $"Death: {StageStateRegistry.Instance.DeathCount}";
        var timeText = TimeSpan.FromSeconds(StageStateRegistry.Instance.ElapsedTime).ToString(@"mm\:ss");
        m_timerText.text = $"Time: {timeText}";
    }

    void ApplyResults()
    {
        m_resultDeathCountText.text = $"Death: {StageStateRegistry.Instance.DeathCount}";
        var timeText = TimeSpan.FromSeconds(StageStateRegistry.Instance.ElapsedTime).ToString(@"mm\:ss");
        m_resultTimerText.text = $"Time: {timeText}";
        var spTime = TimeSpan.FromSeconds(m_ghostTime.TotalGhosttime).ToString(@"mm\:ss");
        m_resultTotalSpiritTimeText.text = $"Time spent in spirit: {spTime}";
    }
}
