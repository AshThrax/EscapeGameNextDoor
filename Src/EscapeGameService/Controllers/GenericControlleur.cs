using EscapeGameService.Dto.Base;
using EscapeGameService.Models.DataType;

using Microsoft.AspNetCore.Mvc;

namespace EscapeGameService.Controllers
{
    public class GenericControlleur<TIn,TOut,TAdd,TUp> : ControllerBase
        where TIn : class
        where TOut : BaseDto
        where TAdd : AddDto
        where TUp : UpdateDto
    {

        private readonly IService<TIn, TOut, TAdd, TUp> _serviceT;

        public GenericControlleur(IService<TIn, TOut, TAdd, TUp> serviceT)
        { 
            _serviceT = serviceT;
        }

        [HttpGet("")]
        public async Task<ActionResult<ServiceResponse<TOut>>> Getpage()
        {
            ServiceResponse<IEnumerable<TOut>> response=new();
            try
            {
                response = await _serviceT.GetAll();
                if (!response.Success)
                {
                    return BadRequest("");
                }
                return Ok(response);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<TOut>>> GetById(int id)
        {
            ServiceResponse<TOut> response = new();
            try
            {
                response = await _serviceT.GetById(id);
                if (!response.Success)
                {
                    return BadRequest(response);
                }
                return Ok(response);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("{id}")]
        public async Task<ActionResult<ServiceResponse<TOut>>> Create(TAdd creationDto)
        {
            ServiceResponse<TOut> response = new();
            try
            {
                response = await _serviceT.Create(creationDto);
                if (!response.Success)
                {
                    return BadRequest("");
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest("");
            }
        }
        [HttpPut("")]
        public async Task<ActionResult<ServiceResponse<TOut>>> Update(TUp updateDto)
        {
            ServiceResponse<TOut> response = new();
            try
            {
                response = await _serviceT.Update(updateDto);
                if (!response.Success)
                {
                    return BadRequest("");
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest("");
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<TOut>>> Delete(int id)
        {
            ServiceResponse<TOut> response = new();
            try
            {
                response = await _serviceT.Delete(id);
                if (!response.Success)
                {
                    return BadRequest("");
                }
                return Ok(response);
            }
            catch (Exception)
            {
                return BadRequest("");
            }
        }
    }
}
