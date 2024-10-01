using breakfast.Models;
using Microsoft.Extensions.Logging;

namespace breakfast.Services.Breakfasts
{
    public class BreakfastService : IBreakfastService
    {
        private static readonly Dictionary<Guid, Breakfast> _breakfasts = new();
        private readonly ILogger<BreakfastService> _logger;

        public BreakfastService(ILogger<BreakfastService> logger)
        {
            _logger = logger;
        }

        public void CreateBreakfast(Breakfast breakfast)
        {
            // Log the addition of a breakfast item
            _logger.LogInformation($"Adding breakfast with ID: {breakfast.Id}");
            _breakfasts.Add(breakfast.Id, breakfast);
        }

        public void DeleteBreakfast(Guid id)
        {
            _breakfasts.Remove(id);
        }

        public Breakfast GetBreakfast(Guid id)
        {
            // Check if the breakfast exists before trying to access it
            if (_breakfasts.TryGetValue(id, out var breakfast))
            {
                _logger.LogInformation($"Retrieved breakfast with ID: {id}");
                return breakfast;
            }

            // Log a warning if the breakfast is not found
            _logger.LogWarning($"Breakfast with ID: {id} not found.");
            throw new KeyNotFoundException($"Breakfast with ID: {id} not found.");
        }

        public void UpsertBreakfast(Breakfast breakfast)
        {
            _breakfasts[breakfast.Id] = breakfast;
        }
    }
}
