using GameShop.WebApplication.Services.Dtos;

namespace GameShop.WebApplication.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductCategoryDto>> GetCategoriesAsync();
        Task<IEnumerable<ProductGroupDto>> GetGroupsAsync(Guid categoryId);
    }
}