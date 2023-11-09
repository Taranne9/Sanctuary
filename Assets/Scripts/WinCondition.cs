using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
    public GameObject Oso;
    public GameObject Jaguar;
    public GameObject Rana;
    public GameObject Condor;
    public GameObject Titi;
    public GameObject RH0;
    public GameObject RH1;
    public GameObject RH2;
    public GameObject RH3;
    public GameObject RH4;
    public GameObject RH5;
    public GameObject panelVictoria;
    public GameObject panelHUD;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PoderGanar()
    {
        if(Jaguar.activeSelf && Oso.activeSelf && Rana.activeSelf && Condor.activeSelf && Titi.activeSelf && RH0.activeSelf && RH1.activeSelf && RH2.activeSelf && RH3.activeSelf && RH4.activeSelf && RH5.activeSelf)
        {
            panelVictoria.SetActive(true);
            panelHUD.SetActive(false);
            panelVictoria.GetComponent<ControlSonido>().Pause();
            print("Victoria Alcanzada");
        }
        else
        {
            print("Faltan");
        }

    }
}
