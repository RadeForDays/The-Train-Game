using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(-1*Speed*Time.deltaTime,0,0);

        if (transform.position.x <= -34)
        {
            transform.position = new Vector3(35,0,0);
        }
    }
}
