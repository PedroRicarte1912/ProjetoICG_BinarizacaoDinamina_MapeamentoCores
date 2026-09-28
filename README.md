# Binarização Dinâmica com Mapeamento de Cores

Aplicação desktop desenvolvida em **C# (Windows Forms)** para a disciplina de Introdução à Computação Gráfica (ICG). O projeto realiza o processamento digital de imagens através do algoritmo de limiarização (*thresholding*), permitindo mapear tons claros e escuros de uma imagem em escala de cinza para duas cores personalizadas selecionadas pelo usuário.

---

## 📌 Informações Acadêmicas

* **Instituição:** Colégio Técnico Antônio Teixeira Fernandes (Univap)
* **Curso:** Técnico em Informática
* **Turma:** 3F
* **Data de Entrega:** 25/09/2026
* **Autores:** Pedro Ricarte Gisler
* Julia Carolina Maciel

---

## 🚀 Funcionalidades

- **Carregamento de Imagens:** Suporte para importação de arquivos nos formatos `.bmp`, `.jpg` e `.png`.
- **Ajuste de Limiar Dinâmico:** Controle do valor do limiar ($T$) através de um componente `TrackBar` em tempo de execução.
- **Mapeamento Personalizado de Cores:**
  - **Cor A:** Mapeia pixels com intensidade menor que o limiar ($I < T$).
  - **Cor B:** Mapeia pixels com intensidade maior ou igual ao limiar ($I \ge T$).
- **Contraste Dinâmico de Interface:** O texto dos botões de seleção de cor ajusta automaticamente a cor da fonte (preto ou branco) para garantir a legibilidade de acordo com a cor de fundo escolhida.
- **Gerenciamento Eficiente de Memória:** Tratamento explícito de recursos (`Dispose`) e técnica de cópia em memória para evitar o bloqueio de escrita do arquivo de imagem em disco.

---

## 🛠️ Tecnologias Utilizadas

- **Linguagem:** C# (.NET Framework / .NET Core)
- **Interface Gráfica:** Windows Forms (WinForms)
- **Biblioteca Principal:** `System.Drawing` (Manipulação de imagens via `Bitmap` e `Color`)

---

## 🧠 Como Funciona o Algoritmo

O algoritmo de thresholding com mapeamento percorre a matriz de pixels da imagem original ponto a ponto:

1. **Leitura da Intensidade:** Obtém o valor do canal vermelho (R) da imagem em escala de cinza (onde $R = G = B$).
2. **Comparação com o Limiar ($T$):**
   $$\text{Cor Resultante} = \begin{cases} \text{Cor A}, & \text{se } \text{Pixel}(x, y) < T \\ \text{Cor B}, & \text{se } \text{Pixel}(x, y) \ge T \end{cases}$$
3. **Mapeamento:** O pixel da imagem de saída é atualizado com a cor correspondente.
4. **Exportação:** A imagem resultante é salva em um arquivo temporário (`resultado_temp.bmp`) e recarregada na interface.

---

## 📋 Pré-requisitos e Como Executar

### Pré-requisitos
* **Visual Studio 2019** ou superior com a carga de trabalho *Desenvolvimento para desktop com .NET* instalada.
* **SDK do .NET Framework** compatível.

### Passo a Passo
1. Clone este repositório ou baixe os arquivos do projeto.
2. Abra o arquivo de solução (`.sln`) no Visual Studio.
3. Certifique-se de que o arquivo `Form1.cs` e a sua respectiva interface gráfica (`Form1.Designer.cs`) estejam vinculados no mesmo projeto.
4. Pressione `F5` ou clique em **Iniciar (Start)** para compilar e executar o projeto.

---

## 🖥️ Como Usar a Aplicação

1. Clique no botão de **Carregar Imagem** e selecione uma imagem em escala de cinza.
2. Defina a **Cor A** (cor para regiões abaixo do limiar).
3. Defina a **Cor B** (cor para regiões acima ou iguais ao limiar).
4. Ajuste a barra deslizante do **Limiar ($T$)** para a sensibilidade desejada.
5. Clique em **Aplicar** para processar e visualizar o resultado final na tela.
