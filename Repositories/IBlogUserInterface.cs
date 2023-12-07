using _231130API.Modells;
using _231130API.Modells.DTOs;

namespace _231130API.Repositories {
    public interface IBlogUserInterface {

        Task<IEnumerable<BlogUser>> Get();

        Task<BlogUser> GetById(Guid id);

        Task<BlogUser> Post(CreatedBlogUserDTO createDTO);

        Task<BlogUser> Put(Guid id, UpdateBlogUserDTO updateDTO);

        Task<BlogUser> DeleteById(Guid id);
    }
}
