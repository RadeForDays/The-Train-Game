using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    public float speed;
    public float Jump;
    private bool JumpAvalable;
    public bool ControllerOn = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        InputHandler();
    }
    void InputHandler()
    {
        if (ControllerOn)
        { 
            float Movement_RightLeft = Input.GetAxis("Horizontal");
            float Movement_UpDown = Input.GetAxis("Vertical");
            if (Movement_RightLeft != 0f)
            {
                player.velocity = new Vector2(Movement_RightLeft * speed * Time.deltaTime, player.velocity.y);
            }
            if ((Movement_UpDown != 0f) && (JumpAvalable == true))
            {
                JumpAvalable = false;
                player.velocity = new Vector2(player.velocity.x, Jump);
            }
           
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        JumpRenew(collision);
    }
    void OnCollisionExit2D(Collision2D collision)
    {
       JumpRenew(collision);
    }
    void JumpRenew(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Barrier") &&  (ControllerOn))
        {
            JumpAvalable = true;
        }
    }
    public void MovingToMiniGame()
    {
        player.gravityScale = 0;
        transform.position = new Vector3 (0,20,0);
        ControllerOn = false;
    }
}
