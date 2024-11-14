# Aula 7: Controle de Câmera com o Mouse

Nesta aula, vamos aprender a rotacionar a câmera em primeira pessoa utilizando o movimento do mouse. Esse é um passo importante para criar um controle de visão em jogos FPS (First-Person Shooter).

## Objetivos da Aula
- Criar um script que permita controlar a rotação da câmera com o mouse.
- Configurar a sensibilidade do mouse.
- Bloquear o cursor na tela para simular o controle FPS.

## Passo 1: Estrutura do Projeto
Antes de começar, certifique-se de que:
1. Você tem um **Player** configurado como GameObject principal do personagem.
2. A câmera (`Main Camera`) está posicionada como filha desse Player, apontando na direção desejada para visão em primeira pessoa.

## Passo 2: Criando o Script `CameraController`

1. Na pasta **Scripts** do seu projeto, crie um novo script chamado `CameraController.cs`.
2. Copie e cole o seguinte código no script:

   ```csharp
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
   ```

### Explicação do Código
- **mouseSensitivity**: controla a velocidade de rotação da câmera. Pode ser ajustado no **Inspector** para ser mais ou menos sensível.
- **Cursor.lockState**: bloqueia o cursor no centro da tela, típico em jogos de primeira pessoa para que o cursor não saia da janela.
- **Update()**: lida com a rotação da câmera e do jogador a cada frame.

## Passo 3: Configurando o Script no Unity

1. **Adicionar o Script**:
   - Selecione a **Main Camera** no Unity (que é filha do Player).
   - Arraste o script `CameraController.cs` para o Inspector da câmera para adicioná-lo como um componente.

2. **Atribuir o PlayerBody**:
   - No campo `Player Body` no Inspector, arraste o GameObject do Player para fazer referência ao transform do jogador.
   
3. **Ajustar a Sensibilidade**:
   - No campo `Mouse Sensitivity`, ajuste o valor conforme necessário para um controle confortável. Um valor comum para testes é entre `100f` e `300f`.

## Passo 4: Testando o Script

1. Pressione **Play** no Unity para entrar no modo de jogo.
2. Mova o mouse para testar o controle da câmera:
   - **Movimento horizontal** (eixo Y): a câmera deve girar horizontalmente junto com o corpo do jogador.
   - **Movimento vertical** (eixo X): a câmera deve inclinar-se para cima e para baixo, mas será limitada a 90 graus para evitar giros completos.

## Dicas para Ajustes
- **Sensibilidade**: Ajuste `mouseSensitivity` para uma rotação mais rápida ou mais lenta.
- **Limite de Ângulo**: `xRotation = Mathf.Clamp(xRotation, -90f, 90f);` limita a rotação vertical, evitando giros completos.

Agora, com o script `CameraController`, você tem um controle de câmera básico e funcional para jogos em primeira pessoa! Experimente ajustar os valores e veja como isso altera a sensação de controle.
