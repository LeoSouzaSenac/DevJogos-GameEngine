using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public Transform[] waypoints; // Pontos de patrulha
    public float patrolSpeed = 2.0f; // Velocidade de patrulha
    private int currentWaypoint = 0; // Índice do waypoint atual

    public float detectionRange = 10.0f; // Distância de detecção do jogador
    public float chaseSpeed = 4.0f; // Velocidade ao perseguir
    private Transform player; // Referência ao jogador

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Localiza o jogador pela tag
    }
    
    void Update()
    {
        // Verifica a distância entre o inimigo e o jogador
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            ChasePlayer();
        }
        else {
            Patrol();
        }
    }

    void ChasePlayer()
    {
        Vector3 direction = (player.position - transform.position).normalized;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.position += direction * chaseSpeed * Time.deltaTime;

        // Mantém o inimigo "olhando" para o jogador
        transform.LookAt(player);
    }

    void Patrol()
    {
        //Verifica se não há waypoints. Se não há, a função termina (e o inimigo não se move)
        if (waypoints.Length == 0) return;

        // Obtém o waypoint atual
        Transform target = waypoints[currentWaypoint];
        //target.position - transform.position calcula a direção entre a posição atual do inimigo e o próximo waypoint. Normalized faz com que a velocidade não seja alterada, apenas a posição
        Vector3 direction = (target.position - transform.position).normalized;

        // Move em direção ao waypoint
        /* 
        Direction é a direção que calculamos;
        patrolSpeed é a velocidade do inimigo;
        Time.deltaTime é o tempo entre os frames, garantindo um movimento suave
         */
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.position += direction * patrolSpeed * Time.deltaTime;

        // Verifica se chegou próximo ao waypoint
        /*
        Vector3.Distance calcula a distância entre o inimigo (transform.position) e o waypoint (target.position). Aquele < 0.5f verifica se a distancia é próxima o suficiente (pois não precisa ser igual)
        */
        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            /*
            Incrementa o índice do waypoint atual. Se o índice for maior do que a quantidade de waypoints, ele volta ao innício.
            */
            
            currentWaypoint = (currentWaypoint + 1) % waypoints.Length; // Avança para o próximo waypoint
        }
    }
}
