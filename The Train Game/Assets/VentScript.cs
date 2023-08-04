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

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SR = GetComponent<SpriteRenderer>();
        playerscript = player.gameObject.GetComponent("TheScript") as TheScript;
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
            FindObjectOfType<TextMeshProUGUI>().enabled = true;
        }
        else
        {
            FindObjectOfType<TextMeshProUGUI>().enabled = false;
        }
    }
    void CheckPos()
    {
        Vector3 pos_player = player.transform.position;
        Vector3 pos_vent = transform.position;
        if ((pos_player.x - pos_vent.x) < MaxBound & (pos_player.x - pos_vent.x) > -MaxBound)
        {
            playerscript.MovingToMiniGame();
        }
    }
}
