using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public BasketController(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<CustomBasket>> GetBasketById(string id)
        {
            var basket = await _basketRepository.GetBasketAsync(id);

            return Ok(basket ?? new CustomBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomBasket>> UpdateBasket(CustomerBasketDto basket)
        {
            var customerBasket = _mapper.Map<CustomerBasketDto, CustomBasket>(basket);

            var updatedBasket = await _basketRepository.UpdateBasketAsync(customerBasket);

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