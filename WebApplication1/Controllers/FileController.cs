using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.StaticFiles;
namespace WebApplication1.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index([FromServices] IConfiguration configuration, [FromQuery] string fileName = null)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return View();
            }
            //Determine the Content Type of the File.
            string contentType = "";
            new FileExtensionContentTypeProvider().TryGetContentType(fileName, out contentType);
            var data = System.IO.File.ReadAllBytes(Path.Combine(configuration["Filespath"], fileName));
            return File(data, contentType, fileName);
        }
        [HttpPost]
        public IActionResult Index([FromServices] IConfiguration configuration)
        {
            var formFile = Request.Form.Files.First();
            using (var stream = new FileStream(Path.Combine(configuration["Filespath"], formFile.FileName), FileMode.Create))
            {
                formFile.CopyTo(stream);
                stream.Flush();
                stream.Close();
            }
            ModelState.Clear();
            return View();
        }
    }
}
