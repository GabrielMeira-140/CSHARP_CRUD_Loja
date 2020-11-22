namespace loja
{
    partial class formEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEstoque));
            this.lblID2 = new System.Windows.Forms.Label();
            this.NumUDID2 = new System.Windows.Forms.NumericUpDown();
            this.cboxTamanho = new System.Windows.Forms.ComboBox();
            this.cboxSexo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numUDQuantidade = new System.Windows.Forms.NumericUpDown();
            this.numUDPreco = new System.Windows.Forms.NumericUpDown();
            this.lblDestribuidor = new System.Windows.Forms.Label();
            this.txtlDestribuidor = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.numUDID = new System.Windows.Forms.NumericUpDown();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumUDID2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPreco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID2
            // 
            this.lblID2.AutoSize = true;
            this.lblID2.BackColor = System.Drawing.Color.Transparent;
            this.lblID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblID2.ForeColor = System.Drawing.Color.Black;
            this.lblID2.Location = new System.Drawing.Point(28, 197);
            this.lblID2.Name = "lblID2";
            this.lblID2.Size = new System.Drawing.Size(84, 17);
            this.lblID2.TabIndex = 35;
            this.lblID2.Text = "informe o ID";
            // 
            // NumUDID2
            // 
            this.NumUDID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NumUDID2.Location = new System.Drawing.Point(208, 195);
            this.NumUDID2.Name = "NumUDID2";
            this.NumUDID2.Size = new System.Drawing.Size(301, 23);
            this.NumUDID2.TabIndex = 36;
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
            this.cboxTamanho.Location = new System.Drawing.Point(208, 355);
            this.cboxTamanho.Name = "cboxTamanho";
            this.cboxTamanho.Size = new System.Drawing.Size(301, 21);
            this.cboxTamanho.TabIndex = 34;
            // 
            // cboxSexo
            // 
            this.cboxSexo.FormattingEnabled = true;
            this.cboxSexo.Items.AddRange(new object[] {
            "Masculino\t",
            "Feminino",
            "Unisex"});
            this.cboxSexo.Location = new System.Drawing.Point(208, 395);
            this.cboxSexo.Name = "cboxSexo";
            this.cboxSexo.Size = new System.Drawing.Size(301, 21);
            this.cboxSexo.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Sexo ";
            // 
            // numUDQuantidade
            // 
            this.numUDQuantidade.Location = new System.Drawing.Point(208, 438);
            this.numUDQuantidade.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.numUDQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQuantidade.Name = "numUDQuantidade";
            this.numUDQuantidade.Size = new System.Drawing.Size(301, 20);
            this.numUDQuantidade.TabIndex = 30;
            this.numUDQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUDPreco
            // 
            this.numUDPreco.DecimalPlaces = 2;
            this.numUDPreco.Location = new System.Drawing.Point(208, 477);
            this.numUDPreco.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numUDPreco.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numUDPreco.Name = "numUDPreco";
            this.numUDPreco.Size = new System.Drawing.Size(301, 20);
            this.numUDPreco.TabIndex = 29;
            this.numUDPreco.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lblDestribuidor
            // 
            this.lblDestribuidor.AutoSize = true;
            this.lblDestribuidor.BackColor = System.Drawing.Color.Transparent;
            this.lblDestribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDestribuidor.ForeColor = System.Drawing.Color.Black;
            this.lblDestribuidor.Location = new System.Drawing.Point(27, 238);
            this.lblDestribuidor.Name = "lblDestribuidor";
            this.lblDestribuidor.Size = new System.Drawing.Size(85, 17);
            this.lblDestribuidor.TabIndex = 6;
            this.lblDestribuidor.Text = "Destribuidor";
            // 
            // txtlDestribuidor
            // 
            this.txtlDestribuidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtlDestribuidor.Location = new System.Drawing.Point(208, 233);
            this.txtlDestribuidor.Name = "txtlDestribuidor";
            this.txtlDestribuidor.Size = new System.Drawing.Size(301, 23);
            this.txtlDestribuidor.TabIndex = 7;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblQuantidade.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidade.Location = new System.Drawing.Point(27, 440);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(82, 17);
            this.lblQuantidade.TabIndex = 8;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNomeProduto.ForeColor = System.Drawing.Color.Black;
            this.lblNomeProduto.Location = new System.Drawing.Point(27, 318);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(148, 17);
            this.lblNomeProduto.TabIndex = 9;
            this.lblNomeProduto.Text = "Descriçao do  produto";
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.BackColor = System.Drawing.Color.Transparent;
            this.lblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTamanho.ForeColor = System.Drawing.Color.Black;
            this.lblTamanho.Location = new System.Drawing.Point(28, 358);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(72, 17);
            this.lblTamanho.TabIndex = 23;
            this.lblTamanho.Text = "Tamanho ";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMarca.ForeColor = System.Drawing.Color.Black;
            this.lblMarca.Location = new System.Drawing.Point(27, 279);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 17);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPreco.ForeColor = System.Drawing.Color.Black;
            this.lblPreco.Location = new System.Drawing.Point(28, 479);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(125, 17);
            this.lblPreco.TabIndex = 11;
            this.lblPreco.Text = "Preço por unidade";
            // 
            // txtProduto
            // 
            this.txtProduto.AcceptsReturn = true;
            this.txtProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProduto.Location = new System.Drawing.Point(208, 313);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(301, 23);
            this.txtProduto.TabIndex = 15;
            // 
            // numUDID
            // 
            this.numUDID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numUDID.Location = new System.Drawing.Point(949, 97);
            this.numUDID.Name = "numUDID";
            this.numUDID.Size = new System.Drawing.Size(335, 23);
            this.numUDID.TabIndex = 35;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(31, 598);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(87, 42);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Adicionar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(246, 598);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(87, 42);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(141, 598);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(87, 42);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnConsulta.ForeColor = System.Drawing.Color.Black;
            this.btnConsulta.Location = new System.Drawing.Point(1290, 89);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(103, 35);
            this.btnConsulta.TabIndex = 19;
            this.btnConsulta.Text = "Procurar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(235)))));
            this.btnExibir.FlatAppearance.BorderSize = 0;
            this.btnExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExibir.ForeColor = System.Drawing.Color.Black;
            this.btnExibir.Location = new System.Drawing.Point(356, 598);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(153, 42);
            this.btnExibir.TabIndex = 20;
            this.btnExibir.Text = "Exibir / Atualizar";
            this.btnExibir.UseVisualStyleBackColor = false;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(530, 130);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(863, 510);
            this.dgv.TabIndex = 30;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMarca.Location = new System.Drawing.Point(208, 274);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(301, 23);
            this.txtMarca.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(786, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "informe o ID do produto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.btnCaixa);
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btnEstoque);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1430, 48);
            this.panel1.TabIndex = 40;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Location = new System.Drawing.Point(96, 3);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(108, 42);
            this.btnCaixa.TabIndex = 40;
            this.btnCaixa.Text = "Pagamento";
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click_1);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Location = new System.Drawing.Point(210, 3);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(87, 42);
            this.btnUsuario.TabIndex = 39;
            this.btnUsuario.Text = "Horarios";
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(88)))), ((int)(((byte)(105)))));
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Location = new System.Drawing.Point(3, 3);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(87, 42);
            this.btnEstoque.TabIndex = 38;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1372, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(1328, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(38, 48);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click_1);
            // 
            // formEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1418, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumUDID2);
            this.Controls.Add(this.lblID2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.numUDID);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.cboxTamanho);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboxSexo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.numUDPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDestribuidor);
            this.Controls.Add(this.lblNomeProduto);
            this.Controls.Add(this.txtlDestribuidor);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.numUDQuantidade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEstoque";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.NumUDID2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPreco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblDestribuidor;
        private System.Windows.Forms.TextBox txtlDestribuidor;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.NumericUpDown numUDPreco;
        private System.Windows.Forms.NumericUpDown numUDQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.ComboBox cboxTamanho;
        private System.Windows.Forms.ComboBox cboxSexo;
        private System.Windows.Forms.NumericUpDown numUDID;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.NumericUpDown NumUDID2;
        private System.Windows.Forms.Label lblID2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
    }
}

