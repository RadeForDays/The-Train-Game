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
    public TMPro.TMP_Text EText; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        SR = GetComponent<SpriteRenderer>();
        playerscript = player.gameObject.GetComponent("TheScript") as TheScript;
        EText = GameObject.FindGameObjectWithTag("Text").GetComponent<TMPro.TMP_Text>();
    }
    // Update is called once per frame
    void Update()
    {   
        
        HandleInput();
    }
    void HandleInput()
    {
        Checkpos();
        if (Input.GetKeyDown(KeyCode.E))
        {
            CheckOnEClick();
        }
    }
    void CheckOnEClick()
    {
        Vector3 pos_player = player.transform.position;
        Vector3 pos_vent = transform.position;
        if ((pos_player.x - pos_vent.x) < MaxBound & (pos_player.x - pos_vent.x) > -MaxBound)
        {
            playerscript.MovingToMiniGame();
        }
    }
    void Checkpos()
    {
        Vector3 pos_player = player.transform.position;
        Vector3 pos_vent = transform.position;
        
        if ((pos_player.x - pos_vent.x) < MaxBound & (pos_player.x - pos_vent.x) > -MaxBound)
        {
            EText.text = "E";
        }
        else
        {
            EText.text = "";
        }
    }
}
