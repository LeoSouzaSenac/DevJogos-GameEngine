# Aula 3: Colisões e Interações no Jogo

## Objetivos da Aula
Nesta aula, vamos:
- Aprender a detectar colisões com objetos no cenário.
- Criar interações básicas ao tocar em diferentes objetos.
- Implementar feedback visual e sonoro para tornar o jogo mais imersivo.

## Conteúdo da Aula

### 1. Preparação da Cena

1. Abra o seu projeto no Unity.
2. No painel **Hierarchy**, crie um novo objeto chamado **Collectible** para representar um item que o jogador pode coletar.
   - **Dica**: Isso pode ser um cubo simples ou um objeto 3D que represente o item.
3. Ajuste a posição do objeto **Collectible** para que ele esteja visível na cena.

### 2. Adicionando um Script de Colisão ao Personagem

Para detectar colisões, vamos adicionar um script ao personagem. Esse script irá identificar quando o personagem encosta em um objeto de tipo específico, como o **Collectible**.

1. **Selecione o objeto do jogador** (aquele com o `Character Controller` que configuramos anteriormente).
2. No **Inspector**, clique em **Add Component** > **New Script** e chame o script de `PlayerCollision`.
3. Abra o script para edição. Aqui está um exemplo de como o script pode ficar:

```csharp
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Método chamado automaticamente quando o jogador colide com outro objeto
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Verifica se o objeto com o qual colidimos possui a tag "Collectible"
        if (hit.gameObject.CompareTag("Collectible"))
        {
            // Exibe uma mensagem no console indicando a colisão
            Debug.Log("Item coletado!");

            // Aqui você pode adicionar outras interações, como efeitos sonoros, pontos, etc.
            
            // Desativa o item coletado
            hit.gameObject.SetActive(false);
        }
    }
}
```

### 3. Configurando o Objeto Collectible

Para que o script detecte o objeto, é necessário atribuir a tag "Collectible" ao objeto que queremos que seja coletável.

1. Selecione o objeto **Collectible** na **Hierarchy**.
2. No **Inspector**, localize o campo **Tag** (no topo).
3. Clique no menu suspenso e selecione **Add Tag**.
4. Adicione uma nova tag chamada **Collectible** e salve.
5. Atribua a tag **Collectible** ao objeto **Collectible**.

### 4. Testando a Colisão

1. Clique em **Play** no Unity para iniciar o modo de teste.
2. Movimente o personagem em direção ao objeto **Collectible**.
3. Ao tocar no objeto, o console deve exibir a mensagem "Item coletado!", e o objeto deve desaparecer.

> **Nota:** Se você não vê a mensagem ou o objeto não desaparece, verifique se o objeto possui a tag **Collectible** e se o script `PlayerCollision` está corretamente configurado no jogador.

### 5. Adicionando Feedback Sonoro e Visual

Vamos tornar a coleta de itens mais interessante adicionando efeitos visuais e sonoros.

#### Passo 1: Adicionando Som

1. No **Project** (painel de projetos), crie uma nova pasta chamada **Sounds**.
2. Adicione um arquivo de som para a coleta, arrastando-o para a pasta **Sounds**.
3. No script `PlayerCollision`, declare uma variável para o som e use o código abaixo:

```csharp
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public AudioClip collectSound; // Som de coleta
    private AudioSource audioSource;

    private void Start()
    {
        // Obtém o componente de áudio
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Collectible"))
        {
            Debug.Log("Item coletado!");
            
            // Toca o som de coleta
            audioSource.PlayOneShot(collectSound);

            hit.gameObject.SetActive(false);
        }
    }
}
```

#### Passo 2: Ligando o Som no Unity

1. No **Inspector** do jogador, você verá o campo **Collect Sound** no script `PlayerCollision`.
2. Arraste o arquivo de som para o campo **Collect Sound**.

#### Passo 3: Testando

1. Clique em **Play** para testar.
2. Ao coletar o item, o som de coleta deve ser reproduzido.

### 6. Adicionando Feedback Visual (Partículas)

Para adicionar um efeito visual, como partículas, siga os passos abaixo:

1. No **Hierarchy**, clique com o botão direito e selecione **Effects** > **Particle System** para criar um sistema de partículas.
2. Ajuste as configurações de partículas no **Inspector** para personalizar o efeito.
3. Desative o sistema de partículas para que ele não seja reproduzido ao início do jogo.
4. No script `PlayerCollision`, adicione uma referência ao sistema de partículas:

```csharp
public class PlayerCollision : MonoBehaviour
{
    public AudioClip collectSound;
    public ParticleSystem collectEffect; // Efeito visual de coleta
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Collectible"))
        {
            Debug.Log("Item coletado!");
            audioSource.PlayOneShot(collectSound);
            
            // Ativa o efeito de partículas na posição do objeto coletado
            Instantiate(collectEffect, hit.transform.position, Quaternion.identity);

            hit.gameObject.SetActive(false);
        }
    }
}
```

5. Arraste o sistema de partículas para o campo **Collect Effect** no `Inspector`.

### 7. Conclusão

Ao final desta aula, você terá aprendido:
- A criar um sistema básico de coleta de itens usando colisões.
- A adicionar feedback visual e sonoro para melhorar a experiência do jogador.
