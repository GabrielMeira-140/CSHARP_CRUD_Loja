namespace loja
{
    partial class PainelPagamento
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
            this.btnAtualizarlista = new System.Windows.Forms.Button();
            this.btn_Pagar = new System.Windows.Forms.Button();
            this.dgvCaixa = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnExclui = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAtualizarlista
            // 
            this.btnAtualizarlista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnAtualizarlista.FlatAppearance.BorderSize = 0;
            this.btnAtualizarlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAtualizarlista.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizarlista.Location = new System.Drawing.Point(1109, 630);
            this.btnAtualizarlista.Name = "btnAtualizarlista";
            this.btnAtualizarlista.Size = new System.Drawing.Size(154, 42);
            this.btnAtualizarlista.TabIndex = 75;
            this.btnAtualizarlista.Text = "Atualizar lista";
            this.btnAtualizarlista.UseVisualStyleBackColor = false;
            this.btnAtualizarlista.Click += new System.EventHandler(this.btnAtualizarlista_Click);
            // 
            // btn_Pagar
            // 
            this.btn_Pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btn_Pagar.FlatAppearance.BorderSize = 0;
            this.btn_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Pagar.ForeColor = System.Drawing.Color.Black;
            this.btn_Pagar.Location = new System.Drawing.Point(1269, 630);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(141, 42);
            this.btn_Pagar.TabIndex = 70;
            this.btn_Pagar.Text = "pagamento";
            this.btn_Pagar.UseVisualStyleBackColor = false;
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(22, 104);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(1386, 521);
            this.dgvCaixa.TabIndex = 73;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(865, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(385, 20);
            this.txtEmail.TabIndex = 76;
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnExclui.FlatAppearance.BorderSize = 0;
            this.btnExclui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExclui.ForeColor = System.Drawing.Color.Black;
            this.btnExclui.Location = new System.Drawing.Point(1256, 56);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(154, 42);
            this.btnExclui.TabIndex = 77;
            this.btnExclui.Text = "Excluir pedido";
            this.btnExclui.UseVisualStyleBackColor = false;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // PainelPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 710);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnAtualizarlista);
            this.Controls.Add(this.btn_Pagar);
            this.Controls.Add(this.dgvCaixa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PainelPagamento";
            this.Text = "Pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAtualizarlista;
        private System.Windows.Forms.Button btn_Pagar;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnExclui;
    }
}