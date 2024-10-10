using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using th4_test.Models;

namespace th4_test.ViewComponents
{
    public class MenuTopViewComponent : ViewComponent
    {
        private readonly QlBanHoaQuaContext _context;

        public MenuTopViewComponent(QlBanHoaQuaContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _context.TbMenus.Where(m =>(bool)m.IsActive).OrderBy(m=>m.Position).ToList();

            return await Task.FromResult<IViewComponentResult>(View(items));
        }
    }
}
