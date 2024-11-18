# Aula 8: Criando a Inteligência Artificial (IA) dos Inimigos

Nesta aula, vamos implementar a **Inteligência Artificial (IA)** básica para os inimigos no jogo. A IA será capaz de patrulhar entre pontos definidos e, ao detectar o jogador, persegui-lo até uma distância específica.

---

## **Objetivos da Aula**
1. Fazer o inimigo patrulhar entre pontos predefinidos.
2. Configurar o inimigo para detectar e perseguir o jogador.
3. Adicionar um sistema de parada ao alcançar o jogador.

---

## **1. Criando o Cenário**

### **1.1 Configurando os Waypoints**
1. Crie alguns objetos `Empty` no cenário e posicione-os onde deseja que o inimigo patrulhe.
2. Renomeie os objetos como `Waypoint1`, `Waypoint2`, etc.
3. Agrupe todos os waypoints dentro de um único objeto `Empty` chamado `Waypoints`.

---

## **2. Criando o Script da IA**

### **2.1 Patrulha entre Waypoints**
Crie um script chamado `EnemyAI` e adicione o seguinte código:

```csharp
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform[] waypoints; // Pontos de patrulha
    public float patrolSpeed = 2.0f; // Velocidade de patrulha
    private int currentWaypoint = 0; // Índice do waypoint atual

    void Update()
    {
        Patrol();
    }

    void Patrol()
    {
        if (waypoints.Length == 0) return;

        // Obtém o waypoint atual
        Transform target = waypoints[currentWaypoint];
        Vector3 direction = (target.position - transform.position).normalized;

        // Move em direção ao waypoint
        transform.position += direction * patrolSpeed * Time.deltaTime;

        // Verifica se chegou próximo ao waypoint
        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            currentWaypoint = (currentWaypoint + 1) % waypoints.Length; // Avança para o próximo waypoint
        }
    }
}
```

### **2.2 Configurando no Unity**
1. Adicione o script `EnemyAI` ao inimigo.
2. Arraste os objetos `Waypoint` para o campo `Waypoints` no **Inspetor**.
3. Ajuste a velocidade (`patrolSpeed`) conforme necessário.

---

## **3. Adicionando Perseguição ao Jogador**

### **3.1 Detecção do Jogador**
Atualize o script `EnemyAI` para incluir um sistema de detecção do jogador.

```csharp
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
    else
    {
        Patrol();
    }
}

void ChasePlayer()
{
    Vector3 direction = (player.position - transform.position).normalized;
    transform.position += direction * chaseSpeed * Time.deltaTime;

    // Mantém o inimigo "olhando" para o jogador
    transform.LookAt(player);
}
```

### **3.2 Configurando no Unity**
1. Certifique-se de que o jogador possui a **Tag** `Player`.
2. Ajuste o valor de `detectionRange` para controlar o alcance de visão do inimigo.
3. Ajuste `chaseSpeed` para definir a velocidade da perseguição.

---

## **4. Parada ao Alcançar o Jogador**

Adicione uma lógica para o inimigo parar ao estar muito próximo do jogador.

```csharp
public float stopDistance = 1.5f; // Distância mínima para parar

void ChasePlayer()
{
    float distanceToPlayer = Vector3.Distance(transform.position, player.position);

    if (distanceToPlayer > stopDistance)
    {
        Vector3 direction = (player.position - transform.position).normalized;
        transform.position += direction * chaseSpeed * Time.deltaTime;
        transform.LookAt(player);
    }
}
```

---

## **5. Melhorias Opcionais**

### **5.1 Adicionando Animações**
- Adicione um **Animator** ao inimigo e configure estados de animação:
  - `Idle` (parado)
  - `Patrolling` (patrulhando)
  - `Chasing` (perseguindo)

Atualize o script para controlar o Animator:
```csharp
private Animator animator;

void Start()
{
    animator = GetComponent<Animator>();
    player = GameObject.FindGameObjectWithTag("Player").transform;
}

void Patrol()
{
    animator.SetBool("isChasing", false);
    animator.SetBool("isPatrolling", true);
    // Restante do código de patrulha
}

void ChasePlayer()
{
    animator.SetBool("isPatrolling", false);
    animator.SetBool("isChasing", true);
    // Restante do código de perseguição
}
```

### **5.2 Sistema de Ataque**
Adicione um script para o inimigo causar dano ao jogador quando próximo:
```csharp
public int damage = 10;
public float attackCooldown = 2.0f;
private float lastAttackTime;

void ChasePlayer()
{
    float distanceToPlayer = Vector3.Distance(transform.position, player.position);

    if (distanceToPlayer <= stopDistance && Time.time > lastAttackTime + attackCooldown)
    {
        AttackPlayer();
        lastAttackTime = Time.time;
    }
}

void AttackPlayer()
{
    // Suponha que o jogador tenha um método "TakeDamage(int)"
    player.GetComponent<PlayerStats>().TakeDamage(damage);
}
```

---

## **6. Conclusão**
Agora, o inimigo:
1. Patrulha entre pontos predefinidos.
2. Detecta e persegue o jogador ao entrar no alcance.
3. Para ao se aproximar do jogador e pode causar dano.
