using System.ComponentModel.DataAnnotations;


namespace API.Dtos
{
    public class BasketItemDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; } = "";

        [Required]
        [Range(0.1, Double.MaxValue, ErrorMessage = "Цена должна быть больше 0.")]
        public decimal Price { get; set; }

        [Range(1, Double.MaxValue, ErrorMessage = "Кол-во товара должно быть больше 0.")]
        [Required]
        public int Quantity { get; set; } = 0;


        public string PictureUrl { get; set; } = "";


        public string Brand { get; set; } = "";


        public string Type { get; set; } = "";
    }
}