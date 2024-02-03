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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            txtResultado.Location = new Point(15, 21);
            txtResultado.Margin = new Padding(3, 4, 3, 4);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(294, 27);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // btnZero
            // 
            btnZero.Location = new Point(14, 412);
            btnZero.Margin = new Padding(3, 4, 3, 4);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(69, 80);
            btnZero.TabIndex = 1;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += btnZero_Click;
            // 
            // btnUm
            // 
            btnUm.Location = new Point(14, 324);
            btnUm.Margin = new Padding(3, 4, 3, 4);
            btnUm.Name = "btnUm";
            btnUm.Size = new Size(69, 80);
            btnUm.TabIndex = 2;
            btnUm.Text = "1";
            btnUm.UseVisualStyleBackColor = true;
            btnUm.Click += btnUm_Click;
            // 
            // btnDois
            // 
            btnDois.Location = new Point(89, 324);
            btnDois.Margin = new Padding(3, 4, 3, 4);
            btnDois.Name = "btnDois";
            btnDois.Size = new Size(69, 80);
            btnDois.TabIndex = 3;
            btnDois.Text = "2";
            btnDois.UseVisualStyleBackColor = true;
            btnDois.Click += btnDois_Click;
            // 
            // btnTres
            // 
            btnTres.Location = new Point(165, 324);
            btnTres.Margin = new Padding(3, 4, 3, 4);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(69, 80);
            btnTres.TabIndex = 4;
            btnTres.Text = "3";
            btnTres.UseVisualStyleBackColor = true;
            btnTres.Click += btnTres_Click;
            // 
            // btnSeis
            // 
            btnSeis.Location = new Point(165, 236);
            btnSeis.Margin = new Padding(3, 4, 3, 4);
            btnSeis.Name = "btnSeis";
            btnSeis.Size = new Size(69, 80);
            btnSeis.TabIndex = 7;
            btnSeis.Text = "6";
            btnSeis.UseVisualStyleBackColor = true;
            btnSeis.Click += btnSeis_Click;
            // 
            // btnCinco
            // 
            btnCinco.Location = new Point(89, 236);
            btnCinco.Margin = new Padding(3, 4, 3, 4);
            btnCinco.Name = "btnCinco";
            btnCinco.Size = new Size(69, 80);
            btnCinco.TabIndex = 6;
            btnCinco.Text = "5";
            btnCinco.UseVisualStyleBackColor = true;
            btnCinco.Click += btnCinco_Click;
            // 
            // btnQuatro
            // 
            btnQuatro.Location = new Point(14, 236);
            btnQuatro.Margin = new Padding(3, 4, 3, 4);
            btnQuatro.Name = "btnQuatro";
            btnQuatro.Size = new Size(69, 80);
            btnQuatro.TabIndex = 5;
            btnQuatro.Text = "4";
            btnQuatro.UseVisualStyleBackColor = true;
            btnQuatro.Click += btnQuatro_Click;
            // 
            // btnNove
            // 
            btnNove.Location = new Point(165, 148);
            btnNove.Margin = new Padding(3, 4, 3, 4);
            btnNove.Name = "btnNove";
            btnNove.Size = new Size(69, 80);
            btnNove.TabIndex = 10;
            btnNove.Text = "9";
            btnNove.UseVisualStyleBackColor = true;
            btnNove.Click += btnNove_Click;
            // 
            // btnOito
            // 
            btnOito.Location = new Point(89, 148);
            btnOito.Margin = new Padding(3, 4, 3, 4);
            btnOito.Name = "btnOito";
            btnOito.Size = new Size(69, 80);
            btnOito.TabIndex = 9;
            btnOito.Text = "8";
            btnOito.UseVisualStyleBackColor = true;
            btnOito.Click += btnOito_Click;
            // 
            // btnSete
            // 
            btnSete.Location = new Point(14, 148);
            btnSete.Margin = new Padding(3, 4, 3, 4);
            btnSete.Name = "btnSete";
            btnSete.Size = new Size(69, 80);
            btnSete.TabIndex = 8;
            btnSete.Text = "7";
            btnSete.UseVisualStyleBackColor = true;
            btnSete.Click += btnSete_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Location = new Point(90, 412);
            btnVirgula.Margin = new Padding(3, 4, 3, 4);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(69, 80);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(240, 324);
            btnSomar.Margin = new Padding(3, 4, 3, 4);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(69, 80);
            btnSomar.TabIndex = 12;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(165, 412);
            btnIgual.Margin = new Padding(3, 4, 3, 4);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(69, 80);
            btnIgual.TabIndex = 13;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(240, 412);
            btnSubtrair.Margin = new Padding(3, 4, 3, 4);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(69, 80);
            btnSubtrair.TabIndex = 14;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(240, 148);
            btnDividir.Margin = new Padding(3, 4, 3, 4);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(69, 80);
            btnDividir.TabIndex = 15;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(240, 236);
            btnMultiplicar.Margin = new Padding(3, 4, 3, 4);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(69, 80);
            btnMultiplicar.TabIndex = 16;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(240, 99);
            btnLimpar.Margin = new Padding(3, 4, 3, 4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(69, 41);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "c";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lbOperacao
            // 
            lbOperacao.AutoSize = true;
            lbOperacao.Location = new Point(19, 25);
            lbOperacao.Name = "lbOperacao";
            lbOperacao.Size = new Size(0, 20);
            lbOperacao.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(323, 505);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
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