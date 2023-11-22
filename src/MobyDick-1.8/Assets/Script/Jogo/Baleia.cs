using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Baleia : MonoBehaviour
{
    private float yMin = 2f;
    private float yMax = 29f;
    private float xMin = -78f;
    private float xMax = 420f;
    private Rigidbody rb;
    public bool podeMover = true;
    public float velocidade = 0.5f; // Adicionando a variável de velocidade

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (podeMover)
        {
            float moveVertical = Input.GetAxisRaw("Vertical") * velocidade; // Multiplicando pelo valor da velocidade
            float moveHorizontal = Input.GetAxisRaw("Horizontal") * velocidade; // Multiplicando pelo valor da velocidade

            transform.Translate(0, moveVertical, 0);
            transform.Translate(0, 0, moveHorizontal);

            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (Input.GetAxisRaw("Horizontal") < 0)
            {
                transform.localScale = new Vector3(1, 1, -1);
            }

            Vector3 posicaoBaleia = transform.position;

            posicaoBaleia.y = Mathf.Clamp(posicaoBaleia.y, yMin, yMax);
            posicaoBaleia.x = Mathf.Clamp(posicaoBaleia.x, xMin, xMax);

            transform.position = posicaoBaleia;
        }
    }
}