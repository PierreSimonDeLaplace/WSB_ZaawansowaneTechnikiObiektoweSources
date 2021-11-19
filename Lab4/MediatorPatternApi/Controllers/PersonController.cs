using System.Collections.Generic;
using System.Threading.Tasks;
using MediatorPatternLib.Commands;
using MediatorPatternLib.Models;
using MediatorPatternLib.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediatorPatternApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator _mediator) => mediator = _mediator;

        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModel>> Get() //a list
        {
            return await mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id) //get one item by id
        {
            return await mediator.Send(new GetPersonByIdQuery(id));
        }

        // POST api/<PersonController>
        [HttpPost] // insert
        //one liner, very simple controller
        public async Task<PersonModel> Post([FromBody] PersonModel value) =>  await mediator.Send(new InsertPersonCommand(value.FirstName, value.LastName));
    }
}
