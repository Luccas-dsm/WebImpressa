using DataAccess.DomainService;
using Impressa.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;

namespace Impressa.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController
    {
        IProdutoService produtoDataAccess = new ProdutoService();

        [HttpGet]
        public async Task<List<ProdutoModel>> Get()
        {
            return await produtoDataAccess.GetAllProducts();
        }
        [HttpGet("{id}")]
        public async Task<ProdutoModel> Get(string id)
        {
            return await produtoDataAccess.GetPrdutoByID(id);
        }
        [HttpPost]
        public void Post([FromBody] ProdutoModel produto)
        {
            produtoDataAccess.AddProduto(produto);
        }
    }
}
