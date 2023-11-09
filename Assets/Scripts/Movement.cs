using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 10f;
    public float fHorizontal;
        float vHorizontal;
    public float alturaRayo;
    public LayerMask piso;
    public bool tocandoPiso;
    public float fuerzaVertical;

    public int Puntaje;
    public TMP_Text textoPuntaje;
    //public GameObject spritePlayer;
        Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        if (fHorizontal <= 0) { fHorizontal = 1; }
    }

    // Update is called once per frame
    void Update()
    {
        vHorizontal = Input.GetAxis("Horizontal");
        //float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");
        //Vector2 dir = new Vector2 (x, y);
        //animator.SetFloat("Speed", Mathf.Abs(x));
        if(vHorizontal != 0)
        {
            if (vHorizontal > 0)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
                //spritePlayer.GetComponent<SpriteRenderer>().flipX = true;
            }
            else if (vHorizontal < 0) 
            {
                transform.rotation = Quaternion.Euler(0, 180, 0);
                //spritePlayer.GetComponent<SpriteRenderer>().flipX = false;
            }
            transform.position += Vector3.right * vHorizontal * fHorizontal * Time.deltaTime;
        }
        animator.SetFloat("Speed", Mathf.Abs(vHorizontal));

        Debug.DrawRay(transform.position, Vector3.down * alturaRayo, Color.blue, 0.1f);
        if (Physics2D.Raycast(transform.position, Vector2.down, alturaRayo, piso))
        {
            tocandoPiso = true;
            //Debug.Log("Hit"); 
            rb.gravityScale = 1f;
            //animator.SetBool("IsJumping", false);
        }
        else
        {
            tocandoPiso = false;
            rb.gravityScale = 2f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && tocandoPiso)
        {
            //Debug.Log("Salto");
            rb.velocity = Vector2.up * fuerzaVertical;
            //animator.SetBool("IsJumping", true);

        }

        //Walk(dir);
    }

    /*private void Walk(Vector2 dir)
    {
        rb.velocity = (new Vector2(dir.x * speed, rb.velocity.y));
    }
    */

    public void SumarPuntaje(int puntosSumados)
    {
        Puntaje += puntosSumados;
        textoPuntaje.text = Puntaje.ToString();
    }

    public void RestarPuntaje(int puntosRestados)
    {
        Puntaje -= puntosRestados;
        textoPuntaje.text = Puntaje.ToString();
    }
}
