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
    private StageStateRegistry()
    {
        collectedKeys = new HashSet<string>();
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