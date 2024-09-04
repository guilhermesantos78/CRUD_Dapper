using System.Data.SQLite;
using Dapper;

namespace CRUD_Dapper
{
    public class ProdutoRepository
    {
        public readonly string _ConnectionString; //Variável de connection string a ser preenchida

        public ProdutoRepository(IConfiguration configuration) //Responsavel por preencher a connection string
        {
            _ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Adicionar(Produto produto)
        {
            using var connection = new SQLiteConnection(_ConnectionString) ; // Criando a conexão

            string commandInsert = @"
                INSERT INTO Produtos(Nome, Preco)
                VALUES (@Nome, @Preco)";

            connection.Execute(commandInsert, produto);0,
        }
    }
}
