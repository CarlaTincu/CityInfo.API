using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : Controller
    {
        public readonly FileExtensionContentTypeProvider _file;
        public FilesController
            (FileExtensionContentTypeProvider file)
        {
            _file = file
            ?? throw new System.ArgumentNullException(nameof(file));
        }
        [HttpGet("{fileId}")]
        public ActionResult GetFile()
        {
            var pathToFile = "getting-started-with-rest-slides.pdf";
            if(!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }
            if(!_file.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octet-stream";
            }
            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes,contentType, Path.GetFileName(pathToFile));
        }
    }
}
