using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using LomasFormApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LomasFormApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PersonController : ControllerBase
  {
    private readonly IMongoService _mongoService;

    public PersonController(IMongoService mongoService)
    {
      _mongoService = mongoService;
    }
    [HttpPost]
    public Task<ActionResult<PersonResponse>> Post() => Task.FromResult<ActionResult<PersonResponse>>(Ok(new PersonResponse()));
  }
}
