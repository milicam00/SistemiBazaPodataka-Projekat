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
    public class TeretneController : ControllerBase
    {

        [HttpGet]
        [Route("PreuzmiTeretneMasine")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTeretneMasine()
        {
            try
            {
                return new JsonResult(DataProvider.GetTeretna());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiTeretneMasine/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTeretneMasineId(int id)
        {
            try
            {
                return new JsonResult(DataProvider.GetTeretnaId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajTeretnuMasinu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddTeretnuMasinu([FromBody] TeretnaView p)
        {
            try
            {
                DataProvider.CreateTeretna(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniTeretnuMasinu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeTeretnuMasinu([FromBody] TeretnaView p)
        {
            try
            {
                DataProvider.UpdateTeretna(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiTeretnuMasinu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteTeretnuMasinu(int id)
        {
            try
            {
                DataProvider.DeleteTeretna(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
