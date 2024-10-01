using Microsoft.AspNetCore.Components;

namespace SupportTicketSystem.Pages;

public partial class Index
{

    [Inject] NavigationManager navigationManager { get; set; }
    private void NavigateToSupport()
    {
        navigationManager.NavigateTo("/support");
    }
}
