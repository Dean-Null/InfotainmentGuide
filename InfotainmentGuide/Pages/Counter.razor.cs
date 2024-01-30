namespace InfotainmentGuide.Pages
{
    public partial class Counter
    {
        private int _currentCount = 0;

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
    }
}