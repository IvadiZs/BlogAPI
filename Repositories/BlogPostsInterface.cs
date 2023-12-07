using _231130API.Modells.DTOs;
using _231130API.Modells;

namespace _231130API.Repositories {
    public interface IBlogPostsInterface {

        Task<IEnumerable<BlogPosts>> Get();

        Task<BlogPosts> GetById(Guid id);

        Task<BlogPosts> Post(CreatedBlogPostsDTO createDTO);

        Task<BlogPosts> Put(Guid id, UpdateBlogPostsDTO updateDTO);

        Task<BlogPosts> DeleteById(Guid id);

        Task<IEnumerable<BlogPosts>> GetUserPosts(Guid id);
    }
}
