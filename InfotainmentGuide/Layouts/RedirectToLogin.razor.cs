using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace InfotainmentGuide.Layouts
{
    public partial class RedirectToLogin
    {
        protected override void OnInitialized()
        {
            Navigation.NavigateToLogin("authentication/login");
        }
    }
}