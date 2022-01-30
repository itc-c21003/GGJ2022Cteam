using UnityEditor;
using UnityEngine;
using System.Collections.Generic;

public class StageStateRegistry
{
    private static StageStateRegistry instance = new StageStateRegistry();
    public static StageStateRegistry Instance
    {
        get
        {
            return instance;
        }
    }

    private HashSet<string> collectedKeys;
    private Vector3 playerSpawnPoint;
    public int DeathCount { get; set; }
    public float ElapsedTime { get; set; }

    public Vector3 PlayerSpawnPoint
    {
        get
        {
            return playerSpawnPoint;
        }
        set
        {
            playerSpawnPoint = value;
        }
    }

    private StageStateRegistry()
    {
        collectedKeys = new HashSet<string>();
        playerSpawnPoint = new Vector3();
    }

    public void AddCollectedKey(string keyName)
    {
        collectedKeys.Add(keyName);
    }
    public bool IsKeyCollected(string keyName)
    {
        return collectedKeys.Contains(keyName);
    }
}