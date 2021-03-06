using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostChenger : MonoBehaviour
{
    public GameObject Ghost,Player;
    public Player PL;
    public GrabThrow Grab;
    public float ghostYUp = 2;
    public Animator anim;
    private bool spirit = false;
    public bool IsSpiritBody
    {
        get
        {
            return spirit;
        }
        set
        {
            if (value)
            {
                Ghost.SetActive(true);
                PL.enabled = false;
                Grab.enabled = false;
                anim.SetTrigger("ghost");
            }
            else
            {
                float PX = Player.transform.position.x;
                float PY = Player.transform.position.y;
                Ghost.transform.position = new Vector2(PX, PY + ghostYUp);
                PL.enabled = true;
                Grab.enabled = true;
                Ghost.SetActive(false);
                anim.SetTrigger("idol");
            }
            spirit = value;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        float PX = Player.transform.position.x;
        float PY = Player.transform.position.y;
        Ghost.transform.position = new Vector2(PX, PY + ghostYUp);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
        {
            IsSpiritBody = !IsSpiritBody;
        }
    }
}
