using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Scaledriven.Database;
using Scaledriven.Models;
using Scaledriven.Services;

namespace Scaledriven.Api
{

    [Route("api/[controller]")]
    [ServiceFilter(typeof(SaveChangesResultFilter))]
    public class PostController : ControllerBase
    {
        private readonly DbSet<Post> _posts;

        public PostController(ApplicationDbContext dbContext)
        {
            _posts = dbContext.Set<Post>();
        }

        /// <summary>
        /// get an index of post
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Post>), 200)]
        public IActionResult Index() => Ok(_posts);


        /// <summary>
        /// Send post data to the serve and back
        /// </summary>
        /// <param name="post"></param>
        [HttpPost("Make")]
        public IActionResult Make(Post post)
        {
            Post postModel = new Post
            {
                Content = post.Content
            };

            return Ok(postModel);
        }


        /// <summary>
        /// Create a post belonging to a user
        /// </summary>
        /// <param name="content"></param>
        [HttpPost]
        public IActionResult Create([FromBody] string content)
        {

            Post post = new Post
            {
                Content = content
            };

            _posts.Add(post);

            return Ok(post);
        }


        [HttpDelete("{id:int}")]
        public IActionResult Delete([FromRoute] string Id)
        {
            Post postModel = _posts.Find(new {Id});

            if (postModel == null)
            {
                return BadRequest();
            }

            return Ok();

        }


        [HttpGet("{id:int}")]
        public IActionResult Show([FromRoute] string Id)
        {
            Post postModel = _posts.Find(new {Id});

            if (postModel == null)
            {
                return NotFound();
            }

            return Ok(postModel);
        }

    }
}
