using System;
using Microsoft.AspNetCore.Mvc;

namespace Knnithyanand.RazorSamples.ViewComponentBasic.Views.Shared.Components
{
    public class PasswordFieldViewComponent : ViewComponent
    {
        public PasswordFieldViewComponent()
        {
        }

        public IViewComponentResult Invoke(string id, string label, string placeholder)
        {
            return View(new PasswordFieldViewModel()
            {
                Id = id,
                Label = label,
                Placeholder = placeholder,
            });
        }
    }
}