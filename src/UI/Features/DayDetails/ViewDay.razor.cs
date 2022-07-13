using Microsoft.AspNetCore.Components;

namespace DateBlazor.UI.Features.DayDetails
{
    public partial class ViewDay : ComponentBase
    {
        [Parameter]
        public string? DateString { get; set; }

        string? _errorMessage;
        DateTime _date;

        protected override async Task OnInitializedAsync()
        {
            bool isDate = DateTime.TryParse(DateString, out _date);
            if (!isDate)
            {
                _errorMessage = "Something went wrong";
            }

            await base.OnInitializedAsync();
        }
    }
}
