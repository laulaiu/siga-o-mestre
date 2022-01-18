using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siga_o_mestre
{
    public partial class Form1 : Form
    {

        Timer tempo= new Timer();        
        Timer transicao= new Timer();        
        List<int> sequencia = new List<int>();


        int indice = 0;
        int troca_vez = 0;
        bool vdd = false;
        int dificuldade = 814;
        int click_do_usuario;
        int troca_transicao = 0;
        int pontuacao = 0;
        int sequencia_game= 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_comecar_Click(object sender, EventArgs e)
        {

            if (radioButton_facil.Checked)
            {
                this.dificuldade = 714;
            }else if(radioButton_medio.Checked)
            {
                this.dificuldade = 565;
            }
            else if (radioButton_dificil.Checked)
            {
                this.dificuldade = 312;
            }
            else if (radioButton_veterano.Checked)
            {
                this.dificuldade = 243;
            }


            tempo.Enabled = true;            
            btn_comecar.Enabled = false;

        }


        public void click()
        {

            if(this.troca_vez == 0) {

                int botao = -1;
                if (vdd == false)
                {

                    desativa_botao();
                    this.tempo.Interval = this.dificuldade;
                    botao = gerador_click();


                    if (this.indice == sequencia.Count() || sequencia.Count() == 0)
                    {
                        botao = gerador_click();
                    }
                    else
                    {
                        botao = sequencia[this.indice];
                        //label_sequencia.Text = this.indice + "";
                    }
                }
                else
                {
                    botao = this.click_do_usuario;
                }

                //________________________________________________________________
                if (botao == 0)
                {
                    pictureBox_amarelo.Image = Properties.Resources.amarelo_aceso;
                }
                if (botao == 1)
                {
                    pictureBox_azul.Image = Properties.Resources.azul_aceso;

                }
                if (botao == 2)
                {
                    pictureBox_verde.Image = Properties.Resources.verde_aceso;
                }
                if (botao == 3)
                {
                    pictureBox_vermelho.Image = Properties.Resources.vermelho_aceso;
                }
                this.troca_vez = 1;

                if (vdd == false)
                {
                    if (indice == sequencia.Count())
                    {
                        sequencia.Add(botao);
                        this.indice = 0;
                        this.vdd = true;
                        ativa_botao();

                    }
                    else
                    {
                        this.indice += 1;
                    }
                }
                else
                {
                    if(this.sequencia[this.indice] == botao)
                    {
                        this.indice += 1;
                        if(this.sequencia.Count == this.indice)
                        {
                            //venci
                            this.pontuacao += 13;
                            this.sequencia_game = this.sequencia.Count;
                            label_pontuacao.Text = "Pontuacao: "+this.pontuacao;
                            label_sequencia.Text = "Sequencia: " + this.sequencia_game;
                            this.vdd = false;                            
                            this.indice = 0;
                            this.tempo.Enabled = false;
                            this.transicao.Enabled = true;

                        }
                    }
                    else
                    {
                        MessageBox.Show("voce errou");
                        this.indice = 0;
                        this.troca_vez = 0;
                        this.sequencia.Clear();
                        this.vdd = false;
                        btn_comecar.Enabled = true;
                        desativa_botao();
                    }
                }                
            }
            else
            {
                pictureBox_vermelho.Image = Properties.Resources.vermelho;
                pictureBox_verde.Image = Properties.Resources.verde;
                pictureBox_azul.Image = Properties.Resources.azul;
                pictureBox_amarelo.Image = Properties.Resources.amarelo;
                this.troca_vez = 0;

                if(vdd == true)
                {
                    tempo.Enabled = false;
                    this.vdd = false;
                }
            }

        }

        public void iniciar_click(Object sende, EventArgs e)
        {
            click();
        }


        public int gerador_click()
        {
            Random aleatorio = new Random();
               return aleatorio.Next(4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            desativa_botao();
            tempo.Interval = this.dificuldade;
            tempo.Tick += new EventHandler(iniciar_click);

            this.transicao.Interval = 900;
            this.transicao.Tick += new EventHandler(transicao_botao);
        }

        public void transicao_botao(object sender, EventArgs e)
        {
            if(this.troca_transicao == 0)
            {
                pictureBox_vermelho.Image = Properties.Resources.vermelho_aceso;
                pictureBox_verde.Image = Properties.Resources.verde_aceso;
                pictureBox_azul.Image = Properties.Resources.azul_aceso;
                pictureBox_amarelo.Image = Properties.Resources.amarelo_aceso;
                this.troca_transicao = 1;
            }
            else
            {
                pictureBox_vermelho.Image = Properties.Resources.vermelho;
                pictureBox_verde.Image = Properties.Resources.verde;
                pictureBox_azul.Image = Properties.Resources.azul;
                pictureBox_amarelo.Image = Properties.Resources.amarelo;
                this.troca_transicao = 0;
                this.transicao.Enabled = false;
                tempo.Enabled = true;
            }
        }

        private void pictureBox_amarelo_Click(object sender, EventArgs e)
        {
            //quando o usuario clicar, sera esse tempo o do botao
            this.tempo.Interval = 200;
            pictureBox_amarelo.Image = Properties.Resources.amarelo_aceso;
            tempo.Enabled = true;
            this.click_do_usuario = 0;
            this.vdd = true;
        }

        private void pictureBox_azul_Click(object sender, EventArgs e)
        {
            //quando o usuario clicar, sera esse tempo o do botao
            this.tempo.Interval = 200;
            pictureBox_azul.Image = Properties.Resources.azul_aceso;
            tempo.Enabled = true;
            this.click_do_usuario = 1;
            this.vdd = true;
        }

        private void pictureBox_verde_Click(object sender, EventArgs e)
        {
            //quando o usuario clicar, sera esse tempo o do botao
            this.tempo.Interval = 200;
            pictureBox_verde.Image = Properties.Resources.verde_aceso;
            tempo.Enabled = true;
            this.click_do_usuario = 2;
            this.vdd = true;
        }

        private void pictureBox_vermelho_Click(object sender, EventArgs e)
        {
            //quando o usuario clicar, sera esse tempo o do botao
            this.tempo.Interval = 200;
            pictureBox_vermelho.Image = Properties.Resources.vermelho_aceso;
            tempo.Enabled = true;
            this.click_do_usuario = 3;
            this.vdd = true;
        }

        public void desativa_botao()
        {
            pictureBox_amarelo.Enabled = false;
            pictureBox_azul.Enabled = false;
            pictureBox_verde.Enabled = false;
            pictureBox_vermelho.Enabled = false;
        }

        public void ativa_botao()
        {
            pictureBox_amarelo.Enabled = true;
            pictureBox_azul.Enabled = true;
            pictureBox_verde.Enabled = true;
            pictureBox_vermelho.Enabled = true;
        }
    }
}
