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
    public class GradilisteController : Controller
    {

        [HttpGet]
        [Route("PreuzmiGradilista")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGradilista()
        {
            try
            {
                return new JsonResult(DataProvider.GetGradilistaInfo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("PreuzmiGradiliste/{id}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetGradiliste(int id)
        {
            try
            {
                return new JsonResult(DataProvider.GetGradilisteId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajGradiliste")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddGradiliste([FromBody] GradilisteView  p)
        {
            try
            {
                DataProvider.DodajGradiliste(p.Tip);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniGradiliste")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeGradiliste([FromBody] GradilisteView p)
        {
            try
            {
                DataProvider.UpdateGradilisteView(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiGradiliste/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteGradiliste(int id)
        {
            try
            {
                DataProvider.DeleteGradiliste(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
