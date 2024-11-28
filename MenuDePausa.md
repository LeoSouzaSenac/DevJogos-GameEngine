## **Passo 1: Configurar o Canvas do Menu de Pausa**

1. **Criar o Canvas**:
   - No **Hierarchy**, clique com o botão direito em um espaço vazio.
   - Selecione **UI > Canvas**. Renomeie-o para `PauseMenu`.

2. **Adicionar elementos ao Canvas**:
   - Dentro do Canvas, adicione:
     - **Texto** para o título do menu:
       - Clique com o botão direito no Canvas e selecione **UI > Text - TextMeshPro**.
       - Renomeie para `PauseTitle` e altere o texto para algo como "PAUSA".
       - Ajuste o tamanho e a posição para o centro da tela.
     - **Botões** para opções:
       - Adicione dois botões: **"Continuar"** e **"Sair"**:
         - Clique com o botão direito no Canvas e selecione **UI > Button - TextMeshPro**.
         - Renomeie o primeiro botão para `ResumeButton` e o segundo para `QuitButton`.
         - Ajuste os textos dentro dos botões para "Continuar" e "Sair".
         - Posicione-os sob o texto de pausa.

3. **Desativar o Menu**:
   - No **Inspector**, desative o Canvas `PauseMenu` clicando na caixa de seleção ao lado do nome.

---

## **Passo 2: Criar o Script de Gerenciamento de Pausa**

1. **Adicionar o script ao jogador ou a um GameObject vazio**:
   - No **Hierarchy**, crie um GameObject vazio (clique com o botão direito e escolha **Create Empty**).
   - Renomeie-o para `GameManager` e adicione o script abaixo.

2. **Criar o script**:
   - Crie um script chamado `PauseMenuManager` e adicione o código:

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class PauseMenuManager : MonoBehaviour
{
    public GameObject pauseMenu; // Referência ao Canvas do menu de pausa

    private bool isPaused = false; // Estado do jogo (pausado ou não)

    void Update()
    {
        // Verifica se o jogador pressionou a tecla "P"
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                ResumeGame(); // Retoma o jogo
            }
            else
            {
                PauseGame(); // Pausa o jogo
            }
        }
    }

    // Pausar o jogo
    public void PauseGame()
    {
        
        pauseMenu.SetActive(true); // Ativa o menu de pausa
        Time.timeScale = 0f; // Congela o tempo do jogo
        isPaused = true;
        Cursor.lockState = CursorLockMode.None; // Libera o cursor
        Cursor.visible = true; // Torna o cursor visível
        Debug.Log("Pausa");
    }

    // Retomar o jogo
    public void ResumeGame()
    {
        pauseMenu.SetActive(false); // Desativa o menu de pausa
        Time.timeScale = 1f; // Retoma o tempo normal do jogo
        isPaused = false;
        // Bloqueia o cursor novamente e o esconde
        Cursor.lockState = CursorLockMode.Locked; // Trava o cursor no centro da tela
        Cursor.visible = false; // Esconde o cursor
        Debug.Log("Resumo");
    }

    // Sair do jogo
    public void QuitGame()
    {
        // Na Unity, este comando encerra o jogo compilado (só funciona depois que o jogo estiver pronto, não na Unity)
        Debug.Log("Saindo do jogo...");
        Application.Quit();
        

        
    }
}

```

---

## **Passo 3: Configurar o Script no Unity**

1. **Conectar o Canvas ao script**:
   - No **Inspector**, arraste o Canvas `PauseMenu` para o campo `PauseMenu` no script `PauseMenuManager`.

2. **Adicionar funcionalidade aos botões**:
   - Selecione o botão `ResumeButton` e, no **Inspector**, desça até **OnClick()**:
     - Clique no botão **"+"**.
     - Arraste o objeto `GameManager` para o campo.
     - No menu suspenso, selecione **PauseMenuManager > ResumeGame**.
   - Repita para o botão `QuitButton`, mas selecione **PauseMenuManager > QuitGame**.

---

## **Passo 4: Testar o Menu de Pausa**

- Pressione **Play** e, durante o jogo, pressione **P** para pausar ou despausar.
- Verifique se:
  - O tempo do jogo congela ao pausar.
  - Os botões "Continuar" e "Sair" funcionam corretamente.

---

### **Melhorias Futuras**
- **Adição de sons**: Adicione sons ao clicar nos botões.
- **Animações**: Use animações para fazer o menu aparecer/desaparecer de forma suave.
- **Mais Opções**: Adicione configurações como controle de volume ou reiniciar nível.

Agora, seu jogo tem um menu de pausa funcional! 🎮
