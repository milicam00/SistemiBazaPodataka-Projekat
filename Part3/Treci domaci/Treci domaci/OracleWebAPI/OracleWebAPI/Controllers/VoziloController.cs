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
    //NISAM SIGURNA DA LI JE TREBALO DA PISEM OVAJ KONTROLER JER SVAKAKO IMAM KONTROLERE ZA SVAKU VRSTU VOZILA
    //ALI SAM IPAK NAPISALA
    [ApiController]
    [Route("[controller]")]
    public class VoziloController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVozila")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVozila()
        {
            try
            {
                return new JsonResult(DataProvider.GetAllVozila());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVozilo/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetVoziloId(int id)
        {
            try
            {
                return new JsonResult(DataProvider.GetVoziloId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiVozilo/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVozilo(int id)
        {
            try
            {
                DataProvider.DeleteVozilo(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
