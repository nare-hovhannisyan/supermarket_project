using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Thenewwebapi.Models;
using Thenewwebapi.Services;
using Thenewwebapi.DataAccess;
using Newtonsoft.Json;

namespace Thenewwebapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController
    {
        private readonly IProductsServices _services;

        public ProductsController(IProductsServices services)
        {
            _services = services;
        }

        // [HttpPost]
        // public ActionResult<People> AddPeople(People person)
        // {
        //     _services.InsertPeople(person);
        //     return person;

        // }


        [HttpGet]
        public ActionResult<string> GetProducts() 
        {

           var result = _services.GetProducts() ;
            return result;
    
        }
    
    }
}