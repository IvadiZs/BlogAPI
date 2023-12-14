using _231130API.Modells.DTOs;
using _231130API.Modells;
using Microsoft.EntityFrameworkCore;

namespace _231130API.Repositories {
    public class BlogPostsService : IBlogPostsInterface {

        private readonly BlogDBContext dbContext;
        public BlogPostsService(BlogDBContext dbContext) {

            this.dbContext = dbContext;
        }

        public async Task<BlogPosts> DeleteById(Guid id) {

            var post = dbContext.BlogPosts.Where(x => x.Id == id).FirstOrDefault();

            dbContext.BlogPosts.Remove(post);
            await dbContext.SaveChangesAsync();

            return post;
        }

        public async Task<IEnumerable<BlogPosts>> Get() {

            return dbContext.BlogPosts.ToList();
        }

        public async Task<BlogPosts> GetById(Guid id) {

            var post = dbContext.BlogPosts.Where(x => x.Id == id).FirstOrDefault();

            return post;
        }

        public async Task<BlogPosts> Post(CreatedBlogPostsDTO createDTO) {

            var post = new BlogPosts {

                Id = Guid.NewGuid(),
                PostName = createDTO.PostName,
                PostContent = createDTO.PostContent,
                UserId = createDTO.UserId,
                CreatedTime = DateTime.UtcNow
            };

            await dbContext.BlogPosts.AddAsync(post);
            await dbContext.SaveChangesAsync();

            return post;
        }

        public async Task<BlogPosts> Put(Guid id, UpdateBlogPostsDTO updateDTO) {

            var post = dbContext.BlogPosts.Where(x => x.Id == id).FirstOrDefault();

            post.PostName = updateDTO.PostName;
            post.PostContent = updateDTO.PostContent;

            await dbContext.SaveChangesAsync();

            return post;
        }

        public async Task<IEnumerable<BlogPosts>> GetUserPosts(Guid id) {

            var postList = dbContext.BlogPosts.Where(x => x.UserId == id).ToList();

            return postList;
        }
    }
}
