using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Microwave
{
    public partial class Form1 : Form
    {

        int time = 0;
        int minuto = 0;
        int segundo = 0;
        int top = 153;
        int left = 1038;

        Boolean isPaused = false;

        public ListaAquecimentos listaAquecimentos;
        public string filePath = AppDomain.CurrentDomain.BaseDirectory + "arquivo.json";

        public Form1()
        {
            InitializeComponent();
            CarregarProgramas();
        }

        private void CarregarProgramas()
        {
            if (!File.Exists(filePath))
            {
                listaAquecimentos = new ListaAquecimentos();
                return;
            }

            string jsonString = File.ReadAllText(filePath);
            listaAquecimentos = JsonConvert.DeserializeObject<ListaAquecimentos>(jsonString);

            foreach (var aquecimento in listaAquecimentos.Aquecimentos)
                CriarBotao(aquecimento);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text += "9";
        }

        private void GetTime(int time, Label txtTempo, Timer timer1)
        {
            minuto = time >= 60 ? time / 60 : 0;
            segundo = time >= 60 ? time % 60 : time;

            txtTempo.Text = minuto + ":" + segundo;
            timer1.Enabled = true;
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                string[] tempoatual = txtTempo.Text.Split(':');
                int minutoatual = Convert.ToInt32(tempoatual[0]);
                int segundoatual = Convert.ToInt32(tempoatual[1]);
                time = (minutoatual * 60) + segundoatual;
                isPaused = false;
            }
            else
            {
                time = Convert.ToInt16(txtCaixaDigitavel.Text);
            }

            if (time > 120 || time < 1)
            {
                txtprincipal.Text = "Erro, digite um valor de 1 a 120 segundos";
            } 
            else
            {
                GetTime(time, txtTempo, timer1);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundo--;
            if (minuto > 0)
            {
                if (segundo < 0)
                {
                    segundo = 59;
                    minuto--;
                }
            }
            txtTempo.Text = minuto + ":" + segundo;
            if (minuto == 0 && segundo == 0)
            {
                timer1.Enabled = false;
            }
        }

        private void btniniciorapido_Click(object sender, EventArgs e)
        {
            if (txtCaixaDigitavel.Text != "")
            {
                string[] tempoatual = txtTempo.Text.Split(':');
                int minutoatual = Convert.ToInt32(tempoatual[0]);
                int segundoatual = Convert.ToInt32(tempoatual[1]);
                time = (minutoatual * 60) + segundoatual + 30;
            }
            else
            {
                txtPotencia.Value = 10;
                txtCaixaDigitavel.Text = "30";
                time = Convert.ToInt16(txtCaixaDigitavel.Text);
            }

            GetTime(time, txtTempo, timer1);
        }

        private void btnpipoca_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text = "180";
            txtPotencia.Value = 7;
            time = Convert.ToInt16(txtCaixaDigitavel.Text);

            txtprincipal.Text = "Alimento: Pipoca de microondas, Tempo: 3 minutos, Potência: 7, Instruções: Observar o barulho de estouro do milho, caso houver um intervalo de mais de 10 segundo entre um estouro e outro, interrompa o aquecimento.";

            GetTime(time, txtTempo, timer1);
        }

        private void btnleite_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text = "300";
            txtPotencia.Value = 5;
            time = Convert.ToInt16(txtCaixaDigitavel.Text);

            txtprincipal.Text = "Alimento: Leite, Tempo: 5 minutos, Potência: 5, Instruções: Cuidado com o aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode causar fervura imediata causando risco de queimaduras.";

            GetTime(time, txtTempo, timer1);
        }

        private void btnboi_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text = "840";
            txtPotencia.Value = 4;
            time = Convert.ToInt16(txtCaixaDigitavel.Text);

            txtprincipal.Text = "Alimento: Carne de boi, Tempo: 14 minutos, Potência: 4, Instruções: Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima, para o descongelamento uniforme.";

            GetTime(time, txtTempo, timer1);
        }

        private void btnfrango_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text = "480";
            txtPotencia.Value = 7;
            time = Convert.ToInt16(txtCaixaDigitavel.Text);

            txtprincipal.Text = "Alimento: Frango (qualquer corte), Tempo: 8 minutos, Potência: 7, Instruções: Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima, para o descongelamento uniforme.";

            GetTime(time, txtTempo, timer1);
        }

        private void btnfeijao_Click(object sender, EventArgs e)
        {
            txtCaixaDigitavel.Text = "480";
            txtPotencia.Value = 9;
            time = Convert.ToInt16(txtCaixaDigitavel.Text);

            txtprincipal.Text = "Alimento: Feijão, Tempo: 8 minutos, Potência: 9, Instruções: Deixe o recipiente destampado e em caso de plástico, cuidado ao retirar o recipiente pois o mesmo pode perder a resistência em altas temperaturas.";

            GetTime(time, txtTempo, timer1);
        }

        private void btnpausecancel_Click(object sender, EventArgs e)
        {
            if ((isPaused || txtCaixaDigitavel.Text != "") && isPaused)
            {
                txtTempo.Text = "0:00";
                txtCaixaDigitavel.Text = "0";
                txtprincipal.Text = "";
                isPaused = false;
            }
            else
            {
                isPaused = true;
            }

            timer1.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Validar as informações

            var novoAquecimento = new NovoAquecimento();
            novoAquecimento.Id = Guid.NewGuid();
            novoAquecimento.Nome = txtAquecimentoNome.Text;
            novoAquecimento.Alimento = txtAquecimentoAlimento.Text;
            novoAquecimento.Potencia = txtAquecimentoPotencia.Text;
            novoAquecimento.Tempo = txtAquecimentoTempo.Text;
            novoAquecimento.Instrucaodeuso = txtAquecimentoInstrucao.Text;

            CriarBotao(novoAquecimento);
            SalvarPrograma(novoAquecimento);
        }

        private void SalvarPrograma(NovoAquecimento novoAquecimento)
        {
            try
            {
                listaAquecimentos.Aquecimentos.Add(novoAquecimento);
                string jsonString = JsonConvert.SerializeObject(listaAquecimentos, Formatting.Indented);
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message);
            }
        }

        private void CriarBotao(NovoAquecimento aquecimento)
        {
            Button button = new Button();
            Point newLoc = new Point(left, top);
            button.Name = aquecimento.Id.ToString();
            button.Size = new Size(75, 57);
            button.Location = newLoc;
            button.Text = aquecimento.Alimento;
            button.Font = new Font(button.Font, FontStyle.Italic);
            button.Visible = true;
            button.Click += btnCarregar_Click;
            Controls.Add(button);
            top += button.Height + 5;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            var id = clickedButton.Name;

            var aquecimento = listaAquecimentos.Aquecimentos.Where(a => a.Id.ToString().Equals(id)).FirstOrDefault();

            txtCaixaDigitavel.Text = aquecimento.Tempo;
            txtPotencia.Value = Convert.ToInt16(aquecimento.Potencia);
            time = Convert.ToInt16(aquecimento.Tempo);
            txtprincipal.Text = aquecimento.Instrucaodeuso;

            GetTime(time, txtTempo, timer1);
        }

        private void txtAquecimentoPotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAquecimentoTempo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

            private void button_Click(object sender, EventArgs e)
        {               

        }
    }
}