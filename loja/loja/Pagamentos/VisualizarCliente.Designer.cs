namespace loja.Pagamentos
{
    partial class FormView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExclui = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizarlista
            // 
            this.btnAtualizarlista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnAtualizarlista.FlatAppearance.BorderSize = 0;
            this.btnAtualizarlista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarlista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAtualizarlista.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizarlista.Location = new System.Drawing.Point(1105, 644);
            this.btnAtualizarlista.Name = "btnAtualizarlista";
            this.btnAtualizarlista.Size = new System.Drawing.Size(154, 42);
            this.btnAtualizarlista.TabIndex = 78;
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
            this.btn_Pagar.Location = new System.Drawing.Point(1265, 644);
            this.btn_Pagar.Name = "btn_Pagar";
            this.btn_Pagar.Size = new System.Drawing.Size(141, 42);
            this.btn_Pagar.TabIndex = 76;
            this.btn_Pagar.Text = "pagamento";
            this.btn_Pagar.UseVisualStyleBackColor = false;
            this.btn_Pagar.Click += new System.EventHandler(this.btn_Pagar_Click);
            // 
            // dgvCaixa
            // 
            this.dgvCaixa.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaixa.Location = new System.Drawing.Point(20, 80);
            this.dgvCaixa.Name = "dgvCaixa";
            this.dgvCaixa.Size = new System.Drawing.Size(1386, 521);
            this.dgvCaixa.TabIndex = 77;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.pagamentoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1418, 24);
            this.menuStrip1.TabIndex = 79;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
            // 
            // pagamentoToolStripMenuItem
            // 
            this.pagamentoToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pagamentoToolStripMenuItem.Name = "pagamentoToolStripMenuItem";
            this.pagamentoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pagamentoToolStripMenuItem.Text = "Pagamento";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(815, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Digite o Email";
            // 
            // btnExclui
            // 
            this.btnExclui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnExclui.FlatAppearance.BorderSize = 0;
            this.btnExclui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExclui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExclui.ForeColor = System.Drawing.Color.Black;
            this.btnExclui.Location = new System.Drawing.Point(1252, 32);
            this.btnExclui.Name = "btnExclui";
            this.btnExclui.Size = new System.Drawing.Size(154, 42);
            this.btnExclui.TabIndex = 81;
            this.btnExclui.Text = "Excluir pedido";
            this.btnExclui.UseVisualStyleBackColor = false;
            this.btnExclui.Click += new System.EventHandler(this.btnExclui_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(892, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(354, 20);
            this.txtEmail.TabIndex = 80;
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 710);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExclui);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAtualizarlista);
            this.Controls.Add(this.btn_Pagar);
            this.Controls.Add(this.dgvCaixa);
            this.Name = "FormView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisualizarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaixa)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarlista;
        private System.Windows.Forms.Button btn_Pagar;
        private System.Windows.Forms.DataGridView dgvCaixa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExclui;
        private System.Windows.Forms.TextBox txtEmail;
    }
}