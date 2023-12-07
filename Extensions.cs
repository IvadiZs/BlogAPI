using _231130API.Modells;
using _231130API.Modells.DTOs;

namespace _231130API {
    public static class Extensions {
        public static BlogUserDTO AsDTO(this BlogUser blogUser) {
            return new(blogUser.Id, blogUser.UserName, blogUser.UserEmail, blogUser.Password, blogUser.CreatedTime);
        }
    }
}
