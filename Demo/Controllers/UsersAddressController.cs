using System.Collections.Generic;
using Demo.Model;
using Demo.Model.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Demo.Controllers
{
	[Route("api/[controller]")]
	public class UsersAddressController : Controller
	{
		private IDataRepository<UserAddress, long> repo;

		public UsersAddressController(IDataRepository<UserAddress,long> repo)
		{
			this.repo = repo;
		}

		// GET: api/<controller>
		[HttpGet]
		public IEnumerable<UserAddress> Get()
		{
			return this.repo.GetAll();
		}

		// GET api/<controller>/5
		[HttpGet("{id}")]
		public UserAddress Get(long id)
		{
			return this.repo.Get(id);
		}

		// POST api/<controller>
		[HttpPost]
		public void Post([FromBody]UserAddress value)
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
