using System.Collections.Generic;
using Demo.Model;
using Demo.Model.Repository;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
	[Route("api/[controller]")]
	[EnableCors("AllowSpecificOrigin")]
	public class UsersController : Controller
	{
		private IDataRepository<Users, long> repo;

		public UsersController(IDataRepository<Users, long> repo)
		{
			this.repo = repo;
		}

		// GET: api/<controller>
		[HttpGet]
		public IEnumerable<Users> Get()
		{
			return repo.GetAll();
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		public Users Get(int id)
		{
			return repo.Get(id);
		}

		// POST api/<controller>
		[HttpPost]
		public void Post([FromBody]Users value)
		{
			this.repo.Add(value);
		}

		// PUT api/<controller>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/<controller>/5
		[HttpDelete("{id}")]
		public long Delete(long id)
		{
			return this.repo.Delete(id);
		}
	}
}
