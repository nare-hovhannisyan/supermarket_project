using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Thenewwebapi.Models;
using Thenewwebapi.Controllers;
using Thenewwebapi.DataAccess;

namespace Thenewwebapi.Services
{
    public interface IPeopleServices
    {
        void InsertPeople(People people);
        string GetPeopleItems();
    }
}