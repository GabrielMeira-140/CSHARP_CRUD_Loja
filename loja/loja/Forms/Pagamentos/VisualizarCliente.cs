using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using loja.Classe;
using MySql.Data.MySqlClient;

namespace loja.Pagamentos
{
    public partial class FormView : Form
    {
        STRSQL conexaoSQL = new STRSQL();
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormView()
        {
            InitializeComponent();
        }

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               botoes                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Botoes
        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formEstoque FrmEstoque = new formEstoque();

            FrmEstoque.Show();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            excluiID();
        }

        private void btnAtualizarlista_Click(object sender, EventArgs e)
        {
            exibir();
        }

        private void btn_Pagar_Click(object sender, EventArgs e)
        {
            FormDinheiro FrmDinheiro = new FormDinheiro();
            FrmDinheiro.Show();
        }


        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PainelHorarios PnlHorario = new PainelHorarios();
            PnlHorario.Show();
        }
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               Metodo                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                                Excluir                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Exclir
        //Exclui pedido realizado apartir do email 

        private void excluiID()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                conexaoSQL.PagamentosExcluiConSQL();

                comando = new MySqlCommand(conexaoSQL.PagamentosExcluiConSQL(), conexao);

                comando.Parameters.AddWithValue("@email", txtEmail.Text);

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
        //exibe as informações dos clientes no datagridview
        private void exibir()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                conexaoSQL.PagamentosExibirConSQL();

                MySqlCommand comando = new MySqlCommand(conexaoSQL.PagamentosExibirConSQL(), conexao);

                DataTable dt = new DataTable();

                MySqlDataAdapter da = new MySqlDataAdapter(comando);

                da.Fill(dt);

                dgvCaixa.DataSource = dt;

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
    }

}
