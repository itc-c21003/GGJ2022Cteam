using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public GameObject PLPos;
    public Player Player;
    float MoveX,MoveY;
    public Rigidbody2D Rig;
    public float speed, PX,PY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveX = Input.GetAxis("Horizontal");
        MoveY = Input.GetAxis("Vertical");
        if (Input.GetKeyDown("z"))
        {
            transform.position = new Vector2(PX,PY+2);

            Player.enabled = true;
            this.gameObject.SetActive(false);
        }  
    }
    private void FixedUpdate()
    {
        Rig.velocity = new Vector2(MoveX,MoveY) * speed;
    }
}
