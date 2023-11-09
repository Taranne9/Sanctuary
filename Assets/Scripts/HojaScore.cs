using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HojaScore : MonoBehaviour
{

    public int puntosSumados;
    public GameObject audioHoja;

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
        if(gameObject.CompareTag("Reward") && other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Movement>().SumarPuntaje(puntosSumados);
            audioHoja.GetComponent<AudioSource>().Play();            
            Destroy(gameObject);
        }
    }
}
