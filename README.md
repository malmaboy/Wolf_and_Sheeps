# Wolf_and_Sheeps

#### Autores

Hugo Carvalho Nº 21901624

Luís Gomes Nº 21901362


- Hugo Carvalho
  - Tabuleiro
  - Posição Inicial das Peças

- Luis Gomes 
  - Movimentação das peças
  - Verificação de vitoria
  

#### Arquitetura da solução

- O programa está organizado por classes e métodos. A classe "BOARD" onde contém o código que desenha o tabuleiro. A Classe "Symbols" que contém as variáveis que sao utilizadas na classe "BOARD". Os métodos "InicialPos()" põe as posicões iniciais das peças incluindo a escolha da posição inicial do lobo. "BoardDisplay()" imprime o tabuleriro com as peças posicionadas. O "MoveWolf()" faz a movimentação do lobo. O "MoveSheep" faz a movimentação das ovelhas. 
  


- Referências

  - StackOverflow 
  - Livro(Aprenda a Programar com C#)
  - codereview.stackexchange

- Fluxograma

![](https://github.com/malmaboy/Images/blob/master/Flowchart.png)

- Bugs

    - A ovelha nº 4 por vezes não se movimenta para a posição correcta.
    - As ovelhas não reconhecem a colisão com as outras peças.
