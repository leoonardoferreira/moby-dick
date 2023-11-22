using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAcompanhando : MonoBehaviour
{
    private Vector3 distancia;
    public GameObject baleia;
    
    void Start()
    {
        distancia = transform.position - baleia.transform.position;
    }
    void Update()
    {
        transform.position = baleia.transform.position + distancia;
    }
}
