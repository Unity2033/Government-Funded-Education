#include <iostream>

using namespace std;

int main()
{
#pragma region 에라토스테네스의 체

	int n = 50;

	for (int i = 2; i <= n; i++)
	{
		bool flag = true;

		for (int j = 2; j < i; j++)
		{
			if (i % j == 0)
			{
				flag = false;

				break;
			}
		}

		if (flag)
		{
			cout << i << " ";
		}
	}


#pragma endregion


	return 0;
}

