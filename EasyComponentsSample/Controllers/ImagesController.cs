using Microsoft.AspNetCore.Mvc;
namespace EasyComponentsSample.Controllers
{
    public class ImagesController : Controller
    {
        [HttpGet("/external-images/{fileName}")]
        public IActionResult GetImage(string fileName)
        {
            var imagePath = Path.Combine(@"D:\data", "images", fileName);
            if (!System.IO.File.Exists(imagePath))
            {
                return NotFound();
            }

            var extension = Path.GetExtension(fileName).ToLowerInvariant();
            var contentType = extension switch
            {
                ".jpg" or ".jpeg" => "image/jpeg",
                ".png" => "image/png",
                ".gif" => "image/gif",
                ".webp" => "image/webp",
                _ => "application/octet-stream"
            };
            return PhysicalFile(imagePath, contentType);
        }
    }
}
