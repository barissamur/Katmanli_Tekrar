using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.DataProtection.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YazarCrudController : ControllerBase
    {
        private readonly IRepository<Yazar> _yazarRepo;

        public YazarCrudController(IRepository<Yazar> yazarRepo)
        {
            _yazarRepo = yazarRepo;
        }
        // GET: api/<YazarCrudController>
        [HttpGet]
        public async Task<List<Yazar>> Get()
        {
            return await _yazarRepo.ListAsync();
        }

        // GET api/<YazarCrudController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<YazarCrudController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<YazarCrudController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<YazarCrudController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
