namespace _231130API.Modells.DTOs {
    public record BlogUserDTO(Guid Id, string UserName, string UserEmail, string Password, DateTime CreatedTime);
    public record CreatedBlogUserDTO(string UserName, string UserEmail, string Password);
    public record UpdateBlogUserDTO(string UserName, string UserEmail, string Password);


    public record BlogPostsDTO(Guid Id, string PostName, string PostContent, DateTime CreatedTime, Guid UserId);

    public record CreatedBlogPostsDTO(string PostName, string PostContent, Guid UserId);

    public record UpdateBlogPostsDTO(string PostName, string PostContent);
}
