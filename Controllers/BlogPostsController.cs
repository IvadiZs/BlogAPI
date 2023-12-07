using _231130API.Modells.DTOs;
using _231130API.Modells;
using _231130API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _231130API.Controllers {
    [Route("api/[controller]")]
    [ApiController]

    public class BlogPostsController : ControllerBase {

        private readonly IBlogPostsInterface blogPostsInterface;

        public BlogPostsController(IBlogPostsInterface blogPostsInterface) {
            this.blogPostsInterface = blogPostsInterface;
        }

        [HttpPost]
        public async Task<ActionResult<BlogPosts>> Post(CreatedBlogPostsDTO createDTO) {

            return StatusCode(201, await blogPostsInterface.Post(createDTO));
        }

        [HttpGet]
        public async Task<IEnumerable<BlogPosts>> Get() {

            return await blogPostsInterface.Get();
        }

        [HttpGet("{id}")]
        public async Task<BlogPosts> Get(Guid id) {

            return await blogPostsInterface.GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<BlogPosts> Put(Guid id, UpdateBlogPostsDTO updateDTO) {

            return await blogPostsInterface.Put(id, updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<BlogPosts> Delete(Guid id) {
            return await blogPostsInterface.DeleteById(id);
        }

        [HttpGet("/byUser/{id}")]
        public async Task<IEnumerable<BlogPosts>> GetUserPosts(Guid id) {
            return await blogPostsInterface.GetUserPosts(id);
        }
    }
}
