using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace Visitor.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class helloController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> GetVisitorName(string visitor_name)
		{
			var client_ip = "127.0.0.1";
			var location = "New York";
			var greeting = $"Hello, {visitor_name}!, the temperature is 11 degrees Celcius in New York";
			return Ok(new {
				client_ip = client_ip,
				location = location,
				greeting = greeting

			});
		}
	}
}
