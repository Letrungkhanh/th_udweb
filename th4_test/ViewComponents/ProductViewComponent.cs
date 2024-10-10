using th4_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace th4_test.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly QlBanHoaQuaContext _context;

        public ProductViewComponent(QlBanHoaQuaContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbProducts.Include(m => m.CategoryProductId).Where(m => (bool)m.IsActive).Where(m => m.IsNew);
            return await Task.FromResult<IViewComponentResult>(View(items.OrderByDescending(m => m.ProductId).ToList()));
        }
    }
}
