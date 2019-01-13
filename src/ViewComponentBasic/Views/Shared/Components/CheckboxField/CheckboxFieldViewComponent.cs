using System;
using Microsoft.AspNetCore.Mvc;

namespace Knnithyanand.RazorSamples.ViewComponentBasic.Views.Shared.Components
{
    public class CheckboxFieldViewComponent : ViewComponent
    {
        public CheckboxFieldViewComponent()
        {
        }

        public IViewComponentResult Invoke(string id, string label)
        {
            return View(new CheckboxFieldViewModel()
            {
                Id = id,
                Label = label
            });
        }
    }
}