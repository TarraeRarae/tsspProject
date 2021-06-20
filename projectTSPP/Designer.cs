using System;
using System.Collections.Generic;
namespace projectTSPP
{
    public class Designer : PicsAndPhotoEditors
    {
        private List<int> pics;

        public List<int> Pics
        {
            get { return pics; }

            set { pics = value; }
        }

        public Designer()
        {
            pics = new List<int>();
        }

        override public void AddPhotosOrPics(int var)
        {
            pics.Add(var);
        }

        override public void RemovePhotosOrPics(int var)
        {
            pics.RemoveAt(var);
        }

        override public void PrintPhotosOrPics()
        {
            if (pics.Count == 0)
            {
                Console.WriteLine(" Список картинок пуст ");
                return;
            }

            for (int i = 0; i < pics.Count; ++i)
            {
                Console.WriteLine(" Картинка №" + i + ": " + pics[i]);
            }
        }
    }
}
