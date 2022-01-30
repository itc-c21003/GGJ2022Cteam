using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostTime : MonoBehaviour
{
    public GhostChenger ghostChenger;
    float Ghosttime = 30,Recoverytime =10,speed;
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
