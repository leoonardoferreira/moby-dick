using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barco : MonoBehaviour
{
    public GameObject baleia;
    public GameObject projetilPrefab;
    public Transform barco;
    public Transform Baleia;
    public float intervalo = 4f;
    public Slider barraDeVida;
    private float proximoTiro;
    public bool podeMover = true;

    void Start()
    {
        proximoTiro = Time.time + intervalo;
    }

    void Update()
    {
        if (podeMover)
        {
            transform.Translate(new Vector3(-3, 0, 0) * Time.deltaTime);

            if (transform.position.x < -91)
            {
                Destroy(this.gameObject);
            }

            if (Time.time >= proximoTiro)
            {
                Atirar();
                proximoTiro = Time.time + intervalo;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == baleia)
        {
            GameObject.Find("ContadorBarcos").GetComponent<ContadorBarcos>().barcos += 1;
            Destroy(this.gameObject);
        }
    }

    void Atirar()
    {
        Vector3 direcao = (Baleia.position - barco.position).normalized;

        float angulo = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg;

        Quaternion rotacao = Quaternion.LookRotation(direcao);

        GameObject bala = Instantiate(projetilPrefab, barco.position, rotacao);

        bala.GetComponent<Rigidbody>().velocity = direcao * 10f;
    }
}

