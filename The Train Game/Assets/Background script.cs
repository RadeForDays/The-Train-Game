using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroundscript : MonoBehaviour
{
    public float BackgroundScrollSpeed;
    public GameObject PreFabForBackground;
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(BackgroundScrollSpeed*Time.deltaTime,0,0);
    }
}
