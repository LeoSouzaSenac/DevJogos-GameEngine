# Aula 2: Controlador de Personagem (Player) - Movimentação Básica na Unity

## Objetivo

Nesta aula, vamos aprender a implementar o movimento básico do nosso personagem utilizando um componente da Unity chamado `CharacterController`. Nosso objetivo é fazer o personagem andar pela cena usando as teclas de direção (W, A, S, D).

### Pré-requisitos

- Unity instalada.
- Um projeto criado (pode ser o mesmo da aula anterior).
- Noções básicas de Unity e de C#.

## Configurando o Projeto e a Cena

1. **Abra seu projeto Unity**.
2. **Crie um novo objeto** para ser o "Player" (isso pode ser um cubo, esfera ou um modelo 3D de personagem que você já tenha).
3. **Renomeie o objeto para `Player`** para identificá-lo facilmente.
4. **Adicione um "Plano"** na cena que servirá como o chão para o Player andar. Você pode fazer isso clicando com o botão direito na `Hierarchy` e selecionando **3D Object > Plane**.
5. Posicione o Player um pouco acima do plano para evitar que ele colida com o chão.

## Adicionando o `CharacterController` ao Player

Para controlar o movimento do Player, usaremos o componente `CharacterController`, que facilita o controle de um personagem com movimentação simples e deteção de colisões.

1. Selecione o objeto `Player` na `Hierarchy`.
2. Vá ao painel `Inspector` e clique em **Add Component**.
3. Pesquise por **CharacterController** e selecione-o para adicionar ao Player.

### O que é o `CharacterController`?

O `CharacterController` é um componente que permite mover um objeto de forma controlada, usando métodos como `SimpleMove` e `Move`. Ele possui colisores embutidos que facilitam a criação de um movimento básico sem precisar programar a física detalhada.

---

## Criando o Script de Movimentação

1. **Crie um novo script**:
   - Na pasta `Assets`, clique com o botão direito, selecione **Create > C# Script** e nomeie o script como `PlayerMovement`.
   
2. **Anexe o script ao Player**:
   - Arraste o script `PlayerMovement` para o objeto `Player` na `Hierarchy`, ou clique em **Add Component** no `Inspector` e selecione `PlayerMovement`.

---

## Escrevendo o Código de Movimentação

Agora vamos programar o movimento do jogador. Abra o script `PlayerMovement` para edição e substitua o conteúdo pelo código abaixo:

```csharp
using UnityEngine;

[RequireComponent(typeof(CharacterController))] // Assegura que o CharacterController está presente
public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0f; // Velocidade de movimento do Player
    private CharacterController controller; // Referência ao CharacterController

    void Start()
    {
        // Obtém o componente CharacterController que está anexado ao Player
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Obter entrada do usuário (teclas W, A, S, D)
        float horizontalInput = Input.GetAxis("Horizontal"); // Entrada para esquerda e direita
        float verticalInput = Input.GetAxis("Vertical");     // Entrada para frente e trás

        // Cria um vetor de direção com base na entrada
        Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;

        // Move o Player com o CharacterController
        controller.SimpleMove(moveDirection * speed);
    }
}
```

---

### Explicação do Código

Vamos entender cada parte do script com cuidado.

1. **`using UnityEngine;`** - Importa a biblioteca da Unity necessária para trabalhar com componentes e funcionalidades do motor de jogo.

2. **`[RequireComponent(typeof(CharacterController))]`** - Esta linha força o objeto a ter um `CharacterController` anexado a ele. Caso o `CharacterController` não esteja presente, a Unity o adicionará automaticamente, evitando erros.

3. **`public class PlayerMovement : MonoBehaviour`** - Define uma nova classe chamada `PlayerMovement` que herda de `MonoBehaviour`. Isso significa que este script pode ser anexado a um objeto na Unity.

4. **`public float speed = 6.0f;`** - Cria uma variável pública chamada `speed` que define a velocidade do movimento. Como é pública, você pode ajustar esse valor diretamente na Unity, sem modificar o código.

5. **`private CharacterController controller;`** - Declara uma variável privada `controller` do tipo `CharacterController`. Essa variável nos permitirá acessar o componente `CharacterController` do Player para movê-lo.

6. **`void Start()`** - O método `Start()` é chamado uma vez, assim que o jogo começa. Aqui, usamos o `Start()` para obter e armazenar o `CharacterController` do Player.

   - **`controller = GetComponent<CharacterController>();`** - Pega o `CharacterController` anexado ao objeto Player e o armazena na variável `controller`. Assim, podemos usá-lo para movimentar o Player.

7. **`void Update()`** - O método `Update()` é chamado uma vez por frame. É aqui que o código de movimentação do jogador é executado continuamente enquanto o jogo roda.

8. **Captura de Entrada do Usuário**:
   - **`float horizontalInput = Input.GetAxis("Horizontal");`** - Captura a entrada horizontal (teclas A e D ou setas).
   - **`float verticalInput = Input.GetAxis("Vertical");`** - Captura a entrada vertical (teclas W e S ou setas).

9. **Definindo a Direção de Movimento**:
   - **`Vector3 moveDirection = transform.right * horizontalInput + transform.forward * verticalInput;`**
     - Cria um vetor `moveDirection` que combina os eixos horizontal e vertical.
     - `transform.right` representa a direção da direita/esquerda do Player.
     - `transform.forward` representa a direção frente/trás do Player.

10. **Movendo o Player**:
    - **`controller.SimpleMove(moveDirection * speed);`** - Usa o `CharacterController` para mover o Player na direção de `moveDirection` com a velocidade definida por `speed`.

---

## Testando o Movimento

1. Salve o script.
2. Volte para a Unity e pressione **Play** para iniciar o jogo.
3. Use as teclas **W, A, S, D** para mover o Player pela cena.

## Ajustes de Velocidade

Se o Player estiver se movendo muito rápido ou muito devagar, você pode ajustar o valor de `speed` diretamente no painel `Inspector` enquanto o objeto `Player` está selecionado.

---

## Dicas para Prática

- Tente modificar o valor de `speed` para ver como isso afeta a velocidade de movimento do Player.
- Experimente substituir `SimpleMove` por `Move` para ver a diferença (note que `Move` requer gravidade manual).

---

## Conclusão

Nesta aula, você aprendeu a:
- Configurar o `CharacterController` no Player.
- Capturar entradas de teclado para controlar o movimento do Player.
- Usar o `SimpleMove` para mover o Player na cena.

Na próxima aula, vamos explorar colisões e como interagir com o ambiente usando física básica na Unity!

--- 

Espero que este formato seja útil e instrutivo para sua turma!
