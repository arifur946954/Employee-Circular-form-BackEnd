/*using EfCoreRelation.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EfCoreRelation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AppDBContext appDBContext;

        public ProductsController(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get(int catagoryId)
        {
         var products=await   appDBContext.products.Where(c => c.CatagoryId == catagoryId).ToListAsync();
            return products;
        }

        //post data in database
        *//*  [HttpPost]
          public async Task<ActionResult<List<Product>>> AddProduct(Product newProduct)
          {
              if (newProduct != null)
              {
                  appDBContext.products.Add(newProduct);
                  await appDBContext.SaveChangesAsync();
                  return await appDBContext.products.ToListAsync();

              }
              return BadRequest();
          }*//*

        //post data in database with chatgpt
        [HttpPost]
        public async Task<IActionResult> PostCategoryWithProducts( Catagory categoryWithProductsDto)
        {
            // Validate the incoming data
            if (categoryWithProductsDto == null || categoryWithProductsDto.products == null)
            {
                return BadRequest("Invalid input data.");
            }

            // Create a new category
            var category = new Catagory
            {
                Name = categoryWithProductsDto.Name,
                products = new List<Product>()  // Initialize the list to avoid null reference exception
            };

            // Add products to the category
            foreach (var productDto in categoryWithProductsDto.products)
            {
                var product = new Product
                {
                    Name = productDto.Name,
                    Price = productDto.Price
                };

                category.products.Add(product);
            }

            // Add the category to the database
            appDBContext.catagories.Add(category);

            // Save changes to the database
            await appDBContext.SaveChangesAsync();

            return Ok("Category with products created successfully.");
        }





    }
}
*/