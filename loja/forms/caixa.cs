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

namespace loja
{
  
    public partial class frmCaixa : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        //MySqlDataAdapter Da;
        MySqlDataReader Dr;
        string stringSQL;
 

        public frmCaixa()
        {
            InitializeComponent();

            txtMarca.Enabled = false;
            txtProduto.Enabled = false;
            cboxTamanho.Enabled = false;
            cboxSexo.Enabled = false;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                

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


    }
}
