using _231130API.Modells;
using _231130API.Modells.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace _231130API.Repositories {
    public class BlogUserService : IBlogUserInterface {

        private readonly BlogDBContext dbContext;
        public BlogUserService(BlogDBContext dbContext) {

            this.dbContext = dbContext;
        }

        public async Task<BlogUser> DeleteById(Guid id) {

            var user = dbContext.BlogUsers.Where(x => x.Id == id).FirstOrDefault();

            dbContext.BlogUsers.Remove(user);
            await dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<IEnumerable<BlogUser>> Get() {

            return dbContext.BlogUsers.ToList();
        }

        public async Task<BlogUser> GetById(Guid id) {

            var user = dbContext.BlogUsers.Where(x => x.Id == id).FirstOrDefault();

            return user;
        }

        public async Task<BlogUser> Post(CreatedBlogUserDTO createDTO) {

            var user = new BlogUser {

                Id = Guid.NewGuid(),
                UserName = createDTO.UserName,
                UserEmail = createDTO.UserEmail,
                Password = createDTO.Password,
                CreatedTime = DateTime.UtcNow
            };

            await dbContext.BlogUsers.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return user;
        }

        public async Task<BlogUser> Put(Guid id, UpdateBlogUserDTO updateDTO) {

            var user = dbContext.BlogUsers.Where(x => x.Id == id).FirstOrDefault();

            user.UserName = updateDTO.UserName;
            user.UserEmail = updateDTO.UserEmail;
            user.Password = updateDTO.Password;

            await dbContext.SaveChangesAsync();

            return user;
        }
    }
}
