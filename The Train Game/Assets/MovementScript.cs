using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D player;
    public float speed;
    public float Jump;
    private bool JumpAvalable = true;
    public bool ControllerOn = true;
    // Update is called once per frame
    void Update()
    {
        if (ControllerOn)
        {
            float Movement_RightLeft = Input.GetAxis("Horizontal");
            float Movement_UpDown = Input.GetAxis("Vertical");
            LeftRight(Movement_RightLeft);
            JumpFunction(Movement_UpDown);
        }
    }
    void LeftRight(float Movement_RightLeft)
    {
        if (Movement_RightLeft != 0f)
        {
            player.velocity = new Vector2(Movement_RightLeft * speed * Time.deltaTime, player.velocity.y);
        } 
    }
    void JumpFunction(float Movement_UpDown)
    {
        if ((Movement_UpDown != 0f) && (JumpAvalable))
            {
                Debug.Log("WOAH");
                JumpAvalable = false;
                player.velocity = new Vector2(player.velocity.x, Jump);
            }
    }
    void OnCollisionEnter2D(Collision2D collision)
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
}
