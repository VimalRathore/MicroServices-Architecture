using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using FindnChitChat.Data;
using FindnChitChat.Dto;
using FindnChitChat.Helper;
using FindnChitChat.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FindnChitChat.Controllers 
{
    [Route ("api/[controller]")]
    [ApiController]
    public class TestController:ControllerBase
    {
       [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Test 1", "Test Succeded" };
        }
    }
}