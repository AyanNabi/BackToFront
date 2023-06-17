using FrontToBack.ViewModels.AdminVM.Slider;
using Microsoft.AspNetCore.Http;
using System.IO;
using System;
using System.Security.Principal;
using Microsoft.AspNetCore.Hosting;

namespace FrontToBack.Helper
{
    public static class Extention
    {
        public static bool CheckFileType(this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }

        public static bool CheckFileSize(this IFormFile file, int size)
        {
            return file.Length > size;
        }

        public static string SaveImage(this IFormFile file, IWebHostEnvironment webHostEnvironment, string foldername)
        {
            
                  var filename = Guid.NewGuid() + file.FileName;
            var path = Path.Combine(webHostEnvironment.WebRootPath, foldername, filename);

            using (FileStream stream = new FileStream(path, FileMode.CreateNew))
            {
                file.CopyTo(stream);
            }
            return filename;

        }
    }
}
