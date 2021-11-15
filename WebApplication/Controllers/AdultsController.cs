using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
        private IAdultService adultService;

        public AdultsController(IAdultService adultService)
        {
            this.adultService = adultService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults([FromQuery] int? id)
        {
            try
            {
                IList<Adult> adults = await adultService.GetAllAdultsAsync();

                if (id != null)  //filter by id
                {
                    adults = adults.Where(adult => adult.Id == id).ToList();
                }

                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> GetExactAdult([FromRoute] int id)
        {
            try
            {
                Adult adult = await adultService.GetAdultAsync(id);
                return Ok(adult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<Adult>> AddAdult([FromBody] Adult todo)
        {
            try
            {
                Adult added = await adultService.AddAdultAsync(todo);
                return Created($"/{added.Id}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPatch]
        [Route("{id:int}")]
        public async Task<ActionResult<Adult>> UpdateAdult([FromBody] Adult adult)
        {
            try
            {
                Adult updatedTodo = await adultService.UpdateAsync(adult);
                return Ok(updatedTodo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteAdult([FromRoute] int id)
        {
            try
            {
                await adultService.RemoveAdultAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}