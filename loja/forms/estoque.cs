using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace loja
{
    public partial class frmEstoque : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        //MySqlDataAdapter Da;
        MySqlDataReader Dr;
        string stringSQL;


        public frmEstoque()


        {
            InitializeComponent();
            NumUDID2.Enabled = false;
            pnlIDEditar.Visible = false;


        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            try
            {
                //desabilitando numUD2
                NumUDID2.Enabled = false;
                pnlIDEditar.Visible = false;

                //abrindo servirdor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=admin;Password=admin4321;");

                //comando mySQL com parametros
                stringSQL = "INSERT INTO produtos (id_produto, destribuidor, marca, descricao_produto, tamanho_produto, sexo, quantidade, preco)" +
                    " values (@id_produto, @destribuidor, @marca, @descricao_produto, @tamanho_produto, @sexo, @quantidade, @preco)";

                comando = new MySqlCommand(stringSQL, conexao);

                comando.Parameters.AddWithValue("@id_produto", numUDID.Value);
                comando.Parameters.AddWithValue("@destribuidor", txtlDestribuidor.Text);
                comando.Parameters.AddWithValue("@marca", txtMarca.Text);
                comando.Parameters.AddWithValue("@descricao_produto", txtProduto.Text);
                comando.Parameters.AddWithValue("@tamanho_produto", cboxTamanho.SelectedItem);
                comando.Parameters.AddWithValue("@sexo", cboxSexo.SelectedItem);
                comando.Parameters.AddWithValue("@quantidade", numUDQuantidade.Value);
                comando.Parameters.AddWithValue("@preco", numUDPreco.Value);

                //abrindo servidor
                conexao.Open();

                //executando o comando
                comando.ExecuteNonQuery();

                
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //fechando servidor
                conexao.Clone();
                conexao = null;
                comando = null;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {



            //habilitando o numUD
            NumUDID2.Enabled = true;
            pnlIDEditar.Visible = true;


            try
            {
                //abrindo servirdor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=admin;Password=admin4321;");

                //comando mySQL com parametros
                stringSQL = "UPDATE produtos SET destribuidor = @destribuidor, marca = @marca, descricao_produto = @descricao_produto, tamanho_produto = @tamanho_produto, sexo = @sexo, quantidade = @quantidade, preco = @preco WHERE id_produto = @id_produto";


                comando = new MySqlCommand(stringSQL, conexao);

                //parametros
                comando.Parameters.AddWithValue("@id_produto", NumUDID2.Value);
                comando.Parameters.AddWithValue("@destribuidor", txtlDestribuidor.Text);
                comando.Parameters.AddWithValue("@marca", txtMarca.Text);
                comando.Parameters.AddWithValue("@descricao_produto", txtProduto.Text);
                comando.Parameters.AddWithValue("@tamanho_produto", cboxTamanho.SelectedItem);
                comando.Parameters.AddWithValue("@sexo", cboxSexo.SelectedItem);
                comando.Parameters.AddWithValue("@quantidade", numUDQuantidade.Value);
                comando.Parameters.AddWithValue("@preco", numUDPreco.Value);

                //abrindo servidor
                conexao.Open();

                //executando o comando
                comando.ExecuteNonQuery();

                

            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //fechando servidor
                conexao.Clone();
                conexao = null;
                comando = null;
                


            }
            

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            //habilitando o numUD
            NumUDID2.Enabled = true;
            pnlIDEditar.Visible = true;


            try
            {
                //abrindo servirdor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=admin;Password=admin4321;");

                //comando mySQL com parametros
                stringSQL = "DELETE FROM produtos WHERE id_produto = @id_produto";

                comando = new MySqlCommand(stringSQL, conexao);

                comando.Parameters.AddWithValue("@id_produto", NumUDID2.Value);


                //abrindo servidor
                conexao.Open();

                //executando o comando
                comando.ExecuteNonQuery();

              
            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //fechando servidor
                conexao.Clone();
                conexao = null;
                comando = null;

            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (numUDID.Value == 0)
            {
                MessageBox.Show("digite um ID de registro");
            }
            try
            {
                //desabilitando numUD2
                NumUDID2.Enabled = false;
                pnlIDEditar.Visible = false;

                //passando o servidor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=admin;Password=admin4321;");

                stringSQL = "SELECT * FROM produtos Where id_produto = @id_produto";
                comando = new MySqlCommand(stringSQL, conexao);

                //paramentro
                comando.Parameters.AddWithValue("@id_produto", numUDID.Value);

                //abrindo o servidor
                conexao.Open();

                Dr = comando.ExecuteReader();

                //loop
                while (Dr.Read())
                {

                    //txt
                    txtlDestribuidor.Text = (string)Dr["destribuidor"];
                    txtMarca.Text = (string)Dr["marca"];
                    txtProduto.Text = (string)Dr["descricao_produto"];

                    //combobox
                    cboxTamanho.Text = (Convert.ToString(Dr["tamanho_produto"]));
                    cboxSexo.Text = (Convert.ToString(Dr["sexo"]));

                    //numericupdown
                    numUDQuantidade.Value = Convert.ToInt32(Dr["quantidade"]);
                    numUDPreco.Value = Convert.ToInt32(Dr["preco"]);

                }


            }
            catch (Exception ex)
            {
                //mensagem de erro
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //fechando servidor
                conexao.Clone();
                conexao = null;
                comando = null;

            }
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            try
            {
                //desabilitando numUD2
                NumUDID2.Enabled = false;
                pnlIDEditar.Visible = false;

                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=admin;Password=admin4321;");

                stringSQL = "SELECT * FROM produtos";

                MySqlCommand comando = new MySqlCommand(stringSQL, conexao);

                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(comando);

                da.Fill(dt);

                dgv.DataSource = dt;

                conexao.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conexao.Clone();
                conexao = null;
                comando = null;


            }
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa jCaixa = new frmCaixa();
            jCaixa.Show();
        }
    }
}
