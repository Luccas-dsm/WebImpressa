using DataAccess.DomainService;
using Google.Cloud.Firestore;
using Impressa.Shared.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProdutoService : IProdutoService
    {
        ProdutoDataAccess _dataAccess = new ProdutoDataAccess();
        public async Task<List<ProdutoModel>> GetAllProducts()
        {
            return await _dataAccess.GetAllProducts();
        }

        public Task<ProdutoModel> GetPrdutoByID(string id)
        {
            return _dataAccess.GetPrdutoByID(id);
        }

        public void AddProduto(ProdutoModel produto)
        {
            _dataAccess.addProduto(produto);
        }
    }
}
