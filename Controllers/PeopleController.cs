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
    public class PeopleController : ControllerBase
    {
        
        private readonly IPeopleServices _services;

        public PeopleController(IPeopleServices services)
        {
            _services = services;
        }

        [HttpPost]
        public ActionResult<People> AddPeople(People person)
        {
            _services.InsertPeople(person);
            return person;

        }


        [HttpGet]
        public ActionResult<string> GetPeopleItems() 
        {

           var result = _services.GetPeopleItems() ;
            return result;
            //return (JsonConvert.SerializeObject(result))
           // return (Json(name, JsonRequestBehavior.AllowGet)); 
        //     var peopleItems = _services.GetPeopleItems();
        //     return({
        //         name : "nannanana",
        //         age : 1,
        //         ID : 2
        //         });
        // }
        }
    }
}
