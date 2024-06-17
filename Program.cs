using System;
using Blog.Data;

namespace Blog;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Vamos estudar Entity Framework!");
        
        using(var context  = new BlogDataContext()){
            
        }
    }
}
