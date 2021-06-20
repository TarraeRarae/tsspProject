using System;
using System.Collections.Generic;

namespace projectTSPP
{
    public class Numbers
    {
        private List<Number> listOfNums;
        private List<Number> listOfNumsToEdit;

        public Numbers()
        {
            listOfNums = new List<Number>();
            listOfNumsToEdit = new List<Number>();
        }

        public bool IsEmpty()
        {
            if (listOfNums.Count == 0)
            {
                return true;
            }
            return false;
        }

        public List<Number> ListOfNums
        {
            get { return listOfNums; }
            set { listOfNums = value; }
        }

        public List<Number> ListOfNumsToEdit
        {
            get { return listOfNumsToEdit; }
            set { listOfNumsToEdit = value; }
        }

        public Number GetNumber(int numOfNum)
        {
            Number temp = listOfNums[numOfNum];
            return temp;
        }

        public void PrintOfList() {
            if (listOfNums.Count == 0)
            {
                Console.WriteLine(" Список номеров пуст ");
                return;
            }

            for (int i = 0; i < listOfNums.Count; ++i)
            {
                Console.WriteLine(" ––––– Список номеров: –––––– ");
                Console.WriteLine(" Номер №" + i);
            }
        }

        public void PrintOfListNeedToEdit()
        {

        }

        public void removeNumFromList(int var) {
            if (listOfNums.Count == 0)
            {
                Console.WriteLine(" Список номеров пуст ");
                return;
            }
            listOfNums.RemoveAt(var);
        }
    }
}
