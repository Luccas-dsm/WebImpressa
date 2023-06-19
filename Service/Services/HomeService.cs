using DataAccess.DomainService;
using DataAccess.Mock;
using Impressa.Shared.Models;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class HomeService : IHomeService
    {
        private readonly MockData _mockData = new MockData();
        public async Task<List<MockModel>> RetornaImagemC1()
        {
            return await  _mockData.RetornaImagemC1();
        }
    }
}
