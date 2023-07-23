using System.Net;

namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int numberOfArticles = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] arguments = Console
                    .ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = arguments[0];
                string content = arguments[1];
                string author = arguments[2];

                Article article = new Article(title, content, author);

                articles.Add(article);
            }

            PrintResult(articles);
        }

        static void PrintResult(List<Article> articles)
        {
            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1}: {2}", this.Title, this.Content, this.Author);
        }
    }
}