namespace loja.Pagamentos
{
    partial class FormDinheiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPagamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioAvista = new System.Windows.Forms.RadioButton();
            this.radio2vez = new System.Windows.Forms.RadioButton();
            this.radio3vez = new System.Windows.Forms.RadioButton();
            this.radio5vez = new System.Windows.Forms.RadioButton();
            this.radio4vez = new System.Windows.Forms.RadioButton();
            this.radio6vez = new System.Windows.Forms.RadioButton();
            this.radio1vez = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.numUDValor = new System.Windows.Forms.NumericUpDown();
            this.lblEmaiil = new System.Windows.Forms.Label();
            this.lblValortoalCompra = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblEmailPessoa = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNomePessoa = new System.Windows.Forms.Label();
            this.lblAvista = new System.Windows.Forms.Label();
            this.lblCartao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDValor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagamento
            // 
            this.btnPagamento.Location = new System.Drawing.Point(369, 375);
            this.btnPagamento.Name = "btnPagamento";
            this.btnPagamento.Size = new System.Drawing.Size(121, 47);
            this.btnPagamento.TabIndex = 0;
            this.btnPagamento.Text = "Finalizar Pagamento";
            this.btnPagamento.UseVisualStyleBackColor = true;
            this.btnPagamento.Click += new System.EventHandler(this.btnPagamento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Digite o Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 21);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(393, 20);
            this.txtEmail.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Valor da compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Cartão de credito";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Dinheiro";
            // 
            // radioAvista
            // 
            this.radioAvista.AutoSize = true;
            this.radioAvista.Location = new System.Drawing.Point(114, 97);
            this.radioAvista.Name = "radioAvista";
            this.radioAvista.Size = new System.Drawing.Size(57, 17);
            this.radioAvista.TabIndex = 86;
            this.radioAvista.TabStop = true;
            this.radioAvista.Text = "A vista";
            this.radioAvista.UseVisualStyleBackColor = true;
            // 
            // radio2vez
            // 
            this.radio2vez.AutoSize = true;
            this.radio2vez.Location = new System.Drawing.Point(177, 127);
            this.radio2vez.Name = "radio2vez";
            this.radio2vez.Size = new System.Drawing.Size(62, 17);
            this.radio2vez.TabIndex = 87;
            this.radio2vez.TabStop = true;
            this.radio2vez.Text = "2 vezes";
            this.radio2vez.UseVisualStyleBackColor = true;
            // 
            // radio3vez
            // 
            this.radio3vez.AutoSize = true;
            this.radio3vez.Location = new System.Drawing.Point(240, 127);
            this.radio3vez.Name = "radio3vez";
            this.radio3vez.Size = new System.Drawing.Size(62, 17);
            this.radio3vez.TabIndex = 88;
            this.radio3vez.TabStop = true;
            this.radio3vez.Text = "3 vezes";
            this.radio3vez.UseVisualStyleBackColor = true;
            // 
            // radio5vez
            // 
            this.radio5vez.AutoSize = true;
            this.radio5vez.Location = new System.Drawing.Point(371, 127);
            this.radio5vez.Name = "radio5vez";
            this.radio5vez.Size = new System.Drawing.Size(62, 17);
            this.radio5vez.TabIndex = 89;
            this.radio5vez.TabStop = true;
            this.radio5vez.Text = "5 vezes";
            this.radio5vez.UseVisualStyleBackColor = true;
            // 
            // radio4vez
            // 
            this.radio4vez.AutoSize = true;
            this.radio4vez.Location = new System.Drawing.Point(308, 127);
            this.radio4vez.Name = "radio4vez";
            this.radio4vez.Size = new System.Drawing.Size(62, 17);
            this.radio4vez.TabIndex = 90;
            this.radio4vez.TabStop = true;
            this.radio4vez.Text = "4 vezes";
            this.radio4vez.UseVisualStyleBackColor = true;
            // 
            // radio6vez
            // 
            this.radio6vez.AutoSize = true;
            this.radio6vez.Location = new System.Drawing.Point(434, 127);
            this.radio6vez.Name = "radio6vez";
            this.radio6vez.Size = new System.Drawing.Size(62, 17);
            this.radio6vez.TabIndex = 91;
            this.radio6vez.TabStop = true;
            this.radio6vez.Text = "6 vezes";
            this.radio6vez.UseVisualStyleBackColor = true;
            // 
            // radio1vez
            // 
            this.radio1vez.AutoSize = true;
            this.radio1vez.Location = new System.Drawing.Point(114, 127);
            this.radio1vez.Name = "radio1vez";
            this.radio1vez.Size = new System.Drawing.Size(51, 17);
            this.radio1vez.TabIndex = 92;
            this.radio1vez.TabStop = true;
            this.radio1vez.Text = "1 vez";
            this.radio1vez.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 47);
            this.button1.TabIndex = 93;
            this.button1.Text = "Vizualizar Valor da compra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numUDValor
            // 
            this.numUDValor.Location = new System.Drawing.Point(103, 47);
            this.numUDValor.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.numUDValor.Name = "numUDValor";
            this.numUDValor.Size = new System.Drawing.Size(393, 20);
            this.numUDValor.TabIndex = 94;
            // 
            // lblEmaiil
            // 
            this.lblEmaiil.AutoSize = true;
            this.lblEmaiil.Location = new System.Drawing.Point(152, 237);
            this.lblEmaiil.Name = "lblEmaiil";
            this.lblEmaiil.Size = new System.Drawing.Size(0, 13);
            this.lblEmaiil.TabIndex = 95;
            // 
            // lblValortoalCompra
            // 
            this.lblValortoalCompra.AutoSize = true;
            this.lblValortoalCompra.Location = new System.Drawing.Point(16, 283);
            this.lblValortoalCompra.Name = "lblValortoalCompra";
            this.lblValortoalCompra.Size = new System.Drawing.Size(106, 13);
            this.lblValortoalCompra.TabIndex = 96;
            this.lblValortoalCompra.Text = "Valor final da compra";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(152, 283);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(0, 13);
            this.lblFinal.TabIndex = 97;
            // 
            // lblEmailPessoa
            // 
            this.lblEmailPessoa.AutoSize = true;
            this.lblEmailPessoa.Location = new System.Drawing.Point(14, 237);
            this.lblEmailPessoa.Name = "lblEmailPessoa";
            this.lblEmailPessoa.Size = new System.Drawing.Size(87, 13);
            this.lblEmailPessoa.TabIndex = 98;
            this.lblEmailPessoa.Text = " Email da pessoa";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(152, 211);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 13);
            this.lblName.TabIndex = 100;
            // 
            // lblNomePessoa
            // 
            this.lblNomePessoa.AutoSize = true;
            this.lblNomePessoa.Location = new System.Drawing.Point(16, 211);
            this.lblNomePessoa.Name = "lblNomePessoa";
            this.lblNomePessoa.Size = new System.Drawing.Size(88, 13);
            this.lblNomePessoa.TabIndex = 101;
            this.lblNomePessoa.Text = "Nome da Pessoa";
            // 
            // lblAvista
            // 
            this.lblAvista.AutoSize = true;
            this.lblAvista.Location = new System.Drawing.Point(152, 260);
            this.lblAvista.Name = "lblAvista";
            this.lblAvista.Size = new System.Drawing.Size(0, 13);
            this.lblAvista.TabIndex = 102;
            // 
            // lblCartao
            // 
            this.lblCartao.AutoSize = true;
            this.lblCartao.Location = new System.Drawing.Point(16, 260);
            this.lblCartao.Name = "lblCartao";
            this.lblCartao.Size = new System.Drawing.Size(85, 13);
            this.lblCartao.TabIndex = 103;
            this.lblCartao.Text = "Avista ou Cartão";
            // 
            // FormDinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 434);
            this.Controls.Add(this.lblCartao);
            this.Controls.Add(this.lblAvista);
            this.Controls.Add(this.lblNomePessoa);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblEmailPessoa);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblValortoalCompra);
            this.Controls.Add(this.lblEmaiil);
            this.Controls.Add(this.numUDValor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radio1vez);
            this.Controls.Add(this.radio6vez);
            this.Controls.Add(this.radio4vez);
            this.Controls.Add(this.radio5vez);
            this.Controls.Add(this.radio3vez);
            this.Controls.Add(this.radio2vez);
            this.Controls.Add(this.radioAvista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnPagamento);
            this.Name = "FormDinheiro";
            this.Text = "PagamentoDinheiroCartao";
            ((System.ComponentModel.ISupportInitialize)(this.numUDValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioAvista;
        private System.Windows.Forms.RadioButton radio2vez;
        private System.Windows.Forms.RadioButton radio3vez;
        private System.Windows.Forms.RadioButton radio5vez;
        private System.Windows.Forms.RadioButton radio4vez;
        private System.Windows.Forms.RadioButton radio6vez;
        private System.Windows.Forms.RadioButton radio1vez;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numUDValor;
        private System.Windows.Forms.Label lblEmaiil;
        private System.Windows.Forms.Label lblValortoalCompra;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblEmailPessoa;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNomePessoa;
        private System.Windows.Forms.Label lblAvista;
        private System.Windows.Forms.Label lblCartao;
    }
}