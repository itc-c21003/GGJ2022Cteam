using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTime : MonoBehaviour
{
    public GhostChenger ghostChenger;
    public float Ghosttime = 20,Recoverytime = 8;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(ghostChenger.IsSpiritBody)
        {
            Ghosttime -= Time.deltaTime;
        }   
        else if(!ghostChenger.IsSpiritBody)
        {
            if(Ghosttime < Recoverytime)
            Ghosttime += Time.deltaTime;
        }
       if(Ghosttime < 0) 
        {
            ghostChenger.IsSpiritBody = false;
            Ghosttime = 0;
        }    
    }
}
