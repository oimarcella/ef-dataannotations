using System;
using Blog.Models;
using Blog.Data;

namespace Blog;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vamos estudar Entity Framework!");
        
        using(var context  = new BlogDataContext()){
            var tag = new Tag {Name="Entity Framework", Slug="entity-framework"};
            context.Tags.Add(tag);
            context.SaveChanges();
        }
    }
}
