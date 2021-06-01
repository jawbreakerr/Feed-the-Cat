using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DinamicaSuper : MonoBehaviour
{
    public GameObject Leche, Leche2, Tocino, Tocino2, ComGat, ComGat2, Lass, Lass2, Remmy, Remmy2;
    void Start()
    {
        Leche2.SetActive(false);
        Tocino2.SetActive(false);
        ComGat2.SetActive(false);
        Lass2.SetActive(false);
        Remmy2.SetActive(false);
        Leche.SetActive(true);
        Tocino.SetActive(true);
        ComGat.SetActive(true);
        Lass.SetActive(true);
        Remmy.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Lechita()
    {
        Leche.SetActive(false);
        Leche2.SetActive(true);
    }

    public void Tocinito()
    {
        Tocino.SetActive(false);
        Tocino2.SetActive(true);
    }

    public void ComidaGatito()
    {
        ComGat.SetActive(false);
        ComGat2.SetActive(true);
    }

    public void Lassagnita()
    {
        Lass.SetActive(false);
        Lass2.SetActive(true);
    }

    public void RatitasMuertitas()
    {
        Remmy.SetActive(false);
        Remmy2.SetActive(true);
    }
}
