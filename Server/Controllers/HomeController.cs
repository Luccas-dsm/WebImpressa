using DataAccess.DomainService;
using DataAccess.Mock;
using Impressa.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using Service.Services;

namespace Impressa.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        IHomeService homeService = new HomeService();
        [HttpGet]
        public async Task<List<MockModel>> Get()
        {
            return await homeService.RetornaImagemC1();
        }
    }
}
