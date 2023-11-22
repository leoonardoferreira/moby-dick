using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public GameObject telaFim;
    public Slider barra;
    public Baleia baleia;
    public Barco barco;
    public Barco barco2;
    public Barco barco3;
    public Barco barco4;
    public Barco barco5;
    public Barco barco6;
    public Barco barco7;
    public Barco barco8;
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
