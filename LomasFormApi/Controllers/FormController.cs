using Domain.Entities;
using LomasFormApi.Models.Request;
using LomasFormApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace LomasFormApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormController : ControllerBase
    {
        private readonly IMongoService _mongoService;

        public FormController(IMongoService mongoService)
        {
            _mongoService = mongoService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(FormRequest request)
        {

            var collection = _mongoService.GetCollection<Form>("Form");
            var form = new Form
            {
                CreatedAt = DateTime.Now,
                CreatedBy = request.UserId.ToString(),
                Description = request.Description,
                FormType = 1,
                LastUpdateBy = "pablo",
                Name = request.Name,
                Stared = true,
                UpdatedAt = DateTime.Now
            };
            await collection.InsertOneAsync(form);
            return Ok(form.Id);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var collection = _mongoService.GetCollection<Form>("Form");
            var test = await collection.Find(x => true).ToListAsync();
            return Ok(test);
        }
        [HttpGet("id")]
        public async Task<IActionResult> Get(string id)
        {
            var collection = _mongoService.GetCollection<Form>("Form");
            var test = await collection.FindAsync(x => x.Id == id);
            return Ok(await test.FirstOrDefaultAsync());
        }
    }
}
