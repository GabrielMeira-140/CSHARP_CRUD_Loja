using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja.Classe
{
    class STRSQL
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///                                                                     Estoque                                                                         ///
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public string AdicionaConSQL()
        {
            string stringSQL = "INSERT INTO produtos (id_produto, destribuidor, marca, descricao_produto, tamanho_produto, sexo, quantidade, preco, precoCliente)" +
                    " values (@id_produto, @destribuidor, @marca, @descricao_produto, @tamanho_produto, @sexo, @quantidade, @preco, @precoCliente)";

            return stringSQL;

        }
        
        public string ExibeConSQL()
        {
            string stringSQL = "SELECT* FROM produtos";

            return stringSQL;
        }
        
        public string ExcluiConSQL()
        {
            string stringSQL = "DELETE FROM produtos WHERE id_produto = @id_produto";

            return stringSQL;
        }
        
        public string EditaConSQL()
        {
            string stringSQL = "UPDATE produtos SET destribuidor = @destribuidor, marca = @marca, descricao_produto = @descricao_produto, tamanho_produto = @tamanho_produto" +
                    ", sexo = @sexo, quantidade = @quantidade, preco = @preco, precoCliente = @precoCliente WHERE id_produto = @id_produto";

            return stringSQL;
        }
        
        public string ConsultaConSQL()
        {
            string stringSQL = "SELECT * FROM produtos Where descricao_produto = @descricao_produto";

            return stringSQL;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///                                                                VisualizarCliente                                                                    ///
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public string PagamentosExcluiConSQL()
        {
            string stringSQL = "DELETE FROM dados WHERE email = @email";

            return stringSQL;
        }

        public string PagamentosExibirConSQL()
        {
            string stringSQL = "SELECT * FROM dados";

            return stringSQL;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///                                                                        Usuario                                                                      ///
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///                                                                                                                                                     ///
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public string UsuarioAdicionaConSQL()
        {
            string stringSQL = "INSERT INTO dados (nome, email, camiseta1, camiseta2, camiseta3, camiseta4, camiseta5, camiseta6, camiseta7, camiseta8, camiseta9, camiseta10, " +
                    "camiseta11, camiseta12, camiseta13, camiseta14, camiseta15, camiseta16, camiseta17, camiseta18, camiseta19, camiseta20," +
                    " Calca1, Calca2, Calca3, Calca4, Calca5, Calca6, Calca7, Calca8, Calca9, Calca10," +
                    " Calca11, Calca12, Calca13, Calca14, Calca15, Calca16, Calca17, Calca18, Calca19, Calca20, total) " +
                    "VALUES (@nome, @email, @camiseta1, @camiseta2, @camiseta3, @camiseta4, @camiseta5, @camiseta6, @camiseta7, @camiseta8, @camiseta9, @camiseta10, " +
                    "@camiseta11, @camiseta12, @camiseta13, @camiseta14, @camiseta15, @camiseta16, @camiseta17, @camiseta18, @camiseta19, @camiseta20," +
                    " @Calca1, @Calca2, @Calca3, @Calca4, @Calca5, @Calca6, @Calca7, @Calca8, @Calca9, Calca10," +
                    " @Calca11, @Calca12, @Calca13, @Calca14, @Calca15, @Calca16, @Calca17, @Calca18, @Calca19, @Calca20, @total)";

            return stringSQL;
        }
    }
}
