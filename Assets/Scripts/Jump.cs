using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    [Range(1, 10)]
    public float jumpVelocity;
    public float groundedSkin = 0.05f;
    public LayerMask mask;
    //public Animator animator;

    bool jumpRequest;
    //List<Collider2D> groundedTouched = new List<Collider2D>();

    bool grounded;

    Vector2 playerSize;
    //Vector2 boxSize;

    // Start is called before the first frame update
    /*void Awake()
    {
        playerSize = GetComponent<BoxCollider2D>().size;
        boxSize = new Vector2(playerSize.x, groundedSkin);
    }*/

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump") && grounded)
        {
            //animator.SetBool("IsJumping", true);
            jumpRequest = true;
        }        
    }

    private void FixedUpdate()
    {
        if(jumpRequest)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpVelocity, ForceMode2D.Impulse);
            jumpRequest = false;
            grounded = false;
            //animator.SetBool("IsJumping", false);
        }
        else
        {
            Vector2 rayStart = (Vector2)transform.position + Vector2.down * playerSize.y * 0.5f;
            grounded = Physics2D.Raycast (rayStart, Vector2.down, groundedSkin, mask);
        }
    }

}
