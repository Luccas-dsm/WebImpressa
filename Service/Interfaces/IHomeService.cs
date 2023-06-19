using DataAccess.Mock;
using Impressa.Shared.Models;

namespace Service.Interfaces
{
    public interface IHomeService
    {

        Task<List<MockModel>> RetornaImagemC1();
    }
}
