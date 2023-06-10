using FrontToBack.ViewModels.AdminVM.Slider;
using Microsoft.AspNetCore.Http;
using System.Security.Principal;

namespace FrontToBack.Helper
{
    public static class Extention
    {
        public static bool CheckFileType(this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }

        public static bool CheckFileType(this IFormFile file, int size)
        {
            return file.ContentType.Contains("image");
        }
    }
}
