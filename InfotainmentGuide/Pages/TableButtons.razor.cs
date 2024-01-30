using System.Net.Http.Json;

namespace InfotainmentGuide.Pages
{
    public partial class TableButtons
    {
        private ButtonHref[] _buttonNames;

        private int _currentCount = 0;

        protected override async Task OnInitializedAsync()
        {
            _buttonNames = await Http.GetFromJsonAsync<ButtonHref[]>("sample-data/buttons.json");
        }

        private void IncrementCount()
        {
            _currentCount++;
        }

        private void DecrementCount()
        {
            _currentCount--;
        }

        private void ResetCount()
        {
            _currentCount = 0;
        }
        private void MaxCount()
        {
            _currentCount = int.MaxValue;
        }

        public class ButtonHref()
        {
            public string? Name { get; set; }

            public string? Path { get; set; }
        }
    }
}