### Aula 6: Criando um Sistema de Disparo para o Player e Introdução a Prefabs

**Objetivo da Aula**: Nesta aula, vamos adicionar a habilidade de o jogador disparar projéteis. Isso vai incluir a criação de um projétil e o código para lançá-lo. Além disso, você aprenderá sobre o conceito de *prefabs*, uma ferramenta essencial do Unity para reutilizar objetos.

---

### 1. Preparação do Projeto

Antes de começar a codificar o sistema de disparo, vamos preparar alguns recursos:

1. **Crie um novo GameObject** para o projétil (pode ser uma esfera pequena ou um objeto 3D semelhante).
2. **Adicione um Material** de cor brilhante para facilitar a visualização do projétil.
3. Renomeie o objeto para "Projétil" para organizá-lo melhor na hierarquia.

### 2. Criando um Prefab para o Projétil

**O que é um Prefab?**
- Um *Prefab* é um modelo de objeto que você pode reutilizar várias vezes na cena ou em várias cenas. Ele é particularmente útil para objetos que serão instanciados (criamos uma nova cópia do objeto na cena durante o jogo) várias vezes, como projéteis, inimigos, itens de coleta, entre outros.

**Passos para Criar o Prefab:**

1. Arraste o objeto "Projétil" da Hierarquia para a pasta **Assets** no painel *Project* para criar o Prefab.
2. Agora, esse objeto será salvo como um Prefab, e você pode deletá-lo da hierarquia, pois vamos instanciá-lo por código quando o jogador disparar.

---

### 3. Script para Disparar o Projétil

Vamos criar um script que permitirá ao jogador disparar o projétil pressionando uma tecla.

1. Crie um novo script chamado **PlayerShoot** e adicione-o ao objeto do jogador.

2. Abra o script e configure-o conforme abaixo:

```csharp
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab; // Prefab do projétil
    public Transform shootPoint; // Ponto de onde o projétil será lançado
    public float projectileSpeed = 20f; // Velocidade do projétil

    void Update()
    {
        // Verifica se o jogador pressionou a tecla para disparar (pode ser "Espaço")
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(); // Executa o método de disparo
        }
    }

    void Shoot()
    {
        // Instancia o projétil no ponto de disparo com rotação padrão
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);

        // Adiciona velocidade ao projétil na direção em que o jogador está olhando
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = transform.forward * projectileSpeed; // Define a velocidade do projétil
        }
    }
}
```

### Explicação do Código

- **`projectilePrefab`**: Referência ao prefab do projétil. Esse será o objeto que criamos e salvamos como prefab anteriormente.
- **`shootPoint`**: Um ponto de disparo (geralmente um `Transform` na frente do jogador).
- **`projectileSpeed`**: A velocidade do projétil.

O método `Shoot()` é chamado toda vez que o jogador pressiona a tecla `Espaço`. Ele:
1. **Instancia** o projétil no ponto de disparo.
2. **Define a velocidade** do projétil usando `Rigidbody` para movê-lo para frente.

---

### 4. Configurando o Objeto Projétil

1. Abra o **Prefab Projétil** no painel *Project* e adicione um **Rigidbody** para permitir que ele seja influenciado pela física (necessário para movê-lo com `velocity`).
2. Configure o Rigidbody para **Is Kinematic**, caso você queira que ele apenas seja afetado por forças aplicadas e não pela gravidade.
3. Salve as alterações e volte para a cena principal.

---

### 5. Configurando o Script `PlayerShoot` no Editor

1. No objeto do jogador, onde está o script `PlayerShoot`, arraste o **Prefab Projétil** para o campo `projectilePrefab`.
2. Para o campo `shootPoint`, crie um novo objeto vazio na frente do jogador e o posicione onde deseja que o projétil surja. Nomeie-o como “PontoDisparo” e arraste-o para o campo `shootPoint` no script.
3. Defina um valor para `projectileSpeed` (20 é uma boa velocidade inicial, mas você pode ajustar para sua preferência).

---

### 6. Testando o Disparo

1. Pressione **Play** para iniciar o jogo.
2. Pressione a tecla `Espaço` e veja se o projétil é disparado corretamente.

---

### 7. Resumo e Explicação

Nesta aula, você aprendeu:

- **Prefabs**: como criar e usá-los para instanciar objetos durante o jogo. Eles são úteis para itens repetidos, como projéteis, pois economizam tempo e ajudam a manter o projeto organizado.
- **Sistema de Disparo**: Como configurar um sistema básico de disparo, instanciando projéteis e aplicando uma velocidade para que se movam na cena.
  
Ao integrar esse sistema de disparo, você começou a implementar mecânicas de ataque para o jogador, possibilitando novos tipos de interação no seu jogo.

---

### Desafios Extras

1. **Adicionar Efeito Visual ou Som**: Adicione um efeito de som ao disparar ou até uma partícula para tornar o disparo mais dinâmico.
2. **Limitar o Alcance do Projétil**: Após uma certa distância, destrua o projétil para não sobrecarregar o jogo com muitos objetos.

Esses recursos aprimoram a jogabilidade e proporcionam uma experiência mais completa ao jogador!
