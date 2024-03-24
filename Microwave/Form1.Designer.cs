namespace Microwave
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCaixaDigitavel = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtprincipal = new System.Windows.Forms.TextBox();
            this.txtPotencia = new System.Windows.Forms.NumericUpDown();
            this.potencia = new System.Windows.Forms.Label();
            this.btnPipoca = new System.Windows.Forms.Button();
            this.btnLeite = new System.Windows.Forms.Button();
            this.btnBoi = new System.Windows.Forms.Button();
            this.btnFrango = new System.Windows.Forms.Button();
            this.btnFeijao = new System.Windows.Forms.Button();
            this.btnInicioRapido = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnPauseCancel = new System.Windows.Forms.Button();
            this.txtTempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAquecimentoNome = new System.Windows.Forms.TextBox();
            this.txtAquecimentoAlimento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAquecimentoPotencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAquecimentoTempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtAquecimentoInstrucao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPotencia)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtCaixaDigitavel
            // 
            this.txtCaixaDigitavel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtCaixaDigitavel.Location = new System.Drawing.Point(1101, 54);
            this.txtCaixaDigitavel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaixaDigitavel.Multiline = true;
            this.txtCaixaDigitavel.Name = "txtCaixaDigitavel";
            this.txtCaixaDigitavel.Size = new System.Drawing.Size(219, 41);
            this.txtCaixaDigitavel.TabIndex = 0;
            this.txtCaixaDigitavel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 814);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // txtprincipal
            // 
            this.txtprincipal.Location = new System.Drawing.Point(31, 43);
            this.txtprincipal.Margin = new System.Windows.Forms.Padding(4);
            this.txtprincipal.Multiline = true;
            this.txtprincipal.Name = "txtprincipal";
            this.txtprincipal.Size = new System.Drawing.Size(999, 499);
            this.txtprincipal.TabIndex = 2;
            // 
            // txtPotencia
            // 
            this.txtPotencia.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtPotencia.Location = new System.Drawing.Point(1241, 111);
            this.txtPotencia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPotencia.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtPotencia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtPotencia.Name = "txtPotencia";
            this.txtPotencia.Size = new System.Drawing.Size(80, 49);
            this.txtPotencia.TabIndex = 2;
            this.txtPotencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPotencia.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // potencia
            // 
            this.potencia.AutoSize = true;
            this.potencia.Font = new System.Drawing.Font("Verdana", 15.25F, System.Drawing.FontStyle.Bold);
            this.potencia.Location = new System.Drawing.Point(1084, 122);
            this.potencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.potencia.Name = "potencia";
            this.potencia.Size = new System.Drawing.Size(136, 38);
            this.potencia.TabIndex = 4;
            this.potencia.Text = "Potência";
            this.potencia.UseCompatibleTextRendering = true;
            // 
            // btnPipoca
            // 
            this.btnPipoca.Location = new System.Drawing.Point(1053, 188);
            this.btnPipoca.Margin = new System.Windows.Forms.Padding(4);
            this.btnPipoca.Name = "btnPipoca";
            this.btnPipoca.Size = new System.Drawing.Size(100, 70);
            this.btnPipoca.TabIndex = 5;
            this.btnPipoca.Text = "Pipoca";
            this.btnPipoca.UseVisualStyleBackColor = true;
            this.btnPipoca.Click += new System.EventHandler(this.btnpipoca_Click);
            // 
            // btnLeite
            // 
            this.btnLeite.Location = new System.Drawing.Point(1161, 188);
            this.btnLeite.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeite.Name = "btnLeite";
            this.btnLeite.Size = new System.Drawing.Size(100, 70);
            this.btnLeite.TabIndex = 6;
            this.btnLeite.Text = "Leite";
            this.btnLeite.UseVisualStyleBackColor = true;
            this.btnLeite.Click += new System.EventHandler(this.btnleite_Click);
            // 
            // btnBoi
            // 
            this.btnBoi.Location = new System.Drawing.Point(1275, 188);
            this.btnBoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoi.Name = "btnBoi";
            this.btnBoi.Size = new System.Drawing.Size(100, 70);
            this.btnBoi.TabIndex = 7;
            this.btnBoi.Text = "Carne de boi";
            this.btnBoi.UseVisualStyleBackColor = true;
            this.btnBoi.Click += new System.EventHandler(this.btnboi_Click);
            // 
            // btnFrango
            // 
            this.btnFrango.Location = new System.Drawing.Point(1053, 266);
            this.btnFrango.Margin = new System.Windows.Forms.Padding(4);
            this.btnFrango.Name = "btnFrango";
            this.btnFrango.Size = new System.Drawing.Size(100, 70);
            this.btnFrango.TabIndex = 8;
            this.btnFrango.Text = "Frango";
            this.btnFrango.UseVisualStyleBackColor = true;
            this.btnFrango.Click += new System.EventHandler(this.btnfrango_Click);
            // 
            // btnFeijao
            // 
            this.btnFeijao.Location = new System.Drawing.Point(1161, 266);
            this.btnFeijao.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeijao.Name = "btnFeijao";
            this.btnFeijao.Size = new System.Drawing.Size(100, 70);
            this.btnFeijao.TabIndex = 9;
            this.btnFeijao.Text = "Feijão";
            this.btnFeijao.UseVisualStyleBackColor = true;
            this.btnFeijao.Click += new System.EventHandler(this.btnfeijao_Click);
            // 
            // btnInicioRapido
            // 
            this.btnInicioRapido.Location = new System.Drawing.Point(1275, 266);
            this.btnInicioRapido.Margin = new System.Windows.Forms.Padding(4);
            this.btnInicioRapido.Name = "btnInicioRapido";
            this.btnInicioRapido.Size = new System.Drawing.Size(100, 70);
            this.btnInicioRapido.TabIndex = 10;
            this.btnInicioRapido.Text = "+ 30 Seg";
            this.btnInicioRapido.UseVisualStyleBackColor = true;
            this.btnInicioRapido.Click += new System.EventHandler(this.btniniciorapido_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(1053, 343);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(100, 70);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(1161, 343);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 70);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(1275, 343);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(100, 70);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(1053, 421);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(100, 70);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(1161, 421);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(100, 70);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(1275, 421);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(100, 70);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(1053, 498);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(100, 70);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(1161, 498);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(100, 70);
            this.btn8.TabIndex = 18;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(1275, 498);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(100, 70);
            this.btn9.TabIndex = 19;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(1161, 576);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(100, 70);
            this.btn0.TabIndex = 20;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(1275, 576);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(175, 70);
            this.btnIniciar.TabIndex = 21;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btnPauseCancel
            // 
            this.btnPauseCancel.Location = new System.Drawing.Point(979, 576);
            this.btnPauseCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnPauseCancel.Name = "btnPauseCancel";
            this.btnPauseCancel.Size = new System.Drawing.Size(175, 70);
            this.btnPauseCancel.TabIndex = 23;
            this.btnPauseCancel.Text = "Pausar/Cancelar";
            this.btnPauseCancel.UseVisualStyleBackColor = true;
            this.btnPauseCancel.Click += new System.EventHandler(this.btnpausecancel_Click);
            // 
            // txtTempo
            // 
            this.txtTempo.AutoSize = true;
            this.txtTempo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold);
            this.txtTempo.Location = new System.Drawing.Point(1413, 54);
            this.txtTempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(128, 41);
            this.txtTempo.TabIndex = 24;
            this.txtTempo.Text = "00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 551);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Aquecimentos Customizados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 594);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nome:";
            // 
            // txtAquecimentoNome
            // 
            this.txtAquecimentoNome.Location = new System.Drawing.Point(162, 591);
            this.txtAquecimentoNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtAquecimentoNome.Name = "txtAquecimentoNome";
            this.txtAquecimentoNome.Size = new System.Drawing.Size(325, 22);
            this.txtAquecimentoNome.TabIndex = 27;
            // 
            // txtAquecimentoAlimento
            // 
            this.txtAquecimentoAlimento.Location = new System.Drawing.Point(162, 623);
            this.txtAquecimentoAlimento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAquecimentoAlimento.Name = "txtAquecimentoAlimento";
            this.txtAquecimentoAlimento.Size = new System.Drawing.Size(325, 22);
            this.txtAquecimentoAlimento.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 626);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Alimento:";
            // 
            // txtAquecimentoPotencia
            // 
            this.txtAquecimentoPotencia.Location = new System.Drawing.Point(162, 655);
            this.txtAquecimentoPotencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtAquecimentoPotencia.Name = "txtAquecimentoPotencia";
            this.txtAquecimentoPotencia.Size = new System.Drawing.Size(325, 22);
            this.txtAquecimentoPotencia.TabIndex = 31;
            this.txtAquecimentoPotencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAquecimentoPotencia_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 658);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "Potência:";
            // 
            // txtAquecimentoTempo
            // 
            this.txtAquecimentoTempo.Location = new System.Drawing.Point(162, 687);
            this.txtAquecimentoTempo.Margin = new System.Windows.Forms.Padding(4);
            this.txtAquecimentoTempo.Name = "txtAquecimentoTempo";
            this.txtAquecimentoTempo.Size = new System.Drawing.Size(325, 22);
            this.txtAquecimentoTempo.TabIndex = 35;
            this.txtAquecimentoTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAquecimentoTempo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 690);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 34;
            this.label6.Text = "Tempo:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(545, 634);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(133, 64);
            this.btnCadastrar.TabIndex = 36;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtAquecimentoInstrucao
            // 
            this.txtAquecimentoInstrucao.Location = new System.Drawing.Point(162, 717);
            this.txtAquecimentoInstrucao.Margin = new System.Windows.Forms.Padding(4);
            this.txtAquecimentoInstrucao.Name = "txtAquecimentoInstrucao";
            this.txtAquecimentoInstrucao.Size = new System.Drawing.Size(325, 22);
            this.txtAquecimentoInstrucao.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 720);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Instrução de uso:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1592, 814);
            this.Controls.Add(this.txtAquecimentoInstrucao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtAquecimentoTempo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAquecimentoPotencia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAquecimentoAlimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAquecimentoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.btnPauseCancel);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnInicioRapido);
            this.Controls.Add(this.btnFeijao);
            this.Controls.Add(this.btnFrango);
            this.Controls.Add(this.btnBoi);
            this.Controls.Add(this.btnLeite);
            this.Controls.Add(this.btnPipoca);
            this.Controls.Add(this.potencia);
            this.Controls.Add(this.txtPotencia);
            this.Controls.Add(this.txtprincipal);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtCaixaDigitavel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPotencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtCaixaDigitavel;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox txtprincipal;
        private System.Windows.Forms.NumericUpDown txtPotencia;
        private System.Windows.Forms.Label potencia;
        private System.Windows.Forms.Button btnPipoca;
        private System.Windows.Forms.Button btnLeite;
        private System.Windows.Forms.Button btnBoi;
        private System.Windows.Forms.Button btnFrango;
        private System.Windows.Forms.Button btnFeijao;
        private System.Windows.Forms.Button btnInicioRapido;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnPauseCancel;
        private System.Windows.Forms.Label txtTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAquecimentoNome;
        private System.Windows.Forms.TextBox txtAquecimentoAlimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAquecimentoPotencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAquecimentoTempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtAquecimentoInstrucao;
        private System.Windows.Forms.Label label5;
    }
}

