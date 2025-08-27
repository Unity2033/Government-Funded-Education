namespace Collection
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

            // Dictionary<string, int> dictionary = new Dictionary<string, int>();
            // 
            // int money = 0;
            // 
            // dictionary.Add("Doran’s Blade",450);
            // dictionary.Add("B.F. Sword", 1300);
            // dictionary.Add("Randuin’s Omen", 2700);
            // 
            // foreach(var element in dictionary)
            // {
            //     Console.WriteLine("KEY : " + $"{element.Key}");
            //     Console.WriteLine("VALUE : " + $"{element.Value}");
            // }
            // 
            // string key = "Doran’s Blade";
            // 
            // if (dictionary.TryGetValue(key, out money))
            // {
            //     money = dictionary[key];
            // }
            // else
            // {
            //     dictionary.Add(key, 3000);
            // }
            // 
            // Console.WriteLine("Money : " + money);

            #endregion

            #region Stack

            //  Stack<int> stack = new Stack<int>();
            //  
            //  stack.Push(10);
            //  stack.Push(20);
            //  stack.Push(30);
            //  stack.Push(40);
            //  stack.Push(50);
            //  
            //  while (stack.Count > 0) 
            //  {
            //      Console.WriteLine(stack.Pop());  
            //  }

            #endregion

            #region Queue

            // Queue<int> queue = new Queue<int>();
            // 
            // queue.Enqueue(10);
            // queue.Enqueue(20);
            // queue.Enqueue(30);
            // queue.Enqueue(40);
            // queue.Enqueue(50);
            // 
            // while (queue.Count > 0)
            // {
            //     Console.WriteLine(queue.Dequeue());
            // }

            #endregion

            #region Linked List

            // LinkedList<int> linkedList = new LinkedList<int>();
            // 
            // linkedList.AddFirst(10);
            // linkedList.AddFirst(5);
            // linkedList.AddFirst(1);
            // 
            // linkedList.AddLast(20);
            // 
            // foreach (int element in linkedList)
            // {
            //     Console.WriteLine(element); 
            // }

            #endregion

            #endregion
        }
    }
}
