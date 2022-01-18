
namespace siga_o_mestre
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_amarelo = new System.Windows.Forms.PictureBox();
            this.pictureBox_azul = new System.Windows.Forms.PictureBox();
            this.pictureBox_verde = new System.Windows.Forms.PictureBox();
            this.pictureBox_vermelho = new System.Windows.Forms.PictureBox();
            this.btn_comecar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_veterano = new System.Windows.Forms.RadioButton();
            this.radioButton_dificil = new System.Windows.Forms.RadioButton();
            this.radioButton_medio = new System.Windows.Forms.RadioButton();
            this.radioButton_facil = new System.Windows.Forms.RadioButton();
            this.label_sequencia = new System.Windows.Forms.Label();
            this.label_pontuacao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_amarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_azul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vermelho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_amarelo
            // 
            this.pictureBox_amarelo.Image = global::siga_o_mestre.Properties.Resources.amarelo;
            this.pictureBox_amarelo.Location = new System.Drawing.Point(93, 38);
            this.pictureBox_amarelo.Name = "pictureBox_amarelo";
            this.pictureBox_amarelo.Size = new System.Drawing.Size(164, 171);
            this.pictureBox_amarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_amarelo.TabIndex = 0;
            this.pictureBox_amarelo.TabStop = false;
            this.pictureBox_amarelo.Click += new System.EventHandler(this.pictureBox_amarelo_Click);
            // 
            // pictureBox_azul
            // 
            this.pictureBox_azul.Image = global::siga_o_mestre.Properties.Resources.azul;
            this.pictureBox_azul.Location = new System.Drawing.Point(286, 38);
            this.pictureBox_azul.Name = "pictureBox_azul";
            this.pictureBox_azul.Size = new System.Drawing.Size(164, 171);
            this.pictureBox_azul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_azul.TabIndex = 1;
            this.pictureBox_azul.TabStop = false;
            this.pictureBox_azul.Click += new System.EventHandler(this.pictureBox_azul_Click);
            // 
            // pictureBox_verde
            // 
            this.pictureBox_verde.Image = global::siga_o_mestre.Properties.Resources.verde;
            this.pictureBox_verde.Location = new System.Drawing.Point(93, 232);
            this.pictureBox_verde.Name = "pictureBox_verde";
            this.pictureBox_verde.Size = new System.Drawing.Size(164, 171);
            this.pictureBox_verde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_verde.TabIndex = 2;
            this.pictureBox_verde.TabStop = false;
            this.pictureBox_verde.Click += new System.EventHandler(this.pictureBox_verde_Click);
            // 
            // pictureBox_vermelho
            // 
            this.pictureBox_vermelho.Image = global::siga_o_mestre.Properties.Resources.vermelho;
            this.pictureBox_vermelho.Location = new System.Drawing.Point(286, 232);
            this.pictureBox_vermelho.Name = "pictureBox_vermelho";
            this.pictureBox_vermelho.Size = new System.Drawing.Size(164, 171);
            this.pictureBox_vermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_vermelho.TabIndex = 3;
            this.pictureBox_vermelho.TabStop = false;
            this.pictureBox_vermelho.Click += new System.EventHandler(this.pictureBox_vermelho_Click);
            // 
            // btn_comecar
            // 
            this.btn_comecar.Location = new System.Drawing.Point(223, 246);
            this.btn_comecar.Name = "btn_comecar";
            this.btn_comecar.Size = new System.Drawing.Size(92, 33);
            this.btn_comecar.TabIndex = 4;
            this.btn_comecar.Text = "Comecar";
            this.btn_comecar.UseVisualStyleBackColor = true;
            this.btn_comecar.Click += new System.EventHandler(this.btn_comecar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_veterano);
            this.groupBox1.Controls.Add(this.radioButton_dificil);
            this.groupBox1.Controls.Add(this.radioButton_medio);
            this.groupBox1.Controls.Add(this.radioButton_facil);
            this.groupBox1.Location = new System.Drawing.Point(209, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 67);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // radioButton_veterano
            // 
            this.radioButton_veterano.AutoSize = true;
            this.radioButton_veterano.Location = new System.Drawing.Point(60, 44);
            this.radioButton_veterano.Name = "radioButton_veterano";
            this.radioButton_veterano.Size = new System.Drawing.Size(67, 17);
            this.radioButton_veterano.TabIndex = 3;
            this.radioButton_veterano.TabStop = true;
            this.radioButton_veterano.Text = "veterano";
            this.radioButton_veterano.UseVisualStyleBackColor = true;
            // 
            // radioButton_dificil
            // 
            this.radioButton_dificil.AutoSize = true;
            this.radioButton_dificil.Location = new System.Drawing.Point(6, 44);
            this.radioButton_dificil.Name = "radioButton_dificil";
            this.radioButton_dificil.Size = new System.Drawing.Size(48, 17);
            this.radioButton_dificil.TabIndex = 2;
            this.radioButton_dificil.TabStop = true;
            this.radioButton_dificil.Text = "dificil";
            this.radioButton_dificil.UseVisualStyleBackColor = true;
            // 
            // radioButton_medio
            // 
            this.radioButton_medio.AutoSize = true;
            this.radioButton_medio.Checked = true;
            this.radioButton_medio.Location = new System.Drawing.Point(60, 10);
            this.radioButton_medio.Name = "radioButton_medio";
            this.radioButton_medio.Size = new System.Drawing.Size(53, 17);
            this.radioButton_medio.TabIndex = 1;
            this.radioButton_medio.TabStop = true;
            this.radioButton_medio.Text = "medio";
            this.radioButton_medio.UseVisualStyleBackColor = true;
            // 
            // radioButton_facil
            // 
            this.radioButton_facil.AutoSize = true;
            this.radioButton_facil.Location = new System.Drawing.Point(6, 10);
            this.radioButton_facil.Name = "radioButton_facil";
            this.radioButton_facil.Size = new System.Drawing.Size(44, 17);
            this.radioButton_facil.TabIndex = 0;
            this.radioButton_facil.Text = "facil";
            this.radioButton_facil.UseVisualStyleBackColor = true;
            // 
            // label_sequencia
            // 
            this.label_sequencia.AutoSize = true;
            this.label_sequencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sequencia.Location = new System.Drawing.Point(89, 9);
            this.label_sequencia.Name = "label_sequencia";
            this.label_sequencia.Size = new System.Drawing.Size(114, 20);
            this.label_sequencia.TabIndex = 6;
            this.label_sequencia.Text = "Sequencia: 0";
            // 
            // label_pontuacao
            // 
            this.label_pontuacao.AutoSize = true;
            this.label_pontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pontuacao.Location = new System.Drawing.Point(282, 9);
            this.label_pontuacao.Name = "label_pontuacao";
            this.label_pontuacao.Size = new System.Drawing.Size(115, 20);
            this.label_pontuacao.TabIndex = 7;
            this.label_pontuacao.Text = "Pontuacao: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 415);
            this.Controls.Add(this.label_pontuacao);
            this.Controls.Add(this.label_sequencia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_comecar);
            this.Controls.Add(this.pictureBox_vermelho);
            this.Controls.Add(this.pictureBox_verde);
            this.Controls.Add(this.pictureBox_azul);
            this.Controls.Add(this.pictureBox_amarelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_amarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_azul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vermelho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_amarelo;
        private System.Windows.Forms.PictureBox pictureBox_azul;
        private System.Windows.Forms.PictureBox pictureBox_verde;
        private System.Windows.Forms.PictureBox pictureBox_vermelho;
        private System.Windows.Forms.Button btn_comecar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_veterano;
        private System.Windows.Forms.RadioButton radioButton_dificil;
        private System.Windows.Forms.RadioButton radioButton_medio;
        private System.Windows.Forms.RadioButton radioButton_facil;
        private System.Windows.Forms.Label label_sequencia;
        private System.Windows.Forms.Label label_pontuacao;
    }
}

