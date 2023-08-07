using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscript : MonoBehaviour
{
    public Vector2 CurrentPos = new Vector2(-2,-2);
    private Vector2 Winningpos = new Vector2(0,0);
    private Vector2 Losingpos = new Vector2(0,1);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (transform.position.y != 4)
            {
                transform.position += new Vector3(0,2,0);
                CurrentPos += new Vector2(0,1);
            }
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            if (transform.position.y != -4)
            {
               transform.position -= new Vector3(0,2,0);
               CurrentPos += new Vector2(0,-1);
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            if (transform.position.x != 4)
            {
                transform.position += new Vector3(2,0,0);
                CurrentPos += new Vector2(1,0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (transform.position.x != -4)
            {
                transform.position -= new Vector3(2,0,0);
                CurrentPos += new Vector2(-1,0);
            }
            
        } 
    }
}
