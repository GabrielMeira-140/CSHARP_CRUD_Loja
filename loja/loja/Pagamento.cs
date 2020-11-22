using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace loja
{
    public partial class PainelPagamento : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader Dr;
        string stringSQL;

        public PainelPagamento()
        {
            InitializeComponent();
        }

        private void btnAtualizarlista_Click(object sender, EventArgs e)
        {
            exibir();
        }

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

        private void btnExclui_Click(object sender, EventArgs e)
        {
            excluiID();
        }

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

    }
}
