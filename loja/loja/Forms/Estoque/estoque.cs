using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loja.Pagamentos;
using loja.Classe;

namespace loja
{
    public partial class formEstoque : Form
    {
        STRSQL StringConexao = new STRSQL();
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader Dr;


        public formEstoque()
        {
            InitializeComponent();

            NumUDID2.Visible = false;
            lblID2.Visible = false;
        }

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               botoes                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//
        #region Botoes
        private void pagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormView FormCliente = new FormView();
            FormCliente.Show();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelHorarios PnlHorario = new PainelHorarios();
            PnlHorario.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               Metodo                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region ParamentrosSQL
        private void parametros() //Pega os dados no banco de dados
        {
            comando.Parameters.AddWithValue("@id_produto", NumUDID2.Value);
            comando.Parameters.AddWithValue("@destribuidor", txtlDestribuidor.Text);
            comando.Parameters.AddWithValue("@marca", txtMarca.Text);
            comando.Parameters.AddWithValue("@descricao_produto", txtProduto.Text);
            comando.Parameters.AddWithValue("@tamanho_produto", cboxTamanho.SelectedItem);
            comando.Parameters.AddWithValue("@sexo", cboxSexo.SelectedItem);
            comando.Parameters.AddWithValue("@quantidade", numUDQuantidade.Value);
            comando.Parameters.AddWithValue("@preco", numUDPreco.Value);
            comando.Parameters.AddWithValue("@precoCliente", numUDPreco.Value + (((numUDPreco.Value) / 100) * 20)); //Regra de negocio junto ao banco de dados
        }
        #endregion

        #region InformaID
        private void InformaID()
        {
            NumUDID2.Visible = true;
            lblID2.Visible = true;
        }
        #endregion
        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                              Adicionar                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//
        #region Adicionar
        //Adiciona as informações dentro do banco de dados
        private void Adicionar()
        {
            exibir();
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                StringConexao.AdicionaConSQL();

                comando = new MySqlCommand(StringConexao.AdicionaConSQL(), conexao);

                parametros();

                conexao.Open();

                comando.ExecuteNonQuery();
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
        #endregion
        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                                 Exibir                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//
        #region Exibir
        //exibe os dados dentro do datagridview
        private void exibir()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                StringConexao.ExibeConSQL();

                MySqlCommand comando = new MySqlCommand(StringConexao.ExibeConSQL(), conexao);

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
#endregion
        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                                Excluir                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//
        #region Excluir
        //exclui qualquer informação do banco de dados
        private void ExcluirDados()
        {
            InformaID();
            exibir();

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                StringConexao.ExcluiConSQL();

                comando = new MySqlCommand(StringConexao.ExcluiConSQL(), conexao);

                comando.Parameters.AddWithValue("@id_produto", NumUDID2.Value);

                conexao.Open();

                comando.ExecuteNonQuery();
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
#endregion
        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                                 Editar                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//
        #region Editar
        //Edita informações do banco de dados
        private void edit()
        {
            InformaID();
            exibir();

            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                StringConexao.EditaConSQL();

                comando = new MySqlCommand(StringConexao.EditaConSQL(), conexao);

                parametros();

                conexao.Open();

                comando.ExecuteNonQuery();

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
        #endregion
        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                              Consultar                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//
        #region Consulta
        //Consulta se tem dentro do banco de dados
        private void ConsultarID()
        {
            InformaID();

            if (txtConsultaProduto.Text == "")
            {
                MessageBox.Show("digite um ID de registro");
            }
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                StringConexao.ConsultaConSQL();

                comando = new MySqlCommand(StringConexao.ConsultaConSQL(), conexao);

                comando.Parameters.AddWithValue("@descricao_produto", txtConsultaProduto.Text);

                conexao.Open();

                Dr = comando.ExecuteReader();

                while (Dr.Read())
                {
                    txtlDestribuidor.Text = (string)Dr["destribuidor"];
                    txtMarca.Text = (string)Dr["marca"];
                    txtProduto.Text = (string)Dr["descricao_produto"];

                    cboxTamanho.Text = (Convert.ToString(Dr["tamanho_produto"]));
                    cboxSexo.Text = (Convert.ToString(Dr["sexo"]));

                    numUDQuantidade.Value = Convert.ToInt32(Dr["quantidade"]);
                    numUDPreco.Value = Convert.ToInt32(Dr["preco"]);
                }

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
        #endregion
    }
}
