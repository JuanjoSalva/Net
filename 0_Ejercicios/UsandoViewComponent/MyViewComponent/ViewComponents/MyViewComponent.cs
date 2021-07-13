
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyViewComponent.ViewComponents
{
    public class MyViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int param)
        {
            int id = await SomeOperationAsync(param);

            // return Task.FromResult<IViewComponentResult>(View("Default"));
            return View("Default", id);
        }

        private async Task<int> SomeOperationAsync(int param)
        {
            await Task.Run(() => { param = param + 2; });
            return param;
        }
    }
}