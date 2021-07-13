using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace ViewComponentsExample.ViewComponents
{
    public class PersonCardViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(int id)
        {
            return Task.FromResult<IViewComponentResult>(View("CardDesign", id));
        }
    }

}
