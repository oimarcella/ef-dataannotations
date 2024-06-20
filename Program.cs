using System;
using Blog.Models;
using Blog.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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

        
        //context.Posts.AsNoTracking().OrderByDescending(x => x.LastUpdateDate).ToList().ForEach(x => Console.WriteLine(x.Title));
        var postFound = context.Posts.Include(x => x.Author).FirstOrDefault();
        if(postFound != null)
        {
            postFound.Author.Name = "Marcella 2";
            context.SaveChanges();
        }
    }
}
