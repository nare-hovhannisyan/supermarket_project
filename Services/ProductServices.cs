using System.Runtime.Serialization;
using System.Collections.Generic;
using Thenewwebapi.Models;
using Thenewwebapi.Controllers;
using Thenewwebapi.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Thenewwebapi.Services
{
    public class ProductsServices : IProductsServices
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

        public void InsertProducts(Products product) 
        {
            // ProductDAL productDAL = new ProductDAL();
            // productDAL.InsertProduct(product);
        }
        
        public string GetProducts()
        {
            ProductDAL productDAL = new ProductDAL();
            var result = productDAL.GetProducts();
            return(result);
            //return (productDAL.GetPeople());
        }
    }
}