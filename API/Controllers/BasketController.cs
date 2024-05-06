using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _basketRepository;

        public BasketController(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        [HttpGet]
        public async Task<ActionResult<CustomBasket>> GetBasketById(string id)
        {
            var basket = await _basketRepository.GetBasketAsync(id);

            return Ok(basket ?? new CustomBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomBasket>> UpdateBasket(CustomBasket basket)
        {
            var updatedBasket = await _basketRepository.UpdateBasketAsync(basket);

            return Ok(updatedBasket);
        }
        
        [HttpDelete]
        async Task<ActionResult> DeleteBasketAsync(string id)
        {
            var done = await _basketRepository.DeleteBasketAsync(id);
            if (done)
            {
                return Ok(); // Можете вернуть что-то еще в зависимости от логики вашего приложения
            }
            else
            {
                return NotFound(); // Вернуть 404 если не удалось найти корзину по указанному id
            }
        }
    }
}