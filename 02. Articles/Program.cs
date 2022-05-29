using System;
using System.Collections.Generic;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var title = array[0];
            var content = array[1];
            var author = array[2];

            Article article = new Article(title, content, author);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);

                ToReplace(input, article);

            }
            var print = article.ToString();
            Console.WriteLine(print);

        }

        static void ToReplace(string[] input, Article article)
        {
            var command = input[0];
            var text = input[1];

            if (command == "Edit")
            {
                article.Edit(text);
            }
            else if (command == "ChangeAuthor")
            {
                article.ChangeAuthor(text);
            }
            else if (command == "Rename")
            {
                article.Rename(text);
            }
            //switch (command)
            //{
            //    case "Edit":
            //        article.Edit(text);
            //        break;
            //    case "ChangeAuthor":
            //        article.ChangeAuthor(text);
            //        break;
            //    case "Rename":
            //        article.Rename(text);
            //        break;


            //}
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; private set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
