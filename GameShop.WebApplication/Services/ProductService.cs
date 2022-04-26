using GameShop.WebApplication.Services.Dtos;

namespace GameShop.WebApplication.Services
{
    public class ProductService : IProductService
    {
        public async Task<IEnumerable<ProductCategoryDto>> GetCategoriesAsync()
        {
            return await Task.FromResult(new List<ProductCategoryDto>
            {
                new ProductCategoryDto { Id = Guid.Parse("3ca65788-e027-41d9-8f19-7a57b81007dd"), Name = "เครื่องเล่นเกมส์" },
                new ProductCategoryDto { Id = Guid.Parse("06a6975b-2e91-4ff9-89a7-ccbbcf6ff4a0"), Name = "แผ่นเกมส์" },
                new ProductCategoryDto { Id = Guid.Parse("3147da2b-84d6-46ad-abae-399a1a883064"), Name = "อุปกรณ์เสริม" },
                new ProductCategoryDto { Id = Guid.Parse("03a27f8b-9849-4c88-bf6d-5597842836cc"), Name = "อื่นๆ" }
            });
        }

        public async Task<IEnumerable<ProductGroupDto>> GetGroupsAsync(Guid categoryId)
        {
            var groupsItem = new List<ProductGroupDto>
            {
                new ProductGroupDto { CategoryId = Guid.Parse("3ca65788-e027-41d9-8f19-7a57b81007dd"), Id = Guid.Parse("e9c95f41-b223-46dc-b573-7b32422c4a3f"), Name = "Playstation" },
                new ProductGroupDto { CategoryId = Guid.Parse("3ca65788-e027-41d9-8f19-7a57b81007dd"), Id = Guid.Parse("fb07e941-6711-49da-a7d2-248e0981636c"), Name = "Nintendo" },
                new ProductGroupDto { CategoryId = Guid.Parse("3ca65788-e027-41d9-8f19-7a57b81007dd"), Id = Guid.Parse("b3f11d8f-54db-48c1-b119-1abe340fa7ef"), Name = "Xbox" },
                new ProductGroupDto { CategoryId = Guid.Parse("06a6975b-2e91-4ff9-89a7-ccbbcf6ff4a0"), Id = Guid.Parse("dc34260d-bb93-4d37-9310-566149b0ad48"), Name = "Rpg" },
                new ProductGroupDto { CategoryId = Guid.Parse("06a6975b-2e91-4ff9-89a7-ccbbcf6ff4a0"), Id = Guid.Parse("24fdb0fa-d989-4c70-ab94-c1c854e63849"), Name = "Racing" },
                new ProductGroupDto { CategoryId = Guid.Parse("06a6975b-2e91-4ff9-89a7-ccbbcf6ff4a0"), Id = Guid.Parse("4b9846c0-7d64-4661-aaee-52bdd9d07708"), Name = "Action" },
                new ProductGroupDto { CategoryId = Guid.Parse("06a6975b-2e91-4ff9-89a7-ccbbcf6ff4a0"), Id = Guid.Parse("cb09d446-49d3-4946-a355-303569a8860f"), Name = "FPS" },
                new ProductGroupDto { CategoryId = Guid.Parse("06a6975b-2e91-4ff9-89a7-ccbbcf6ff4a0"), Id = Guid.Parse("817acf68-203c-4665-9790-3b8537d898f2"), Name = "Adventure" },
                new ProductGroupDto { CategoryId = Guid.Parse("06a6975b-2e91-4ff9-89a7-ccbbcf6ff4a0"), Id = Guid.Parse("57ce675d-b238-4e2d-9737-9bf6675da3c3"), Name = "Simulation" },
                new ProductGroupDto { CategoryId = Guid.Parse("3147da2b-84d6-46ad-abae-399a1a883064"), Id = Guid.Parse("0f0e45f2-3afc-477f-879d-6e71945f9c57"), Name = "Controller" },
                new ProductGroupDto { CategoryId = Guid.Parse("3147da2b-84d6-46ad-abae-399a1a883064"), Id = Guid.Parse("7ced976c-2fc9-490f-9593-723b84afc3bc"), Name = "Charger" },
                new ProductGroupDto { CategoryId = Guid.Parse("03a27f8b-9849-4c88-bf6d-5597842836cc"), Id = Guid.Parse("845f997d-8c02-47ff-8a4a-abcb78c72196"), Name = "Xbox Game Pass" },
                new ProductGroupDto { CategoryId = Guid.Parse("03a27f8b-9849-4c88-bf6d-5597842836cc"), Id = Guid.Parse("241527f3-bec1-4c67-8860-0113e656a5ed"), Name = "PSN Subscription" },
                new ProductGroupDto { CategoryId = Guid.Parse("03a27f8b-9849-4c88-bf6d-5597842836cc"), Id = Guid.Parse("44cee415-e6dc-4e30-958f-f9108b64b695"), Name = "Nintendo Subscription" }
            };

            return await Task.FromResult(groupsItem.Where(p => p.CategoryId == categoryId));
        }
    }
}
