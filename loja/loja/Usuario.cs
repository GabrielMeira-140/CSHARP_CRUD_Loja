using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace loja
{
    public partial class PainelHorarios : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader Dr;
        string stringSQL;

        public PainelHorarios()
        {
            InitializeComponent();

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            AdicionaCompras();
            MessageBox.Show("pedido enviado");
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

        private void precoTotaCamiseta()
        {
            comando.Parameters.AddWithValue("@total", (((numCamiseta1.Value) * 35) + ((numCamiseta2.Value) * 50) + ((numCamiseta3.Value) * 30) + ((numCamiseta4.Value) * 70) + ((numCamiseta5.Value) * 130) + ((numCamiseta6.Value) * 19) + ((numCamiseta7.Value) * 60) + ((numCamiseta8.Value) * 30) + ((numCamiseta9.Value) * 30) + ((numCamiseta10.Value) * 99)
                + ((numCamiseta11.Value) * 25) + ((numCamiseta12.Value) * 15) + ((numCamiseta13.Value) * 30) + ((numCamiseta14.Value) * 110) + ((numCamiseta15.Value) * 100) + ((numCamiseta16.Value) * 70) + ((numCamiseta17.Value) * 20) + ((numCamiseta18.Value) * 40) + ((numCamiseta19.Value) * 59) + ((numCamiseta20.Value) * 75)));
        }

        private void precoTotalCalca()
        {
            comando.Parameters.AddWithValue("@total", (((numCalca1.Value) * 79) + ((numCalca2.Value) * 150) + ((numCalca3.Value) * 100) + ((numCalca4.Value) * 85) + ((numCalca5.Value) * 200) + ((numCalca6.Value) * 145) + ((numCalca7.Value) * 135) + ((numCalca8.Value) * 105) + ((numCalca9.Value) * 75) + ((numCalca10.Value) * 60)
                + ((numCalca11.Value) * 65) + ((numCalca12.Value) * 100) + ((numCalca13.Value) * 135) + ((numCalca14.Value) * 145) + ((numCalca15.Value) * 150) + ((numCalca16.Value) * 130) + ((numCalca17.Value) * 250) + ((numCalca18.Value) * 180) + ((numCalca19.Value) * 200) + ((numCalca20.Value) * 165)));
        }
    }
}
