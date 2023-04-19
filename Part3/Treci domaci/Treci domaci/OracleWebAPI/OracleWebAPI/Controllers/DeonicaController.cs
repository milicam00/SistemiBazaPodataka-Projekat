using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PuteviLibrary.DTOs;
using PuteviLibrary;
using PuteviLibrary.Entiteti;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeonicaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiDeonice")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetDeonice()
        {
            try
            {
                return new JsonResult(DataProvider.GetDeonInfo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiDeonicu/{ID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetDeonice(int ID)
        {
            try
            {
                return new JsonResult(DataProvider.UcitajInformacijeDeonicaPoId(ID));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajDeonicu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddDeonica([FromBody] Deonica p)
        {
            try
            {
                DataProvider.DodajDeonicu(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniDeonicu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeDeonica([FromBody] DeonicaView p)
        {
            try
            {
                DataProvider.UpdateDeonicaView(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        [HttpDelete]
        [Route("IzbrisiDeonicu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteDeonicu(int id)
        {
            try
            {
                DataProvider.DeleteDeonicu(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
