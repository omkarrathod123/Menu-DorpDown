using System.Net.Http.Json;
using TestMenu.Classes;

namespace TestMenu.Client.Pages
{
    public partial class Countries
    {
        IList<Country> country;

        protected override async Task OnInitializedAsync()
        {
            country = await Http.GetFromJsonAsync<IList<Country>>("Countries");
        }
    }
}
