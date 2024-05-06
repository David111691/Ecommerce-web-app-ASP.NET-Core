using Core.Entities;

namespace Core.Interfaces
{
    public interface IBasketRepository
    {
        Task<CustomBasket> GetBasketAsync(string basketId);
        Task<CustomBasket> UpdateBasketAsync(CustomBasket basket);
        Task<bool> DeleteBasketAsync(string basketId);
    }
}