#include <iostream>
#include <vector>

using namespace std;

void backtrack(int n, int k, int start, vector<int>& current)
{
    // k개를 선택했으면 출력하고 반환
    if (current.size() == k)
    {
        for (int num : current)
        {
            cout << num << " ";
        }
        cout << endl;
        return;
    }

    // 가능한 수를 순차적으로 시도 (가지치기)
    for (int i = start; i <= n; i++)
    {
        // 이미 선택한 수보다 작은 수는 선택하지 않음 (가지치기)
        if (current.size() > 0 && i <= current.back())
        {
            continue;
        }

        current.push_back(i);          // 수를 선택
        backtrack(n, k, i + 1, current); // 재귀적으로 탐색
        current.pop_back();           // 백트래킹
    }
}

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

    int n, k;

    cout << "Please enter n : ";

    cin >> n;

    cout << endl;

    cout << "Please enter k : ";

    cin >> k;

    cout << endl;

    vector<int> current;

    backtrack(n, k, 1, current);  // 1부터 시작하여 백트래킹 실행

#pragma endregion

    return 0;
}