namespace GameShop.WebApplication.Services.Dtos
{
    public class ProductGroupDto
    {
        public Guid CategoryId { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
