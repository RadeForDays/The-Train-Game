using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyscript : MonoBehaviour
{
    private Vector2 CurrentPos = new Vector2(-2,-2);
    private Vector2 Winningpos = new Vector2(0,0);
    private Vector2 Losingpos = new Vector2(0,1);
    public GameObject Tile;
    void Start()
    {
        CreateGrid(5,5);
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
    private void CreateGrid(int x, int y)
    {
        for (int i=0;i<x;i++)
        {
            for (int j=0;j<y;j++)
            {
                Instantiate(Tile,new Vector3(i*2-x+1,j*2-y+1,0),Quaternion.identity);
                Debug.Log("It Works");
            }
        }
    }
}
