﻿using DataAccess.DomainService;
using Impressa.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Impressa.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        EmployeeDataAccess objemployee = new EmployeeDataAccess();
        [HttpGet]
        public Task<List<Employee>> Get()
        {
            return objemployee.GetAllEmployees();
        }
        [HttpGet("{id}")]
        public Task<Employee> Get(string id)
        {
            return objemployee.GetEmployeeData(id);
        }
        [HttpPost]
        public void Post([FromBody] Employee employee)
        {
            objemployee.AddEmployee(employee);
        }
        [HttpPut]
        public void Put([FromBody] Employee employee)
        {
            objemployee.UpdateEmployee(employee);
        }
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            objemployee.DeleteEmployee(id);
        }
        [HttpGet("GetCities")]
        public Task<List<Cities>> GetCities()
        {
            return objemployee.GetCityData();
        }
    }
}
