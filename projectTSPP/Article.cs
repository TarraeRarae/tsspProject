using System;
namespace projectTSPP
{
    public class Article
    {
        private string textOfArticle;

        public string TextOfArticle
        {
            get { return this.textOfArticle; }
            set { this.textOfArticle = value; }

        }

        public Article()
        {
            textOfArticle = "Empty text";
        }
    }
}
