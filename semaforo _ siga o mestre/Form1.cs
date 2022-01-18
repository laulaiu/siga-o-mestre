using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace semaforo___siga_o_mestre
{
    public partial class Form1 : Form
    {
        int num = 0;
        Timer tempo = new Timer();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempo.Enabled = true;

        }

        public void ligarSemaforo(object sender, EventArgs e)
        {
            int numero = 0;
            numero = num + 1;
            label1.Text = numero + "";
            this.num = numero;
            
            //acende e apaga o vermelho
            if(numero >= 0 && numero <6)
            {
                pcb_semaforo.Image = Properties.Resources.ped_verde;
                pcb_vermelho.Image = Properties.Resources.vermelho_aceso;
            }
            else
            {
                pcb_vermelho.Image = Properties.Resources.vermelho;
            }
            
            //acende e apaga o amarelo
            if (numero >= 6 && numero <8)
            {
                pcb_amarelo.Image = Properties.Resources.amarelo_aceso;
            }
            else
            {
                pcb_amarelo.Image = Properties.Resources.amarelo;
            }

            //acende e apaga o verde
            if (numero >= 8 && numero <15)
            {
                pcb_semaforo.Image = Properties.Resources.ped_vermelho;
                pcb_verde.Image = Properties.Resources.verde_aceso;
            }
            else
            {
                pcb_verde.Image = Properties.Resources.verde;
            }


            if(numero == 14)
            {
                this.num = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            tempo.Interval = 1000;
            tempo.Tick += new EventHandler(ligarSemaforo);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            tempo.Enabled = false;
        }
    }


}
