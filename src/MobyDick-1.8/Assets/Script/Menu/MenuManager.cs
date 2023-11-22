using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelCreditos;
    [SerializeField] private GameObject painelTutorial;

    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void AbrirCreditos()
    {
        painelMenuInicial.SetActive(false);
        painelCreditos.SetActive(true);
    }

    public void FecharCreditos()
    {
        painelCreditos.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelTutorial.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelMenuInicial.SetActive(true);
        painelTutorial.SetActive(false);
    }
}
