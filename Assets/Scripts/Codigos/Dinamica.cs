using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class Dinamica : MonoBehaviour
{
    #region Variables
    public GameObject Celular, Billetera, Campera, CelularB, BilleteraB, CamperaB;
    #endregion
    void Start()
    {
        Celular.SetActive(false);
        Billetera.SetActive(false);
        Campera.SetActive(false);
        CelularB.SetActive(true);
        BilleteraB.SetActive(true);
        CamperaB.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Celu()
    {
        Celular.SetActive(true);
        CelularB.SetActive(false);

    }
    public void Bitellera()
    {
        Billetera.SetActive(true);
        BilleteraB.SetActive(false);

    }
    public void Campe()
    {
        Campera.SetActive(true);
        CamperaB.SetActive(false);
    }
}
