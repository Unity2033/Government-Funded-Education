namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 박싱 
            // 값 형식의 데이터를 참조 형식으로 변환하는 과정입니다.

            // int value = 100;
            // 
            // object generic = value;
            // 
            // Console.WriteLine("value : " + value);
            // Console.WriteLine("generic : " + generic);
            #endregion

            #region 언박싱
            // 참조 형식의 데이터를 값 형식으로 변환하는 과정입니다.

            // int box = (int)generic;
            // 
            // Console.WriteLine("box : " + box);
            #endregion

            Utility utility = new Utility() ;

            utility.Pause();

            int next = 10;
            int previous = 0;

            int distance = -4;

            utility.Swap(ref next, ref previous);

            Console.WriteLine("next 변수의 값 : " + next);
            Console.WriteLine("previous 변수의 값 : " + previous);
            Console.WriteLine("Absolute의 값 : " + utility.Absolute(in distance));
        }
    }
}
