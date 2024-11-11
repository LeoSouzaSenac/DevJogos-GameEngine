using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    //public int score = 0;  // Armazena a pontuação do jogador

    // Detecta colisão com o coletável
    public AudioClip collectSound; // Som de coleta
    private AudioSource audioSource;
    private PlayerStats playerStats; // Referência ao PlayerStats

    private void Start()
    {
        // Obtém o componente de áudio
        audioSource = gameObject.AddComponent<AudioSource>();
         // Busca o componente PlayerStats no mesmo GameObject
        playerStats = GetComponent<PlayerStats>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coletável"))
        {
            //score += 10;  // Aumenta a pontuação


            // Adiciona pontos ao chamar o método AddScore de PlayerStats
            playerStats.AddScore(10); // Adiciona 10 pontos (pode ajustar o valor como preferir)

            audioSource.PlayOneShot(collectSound);
            Destroy(other.gameObject);  // Remove o coletável
            //Debug.Log("Coletável obtido! Pontuação: " + score);
        }
    }
}
