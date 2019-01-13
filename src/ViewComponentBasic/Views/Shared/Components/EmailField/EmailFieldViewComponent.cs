using Microsoft.AspNetCore.Mvc;

namespace Knnithyanand.RazorSamples.ViewComponentBasic.Views.Shared.Components
{
    public class EmailFieldViewComponent : ViewComponent
    {
        public EmailFieldViewComponent()
        {
        }

        public IViewComponentResult Invoke(string id, string label, string placeholder, string hint)
        {
            return View(new EmailFieldViewModel()
            {
                Id = id,
                Label = label,
                Placeholder = placeholder,
                Hint = hint
            });
        }
    }
}