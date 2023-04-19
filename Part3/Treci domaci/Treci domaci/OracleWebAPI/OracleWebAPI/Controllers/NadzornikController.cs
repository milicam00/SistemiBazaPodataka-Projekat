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
    public class NadzornikController : Controller
    {
        [HttpGet]
        [Route("PreuzmiNadzornike")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetNadzornici()
        {
            try
            {
                return new JsonResult(DataProvider.GetNadzornikInfo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        [HttpGet]
        [Route("PreuzmiNadzornika/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetNdzornikId(int id)
        {
            try
            {
                return new JsonResult(DataProvider.GetNadzornikPregledId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajNadzornika")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddNadzornik([FromBody] NadzornikView p)
        {
            try
            {
                DataProvider.CreateNadzornik(p.GodinaRodjenja, p.Adresa, p.Jmbg, p.Ime, p.Prezime, p.OcevoIme);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniNadzornika")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeNadzornik([FromBody] NadzornikView p)
        {
            try
            {
                DataProvider.UpdateNadzornikView(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



        [HttpDelete]
        [Route("IzbrisiNadzornika/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteNadzornik(int id)
        {
            try
            {
                DataProvider.DeleteNadzornikView(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
