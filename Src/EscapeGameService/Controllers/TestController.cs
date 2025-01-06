using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace EscapeGameService.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly ICloudinaryService _cloudinaryService;
        public TestController(ICloudinaryService cloudinaryService) 
        {
          _cloudinaryService = cloudinaryService;
        } 

        [HttpGet("cloudinary")]
        public async Task<ActionResult> GetCloudinaryFile(string GetMyFile)
        {
            try
            {
                await  _cloudinaryService.GetAsync(GetMyFile);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest("");
            }
        }
        [HttpPost("cloudinary")]
        public async Task<ActionResult> CreateCloudinaryFile(IFormFile postMyFile)
        {
            try
            {
                string urlimage = await _cloudinaryService.UploadAsync(postMyFile);
                return Ok(urlimage);
            }
            catch (Exception)
            {
                return BadRequest("");
            }
        }
    }
}
