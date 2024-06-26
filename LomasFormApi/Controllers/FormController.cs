﻿using Domain.Entities;
using LomasFormApi.Models.Request;
using LomasFormApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace LomasFormApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class FormController : ControllerBase
  {
    private readonly IMongoService _mongoService;
    private readonly IMongoCollection<Form> _collection;
    private readonly IMongoCollection<Form> _collectionTemplates;

    public FormController(IMongoService mongoService)
    {
      _mongoService = mongoService;
      _collection = _mongoService.GetCollection<Form>("Form");
      _collectionTemplates = _mongoService.GetCollection<Form>("FormTemplates");
    }

    [HttpPost]
    public async Task<IActionResult> Post(FormRequest request)
    {
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
      await _collection.InsertOneAsync(form);
      return Ok(form.Id);
    }
    [HttpPost("idTemplate")]
    public async Task<IActionResult> CreateByTemplate(FormRequest request, string idTemplate)
    {
      var template = await _collectionTemplates.FindAsync(x => x.Id == idTemplate);
      var formTemplate = await template.FirstOrDefaultAsync();
      formTemplate.CreatedAt = DateTime.Now;
      formTemplate.CreatedBy = request.UserId.ToString();
      formTemplate.LastUpdateBy = "admin";
      formTemplate.Stared = true;
      formTemplate.UpdatedAt = DateTime.Now;
      formTemplate.Id = ObjectId.GenerateNewId().ToString();
      await _collection.InsertOneAsync(formTemplate);
      return Ok(formTemplate.Id);
    }
    [HttpPut]
    public async Task<IActionResult> Put(Form form)
    {
      var filter = Builders<Form>.Filter.Eq(s => s.Id, form.Id);
      var update = Builders<Form>.Update.Set(c => c.UpdatedAt, DateTime.Now);
      var newValue = await _collection.FindOneAndReplaceAsync(filter, form);
      return Ok(newValue);
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      var test = await _collection.Find(x => true).ToListAsync();
      return Ok(test);
    }
    [HttpGet("id")]
    public async Task<IActionResult> Get(string id)
    {
      var test = await _collection.FindAsync(x => x.Id == id);
      return Ok(await test.FirstOrDefaultAsync());
    }
  }
}
