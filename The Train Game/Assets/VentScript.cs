using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;


public class VentScript : MonoBehaviour
{
    private GameObject player;
    private SpriteRenderer SR;
    public float MaxBound;
    private TheScript playerscript;
    private TextMeshProGUI text;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SR = GetComponent<SpriteRenderer>();
        playerscript = player.gameObject.GetComponent("TheScript") as TheScript;
        text = GameObject.FindGameObjectWithTag("tmp_object");
    }
    // Update is called once per frame
    void Update()
    {   
        Vector3 pos_player = player.transform.position;
        Vector3 pos_vent = transform.position;

        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckPos();
        }
        
        if ((pos_player.x - pos_vent.x) < MaxBound & (pos_player.x - pos_vent.x) > -MaxBound)
        {
            
        }
    }
    void CheckPos()
    {
        Vector3 pos_player = player.transform.position;
        Vector3 pos_vent = transform.position;
        if ((pos_player.x - pos_vent.x) < MaxBound & (pos_player.x - pos_vent.x) > -MaxBound)
        {
            SR.color = Color.blue;
            playerscript.MovingToMiniGame();
        }
    }
}
