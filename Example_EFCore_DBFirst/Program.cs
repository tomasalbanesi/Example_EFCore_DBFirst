using Console_EFCore_DBFirst.Models;
using System;
using System.Linq;

namespace Example_EFCore_DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DB_EFCore_TestContext())
            {
                Console.WriteLine("Elementos antes de realizar el INSERT");
                foreach (var post in context.Posts.ToList())
                {
                    Console.WriteLine(post.Title);
                }

                var p = new Post();
                p.Title = "Las universidades volveran a la presencialidad";
                p.Body = "Por lo que se esta hablando, en 2022 las universidades retomaran el ciclo de forma presencial";
                context.Posts.Add(p); // es un INSERT INTO
                context.SaveChanges(); // Guardar los cambios en la base de datos

                Console.WriteLine("Elementos luego de realizar el INSERT");
                foreach (var post in context.Posts.ToList())
                {
                    Console.WriteLine(post.Title);
                }
            }
        }
    }
}
