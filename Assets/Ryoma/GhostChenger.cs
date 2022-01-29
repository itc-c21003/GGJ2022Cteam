using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostChenger : MonoBehaviour
{
    public GameObject Ghost,Player;
    bool Spirit = false;
    public Player PL;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            Cheng();
        }
    }
    public bool GetSetSpirit
    {
        get { return Spirit; }
        set { Spirit = value; }
    }
    public void Cheng()
    {
        Spirit = !Spirit;
        if (Spirit) 
        {
            Ghost.SetActive(true);
            PL.enabled = false;
        }     
        else if (!Spirit) 
        {
            float PX = Player.transform.position.x;
            float PY = Player.transform.position.y;
            Ghost.transform.position = new Vector2(PX, PY + 2);
            PL.enabled = true;
            Ghost.SetActive(false);
        }
    }
}
