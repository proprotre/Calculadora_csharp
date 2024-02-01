namespace Calculadora
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
            txtResultado = new TextBox();
            btnZero = new Button();
            btnUm = new Button();
            btnDois = new Button();
            btnTres = new Button();
            btnSeis = new Button();
            btnCinco = new Button();
            btnQuatro = new Button();
            btnNove = new Button();
            btnOito = new Button();
            btnSete = new Button();
            btnVirgula = new Button();
            btnSomar = new Button();
            btnIgual = new Button();
            btnSubtrair = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            btnLimpar = new Button();
            lbOperacao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(13, 16);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(258, 23);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(12, 309);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(60, 60);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(12, 243);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(60, 60);
            btnUm.TabIndex = 2;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(78, 243);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(60, 60);
            btnDois.TabIndex = 3;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(144, 243);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(60, 60);
            btnTres.TabIndex = 4;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(144, 177);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(60, 60);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(78, 177);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(60, 60);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(12, 177);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(60, 60);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(144, 111);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(60, 60);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(78, 111);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(60, 60);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(12, 111);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(60, 60);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(78, 307);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(60, 60);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(210, 243);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(60, 60);
            btnSomar.TabIndex = 12;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(144, 309);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(60, 60);
            btnIgual.TabIndex = 13;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(210, 309);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(60, 60);
            btnSubtrair.TabIndex = 14;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(210, 111);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(60, 60);
            btnDividir.TabIndex = 15;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(210, 177);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(60, 60);
            btnMultiplicar.TabIndex = 16;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(210, 74);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(60, 31);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "c";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lbOperacao
            // 
            lbOperacao.AutoSize = true;
            lbOperacao.Location = new Point(17, 19);
            lbOperacao.Name = "lbOperacao";
            lbOperacao.Size = new Size(0, 15);
            lbOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 379);
            Controls.Add(lbOperacao);
            Controls.Add(btnLimpar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnSubtrair);
            Controls.Add(btnIgual);
            Controls.Add(btnSomar);
            Controls.Add(btnVirgula);
            Controls.Add(btnNove);
            Controls.Add(btnOito);
            Controls.Add(btnSete);
            Controls.Add(btnSeis);
            Controls.Add(btnCinco);
            Controls.Add(btnQuatro);
            Controls.Add(btnTres);
            Controls.Add(btnDois);
            Controls.Add(btnUm);
            Controls.Add(btnZero);
            Controls.Add(txtResultado);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btnZero;
        private Button btnUm;
        private Button btnDois;
        private Button btnTres;
        private Button btnSeis;
        private Button btnCinco;
        private Button btnQuatro;
        private Button btnNove;
        private Button btnOito;
        private Button btnSete;
        private Button btnVirgula;
        private Button btnSomar;
        private Button btnIgual;
        private Button btnSubtrair;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnLimpar;
        private Label lbOperacao;
    }
}