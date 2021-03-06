using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    #region Variables
    public float Vel;
    public float VelSalto;
    public float TiempoSalto;
    #endregion


    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vel * Time.deltaTime, 0, 0);
        if (Input.GetMouseButton(0) && TiempoSalto <= 0)
        {
            Saltito();
            TiempoSalto = 1f;
        }
        if (TiempoSalto >= 0)
        {
            TiempoSalto -= Time.deltaTime;
        }
    }

    public void Saltito()
    {
        transform.Translate(0, VelSalto, 0);
    }
}
