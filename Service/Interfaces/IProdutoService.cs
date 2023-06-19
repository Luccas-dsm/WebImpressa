using Impressa.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Interfaces
{
    public  interface IProdutoService
    {
        Task<List<ProdutoModel>> GetAllProducts();
        Task<ProdutoModel> GetPrdutoByID(string id);
        void AddProduto(ProdutoModel produto);
    }
}
