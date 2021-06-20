using System;
using System.Collections.Generic;

namespace projectTSPP
{
    public class Number
    {
        private List<Article> articles;
        private Maket mak;
        private bool needToEdit;
        private bool isUpdate = false;

        public Number()
        {
            articles = new List<Article>();
            mak = new Maket();
            needToEdit = false;
        }

        public void AddArticleToList(Article var)
        {
            articles.Add(var);
        }

        public void RemoveArticleFromList(int indx)
        {
            articles.RemoveAt(indx);
        }

        public void PrintListOfArticles()
        {
            if (articles.Count == 0)
            {
                Console.WriteLine(" Список статей пуст ");
                return;
            }

            Console.WriteLine(" ––––– Просмотр списка статей ––––– ");

            for (int i = 0; i < articles.Count; ++i)
            {
                Console.WriteLine("Artcle №" + i + ": " + articles[i].TextOfArticle);
            }
        }

        public Article GetArticle(int num)
        {
            return articles[num];
        }

        public Maket Mak
        {
            get { return mak; }
            set { mak = value; }
        }

        public List<Article> Articles
        {
            get { return articles; }
            set { articles = value; }
        }

        public bool NeedToEdit
        {
            get { return needToEdit; }
            set { needToEdit = value; }
        }
    }
}
