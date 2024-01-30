using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace InfotainmentGuide.Layouts
{ 
    public partial class LoginDisplay
    {
        public void BeginLogOut()
        {
            Navigation.NavigateToLogout("authentication/logout");
        }
    }
}