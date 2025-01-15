using DND_App.Web.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Net;

namespace DND_App.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }
        [HttpPost]
        public async Task<IActionResult> UploadAsync(IFormFile file)
        {
            if (file == null)
            {
                return BadRequest("No file uploaded.");
            }

            var imageURL = await imageRepository.UploadAsync(file);

            if (imageURL == null)
            {
                return Problem("Image upload failed", null, (int)HttpStatusCode.InternalServerError);
            }

            return new JsonResult(new { link = imageURL });
        }
    }
}
