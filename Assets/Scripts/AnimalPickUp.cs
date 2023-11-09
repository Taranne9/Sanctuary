using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalPickUp : MonoBehaviour
{

    public GameObject animalSafe;
    public GameObject victoriaCondicion;
    public GameObject audioAnimalPick;

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
        if (other.gameObject.CompareTag("Player")) 
        {
            animalSafe.SetActive(true);
            audioAnimalPick.GetComponent<AudioSource>().Play();
            victoriaCondicion.GetComponent<WinCondition>().PoderGanar();
            Destroy(gameObject);
        }
    }
}
