using _231130API.Modells;
using _231130API.Modells.DTOs;
using _231130API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace _231130API.Controllers {
    [Route("api/[controller]")]
    [ApiController]

    public class BlogUserController : ControllerBase {

        private readonly IBlogUserInterface blogUserInterface;

        public BlogUserController(IBlogUserInterface blogUserInterface) {
            this.blogUserInterface = blogUserInterface;
        }

        [HttpPost]
        public async Task<ActionResult<BlogUser>> Post(CreatedBlogUserDTO createDTO) {

            return StatusCode(201, await blogUserInterface.Post(createDTO));
        }

        [HttpGet]
        public async Task<IEnumerable<BlogUser>> Get() {

            return await blogUserInterface.Get();
        }

        [HttpGet("{id}")]
        public async Task<BlogUser> Get(Guid id) {

            return await blogUserInterface.GetById(id);
        }

        [HttpPut("{id}")]
        public async Task<BlogUser> Put(Guid id, UpdateBlogUserDTO updateDTO) {

            return await blogUserInterface.Put(id, updateDTO);
        }

        [HttpDelete("{id}")]
        public async Task<BlogUser> Delete(Guid id) {
            return await blogUserInterface.DeleteById(id);
        }
    }
}
