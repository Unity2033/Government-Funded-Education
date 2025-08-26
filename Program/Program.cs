using System.Reflection;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 컬렉션

            #region List

            // List<int> list = new List<int>();
            // 
            // list.Capacity = 10;
            // 
            // list.Add(10); // 10       [0]
            // list.Add(20); // 10 20    [0] [1]
            // list.Add(30); // 10 20 30 [0] [1] [2]
            // list.Add(40); // 30
            // list.Add(50); // 30
            // 
            // list.Remove(40);
            // 
            // list.Insert(3, 75);// 10 20 30 75 [0] [1] [2] [3]
            // 
            // foreach (int element in list)
            // {
            //     Console.WriteLine(element);
            // }

            #endregion

            #region Dictionary

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            int money = 0;

            dictionary.Add("Doran’s Blade",450);
            dictionary.Add("B.F. Sword", 1300);
            dictionary.Add("Randuin’s Omen", 2700);

            foreach(var element in dictionary)
            {
                Console.WriteLine("KEY : " + $"{element.Key}");
                Console.WriteLine("VALUE : " + $"{element.Value}");
            }

            string key = "Doran’s Blade";

            if (dictionary.TryGetValue(key, out money))
            {
                money = dictionary[key];
            }
            else
            {
                dictionary.Add(key, 3000);
            }

            Console.WriteLine("Money : " + money);

            #endregion

            #endregion

        }
    }
}
