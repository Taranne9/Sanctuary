using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpaMapa : MonoBehaviour
{

    public GameObject playerRef;
    public GameObject TpMapa;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerRef.transform.position = TpMapa.transform.position;

        }
    }
}
