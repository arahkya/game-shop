using GameShop.WebApplication.Models.Porduct;
using GameShop.WebApplication.Services;
using GameShop.WebApplication.Services.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameShop.WebApplication.Controllers
{
    [Route("{Controller}")]
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [Route("groups/{categoryid}")]
        [HttpGet]
        public async Task<IEnumerable<ProductGroupDto>> GetGroups(string categoryId)
        {
            var groups = await this.productService.GetGroupsAsync(Guid.Parse(categoryId));

            return groups;
        }

        [Route("post")]
        [HttpGet]
        public async Task<IActionResult> Post()
        {
            var categoriesDto = await productService.GetCategoriesAsync();
            var model = new PostProductModel
            {
                Categories = categoriesDto.Select(p => new SelectListItem(p.Name, p.Id.ToString()))
            };

            return View(model);
        }

        [Route("post")]
        [HttpPost]
        public IActionResult Post(PostProductModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("PostSuccess");
        }

        [Route("post/success")]
        public IActionResult PostSuccess()
        {
            return View();
        }
    }
}
