### Aula 4: Configurando e Interagindo com Objetos no Jogo (Coletáveis e Obstáculos)

---

**Objetivo da Aula**: Ensinar aos alunos como configurar objetos coletáveis e obstáculos, fazer o player interagir com eles e aplicar efeitos visuais e de som para melhorar a experiência de jogo. Vamos usar conceitos de colisão e adicionar som ao nosso projeto para dar feedback ao jogador ao interagir com esses elementos.

**Pré-requisitos**: 
- Compreensão do uso de `CharacterController` e `Rigidbody`.
- Conhecimento básico de C#.
- Familiaridade com o conceito de colisões e triggers.

---

#### 1. Preparação dos Objetos (Coletáveis e Obstáculos)

1. **Criar os Coletáveis**:
   - No Unity, clique com o botão direito no painel **Hierarchy** e selecione **3D Object > Sphere** para criar um objeto esférico que representará o coletável.
   - Altere o nome do objeto para "Coletável".
   - Ajuste o tamanho da esfera no componente **Transform > Scale** para torná-la menor (ex.: `0.5, 0.5, 0.5`).
   - Atribua uma cor ou material para o coletável para que ele se destaque.

2. **Configurar o Coletável como Trigger**:
   - Certifique-se de que o coletável tem um **Collider** (ex.: `Sphere Collider`).
   - Marque a opção **Is Trigger** no componente **Collider** para que o player possa atravessar o coletável sem uma colisão física.

3. **Criar os Obstáculos**:
   - No painel **Hierarchy**, clique com o botão direito e selecione **3D Object > Cube** para criar um obstáculo.
   - Altere o nome para "Obstáculo".
   - Redimensione o cubo e posicione-o no caminho do jogador.
   - O **Collider** padrão do cubo servirá como um obstáculo físico, então mantenha a opção **Is Trigger** desmarcada.

#### 2. Criando o Script de Coleta para o Player

Agora, vamos criar um script que detectará quando o player colidir com um coletável. Esse script será adicionado ao player.

1. **Criar o Script**:
   - Na pasta `Scripts`, crie um novo script chamado `PlayerCollect` e adicione-o ao jogador.

2. **Escrevendo o Código de Coleta**:

```csharp
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public int score = 0;  // Armazena a pontuação do jogador

    // Detecta colisão com o coletável
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coletável"))
        {
            score += 10;  // Aumenta a pontuação
            Destroy(other.gameObject);  // Remove o coletável
            Debug.Log("Coletável obtido! Pontuação: " + score);
        }
    }
}
```

**Explicação do Código**:
- `OnTriggerEnter(Collider other)`: Função que é chamada quando o player entra em contato com um objeto marcado como **Trigger**.
- `other.CompareTag("Coletável")`: Verifica se o objeto tocado tem a tag "Coletável".
- `score += 10;`: Aumenta a pontuação do player ao coletar o item.
- `Destroy(other.gameObject);`: Remove o coletável da cena ao ser coletado.

3. **Configurar a Tag do Coletável**:
   - Selecione o objeto "Coletável" no **Inspector** e, no menu **Tag**, crie e aplique a tag "Coletável".
   - Assim, o script reconhecerá esses objetos ao colidir.

#### 3. Adicionando Som ao Coletável

1. **Importar o Som**:
   - Importe um arquivo de som (ex.: `coleta.wav`) para a pasta **Assets**.
   
2. **Adicionar o Som no Script**:
   - No script `PlayerCollect`, declare uma variável para o som e adicione o código para tocar o som ao coletar o item:

```csharp
public AudioClip collectSound;  // Som da coleta
private AudioSource audioSource;

void Start()
{
    audioSource = GetComponent<AudioSource>();
}

private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Coletável"))
    {
        score += 10;
        audioSource.PlayOneShot(collectSound);  // Toca o som da coleta
        Destroy(other.gameObject);
        Debug.Log("Coletável obtido! Pontuação: " + score);
    }
}
```

3. **Configurar o Componente de Áudio**:
   - No Unity, selecione o jogador e adicione o componente **AudioSource**.
   - No script `PlayerCollect`, arraste o arquivo de áudio para o campo **Collect Sound** no **Inspector**.

#### 4. Criando um Script para Obstáculos

1. **Criar o Script de Obstáculo**:
   - Crie um novo script chamado `ObstacleCollision` e adicione-o ao jogador.

2. **Escrever o Código do Obstáculo**:

```csharp
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public int health = 100;  // Vida do jogador

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstáculo"))
        {
            health -= 20;  // Reduz a vida
            Debug.Log("Colidiu com obstáculo! Vida: " + health);
        }
    }
}
```

**Explicação do Código**:
- `OnCollisionEnter(Collision collision)`: Função chamada ao colidir com um obstáculo.
- `health -= 20;`: Reduz a vida do jogador ao colidir com o obstáculo.

3. **Configurar a Tag do Obstáculo**:
   - Aplique a tag "Obstáculo" ao cubo criado anteriormente.

---

#### 5. Testar e Ajustar

- **Pontuação**: Observe no console a pontuação aumentada ao coletar os itens.
- **Vida**: Veja a vida diminuir ao colidir com obstáculos.
