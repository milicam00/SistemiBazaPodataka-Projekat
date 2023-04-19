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
    public class SpoljniSaradnikController : Controller
    {
        [HttpGet]
        [Route("PreuzmiSpoljneSaradnike")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSpoljniSaradnici()
        {
            try
            {
                return new JsonResult(DataProvider.GetSpoljniSaradniciInfo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSpoljnogSaradnika/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSpoljniSaradnik(int id)
        {
            try
            {
                return new JsonResult(DataProvider.GetSpoljniSaradnikId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSpoljnogSaradnika")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSpoljniSaradnik([FromBody] SpoljniSaradnikView p)
        {
            try
            {
                DataProvider.DodajSaradnika(p.BrUgovoraODelu);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniSpoljnogSaradnika")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeSpoljniSaradnik([FromBody] SpoljniSaradnikView p)
        {
            try
            {
                DataProvider.UpdateSpoljniSaradnikView(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiSpoljnogSaradnika/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteSpoljniSaradnik(int id)
        {
            try
            {
                DataProvider.DeleteSpoljniSaradnikView(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
