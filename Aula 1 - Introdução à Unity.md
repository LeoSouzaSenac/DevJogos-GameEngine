# Aula 1: Introdução à Unity - Criando o Primeiro Projeto e Configurando a Cena

## Objetivo

Nesta primeira aula, vamos nos familiarizar com o ambiente da Unity, criar um novo projeto e configurar uma cena básica. Vamos também aprender a adicionar objetos 3D e entender conceitos básicos de hierarquia, transformações e navegação na interface da Unity.

### Pré-requisitos

- Instalação do Unity Hub e da versão mais recente do Unity.
- Noções básicas de programação em C# (não necessário, mas ajuda).

## Passo a Passo para a Criação do Projeto

1. **Abrir o Unity Hub**:
   - Abra o Unity Hub na sua máquina.

2. **Criar um Novo Projeto**:
   - No Unity Hub, clique em **New Project**.
   - Selecione a opção **3D (Core)** para criar um projeto 3D.
   - Dê um nome ao projeto, como "MeuPrimeiroJogo".
   - Escolha uma pasta para salvar o projeto e clique em **Create Project**.

3. **Explorando a Interface da Unity**:
   - Após a criação, a Unity abrirá o projeto e mostrará a interface principal.
   - A interface da Unity tem várias seções principais:
     - **Scene View**: onde você visualiza e edita os objetos da cena.
     - **Game View**: a visão final do jogo, como será renderizado para o jogador.
     - **Hierarchy**: lista todos os objetos presentes na cena.
     - **Inspector**: mostra as propriedades do objeto selecionado.
     - **Project**: onde você gerencia todos os arquivos do projeto (modelos, scripts, texturas, etc.).

4. **Configurando a Cena Principal**:
   - Vamos criar um ambiente básico onde o personagem poderá se mover.

---

## Adicionando Objetos Básicos à Cena

1. **Adicionando um Plano (chão)**:
   - Clique com o botão direito no painel **Hierarchy**.
   - Selecione **3D Object > Plane** para criar um plano que servirá como chão.
   - Renomeie o plano para "Chao" para facilitar a organização.

2. **Adicionando um Objeto para o Jogador**:
   - Clique com o botão direito na **Hierarchy** novamente.
   - Selecione **3D Object > Cube** para criar um cubo que servirá como o personagem principal.
   - Renomeie o cubo para "Player".
   - Posicione o Player um pouco acima do plano para evitar que ele colida com o chão:
     - No painel **Inspector**, ajuste a posição Y do Player para 1 (em **Transform**).

3. **Entendendo Transformações**:
   - **Transform** é o componente que define a posição, rotação e escala de qualquer objeto na Unity.
   - Vamos explorar cada uma dessas transformações:
     - **Position**: define onde o objeto está na cena.
     - **Rotation**: define a orientação do objeto.
     - **Scale**: define o tamanho do objeto.
   - Experimente alterar os valores de `Position`, `Rotation` e `Scale` no **Inspector** para ver como o objeto se comporta na cena.

---

## Movendo, Rotacionando e Escalando Objetos na Unity

1. **Ferramentas de Transformação**:
   - Na barra de ferramentas superior, você verá várias ferramentas para manipular objetos:
     - **Move Tool** (atalho: W): permite mover o objeto selecionado.
     - **Rotate Tool** (atalho: E): permite rotacionar o objeto.
     - **Scale Tool** (atalho: R): permite redimensionar o objeto.
   - Tente usar essas ferramentas no Player para entender como mover e ajustar objetos na cena.

2. **Navegando pela Cena**:
   - Use o **botão direito do mouse** para girar a câmera na cena.
   - Use a **roda do mouse** para dar zoom in e out.
   - Pressione **Alt** + botão esquerdo para orbitar a câmera em torno do objeto selecionado.

---

## Configurando a Câmera para Visualizar o Jogador

1. **Selecionando a Câmera**:
   - Na `Hierarchy`, clique em **Main Camera** para selecionar a câmera principal.
   
2. **Posicionando a Câmera**:
   - No **Inspector**, ajuste a posição da câmera para que ela aponte para o Player:
     - Position (X: 0, Y: 5, Z: -10)
     - Rotation (X: 30, Y: 0, Z: 0)
   - Estes valores fazem com que a câmera fique atrás e um pouco acima do Player, simulando uma visão em terceira pessoa.

3. **Testando a Cena**:
   - Pressione **Play** na barra superior para iniciar a cena.
   - Verifique se o Player aparece no centro da visão da câmera.
   - Para sair do modo Play, clique em **Play** novamente.

---

## Estrutura e Organização do Projeto

1. **Criando Pastas para Organização**:
   - No painel **Project**, é importante organizar os arquivos do projeto.
   - Clique com o botão direito em **Assets** e selecione **Create > Folder**.
   - Crie as seguintes pastas:
     - **Scripts**: onde colocaremos os códigos em C#.
     - **Models**: onde guardaremos modelos 3D.
     - **Materials**: onde colocaremos os materiais (cores, texturas).
     - **Scenes**: onde salvaremos as cenas do jogo.

2. **Salvando a Cena**:
   - Vá ao menu **File > Save As**.
   - Salve a cena atual na pasta **Scenes** com o nome "MainScene".

---

## Conclusão

Nesta primeira aula, aprendemos a:
- Criar um novo projeto na Unity.
- Entender a interface e os principais painéis da Unity.
- Adicionar e configurar objetos 3D básicos (Plano e Cubo) para criar um ambiente inicial.
- Usar as ferramentas de Transformação para mover, rotacionar e escalar objetos.
- Organizar a estrutura do projeto criando pastas específicas.
- Configurar a câmera para uma visualização em terceira pessoa do personagem.

Na próxima aula, vamos criar um script para movimentar o Player usando o teclado. Prepare-se para aprender a programar interações básicas com o ambiente da Unity!

