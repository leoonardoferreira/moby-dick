using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{

    public Baleia baleia;
    public void IniciarFase1()
    {
        SceneManager.LoadScene("Fase1");
        baleia.podeMover = true;
    }

    public void VoltarInicio()
    {
        SceneManager.LoadScene("Menu");
    }

    public void IniciarFase2()
    {
        SceneManager.LoadScene("Fase2");
        baleia.podeMover = true;
    }

    public void IniciarFase3()
    {
        SceneManager.LoadScene("Fase3");
        baleia.podeMover = true;
    }
}
