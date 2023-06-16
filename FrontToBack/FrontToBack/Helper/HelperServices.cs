namespace FrontToBack.Helper
{
    public static class HelperServices
    {
        public static  void DeleteFile(string path)
        {
            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }


        }
    }
}
