using Microsoft.AspNetCore.Mvc;

namespace CRUD_Dapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoRepository _repository ;

        public ProdutoController(IConfiguration configuration)
        {
            _repository = new ProdutoRepository(configuration);
        }

        [HttpGet]
        public void Teste()
        {

        }
    }

}