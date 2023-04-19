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
    public class RadneMasineController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiRadneMasine")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRadneMasine()
        {
            try
            {
                return new JsonResult(DataProvider.GetRadneMasineInfo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiRadneMasine/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRadneMasineId(int id)
        {
            try
            {
                return new JsonResult(DataProvider.GetRadneMasineId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajRadnuMasinu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddRadnaMasina([FromBody] RadneMasineView p)
        {
            try
            {
                DataProvider.CreateRadneMasine(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniRadnuMasinu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeRadnaMasina([FromBody] RadneMasineView p)
        {
            try
            {
                DataProvider.UpdateRadneMasine(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiRadnuMasinu/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteRadnuMasinu(int id)
        {
            try
            {
                DataProvider.DeleteRadneMasine(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
