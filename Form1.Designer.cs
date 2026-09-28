namespace Atividade_ICG_BinarizacaoDinamica_MapeamentoCores
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxResultado = new PictureBox();
            trackBarLimiar = new TrackBar();
            labelLimiarTitulo = new Label();
            labelLimiarValor = new Label();
            btnCarregarImagem = new Button();
            btnCorA = new Button();
            btnCorB = new Button();
            btnAplicar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLimiar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxResultado
            // 
            pictureBoxResultado.Location = new Point(215, 12);
            pictureBoxResultado.Name = "pictureBoxResultado";
            pictureBoxResultado.Size = new Size(563, 375);
            pictureBoxResultado.TabIndex = 0;
            pictureBoxResultado.TabStop = false;
            pictureBoxResultado.Click += pictureBoxResultado_Click;
            // 
            // trackBarLimiar
            // 
            trackBarLimiar.Location = new Point(2, 406);
            trackBarLimiar.Name = "trackBarLimiar";
            trackBarLimiar.Size = new Size(288, 45);
            trackBarLimiar.TabIndex = 1;
            trackBarLimiar.Scroll += trackBarLimiar_Scroll;
            // 
            // labelLimiarTitulo
            // 
            labelLimiarTitulo.AutoSize = true;
            labelLimiarTitulo.Location = new Point(25, 38);
            labelLimiarTitulo.Name = "labelLimiarTitulo";
            labelLimiarTitulo.Size = new Size(98, 15);
            labelLimiarTitulo.TabIndex = 2;
            labelLimiarTitulo.Text = "Posição Track Bar";
            labelLimiarTitulo.Click += labelLimiarTitulo_Click;
            // 
            // labelLimiarValor
            // 
            labelLimiarValor.AutoSize = true;
            labelLimiarValor.Location = new Point(25, 71);
            labelLimiarValor.Name = "labelLimiarValor";
            labelLimiarValor.Size = new Size(36, 15);
            labelLimiarValor.TabIndex = 3;
            labelLimiarValor.Text = "Valor:";
            labelLimiarValor.Click += labelLimiarValor_Click;
            // 
            // btnCarregarImagem
            // 
            btnCarregarImagem.Location = new Point(25, 123);
            btnCarregarImagem.Name = "btnCarregarImagem";
            btnCarregarImagem.Size = new Size(121, 23);
            btnCarregarImagem.TabIndex = 4;
            btnCarregarImagem.Text = "Carregar Imagem";
            btnCarregarImagem.UseVisualStyleBackColor = true;
            btnCarregarImagem.Click += btnCarregarImagem_Click;
            // 
            // btnCorA
            // 
            btnCorA.Location = new Point(25, 164);
            btnCorA.Name = "btnCorA";
            btnCorA.Size = new Size(121, 23);
            btnCorA.TabIndex = 5;
            btnCorA.Text = "Cor A";
            btnCorA.UseVisualStyleBackColor = true;
            btnCorA.Click += btnCorA_Click;
            // 
            // btnCorB
            // 
            btnCorB.Location = new Point(25, 208);
            btnCorB.Name = "btnCorB";
            btnCorB.Size = new Size(121, 23);
            btnCorB.TabIndex = 6;
            btnCorB.Text = "Cor B";
            btnCorB.UseVisualStyleBackColor = true;
            btnCorB.Click += btnCorB_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(25, 254);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(121, 23);
            btnAplicar.TabIndex = 7;
            btnAplicar.Text = "Aplicar Cores";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 466);
            Controls.Add(btnAplicar);
            Controls.Add(btnCorB);
            Controls.Add(btnCorA);
            Controls.Add(btnCarregarImagem);
            Controls.Add(labelLimiarValor);
            Controls.Add(labelLimiarTitulo);
            Controls.Add(trackBarLimiar);
            Controls.Add(pictureBoxResultado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxResultado).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarLimiar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxResultado;
        private TrackBar trackBarLimiar;
        private Label labelLimiarTitulo;
        private Label labelLimiarValor;
        private Button btnCarregarImagem;
        private Button btnCorA;
        private Button btnCorB;
        private Button btnAplicar;
    }
}
