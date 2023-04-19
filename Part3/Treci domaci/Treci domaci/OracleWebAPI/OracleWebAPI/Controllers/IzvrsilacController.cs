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
    public class IzvrsilacController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiIzvrsioce")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIzvrsioci()
        {
            try
            {
                return new JsonResult(DataProvider.GetIzvrsiociInfo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiIzvrsioca/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIzvrsilac(int id)
        {
            try
            {
                return new JsonResult(DataProvider.GetIzvrsilacViewId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajIzvrsioca")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddIzvrsilac([FromBody] IzvrsilacView p)
        {
            try
            {
                DataProvider.CreateIzvrsilac(p.GodinaRodjenja,p.Adresa,p.Jmbg,p.Ime,p.Prezime,p.OcevoIme);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniIzvrsioca")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeIzvrsilac([FromBody] IzvrsilacView p)
        {
            try
            {
                DataProvider.UpdateIzvrsilacView(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpDelete]
        [Route("IzbrisiIzvrsioca/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteIzvrsilac(int id)
        {
            try
            {
                DataProvider.DeleteIzvrsilacView(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }

}
