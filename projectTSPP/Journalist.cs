using System;
namespace projectTSPP
{
    public class Journalist
    {
        private Article someArticle;


        public Article SomeArticle
        {
            get { return someArticle; }
            set { someArticle = value; }
        }

        public Journalist()
        {
            someArticle = new Article();
        }

        public void CreateArticle()
        {
            Console.WriteLine(" ––––– Создание статьи журналистом ––––– ");
            Console.WriteLine(" ––––– Введите текст статьи ––––– ");
            someArticle = new Article();
            someArticle.TextOfArticle = Console.ReadLine();
        }

        public void PrintArticle() {
            if (someArticle.TextOfArticle == "Empty text") {
                Console.WriteLine(" ––––– Статья не создана или не получена ––––– ");
                return;
            }
            Console.WriteLine(someArticle.TextOfArticle);
        }
    }
}
