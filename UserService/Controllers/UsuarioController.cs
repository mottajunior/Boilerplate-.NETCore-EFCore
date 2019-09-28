using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserService.Domain.Entities;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {        
        [HttpPost("cliente")]
        public ActionResult SalvarCliente([FromBody] object cliente)
        {            
            return Ok(cliente);
        }        
    }
}
