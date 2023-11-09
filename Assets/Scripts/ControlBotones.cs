using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBotones : MonoBehaviour
{

    public GameObject playerRef;
    public GameObject TpZonaSegura;
    //public GameObject swapAnim;

    // Start is called before the first frame update
    void Start()
    {
        //swapAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aZonaSegura()
    {
        //swapAnim.GetComponent<Animation>().Play("SwapAnimUI");
        playerRef.transform.position = TpZonaSegura.transform.position;
    }
}
