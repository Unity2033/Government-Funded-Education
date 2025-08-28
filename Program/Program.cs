using System.Reflection;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 단일 책임 원칙
            // 클래스의 구성 단위가 하나의 책임만 가질 수 있도록
            // 설계해야 되는 원칙입니다.

            // List<Quest> quests = new List<Quest>();
            // 
            // quests.Add(new Quest("잃어버린 검은 고양이", "마을의 소녀 리아가 사랑하는 검은 고양이 '루나'를 잃어버렸습니다.", new Reward(10, 500)));
            // quests.Add(new Quest("폐광 속의 속삭임", "광부들이 갑자기 폐광에서 들려오는 이상한 속삭임 때문에 일을 중단했습니다.", new Reward(50, 750)));
            // quests.Add(new Quest("수상한 약초 상인", "최근 마을에서 퍼진 병은 약초 상인 '겔론'이 판 약초와 관련이 있어 보입니다.", new Reward(100, 2500)));
            // 
            // for(int i = 0; i < quests.Count(); i++)
            // {
            //     quests[i].Describe();
            // }

            #endregion

            #region 개방 폐쇄 원칙
            // 소프트웨어의 구성 요소는 확장에는 열려 있어야 하고, 변경에는 닫혀 있어야 합니다.

            Enchant enchant = new Enchant();

            enchant.Enhance(new Item("Sword", 10, 5, 0));

            enchant.Enhance(new Item("Necklace", 1, 1, 10));

            enchant.Enhance(new Item("Shoes", 0, 20, 0));


            #endregion
        }
    }
}
