#include <iostream>
#include <vector>

using namespace std;

void Combination(int start, int n, int r, vector<int> & vector)
{
	// r개를 다 선택한 경우
	if (vector.size() == r)
	{
		for (const int & x : vector)
		{
			cout << x << " ";
		}

		cout << endl;

		return;
	}

	for (int i = start; i <= n; i++)
	{
		vector.push_back(i);

		Combination(i + 1, n, r, vector);

		vector.pop_back();
	}

}

int main()
{
#pragma region 퇴각 검색
	// 조건을 만족하는 한 계속 검사해 나가다, 조건에 부합하지 않는 순간
	// 탐색을 취소하고 이전 단계로 돌아온 뒤 탐색을 이어나가는 탐색입니다.

	int n = 0;
	int r = 0;

	cout << "Enter the value of n : ";

	cin >> n;

	cout << endl;

	cout << "Enter the value of r : ";

	cin >> r;		 

	cout << endl;

	vector<int> container;

	Combination(1, n, r, container);

#pragma endregion


	return 0;
}