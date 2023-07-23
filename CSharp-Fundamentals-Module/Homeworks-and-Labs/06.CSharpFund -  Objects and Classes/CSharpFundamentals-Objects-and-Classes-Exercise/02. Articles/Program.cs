namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string title = arguments[0];
            string content = arguments[1];
            string author = arguments[2];

            Article article = new Article(title, content, author);

            int numberOfCommands = int
                .Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console
                    .ReadLine()
                    .Split(": ");

                switch (commands[0])
                {
                    case "Edit":
                        string editContent = commands[1];
                        article.EditContent(editContent);
                        break;
                    case "ChangeAuthor":
                        string editAuthor = commands[1];
                        article.ChangeAuthor(editAuthor);
                        break;
                    case "Rename":
                        string renameTitle = commands[1];
                        article.RenameTitle(renameTitle);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
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

        public void EditContent(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string changeAuthor)
        {
            this.Author = changeAuthor;
        }

        public void RenameTitle(string renameTitle)
        {
            this.Title = renameTitle;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}: {2}", this.Title, this.Content, this.Author);
        }
    }
}