using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntregarHojas : MonoBehaviour
{

    bool playerCerca;
    public GameObject objEnergia;
    public GameObject flechaUp;
    public GameObject cantidadHojas;
    public GameObject playerRef;
    public GameObject victoriaCondicion;
    public int puntosRestados;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow) && playerCerca) 
        {
           EntregarHojasMagicas(); 
        }
                
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entregar hojas posible");
            flechaUp.SetActive(true);
            cantidadHojas.SetActive(true);
            playerCerca = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entregar hojas interrumpido");
            flechaUp.SetActive(false);
            cantidadHojas.SetActive(false);
            playerCerca = false;
        }
    }

    public void EntregarHojasMagicas()
    {
        if(playerRef.GetComponent<Movement>().Puntaje >= puntosRestados)
        {
            objEnergia.SetActive(true);
            playerRef.GetComponent<Movement>().RestarPuntaje(puntosRestados);
            victoriaCondicion.GetComponent<WinCondition>().PoderGanar();
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("Hojas insuficientes");
        }
    }
}
