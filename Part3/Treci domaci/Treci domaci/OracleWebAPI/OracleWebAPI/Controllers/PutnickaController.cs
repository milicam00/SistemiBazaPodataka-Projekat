using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using PuteviLibrary.DTOs;
using PuteviLibrary;

namespace OracleWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PutnickaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiPutnicka")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPutnicka()
        {
            try
            {
                return new JsonResult(DataProvider.GetPutnickaView());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiPutnicka/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPutnickaId(int id)
        {
            try
            {
                return new JsonResult(DataProvider.GetPutnickaIdView(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajPutnicko")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPutnicko([FromBody] PutnickaView p)
        {
            try
            {
                DataProvider.CreatePutnicka(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniPutnicko")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangePutnicko([FromBody] PutnickaView p)
        {
            try
            {
                DataProvider.UpdatePutnicka(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiPutnicko/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePutnicko(int id)
        {
            try
            {
                DataProvider.DeletePutnicka(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
