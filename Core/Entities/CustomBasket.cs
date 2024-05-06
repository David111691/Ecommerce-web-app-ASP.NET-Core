namespace Core.Entities
{
    public class CustomBasket
    {
        public CustomBasket()
        {
        }

        public CustomBasket(string id)
        {
            Id = id;
        }

        public string Id { get; set; } = "";
        public List<BasketItem> Items { get; set; } = new List<BasketItem>();
    }
}