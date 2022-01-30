using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTime : MonoBehaviour
{
    public GhostChenger ghostChenger;
    public float Ghosttime = 30,TotalGhosttime; float Recoverytime =15,speed;
    public GrabThrow Grab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(ghostChenger.IsSpiritBody)
        {
            if (Grab.IsGragSpirit)
            {
                speed = 1.3f;
            }   
            if (!Grab.IsGragSpirit)
            {
                speed = 1f;
            }
            Ghosttime -= Time.deltaTime * speed;
            TotalGhosttime += Time.deltaTime * speed;
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
    public void Recovery()
    {
        Ghosttime += 15;
    }
}
