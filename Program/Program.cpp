#include <iostream>

using namespace std;

int main()
{
#pragma region 퇴각 검색
    // 해를 찾아가는 도중에 지금 경로가 해가 될 것 같지 않으면,
    // 더 이상 깊이 들어가지 않고, 이전 단계로 다시 들어가는 알고리즘입니다.

    // 퇴각 검색의 유망성 판단
    // 해가 될 만한지 판단한 후에 유망하지 않다고 결정되면,
    // 그 노드의 이전 노드로 돌아가 다음 자식 노드로 이동합니다.

    // 해가 될 만한 기능이 있으면 유망하다. (Promising)
    // 유망하지 않은 노드에 가지 않는 것 (Pruning)

    // Simulation

#pragma endregion


    return 0;
}