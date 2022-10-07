using BlogSN.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.ModelsBlogSN;
using Models.ModelsIdentity;
using Models.ModelsIdentity.IdentityAuth;

namespace Identity.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser { Id = "88aec81d-b5b0-45f3-8721-8d41560b02f7",UserName = "Vanya", Email = "1@mail.ru", PasswordHash = "EtoHash" }
            );

            builder.Entity<Category>().HasData(
                new Category{ Id = 1, Name = "Спорт", Description = ""},
                new Category {Id = 2, Name = "Киберспорт", Description = ""},
                new Category {Id = 3, Name = "Кино и сериалы", Description = ""},
                new Category {Id =4, Name = "Шаурма и друзья", Description = ""},
                new Category {Id = 5, Name = "Техника", Description = ""},
                new Category {Id = 6, Name = "Музыка", Description = ""},
                new Category {Id =7, Name = "Арт", Description = ""},
                new Category {Id = 8, Name = "Культура", Description = ""},
                new Category{Id = 9, Name = "Игры", Description = ""}
                
                );

            builder.Entity<Post>().HasData(
                new Post { Id = 1, Title = "Спорт", Description = "Описание спорта", Content = "Про спорт и все такое", CategoryId = 1 , ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7" },
                new Post { Id = 2, Title = "Киберспорт", Description = "Описание киберспорта", Content = "Про киберспорт и все такое", CategoryId = 2, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7" },
                new Post { Id = 3, Title = "Киберспорт", Description = "Описание киберспорта", Content = "Про киберспорт и все такое", CategoryId = 2, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7" },
                new Post { Id = 4, Title = "Игры", Description = "Описание игры", Content = "Про игры и все такое", CategoryId = 9, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7" });

            builder.Entity<Comment>().HasData(
                new Comment { Id = 1, Content = "Норм тема", PostId = 1, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7", CreatedDate = DateTime.UtcNow },
                new Comment { Id = 2, Content = "Норм тема", PostId = 1, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7", CreatedDate = DateTime.UtcNow },
                new Comment { Id = 3, Content = "Норм тема", PostId = 2, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7", CreatedDate = DateTime.UtcNow },
                new Comment { Id = 4, Content = "Норм тема", PostId = 2, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7", CreatedDate = DateTime.UtcNow });

            builder.Entity<Rating>().HasData(
                new Rating { Id = "188aec81d-b5b0-45f3-8721-8d41560b02f7", LikeStatus = true, PostId = 1, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7" },
                new Rating { Id = "288aec81d-b5b0-45f3-8721-8d41560b02f7", LikeStatus = true, PostId = 1, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7" },
                new Rating { Id = "388aec81d-b5b0-45f3-8721-8d41560b02f7", LikeStatus = false, PostId = 2, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7" },
                new Rating { Id = "488aec81d-b5b0-45f3-8721-8d41560b02f7", LikeStatus = false, PostId = 2, ApplicationUserId = "88aec81d-b5b0-45f3-8721-8d41560b02f7" }
                );
        }
        
    }
}
