# Aula 5: Exibindo a Vida e Pontuação do Personagem na Tela

Nesta aula, vamos criar um sistema para mostrar a vida e a pontuação do personagem na tela. Vamos utilizar a interface gráfica (UI) da Unity para isso, com uma barra de vida e um contador de pontuação.

---

## Objetivos da Aula

- Exibir uma barra de vida na tela para indicar a quantidade de vida do personagem.
- Exibir a pontuação atual do jogador.
- Atualizar a barra de vida e a pontuação conforme o jogador recebe dano ou ganha pontos.

---

## Passo 1: Configurar a UI para a Vida

1. **Adicionar uma Barra de Vida**:
   - No painel **Hierarchy**, clique com o botão direito > **UI** > **Slider**. Renomeie para `HealthBar`.
   - Isso cria um `Canvas` automaticamente, onde todos os elementos de UI serão exibidos.
   - No componente **Slider** do `HealthBar`, configure os seguintes parâmetros:
     - **Min Value**: 0
     - **Max Value**: O valor máximo de vida do personagem (ex: 100).
     - **Value**: Defina como o valor inicial da vida do personagem (ex: 100).
   - Ajuste a posição e o tamanho da barra de vida no **Scene View**.

2. **Estilizar a Barra de Vida**:
   - Selecione o objeto `HealthBar`, expanda-o no **Hierarchy** e selecione `Fill Area > Fill`.
   - Na aba **Inspector**, altere a cor da barra de vida (por exemplo, vermelho ou verde).
   - A barra de vida será preenchida com base no valor da vida do personagem.

---

## Passo 2: Configurar a UI para a Pontuação

1. **Adicionar um Texto de Pontuação**:
   - No **Hierarchy**, clique com o botão direito no `Canvas` > **UI** > **Text**. Renomeie para `ScoreText`.
   - Na aba **Inspector**, defina o texto padrão para algo como `"Pontuação: 0"`.
   - Ajuste o **Font Size** para deixar o texto visível e mude a cor para destacá-lo (por exemplo, branco ou amarelo).
   - Posicione o `ScoreText` no canto da tela, onde deseja exibir a pontuação.

---

## Passo 3: Criar o Script de Vida e Pontuação

Agora, vamos criar um script para controlar a vida e a pontuação do personagem.

1. **Criar o Script**:
   - No **Project**, clique com o botão direito > **Create** > **C# Script**. Nomeie como `PlayerStats`.
   - Abra o script e escreva o código abaixo.

```csharp
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100; // Vida máxima
    public int currentHealth; // Vida atual do personagem
    public int score = 0; // Pontuação do jogador

    public Slider healthBar; // Referência à barra de vida
    public Text scoreText; // Referência ao texto de pontuação

    void Start()
    {
        // Define a vida inicial como o valor máximo
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = currentHealth;
        UpdateScoreText();
    }

    // Método para atualizar a vida
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Garante que a vida não fique negativa
        healthBar.value = currentHealth;
    }

    // Método para adicionar pontos
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // Atualiza o texto da pontuação
    void UpdateScoreText()
    {
        scoreText.text = "Pontuação: " + score;
    }
}
```

2. **Explicação do Código**:
   - `maxHealth` e `currentHealth`: Controlam a quantidade máxima e atual de vida.
   - `score`: Armazena a pontuação do jogador.
   - `healthBar` e `scoreText`: Referências aos elementos da interface para a barra de vida e o texto da pontuação.
   - `Start()`: Define a vida inicial, o valor máximo da barra de vida e atualiza a pontuação inicial.
   - `TakeDamage(int damage)`: Reduz a vida do personagem ao receber dano, atualizando a barra de vida.
   - `AddScore(int points)`: Aumenta a pontuação do jogador e atualiza o texto da pontuação.

---

## Passo 4: Vincular a UI ao Script

1. **Atribuir Referências**:
   - Arraste o script `PlayerStats` para o objeto do personagem no **Hierarchy**.
   - Selecione o personagem, e no **Inspector**, você verá o script `PlayerStats` anexado.
   - Arraste o objeto `HealthBar` para o campo `Health Bar` e `ScoreText` para o campo `Score Text` no script.

---

## Passo 5: Testar o Sistema de Vida e Pontuação

1. **Aplicar Dano e Aumentar Pontuação**:
   - Para simular dano ou ganho de pontos, crie botões ou ações no jogo que chamem os métodos `TakeDamage(int damage)` e `AddScore(int points)`.
   - Por exemplo, você pode adicionar um evento temporário no método `Update()` para reduzir vida ou aumentar pontuação ao pressionar certas teclas, apenas para teste:

```csharp
void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        TakeDamage(10); // Dano ao pressionar a tecla Espaço
    }
    
    if (Input.GetKeyDown(KeyCode.P))
    {
        AddScore(5); // Pontos ao pressionar a tecla P
    }
}
```

2. **Verificar o Funcionamento**:
   - Execute o jogo e teste se a barra de vida diminui ao receber dano e se a pontuação aumenta ao ganhar pontos.
   - Certifique-se de que a barra de vida não passa do limite e que a pontuação atualiza corretamente.

---

## Resumo

Nesta aula, criamos um sistema para exibir a vida e a pontuação do jogador na tela. Aprendemos como:

- Adicionar uma barra de vida e um contador de pontuação usando o sistema de UI da Unity.
- Vincular esses elementos ao script do personagem.
- Controlar a atualização da barra de vida e do texto de pontuação ao longo do jogo.
