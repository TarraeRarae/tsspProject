using System;
using System.ComponentModel.Design;

namespace projectTSPP
{
    class MainClass
    {
         
        private static bool checker = false;
        
        public static void CheckerToFalse() {
            checker = false;
        }

        public static Numbers JournalistMotion(Numbers numbers) {

            Journalist journalist = new Journalist();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ––––– Функции журналиста ––––– ");
                Console.WriteLine(" 1 – Создать статью ");
                Console.WriteLine(" 2 – Просмотреть статью (созданную или полученную из списка) ");
                Console.WriteLine(" 3 – Просмотреть список номеров ");
                Console.WriteLine(" 4 – Просмотреть список статей номера ");
                Console.WriteLine(" 5 – Добавить статью в номер ");
                Console.WriteLine(" 6 – Удалить статью из номера ");
                Console.WriteLine(" 7 – Выход ");
                Console.WriteLine();

                int inputKey = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                int numOfNum;
                switch (inputKey)
                {
                    case 1:
                        journalist.CreateArticle();
                        break;
                    case 2:
                        journalist.PrintArticle();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        numbers.PrintOfList();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine(" Введите порядковый номер номера ");
                        numOfNum = Convert.ToInt32(Console.ReadLine());
                        numbers.GetNumber(numOfNum).PrintListOfArticles();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(" Введите порядковый номер номера, к которому нужно добавить статью ");
                        numOfNum = Convert.ToInt32(Console.ReadLine());
                        numbers.GetNumber(numOfNum).AddArticleToList(journalist.SomeArticle);
                        Console.Clear();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(" Введите порядковый номер номера для выбора статьи для удаления ");
                        numOfNum = Convert.ToInt32(Console.ReadLine());
                        numbers.GetNumber(numOfNum).PrintListOfArticles();
                        Console.WriteLine(" Введите номер статьи для удаления ");
                        int numofArt = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        numbers.GetNumber(numOfNum).RemoveArticleFromList(numofArt);
                        Console.WriteLine(" Статья удалена из списка ");
                        Console.ReadKey();
                        break;
                    case 7:
                        return numbers;
                    default:
                        Console.Clear();
                        Console.WriteLine(" Введен номер несуществующего пункта меню ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        public static Numbers EditorMotion(Numbers numbers)
        {
            Editor editor = new Editor();
            while (true)
            {
                Console.Clear();
                Console.WriteLine(" ––––– Функции редактора ––––– ");
                Console.WriteLine(" 1 – Создать номер и добавить его в список ");
                Console.WriteLine(" 2 – Просмотреть список номеров ");
                Console.WriteLine(" 3 – Удалить номер из списка ");
                Console.WriteLine(" 4 – Просмотреть статьи и макет номера ");
                Console.WriteLine(" 5 – Выход ");
                Console.WriteLine();

                int inputKey = Convert.ToInt32(Console.ReadLine());

                int num;
                switch (inputKey)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" ––––– Добавление номера в список номеров ––––– ");
                        editor.AddNumToList(numbers);
                        Console.WriteLine(" Номер добавлен в список");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(" ––––– Печать списка ––––– ");
                        numbers.PrintOfList();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        if (numbers.IsEmpty())
                        {
                            Console.WriteLine(" Список номеров пуст ");
                            break;
                        }
                        Console.WriteLine(" ––––– Удаление номера из списка ––––– ");
                        Console.WriteLine(" Введите порядковый номер номера для удаления ");
                        num = Convert.ToInt32(Console.ReadLine());
                        numbers.removeNumFromList(num);
                        Console.WriteLine(" Номер удален из списка ");
                        break;
                    case 4:
                        Console.Clear();
                        if (numbers.IsEmpty())
                        {
                            Console.WriteLine(" Список номеров пуст ");
                            break;
                        }
                        Console.WriteLine(" ––––– Просмотр статей и макета номера ––––– ");
                        Console.WriteLine(" Введите порядковый номер номера");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(" ––––– Просмотр номера " + num + " ––––– ");
                        numbers.GetNumber(num).PrintListOfArticles();
                        numbers.GetNumber(num).Mak.GetListOfPhotos();
                        numbers.GetNumber(num).Mak.GetListOPics();
                        Console.ReadKey();
                        break;
                    case 5:
                        return numbers;
                    default:
                        Console.Clear();
                        Console.WriteLine(" Введен номер несуществующего пункта меню");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static Numbers DesignerMotion(Numbers numbers)
        {
            Designer designer = new Designer();
            while (true)
            {
                Console.WriteLine(" ––––– Функции дизайнера ––––– ");
                Console.WriteLine(" 1 – Добавить картинку в список ");
                Console.WriteLine(" 2 – Просмотреть список картинок");
                Console.WriteLine(" 3 – Удалить картинку из списка");
                Console.WriteLine(" 4 – Просмотреть список номеров ");
                Console.WriteLine(" 5 – Просмотреть макет номера ");
                Console.WriteLine(" 6 – Получить список картинок из макета номера");
                Console.WriteLine(" 7 – Добавить картинки к макету номера ");
                Console.WriteLine(" 8 – Выход ");
                Console.WriteLine();

                int inputKey = Convert.ToInt32(Console.ReadLine());
                int num;
                switch (inputKey)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" ––––– Добавление картинки в макет ––––– ");
                        Console.WriteLine(" Введите номер картинки ");
                        num = Convert.ToInt32(Console.ReadLine()); 
                        designer.AddPhotosOrPics(num);
                        Console.WriteLine(" Картинка добавлена в макет ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        designer.PrintPhotosOrPics();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(" ––––– Удаление картинки из списка ––––– ");
                        Console.WriteLine(" Введите номер картинки для удаления ");
                        num = Convert.ToInt32(Console.ReadLine());
                        designer.RemovePhotosOrPics(num);
                        break;
                    case 4:
                        Console.Clear();
                        numbers.PrintOfList();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        if (numbers.IsEmpty())
                        {
                            Console.WriteLine(" Список номеров пуст ");
                            break;
                        }
                        Console.WriteLine(" Введите порядковый номер номера");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(" ––––– Просмотр номера " + num + " ––––– ");
                        numbers.GetNumber(num).Mak.GetListOfPhotos();
                        numbers.GetNumber(num).Mak.GetListOPics();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(" ––––– Получение списка картинок из макета номера ––––– ");
                        Console.WriteLine(" Введите порядковый номер номера ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        designer.Pics = numbers.GetNumber(num).Mak.Pictures;
                        Console.WriteLine(" Список кратинок получен ");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        if (numbers.IsEmpty())
                        {
                            Console.WriteLine(" Список номеров пуст ");
                            break;
                        }
                        Console.WriteLine(" Введите порядковый номер номера ");
                        num = Convert.ToInt32(Console.ReadLine());
                        numbers.GetNumber(num).Mak.Pictures = designer.Pics;
                        Console.WriteLine(" Картинки добавлены к номеру ");
                        Console.ReadKey();
                        break;
                    case 8:
                        return numbers;
                    default:
                        Console.Clear();
                        Console.WriteLine(" Введен номер несуществующего пункта меню ");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static Numbers PhotographMotion(Numbers numbers)
        {
            Photograph photograph = new Photograph();
            while (true)
            {
                Console.WriteLine(" ––––– Функции фотографа ––––– ");
                Console.WriteLine(" 1 – Добавить фотографию в список ");
                Console.WriteLine(" 2 – Просмотреть список фотографий");
                Console.WriteLine(" 3 – Удалить фотографию из списка");
                Console.WriteLine(" 4 – Просмотреть список номеров ");
                Console.WriteLine(" 5 – Просмотреть макет номера ");
                Console.WriteLine(" 6 – Получить список фотографий из макета номера");
                Console.WriteLine(" 7 – Добавить фотографии к макету номера ");
                Console.WriteLine(" 8 – Выход ");
                Console.WriteLine();

                int inputKey = Convert.ToInt32(Console.ReadLine());
                int num;
                switch (inputKey)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine(" ––––– Добавление фотографии в макет ––––– ");
                        Console.WriteLine(" Введите номер фотографии ");
                        num = Convert.ToInt32(Console.ReadLine());
                        photograph.AddPhotosOrPics(num);
                        Console.WriteLine(" Картинка добавлена в макет ");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        photograph.PrintPhotosOrPics();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine(" ––––– Удаление фотографии из списка ––––– ");
                        Console.WriteLine(" Введите номер фотографии для удаления ");
                        num = Convert.ToInt32(Console.ReadLine());
                        photograph.RemovePhotosOrPics(num);
                        break;
                    case 4:
                        Console.Clear();
                        numbers.PrintOfList();
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        if (numbers.IsEmpty())
                        {
                            Console.WriteLine(" Список номеров пуст ");
                            break;
                        }
                        Console.WriteLine(" Введите порядковый номер номера");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine(" ––––– Просмотр номера " + num + " ––––– ");
                        numbers.GetNumber(num).Mak.GetListOfPhotos();
                        numbers.GetNumber(num).Mak.GetListOPics();
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine(" ––––– Получение списка фотографий из макета номера ––––– ");
                        Console.WriteLine(" Введите порядковый номер номера ");
                        num = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        photograph.Photos = numbers.GetNumber(num).Mak.Photos;
                        Console.WriteLine(" Список кратинок получен ");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        if (numbers.IsEmpty())
                        {
                            Console.WriteLine(" Список номеров пуст ");
                            break;
                        }
                        Console.WriteLine(" Введите порядковый номер номера ");
                        num = Convert.ToInt32(Console.ReadLine());
                        numbers.GetNumber(num).Mak.Photos = photograph.Photos;
                        Console.WriteLine(" Картинки добавлены к номеру ");
                        Console.ReadKey();
                        break;
                    case 8:
                        return numbers;
                    default:
                        Console.Clear();
                        Console.WriteLine(" Введен номер несуществующего пункта меню ");
                        Console.ReadKey();
                        break;
                }
            }
        }


        public static void Main()
        {
            Numbers nums = new Numbers();
            while (!checker)
            {
                Console.Clear();

                Console.WriteLine(" ––––– Выберите роль ––––– ");
                Console.WriteLine(" 1 – Журналист ");
                Console.WriteLine(" 2 – Редактор ");
                Console.WriteLine(" 3 – Дизайнер ");
                Console.WriteLine(" 4 – Фотограф ");
                Console.WriteLine(" 5 – Выход ");
                Console.WriteLine();

                int inputkey = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (inputkey)
                {
                    case 1:
                         nums = JournalistMotion(nums);
                         break;
                    case 2:
                        nums = EditorMotion(nums);
                        break;
                    case 3:
                        nums = DesignerMotion(nums);
                        break;
                    case 4:
                        nums = PhotographMotion(nums);
                        break;
                    case 5:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine(" Введен номер несуществующего пункта меню ");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
