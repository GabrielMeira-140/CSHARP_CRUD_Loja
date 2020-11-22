namespace loja
{
    partial class frmCaixa
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.numUDID = new System.Windows.Forms.NumericUpDown();
            this.pnlIDEditar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.cboxTamanho = new System.Windows.Forms.ComboBox();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cboxSexo = new System.Windows.Forms.ComboBox();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDID)).BeginInit();
            this.pnlIDEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panel2.Location = new System.Drawing.Point(3, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 668);
            this.panel2.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.pnlIDEditar);
            this.panel1.Controls.Add(this.txtMarca);
            this.panel1.Controls.Add(this.cboxTamanho);
            this.panel1.Controls.Add(this.txtProduto);
            this.panel1.Controls.Add(this.lblMarca);
            this.panel1.Controls.Add(this.cboxSexo);
            this.panel1.Controls.Add(this.lblTamanho);
            this.panel1.Controls.Add(this.lblNomeProduto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 668);
            this.panel1.TabIndex = 48;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(517, 545);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(879, 110);
            this.dgv.TabIndex = 46;
            // 
            // numUDID
            // 
            this.numUDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numUDID.Location = new System.Drawing.Point(164, 3);
            this.numUDID.Name = "numUDID";
            this.numUDID.Size = new System.Drawing.Size(291, 23);
            this.numUDID.TabIndex = 47;
            // 
            // pnlIDEditar
            // 
            this.pnlIDEditar.Controls.Add(this.label2);
            this.pnlIDEditar.Controls.Add(this.numUDID);
            this.pnlIDEditar.Location = new System.Drawing.Point(16, 283);
            this.pnlIDEditar.Name = "pnlIDEditar";
            this.pnlIDEditar.Size = new System.Drawing.Size(470, 29);
            this.pnlIDEditar.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "informe o ID";
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMarca.Location = new System.Drawing.Point(180, 318);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(291, 23);
            this.txtMarca.TabIndex = 44;
            // 
            // cboxTamanho
            // 
            this.cboxTamanho.FormattingEnabled = true;
            this.cboxTamanho.Items.AddRange(new object[] {
            "PP",
            "P",
            "M",
            "G",
            "GG"});
            this.cboxTamanho.Location = new System.Drawing.Point(180, 377);
            this.cboxTamanho.Name = "cboxTamanho";
            this.cboxTamanho.Size = new System.Drawing.Size(291, 21);
            this.cboxTamanho.TabIndex = 51;
            // 
            // txtProduto
            // 
            this.txtProduto.AcceptsReturn = true;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProduto.Location = new System.Drawing.Point(180, 348);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(291, 23);
            this.txtProduto.TabIndex = 45;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(20, 321);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 42;
            this.lblMarca.Text = "Marca";
            // 
            // cboxSexo
            // 
            this.cboxSexo.FormattingEnabled = true;
            this.cboxSexo.Items.AddRange(new object[] {
            "Masculino\t",
            "Feminino",
            "Unisex"});
            this.cboxSexo.Location = new System.Drawing.Point(180, 404);
            this.cboxSexo.Name = "cboxSexo";
            this.cboxSexo.Size = new System.Drawing.Size(291, 21);
            this.cboxSexo.TabIndex = 50;
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.BackColor = System.Drawing.Color.Transparent;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTamanho.ForeColor = System.Drawing.Color.Black;
            this.lblTamanho.Location = new System.Drawing.Point(21, 378);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(72, 17);
            this.lblTamanho.TabIndex = 46;
            this.lblTamanho.Text = "Tamanho ";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomeProduto.ForeColor = System.Drawing.Color.Black;
            this.lblNomeProduto.Location = new System.Drawing.Point(20, 351);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(57, 17);
            this.lblNomeProduto.TabIndex = 41;
            this.lblNomeProduto.Text = "produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Sexo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(956, 515);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Valor total da compra";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDown1.Location = new System.Drawing.Point(1105, 513);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(291, 23);
            this.numericUpDown1.TabIndex = 47;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 667);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaixa";
            this.Text = "caixa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDID)).EndInit();
            this.pnlIDEditar.ResumeLayout(false);
            this.pnlIDEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.NumericUpDown numUDID;
        private System.Windows.Forms.Panel pnlIDEditar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.ComboBox cboxTamanho;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cboxSexo;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}