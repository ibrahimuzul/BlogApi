using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : Controller
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Blog>> Get()
        {
            return BlogStaticTest.GetBlogs() ;
        }

        // GET api/values/5ghjli

        [HttpGet("{id}")]
        public ActionResult<Blog> Get(long id)
        {
            return BlogStaticTest.GetBlog(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Blog blog)
        {
            BlogStaticTest.AddBlog(blog);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            BlogStaticTest.DeleteBlog(id);
        }
    }
}