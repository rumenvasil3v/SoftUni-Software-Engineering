/*
SoftUni Article
Some content of the SoftUni article
some comment
more comment
last comment
end of comments
 */

namespace _05._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string contentOfArticle = Console.ReadLine();

            string title = $@"<h1>
    {articleTitle}
</h1>";

            Console.WriteLine(title);

            string content = $@"<article>
    {contentOfArticle}
</article>";

            Console.WriteLine(content);

            string input;
            while ((input = Console.ReadLine()) != "end of comments")
            {
                string currentComment = $@"<div>
    {input}
</div>";

                Console.WriteLine(currentComment);
            }
        }
    }
}