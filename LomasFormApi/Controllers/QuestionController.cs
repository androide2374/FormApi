using Domain.Entities;
using LomasFormApi.Models.Request;
using LomasFormApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using static Domain.Enumerados.Enums;

namespace LomasFormApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IMongoService _mongoService;

        public QuestionController(IMongoService mongoService)
        {
            _mongoService = mongoService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(QuestionRequestForm request)
        {

            var collection = _mongoService.GetCollection<Form>("Form");

            var questions = new List<Question>();
            foreach (var question in request.Questions)
            {
                var quest = new Question();
                quest = new Question
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    CreatedAt = DateTime.Now,
                    QuestionImage = question.QuestionText,
                    QuestionText = question.QuestionText,
                    QuestionType = question.QuestionType,
                    UpdateAt = DateTime.Now
                };
                quest.Options = new List<Option>();
                foreach (var item in question.Options)
                {
                    quest.Options.Add(new Option { OptionImage = item.OptionImage, OptionText = item.OptionText, Id = ObjectId.GenerateNewId().ToString() });
                }
                questions.Add(quest);
            }

            var update = Builders<Form>.Update.Set(c => c.Questions, questions);
            var value = await collection.FindOneAndUpdateAsync(p => p.Id == request.FormId, update);
            return Ok(value);
        }
        [HttpGet]
        public async Task<IActionResult> Get(string formId)
        {
            var collection = _mongoService.GetCollection<Form>("Form");
            return Ok(await collection.Find(x => x.Id == formId).ToListAsync());
        }
    }
}
