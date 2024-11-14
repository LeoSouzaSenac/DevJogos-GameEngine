using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    public float mouseSensitivity = 100f; // Sensibilidade do mouse
    public Transform playerBody; // Referência ao transform do jogador

    private float xRotation = 0f; // Rotação acumulada no eixo X

    void Start()
    {
        // Trava o cursor no centro da tela e o torna invisível
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Obtém a entrada do mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Ajusta a rotação no eixo X (vertical) para limitar o ângulo de visão
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Aplica a rotação vertical na câmera
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotaciona o jogador horizontalmente com o movimento do mouse
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
