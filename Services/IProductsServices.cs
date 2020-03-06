using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Thenewwebapi.Models;
using Thenewwebapi.Controllers;
using Thenewwebapi.DataAccess;

namespace Thenewwebapi.Services
{
    public interface IProductsServices
    {
        void InsertProducts(Products product);
        string GetProducts();
    }
}