using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
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
        if (MoveX > 0)
        {
            transform.rotation = Quaternion.AngleAxis(180, new Vector3(0, 1, 0));
        }
        if (MoveX < 0)
        {
            transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 1, 0));
        }
    }
    private void FixedUpdate()
    {
        Rig.velocity = new Vector2(MoveX,MoveY) * speed;
    }
}
