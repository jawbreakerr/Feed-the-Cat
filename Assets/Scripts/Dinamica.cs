using UnityEngine;
using UnityEngine.SceneManagement;

public class Dinamica : MonoBehaviour
{
    #region Variables
    public GameObject Celular, Billetera, Campera, Barbijo, BarbijoB, CelularB, BilleteraB, CamperaB;
    public int PickedObjects;
    #endregion
    void Start()
    {
        //para descomentar ctrl k u
        //para comentar ctrl k c
        //Celular.SetActive(false);
        //Billetera.SetActive(false);
        //Campera.SetActive(false);
        //Barbijo.SetActive(false);
        CelularB.SetActive(true);
        BilleteraB.SetActive(true);
        CamperaB.SetActive(true);
        BarbijoB.SetActive(true);
        PickedObjects = 0;
    }
    void Update()
    {

    }
    #region BotonesObjetos
    public void Celu()
    {
        //Celular.SetActive(true);
        CelularB.SetActive(false);
        PickedObjects += 1;

    }
    public void Bitellera()
    {
        //Billetera.SetActive(true);
        BilleteraB.SetActive(false);
        PickedObjects += 1;
    }
    public void Campe()
    {
        //Campera.SetActive(true);
        CamperaB.SetActive(false);
        PickedObjects += 1;
    }
    public void Barbijillo()
    {
        //Barbijo.SetActive(true);
        BarbijoB.SetActive(false);
        PickedObjects += 1;
    }
    public void Puertirigilla()
    {
        if (PickedObjects == 4)
        {
            SceneManager.LoadScene("Nivel 2");
        }
    }
    #endregion
}