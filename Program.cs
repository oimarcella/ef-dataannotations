using System;
using Blog.Models;
using Blog.Data;

namespace Blog;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vamos estudar Entity Framework!");
        
        using var context  = new BlogDataContext();
        
        var user = new User{
            Name = "Marcella Letícia A.S.A.",
            Slug = "marcellaleticia-asa",
            Email = "marcella@email.com.br",
            Bio = "Dev Fullstack",
            Image = "marcella-profile.jpg",
            PasswordHash = "1234abc"
        };

        var category = new Category { Name = "Backend", Slug = "backend"};

        var post = new Post { 
            Author = user,
            Category = category,
            Body = "<p>Teste</p>",
            Slug = "comecando-com-ef-core",
            Summary = "Vamos aprender sobre EF Core",
            Title = "Entity Framework Core o agiliza sua vida!",
            CreateDate = DateTime.Now,
            LastUpdateDate = DateTime.Now
        };

        //context.Posts.Add(post);
        context.SaveChanges();
    }
}
