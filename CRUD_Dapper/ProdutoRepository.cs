namespace CRUD_Dapper
{
    public class ProdutoRepository
    {
        public readonly string _ConnectionString; //Variável de connection string a ser preenchida

        public ProdutoRepository(IConfiguration configuration) //Responsavel por preencher a connection string
        {
            _ConnectionString = configuration.GetConnectionString("DefaultConnection");
        }
    }
}
