using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEB_API_In_Dot_Net_Mac.Models;

namespace WEB_API_In_Dot_Net_Mac.Controllers
{    
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character knight = new Character();

        [HttpGet]
        public ActionResult<Character> Get(){
            return Ok(knight);
        }
    }
}