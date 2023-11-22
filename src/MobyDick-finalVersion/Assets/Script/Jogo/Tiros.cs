using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiros : MonoBehaviour
{
    public GameObject baleia;
    private float dano = 10f;
    public Slider barraDeVida;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == baleia)
        {
            Destroy(this.gameObject);
            TirarVida();
        }
    }
    void TirarVida()
    {
        barraDeVida.value -= dano;
    }
}
