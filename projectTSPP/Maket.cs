using System;
using System.Collections.Generic;

namespace projectTSPP
{ 

    public class Maket
    {
        private List<int> photos;
        private List<int> pictures;

        public List<int> Photos
        {
            get { return photos; }
            set { photos = value; }
        }

        public List<int> Pictures
        {
            get { return pictures; }
            set { pictures = value; }
        }

        public Maket()
        {
            photos = new List<int>();
            pictures = new List<int>();
        }

        public void AddPhoto(int var) {
            photos.Add(var);
        }

        public void RemovePhoto(int indx)
        {
            photos.RemoveAt(indx);
        }

        public void AddPictures(int var)
        {
            pictures.Add(var);
        }

        public void RemovePicture(int indx)
        {
            pictures.RemoveAt(indx);
        }

        public void GetListOfPhotos()
        {
            Console.WriteLine(" ––––– Просмотр списка фотографий ––––– ");
            if (photos.Count == 0)
            {
                Console.WriteLine(" Список фотографий пуст ");
            }

            for (int i = 0; i < photos.Count; ++i) {
                Console.WriteLine(" Фото №" + i + ": "+ photos[i]);
            }
        }

        public void GetListOPics()
        {
            Console.WriteLine(" ––––– Просмотр списка картинок ––––– ");
            if (pictures.Count == 0)
            {
                Console.WriteLine(" Список фотографий пуст ");
            }

            for (int i = 0; i < pictures.Count; ++i)
            {
                Console.WriteLine(" Картинка №" + i + ": " + pictures[i]);
            }
        }
    }
}
