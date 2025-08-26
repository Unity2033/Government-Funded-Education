namespace Grammar
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

            #region 매개 변수 한정자
            // 함수의 매개 변수 앞에 해당하는 인자의 전달 방식을
            // 지정하는 키워드입니다.

            Utility utility = new Utility() ;
            
            float length;
            
            int next = 10;
            int previous = 0;
            
            int distance = -4;
            
            Vector2 direction = new Vector2(1, 2);
            
            utility.Pause();
            
            utility.Swap(ref next, ref previous);
            
            utility.Magnitude(direction, out length);
            
            Console.WriteLine("next 변수의 값 : " + next);
            Console.WriteLine("previous 변수의 값 : " + previous);
            
            Console.WriteLine("length 변수의 값 : " + length);
            
            Console.WriteLine("Absolute의 값 : " + utility.Absolute(in distance));
            #endregion
        }
    }
}
