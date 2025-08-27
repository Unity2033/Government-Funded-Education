using System.Reflection;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 추상 클래스
            // 클래스를 생성할 수는 없지만, 다른 클래스가 상속받아 구체적인 기능을 만들 수 
            // 있도록 설계되어 있는 클래스입니다.

            Terrain terrain = new Forest();

            Console.WriteLine("Width : " + terrain.Width);
            Console.WriteLine("Height : " + terrain.Height);

            terrain.Describe();

            terrain = new Desert();

            Console.WriteLine("Width : " + terrain.Width);
            Console.WriteLine("Height : " + terrain.Height);

            terrain.Describe();

            terrain = new Swamp();

            Console.WriteLine("Width : " + terrain.Width);
            Console.WriteLine("Height : " + terrain.Height);

            terrain.Describe();

            #endregion

        }
    }
}
