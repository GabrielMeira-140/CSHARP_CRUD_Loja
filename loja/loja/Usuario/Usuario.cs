using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    public partial class PainelHorarios : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        string stringSQL;

        public PainelHorarios()
        {
            InitializeComponent();
        }

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                                 Botao                                                 //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region botao
        private void btnPagar_Click(object sender, EventArgs e)
        {
            AdicionaCompras();
            MessageBox.Show("pedido enviado");
        }
        #endregion

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                               Metodos                                                 //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        //*******************************************************************************************************//
        //                                                                                                       //
        //                                                                                                       //
        //                                              Adicionar                                                //
        //                                                                                                       //
        //                                                                                                       //
        //*******************************************************************************************************//

        #region Adicionar Compra
        void AdicionaCompras()
        {
            try
            {

                //abrindo servirdor
                conexao = new MySqlConnection("Server=localhost;Database=loja;User Id=root;");

                //comando mySQL com parametros
                stringSQL = "INSERT INTO dados (nome, email, camiseta1, camiseta2, camiseta3, camiseta4, camiseta5, camiseta6, camiseta7, camiseta8, camiseta9, camiseta10, " +
                    "camiseta11, camiseta12, camiseta13, camiseta14, camiseta15, camiseta16, camiseta17, camiseta18, camiseta19, camiseta20," +
                    " Calca1, Calca2, Calca3, Calca4, Calca5, Calca6, Calca7, Calca8, Calca9, Calca10," +
                    " Calca11, Calca12, Calca13, Calca14, Calca15, Calca16, Calca17, Calca18, Calca19, Calca20, total) " +
                    "VALUES (@nome, @email, @camiseta1, @camiseta2, @camiseta3, @camiseta4, @camiseta5, @camiseta6, @camiseta7, @camiseta8, @camiseta9, @camiseta10, " +
                    "@camiseta11, @camiseta12, @camiseta13, @camiseta14, @camiseta15, @camiseta16, @camiseta17, @camiseta18, @camiseta19, @camiseta20," +
                    " @Calca1, @Calca2, @Calca3, @Calca4, @Calca5, @Calca6, @Calca7, @Calca8, @Calca9, Calca10," +
                    " @Calca11, @Calca12, @Calca13, @Calca14, @Calca15, @Calca16, @Calca17, @Calca18, @Calca19, @Calca20, @total)";

                comando = new MySqlCommand(stringSQL, conexao);

                parametrosdados();
                parametrosCamisetas();
                parametrosCalcas();
                precoTotaCamiseta();

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

        #region ParametrosSQL
        private void parametrosdados()
        {
            comando.Parameters.AddWithValue("@nome", txtNome.Text);
            comando.Parameters.AddWithValue("@email", txtEmail.Text);

        }

        private void parametrosCamisetas()
        {
            comando.Parameters.AddWithValue("@camiseta1", numCamiseta1.Value);
            comando.Parameters.AddWithValue("@camiseta2", numCamiseta2.Value);
            comando.Parameters.AddWithValue("@camiseta3", numCamiseta3.Value);
            comando.Parameters.AddWithValue("@camiseta4", numCamiseta4.Value);
            comando.Parameters.AddWithValue("@camiseta5", numCamiseta5.Value);
            comando.Parameters.AddWithValue("@camiseta6", numCamiseta6.Value);
            comando.Parameters.AddWithValue("@camiseta7", numCamiseta7.Value);
            comando.Parameters.AddWithValue("@camiseta8", numCamiseta8.Value);
            comando.Parameters.AddWithValue("@camiseta9", numCamiseta9.Value);
            comando.Parameters.AddWithValue("@camiseta10", numCamiseta10.Value);
            comando.Parameters.AddWithValue("@camiseta11", numCamiseta11.Value);
            comando.Parameters.AddWithValue("@camiseta12", numCamiseta12.Value);
            comando.Parameters.AddWithValue("@camiseta13", numCamiseta13.Value);
            comando.Parameters.AddWithValue("@camiseta14", numCamiseta14.Value);
            comando.Parameters.AddWithValue("@camiseta15", numCamiseta15.Value);
            comando.Parameters.AddWithValue("@camiseta16", numCamiseta16.Value);
            comando.Parameters.AddWithValue("@camiseta17", numCamiseta17.Value);
            comando.Parameters.AddWithValue("@camiseta18", numCamiseta18.Value);
            comando.Parameters.AddWithValue("@camiseta19", numCamiseta19.Value);
            comando.Parameters.AddWithValue("@camiseta20", numCamiseta20.Value);
        }

        private void parametrosCalcas()
        {
            comando.Parameters.AddWithValue("@Calca1", numCalca1.Value);
            comando.Parameters.AddWithValue("@Calca2", numCalca2.Value);
            comando.Parameters.AddWithValue("@Calca3", numCalca3.Value);
            comando.Parameters.AddWithValue("@Calca4", numCalca4.Value);
            comando.Parameters.AddWithValue("@Calca5", numCalca5.Value);
            comando.Parameters.AddWithValue("@Calca6", numCalca6.Value);
            comando.Parameters.AddWithValue("@Calca7", numCalca7.Value);
            comando.Parameters.AddWithValue("@Calca8", numCalca8.Value);
            comando.Parameters.AddWithValue("@Calca9", numCalca9.Value);
            comando.Parameters.AddWithValue("@Calca10", numCalca10.Value);
            comando.Parameters.AddWithValue("@Calca11", numCalca11.Value);
            comando.Parameters.AddWithValue("@Calca12", numCalca12.Value);
            comando.Parameters.AddWithValue("@Calca13", numCalca13.Value);
            comando.Parameters.AddWithValue("@Calca14", numCalca14.Value);
            comando.Parameters.AddWithValue("@Calca15", numCalca15.Value);
            comando.Parameters.AddWithValue("@Calca16", numCalca16.Value);
            comando.Parameters.AddWithValue("@Calca17", numCalca17.Value);
            comando.Parameters.AddWithValue("@Calca18", numCalca18.Value);
            comando.Parameters.AddWithValue("@Calca19", numCalca19.Value);
            comando.Parameters.AddWithValue("@Calca20", numCalca20.Value);
        }
        #endregion

        #region preco
        private void precoTotaCamiseta()
        {
            comando.Parameters.AddWithValue("@total", (((numCamiseta1.Value) * 42) + ((numCamiseta2.Value) * 60) + ((numCamiseta3.Value) * 36) + ((numCamiseta4.Value) * 84) + ((numCamiseta5.Value) * 156) + ((numCamiseta6.Value) * 24) + ((numCamiseta7.Value) * 42) + ((numCamiseta8.Value) * 144) + ((numCamiseta9.Value) * 180) + ((numCamiseta10.Value) * 138)
                + ((numCamiseta11.Value) * 30) + ((numCamiseta12.Value) * 48) + ((numCamiseta13.Value) * 72) + ((numCamiseta14.Value) * 114) + ((numCamiseta15.Value) * 18) + ((numCamiseta16.Value) * 12) + ((numCamiseta17.Value) * 180) + ((numCamiseta18.Value) * 24) + ((numCamiseta19.Value) * 114) + ((numCamiseta20.Value) * 300))
                + ((numCalca1.Value) * 300) + ((numCalca2.Value) * 360) + ((numCalca3.Value) * 84) + ((numCalca4.Value) * 72) + ((numCalca5.Value) * 108) + ((numCalca6.Value) * 102) + ((numCalca7.Value) * 360) + ((numCalca8.Value) * 144) + ((numCalca9.Value) * 72) + ((numCalca10.Value) * 120)
                + ((numCalca11.Value) * 432) + ((numCalca12.Value) * 264) + ((numCalca13.Value) * 132) + ((numCalca14.Value) * 180) + ((numCalca15.Value) * 192) + ((numCalca16.Value) * 240) + ((numCalca17.Value) * 216) + ((numCalca18.Value) * 192) + ((numCalca19.Value) * 180) + ((numCalca20.Value) * 240));

        }
        #endregion
    }
}
