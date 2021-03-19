using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_Uygulaması.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KimlikController : ControllerBase
    {
        //api/Kimlik//GirisYap
        [HttpGet("[action]")]
        public IActionResult GirisYap()
        {

            return Created("",new  CreateToken().TokenOlustur());
        }
        [Authorize]
        [HttpGet("[action]")]
        public IActionResult Erisim()
        {

            return Ok("Token geçti");
        }
    }
}
