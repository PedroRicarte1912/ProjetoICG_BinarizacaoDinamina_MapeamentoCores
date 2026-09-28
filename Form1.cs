/*using System.Drawing;

*Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 25 / 09 / 2026
 * Autores do Projeto: XXXXXXXXXXXXXXXXXXXXXXXXX
 *
 * Turma: 3F
 * Atividade Proposta em aula
 * Observação: < colocar se houver>
 * 
 * 
 * ******************************************************************/
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace Atividade_ICG_BinarizacaoDinamica_MapeamentoCores
{
    public partial class Form1 : Form
    {
        // -------------------------------------------------------------------
        // CAMPOS PRIVADOS DE CLASSE
        // -------------------------------------------------------------------
        private String caminhoImagemOriginal = string.Empty;
        private String caminhoImagemSaida = string.Empty;

        // Campos obrigatórios para armazenar as cores A e B selecionadas
        private Color corA = Color.Empty;
        private Color corB = Color.Empty;

        // Armazena o objeto de imagem atual no PictureBox para liberação adequada
        private Image imagemExibidaAtual = null;
        public Form1()
        {
            // Configurações gerais da janela
            this.Text = "Binarização Dinâmica com Mapeamento de Cores";
            this.Size = new Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            // Define o caminho temporário de saída para salvar o resultado da binarização
            this.caminhoImagemSaida = Path.Combine(Application.StartupPath, "resultado_temp.bmp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void labelLimiarTitulo_Click(object sender, EventArgs e)
        {

        }

        private void labelLimiarValor_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxResultado_Click(object sender, EventArgs e)
        {

        }

        private void trackBarLimiar_Scroll(object sender, EventArgs e)
        {
            labelLimiarValor.Text = trackBarLimiar.Value.ToString();
        }

        private void btnCarregarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem (*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";
            openFileDialog.Title = "Selecione uma imagem em escala de cinza";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                caminhoImagemOriginal = openFileDialog.FileName;

                // Carrega a imagem selecionada e exibe no PictureBox
                AtualizarPictureBox(caminhoImagemOriginal);
            }
        }

        private void btnCorA_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                corA = colorDialog.Color;

                // Atualiza o visual do botão em vez de usar um Panel
                btnCorA.BackColor = corA;
                btnCorA.ForeColor = (corA.R * 0.299 + corA.G * 0.587 + corA.B * 0.114) > 128 ? Color.Black : Color.White;
                btnCorA.Text = $"Cor A: R={corA.R} G={corA.G} B={corA.B}";
            }
        }

        private void btnCorB_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                corB = colorDialog.Color;

                // Atualiza o visual do botão em vez de usar um Panel
                btnCorB.BackColor = corB;
                btnCorB.ForeColor = (corB.R * 0.299 + corB.G * 0.587 + corB.B * 0.114) > 128 ? Color.Black : Color.White;
                btnCorB.Text = $"Cor B: R={corB.R} G={corB.G} B={corB.B}";
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            // Validações antes do processamento
            if (string.IsNullOrEmpty(caminhoImagemOriginal) || !File.Exists(caminhoImagemOriginal))
            {
                MessageBox.Show("Por favor, carregue uma imagem válida antes de processar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (corA.IsEmpty)
            {
                MessageBox.Show("Por favor, selecione a 'Cor A' antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (corB.IsEmpty)
            {
                MessageBox.Show("Por favor, selecione a 'Cor B' antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Executa a binarização
            int limiarT = trackBarLimiar.Value;
            Threshold(caminhoImagemOriginal, caminhoImagemSaida, limiarT);
        }
        public void Threshold(String imagem, String imagemsaida, int T)
        {
            // Instanciação manual do Bitmap sem uso de 'using'
            Bitmap bitmapEntrada = new Bitmap(imagem);

            // Criação do Bitmap de saída
            int largura = bitmapEntrada.Width;
            int altura = bitmapEntrada.Height;
            Bitmap bitmapSaida = new Bitmap(largura, altura);

            // Varredura pixel a pixel utilizando laço for duplo (X e Y)
            for (int y = 0; y < altura; y++)
            {
                for (int x = 0; x < largura; x++)
                {
                    // Obtém a cor do pixel original
                    Color pixelOriginal = bitmapEntrada.GetPixel(x, y);

                    // Canal R utilizado para escala de cinza (R=G=B)
                    int intensidadeCinza = pixelOriginal.R;

                    // Aplicação da regra de mapeamento
                    if (intensidadeCinza < T)
                    {
                        bitmapSaida.SetPixel(x, y, corA);
                    }
                    else
                    {
                        bitmapSaida.SetPixel(x, y, corB);
                    }
                }
            }

            // Salva o arquivo final
            bitmapSaida.Save(imagemsaida);

            // Liberação explícita de memória
            bitmapEntrada.Dispose();
            bitmapSaida.Dispose();

            // Carrega e exibe a imagem gerada no PictureBox
            AtualizarPictureBox(imagemsaida);
        }
        private void AtualizarPictureBox(string caminhoArquivo)
        {
            // Libera a referência do PictureBox
            pictureBoxResultado.Image = null;

            // Libera o objeto anterior de memória se existir
            if (imagemExibidaAtual != null)
            {
                imagemExibidaAtual.Dispose();
                imagemExibidaAtual = null;
            }

            // Carrega a imagem criando uma cópia em memória para evitar o bloqueio do arquivo
            Image imagemAuxiliar = Image.FromFile(caminhoArquivo);
            imagemExibidaAtual = new Bitmap(imagemAuxiliar);
            imagemAuxiliar.Dispose(); // Libera o manipulador de arquivo do disco

            // Define no PictureBox
            pictureBoxResultado.Image = imagemExibidaAtual;
        }
    }
}

