using FrontToBack.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.ViewCompanents
{
    public class ProductViewComponent:ViewComponent
    {
        readonly AppDbContext _appDbContext;
        public ProductViewComponent(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = _appDbContext.Products
                .Include(p=>p.ProductImages)
                .Include(p=>p.category)
                .Take(4)
                .ToList();
            return View(await Task.FromResult(products));  

        }
    }
}

