using System;
namespace projectTSPP
{
    public class Editor
    {
        private Number num;

        public Editor()
        {
            num = new Number();
        }

        public void AddNumToList(Numbers listOfNums)
        {
            listOfNums.ListOfNums.Add(num);
        }

        public void RemoveNumFromList(Numbers listOfNums, int var)
        {
            listOfNums.ListOfNums.RemoveAt(var);
        }
    }
}
