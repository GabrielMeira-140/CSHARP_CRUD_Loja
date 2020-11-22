using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loja.Pagamentos
{
    public partial class FormView : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string stringSQL;
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
        private void excluiID()
        {
            try
            {
                //abrindo servirdor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                //comando mySQL com parametros
                stringSQL = "DELETE FROM dados WHERE email = @email";

                comando = new MySqlCommand(stringSQL, conexao);

                comando.Parameters.AddWithValue("@email", txtEmail.Text);


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
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                                 Exibir                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Exibir
        private void exibir()
        {
            try
            {
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                stringSQL = "SELECT * FROM dados";

                MySqlCommand comando = new MySqlCommand(stringSQL, conexao);

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
