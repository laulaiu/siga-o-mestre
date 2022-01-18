
namespace semaforo___siga_o_mestre
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
            this.pcb_amarelo = new System.Windows.Forms.PictureBox();
            this.pcb_vermelho = new System.Windows.Forms.PictureBox();
            this.pcb_verde = new System.Windows.Forms.PictureBox();
            this.pcb_semaforo = new System.Windows.Forms.PictureBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_amarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_vermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_semaforo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_amarelo
            // 
            this.pcb_amarelo.Image = global::semaforo___siga_o_mestre.Properties.Resources.amarelo;
            this.pcb_amarelo.Location = new System.Drawing.Point(102, 174);
            this.pcb_amarelo.Name = "pcb_amarelo";
            this.pcb_amarelo.Size = new System.Drawing.Size(88, 80);
            this.pcb_amarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_amarelo.TabIndex = 0;
            this.pcb_amarelo.TabStop = false;
            // 
            // pcb_vermelho
            // 
            this.pcb_vermelho.Image = global::semaforo___siga_o_mestre.Properties.Resources.vermelho;
            this.pcb_vermelho.Location = new System.Drawing.Point(102, 54);
            this.pcb_vermelho.Name = "pcb_vermelho";
            this.pcb_vermelho.Size = new System.Drawing.Size(90, 80);
            this.pcb_vermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_vermelho.TabIndex = 1;
            this.pcb_vermelho.TabStop = false;
            // 
            // pcb_verde
            // 
            this.pcb_verde.Image = global::semaforo___siga_o_mestre.Properties.Resources.verde;
            this.pcb_verde.Location = new System.Drawing.Point(102, 284);
            this.pcb_verde.Name = "pcb_verde";
            this.pcb_verde.Size = new System.Drawing.Size(88, 80);
            this.pcb_verde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_verde.TabIndex = 2;
            this.pcb_verde.TabStop = false;
            // 
            // pcb_semaforo
            // 
            this.pcb_semaforo.Image = global::semaforo___siga_o_mestre.Properties.Resources.ped_verde;
            this.pcb_semaforo.Location = new System.Drawing.Point(297, 84);
            this.pcb_semaforo.Name = "pcb_semaforo";
            this.pcb_semaforo.Size = new System.Drawing.Size(136, 257);
            this.pcb_semaforo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_semaforo.TabIndex = 3;
            this.pcb_semaforo.TabStop = false;
            this.pcb_semaforo.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(476, 150);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(120, 61);
            this.btn_iniciar.TabIndex = 4;
            this.btn_iniciar.Text = "Start";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(476, 244);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(120, 61);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 410);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.pcb_semaforo);
            this.Controls.Add(this.pcb_verde);
            this.Controls.Add(this.pcb_vermelho);
            this.Controls.Add(this.pcb_amarelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_amarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_vermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_semaforo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_amarelo;
        private System.Windows.Forms.PictureBox pcb_vermelho;
        private System.Windows.Forms.PictureBox pcb_verde;
        private System.Windows.Forms.PictureBox pcb_semaforo;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_stop;
    }
}

