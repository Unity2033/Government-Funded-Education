#include <iostream>

int main()
{
#pragma region 완전 탐색
	// 가능한 모든 경우의 수를 탐색하면서
	// 결과를 찾아내는 알고리즘입니다.

	int password [ ] = { 7, 1, 2 };

	for (int i = 0; i < 10; i++)
	{
		for (int j = 0; j < 10; j++)
		{
			for (int k = 0; k < 10; k++)
			{
				if (password[0] == i && password[1] == j && password[2] == k)
				{
					std::cout << "release : " << i << " " << j << " " << k << std::endl;

					return 0;
				}
			}
		}
	}


#pragma endregion


	return 0;
}

