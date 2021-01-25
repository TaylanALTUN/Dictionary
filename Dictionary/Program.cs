using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Value1");
            myDictionary.Add(2, "Value2");
            myDictionary.Add(3, "Value3");
            myDictionary.Add(4, "Value4");
            myDictionary.Add(5, "Value5");

            ListMyDictionary(myDictionary);
        }

        static void ListMyDictionary(MyDictionary<int, string> myDictionary)
        {
            for (int i = 0; i < myDictionary.Count; i++)
            {
                Console.WriteLine("( " + myDictionary.Key[i] + " , " + myDictionary.Value[i] + " )");
            }
        }
    }
}
