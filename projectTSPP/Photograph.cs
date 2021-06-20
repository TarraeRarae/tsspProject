using System;
using System.Collections.Generic;
namespace projectTSPP
{
    public class Photograph : PicsAndPhotoEditors
    {
        private List<int> photos;

        public List<int> Photos
        {
            get { return photos; }

            set { photos = value; }
        }

        public Photograph()
        {
            photos = new List<int>();
        }

        override public void AddPhotosOrPics(int var)
        {
            photos.Add(var);
        }

        override public void RemovePhotosOrPics(int var)
        {
            photos.RemoveAt(var);
        }

        override public void PrintPhotosOrPics()
        {
            if (photos.Count == 0)
            {
                Console.WriteLine(" Список картинок пуст ");
                return;
            }

            for (int i = 0; i < photos.Count; ++i)
            {
                Console.WriteLine(" Картинка №" + i + ": " + photos[i]);
            }
        }
    }
}
