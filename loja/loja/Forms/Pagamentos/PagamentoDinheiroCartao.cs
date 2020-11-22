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
    public partial class FormDinheiro : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader Dr;
        string stringSQL;


        public FormDinheiro()
        {
            InitializeComponent();

            Esconde();
        }

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               Botoes                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Botoes
        private void btnPagamento_Click(object sender, EventArgs e)
        {
            ValorFinal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            edit();
        }
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               Metodo                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Aparecer label
        void aparecer()
        {
            lblAvista.Visible = true;
            lblEmaiil.Visible = true;
            lblFinal.Visible = true;
            lblName.Visible = true;
            lblCartao.Visible = true;
            lblEmailPessoa.Visible = true;
            lblNomePessoa.Visible = true;
            lblValortoalCompra.Visible = true;

        }
        #endregion

        #region Esconde label
        void Esconde()
        {
            lblAvista.Visible = false;
            lblEmaiil.Visible = false;
            lblFinal.Visible = false;
            lblName.Visible = false;
            lblCartao.Visible = false;
            lblEmailPessoa.Visible = false;
            lblNomePessoa.Visible = false;
            lblValortoalCompra.Visible = false;
        }
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               Editar                                                  //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//
        #region Editar
        private void edit()
        {
            conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");
            try
            {
                stringSQL = "SELECT * FROM dados Where email = @email";
                comando = new MySqlCommand(stringSQL, conexao);

                comando.Parameters.AddWithValue("@email", txtEmail.Text);

                conexao.Open();

                Dr = comando.ExecuteReader();

                while (Dr.Read())
                {
                    numUDValor.Value = Convert.ToInt32(Dr["Total"]);
                    lblName.Text = Convert.ToString(Dr["Nome"]);
                    lblEmaiil.Text = Convert.ToString(Dr["Email"]);
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

        #region ValorFinal
        void ValorFinal()
        {
            avista();
            aparecer();
            MessageBox.Show("Compra realizada com sucesso!!!!");
        }
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                        Regra de negocio                                               //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Regra
        //estra regra consiste em descontos e juros encima do valor do produto, ou seja quanto mais prestações ela precisar mais juros a conpra terá

        void avista()
        {
            int Avista, Cartao;
            if (radioAvista.Checked == true)
            {
                Avista = (int)(numUDValor.Value - (numUDValor.Value / 100 * 5));
                lblFinal.Text = Convert.ToString(Avista + " reais");
                lblAvista.Text = "Compra realizada Avista";
            }

            if (radio1vez.Checked == true)
            {
                Cartao = (int)(numUDValor.Value);
                lblFinal.Text = Convert.ToString(Cartao + " reais");
                lblAvista.Text = "Compra realizada em 1 vezes no cartão";
            }

            if (radio2vez.Checked == true)
            {
                Cartao = (int)(numUDValor.Value);
                lblFinal.Text = Convert.ToString(Cartao + " reais");
                lblAvista.Text = "Compra realizada em 2 vezes no cartão";
            }

            if (radio3vez.Checked == true)
            {
                Cartao = (int)(numUDValor.Value + (numUDValor.Value / 100 * 5));
                lblFinal.Text = Convert.ToString(Cartao + " reais");
                lblAvista.Text = "Compra realizada em 3 vezes no cartão";
            }

            if (radio4vez.Checked == true)
            {
                Cartao = (int)(numUDValor.Value + (numUDValor.Value / 100 * 5));
                lblFinal.Text = Convert.ToString(Cartao + " reais");
                lblAvista.Text = "Compra realizada em 4 vezes no cartão";
            }

            if (radio5vez.Checked == true)
            {
                Cartao = (int)(numUDValor.Value + (numUDValor.Value / 100 * 10));
                lblFinal.Text = Convert.ToString(Cartao + " reais");
                lblAvista.Text = "Compra realizada em 5 vezes no cartão";
            }

            if (radio6vez.Checked == true)
            {
                Cartao = (int)(numUDValor.Value + (numUDValor.Value / 100 * 10));
                lblFinal.Text = Convert.ToString(Cartao + " reais");
                lblAvista.Text = "Compra realizada em 6 vezes no cartão";
            }
        }
        #endregion
    }
}
