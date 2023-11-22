using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorBarcos2 : MonoBehaviour
{
    public int barcos;
    public GUIStyle estilo;
    public GameObject telaVenceu;
    public Baleia baleia;
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), barcos.ToString(), estilo);
    }

    void Update()
    {
        if (barcos >= 6)
        {
            telaVenceu.SetActive(true);
            baleia.podeMover = false;
        }
    }
}
