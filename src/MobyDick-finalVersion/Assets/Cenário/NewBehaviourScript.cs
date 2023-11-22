using UnityEngine;

public class DetectarSaidaAgua : MonoBehaviour
{
    public Transform cameraTransform; // Referência ao transform da câmera
    public float alturaAgua = 29.6f; // Altura da superfície da água

    private bool naAgua = true; // Indica se a câmera está atualmente na água

    void Start()
    {
        naAgua = true;
        EntrarNaAgua();
    }

    void Update()
    {
        // Verificar a posição da câmera em relação à altura da água
        if (cameraTransform.position.y > alturaAgua && naAgua)
        {
            // A câmera saiu da água
            naAgua = false;
            SairDaAgua();
        }
        else if (cameraTransform.position.y <= alturaAgua && !naAgua)
        {
            // A câmera voltou para a água
            naAgua = true;
            EntrarNaAgua();
        }
    }

    void SairDaAgua()
    {
        // Coloque aqui o código que deseja executar quando a câmera sai da água

        RenderSettings.fog = false;
    }

    void EntrarNaAgua()
    {
        // Coloque aqui o código que deseja executar quando a câmera entra na água
        RenderSettings.fog = true;
    }
}