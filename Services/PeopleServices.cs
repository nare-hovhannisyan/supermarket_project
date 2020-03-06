using System.Runtime.Serialization;
using System.Collections.Generic;
using Thenewwebapi.Models;
using Thenewwebapi.Controllers;
using Thenewwebapi.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Thenewwebapi.Services
{
    public class PeopleServices : IPeopleServices
    {
        //  private readonly IPeopleServices _peopleItems;
        // public PeopleServices(IPeopleServices peopleItems)
        // {
        //     _peopleItems = peopleItems;
        // }


        // public PeopleServices()
        // {
        //     _peopleItems = new Dictionary<string, People>();
        // }

        public void InsertPeople(People person) 
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.InsertPeople(person);
        }
        
        public string GetPeopleItems()
        {
            ProductDAL productDAL = new ProductDAL();
            productDAL.GetPeople();
            return("aa");
            //return (productDAL.GetPeople());
        }
    }
}