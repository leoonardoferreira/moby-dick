using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida2 : MonoBehaviour
{
    public GameObject telaFim;
    public Slider barra;
    public Baleia baleia;
    public Barco2 barco;
    public Barco2 barco2;
    public Barco2 barco3;
    public Barco2 barco4;
    public Barco2 barco5;
    public Barco2 barco6;
    public Barco2 barco7;
    public Barco2 barco8;
    void Update()
    {
        if (barra.value <= 0)
        {
            barra.value = 0;
            telaFim.SetActive(true);
            baleia.podeMover = false;
            barco.podeMover = false;
            barco2.podeMover = false;
            barco3.podeMover = false;
            barco4.podeMover = false;
            barco5.podeMover = false;
            barco6.podeMover = false;
            barco7.podeMover = false;
            barco8.podeMover = false;
        }
    }
}
