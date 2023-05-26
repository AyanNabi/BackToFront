using Lab0526.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lab0526.ViewComponents
{
    public class LayoutViewCompanent
    {
        readonly AppDbContext _appDbContext;
        public LayoutViewCompanent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            
            return View(await Task.FromResult());

        }
    }
}
