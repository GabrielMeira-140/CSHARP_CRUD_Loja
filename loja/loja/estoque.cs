using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace loja
{
    public partial class formEstoque : Form
    {

        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader Dr;
        string stringSQL;


        public formEstoque()
        {
            InitializeComponent();

            NumUDID2.Visible = false;
            lblID2.Visible = false;
        }

        //botoes de sair e minimizar
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //adicionar excluir editar e consultar
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Adicionar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirDados();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            ConsultarID();

        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            exibir();
        }

        //estoque, caixa e horario
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            formEstoque frmEstoque = new formEstoque();

            frmEstoque.BringToFront();
        }

        private void btnCaixa_Click_1(object sender, EventArgs e)
        {
            PainelPagamento pnlPagamento = new PainelPagamento();
            pnlPagamento.BringToFront();

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            PainelHorarios pnlHorario = new PainelHorarios();
            pnlHorario.BringToFront();
        }

        private void parametros()
        {
            comando.Parameters.AddWithValue("@id_produto", NumUDID2.Value);
            comando.Parameters.AddWithValue("@destribuidor", txtlDestribuidor.Text);
            comando.Parameters.AddWithValue("@marca", txtMarca.Text);
            comando.Parameters.AddWithValue("@descricao_produto", txtProduto.Text);
            comando.Parameters.AddWithValue("@tamanho_produto", cboxTamanho.SelectedItem);
            comando.Parameters.AddWithValue("@sexo", cboxSexo.SelectedItem);
            comando.Parameters.AddWithValue("@quantidade", numUDQuantidade.Value);
            comando.Parameters.AddWithValue("@preco", numUDPreco.Value);
            comando.Parameters.AddWithValue("@precoCliente", numUDPreco.Value + (((numUDPreco.Value) / 100) * 20));
        }


        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                                                                                       //
        //                                                                                                       //
        //                                            Adicionar                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        private void Adicionar()
        {
            try
            {

                //abrindo servirdor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                //comando mySQL com parametros
                stringSQL = "INSERT INTO produtos (id_produto, destribuidor, marca, descricao_produto, tamanho_produto, sexo, quantidade, preco, precoCliente)" +
                    " values (@id_produto, @destribuidor, @marca, @descricao_produto, @tamanho_produto, @sexo, @quantidade, @preco, @precoCliente)";

                comando = new MySqlCommand(stringSQL, conexao);

                parametros();

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


        private void InformaID()
        {
            NumUDID2.Visible = true;
            lblID2.Visible = true;
        }

        private void ConsultarID()
        {
            InformaID();

            if (numUDID.Value == 0)
            {
                MessageBox.Show("digite um ID de registro");
            }
            try
            {
                //passando o servidor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

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

        private void exibir()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

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

        private void ExcluirDados()
        {
            InformaID();

            try
            {
                //abrindo servirdor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

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

        private void edit()
        {
            InformaID();

            try
            {
                //abrindo servirdor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                //comando mySQL com parametros
                stringSQL = "UPDATE produtos SET destribuidor = @destribuidor, marca = @marca, descricao_produto = @descricao_produto, tamanho_produto = @tamanho_produto" +
                    ", sexo = @sexo, quantidade = @quantidade, preco = @preco, precoCliente = @precoCliente WHERE id_produto = @id_produto";


                comando = new MySqlCommand(stringSQL, conexao);

                //parametros
                parametros();

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

    }
}
