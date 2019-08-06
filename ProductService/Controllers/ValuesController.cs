﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductService.Domain.Entities;
using ProductService.Domain.IRepositories;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserRepository _userRepository;
        public ValuesController(IUserRepository userRepository){
            _userRepository = userRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get(){
            return Ok(_userRepository.GetAll());            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id){
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
