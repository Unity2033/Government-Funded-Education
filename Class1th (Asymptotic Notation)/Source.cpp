#include <iostream>

int main()
{
#pragma region 시간 복잡도
    // 컴퓨터 프로그램의 입력값과 연산 수행 시간의
    // 상관 관계를 나타내는 척도입니다.

#pragma region O(1) 상수 시간
    // 입력 크기와 상관 없이 일정한 시간 복잡도를
    // 가지는 시간입니다.

    // ex) 배열의 요소 접근
#pragma endregion

#pragma region O(log n) 로그 시간
    // 데이터 크기에 따라 실행 시간이 로그 함수의 형태로
    // 증가하는 시간 복잡도입니다.

    // ex) 이진 탐색
#pragma endregion

#pragma region O(n) 선형 시간
    // 입력에 따라 걸리는 시간이 선형적으로 증가되는
    // 시간 복잡도입니다.

    // ex) 순차 탐색
#pragma endregion

#pragma region O(n log n) 로그 선형 시간
    // 입력 크기 n에 대해 선형적으로 증가하면서,
    // 로그 항이 곱해지는 형태의 시간 복잡도입니다.

    // ex) 정렬 알고리즘
#pragma endregion

#pragma region O(n²) 제곱 시간
    // 입력되는 데이터를 기준으로 n² 만큼의 시간이
    // 증가되는 시간 복잡도입니다.

    // ex) 2 for statement

#pragma endregion


#pragma endregion

#pragma region 공간 복잡도
    // 프로그램 실행과 완료에 얼마나 많은 공간이
    // 필요한 지 나타내는 척도입니다.

#pragma region 고정 공간
    // 입력 크기와 상관없이, 프로그램 시작 시
    // 항상 필요한 메모리 공간입니다.

    // ex) 배열
#pragma endregion

#pragma region 가변 공간
    // 입력 크기나 재귀의 깊이에 따라 변하는
    // 메모리 공간입니다. 

    // ex) 재귀 함수
#pragma endregion

#pragma endregion

#pragma region 점근적 표기법
    // 상수 계수와 중요하지 않은 항목을 제거하여
    // 표기하는 표기법입니다.

    // f(n) = n² + n + 300

    // 점근법 표기법 -> n² 

    // 높은 수가 낮은 차수에 붙어 있어도 n이 무한대로 갈 수 
    // 있기 때문에 제일 높은 차수가 됩니다.
#pragma endregion
}